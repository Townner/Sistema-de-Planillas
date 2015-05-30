using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UI
{
    public partial class ActualizarTrabajador : System.Web.UI.Page
    {
        private SqlConnection Conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaDepartamento();
            ConultarPuesto();

            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
            }

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);

            if (BL_Trab.ced != null)
            {
                lblConfirm.Text = "Se ha verificado al trabajador " + " " + BL_Trab.nombre + " " + BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblConfirm.Visible = true;
                btnConsultar.Visible = false;
                btnNueva.Visible = true; 
                
                lblVenCed.Text = BL_Trab.ven_ced;
                txtNom.Text = BL_Trab.nombre;
                txtAp1.Text = BL_Trab.apellido1;
                txtAp2.Text = BL_Trab.apellido2;

                if (BL_Trab.mail != "N/A")
                {
                    txtMail.Text = BL_Trab.mail;
                }
                else {
                    txtMail.Text = "N/A";
                }

                if (BL_Trab.tel1 != "N/A")
                {
                    txtTel1.Text = BL_Trab.tel1;
                }
                else
                {
                    txtTel1.Text = "N/A";
                }

                if (BL_Trab.tel2 != "N/A")
                {
                    txtTel2.Text = BL_Trab.tel2;
                }
                else
                {
                    txtTel2.Text = "N/A";
                }

                if (BL_Trab.dir != "N/A")
                {
                    txtDir.Text = BL_Trab.dir;
                }
                else
                {
                    txtDir.Text = "N/A";
                }
            
                DropEst_Civ.SelectedValue = BL_Trab.est_civ;
                txtNacionalidad.Text = BL_Trab.nacionalidad;
                DropDepartamento.SelectedValue = Convert.ToString(BL_Trab.id_departamento);
                DropPuesto.SelectedValue = Convert.ToString(BL_Trab.id_puesto);

                if (BL_Trab.experiencia != "N/A")
                {
                    txtExp.InnerText = BL_Trab.experiencia;
                }
                else {
                    txtExp.InnerText = "N/A";
                }

                if (BL_Trab.titulos != "N/A")
                {
                    txtTitulos.InnerText = BL_Trab.titulos;
                }
                else {
                    txtTitulos.InnerText = "N/A";
                }

                txtNum_Seguro.Text = Convert.ToString(BL_Trab.num_seguro);
                lbluniforme.Text = BL_Trab.uniforme;
                DropEstado_T.SelectedValue = Convert.ToString(BL_Trab.estado_t);
                txtL_Trabajo.Text = BL_Trab.l_trabajo;
                DDLRecontratable.SelectedValue = BL_Trab.inact;

                btnActua.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarTrabajador.aspx" + "'; </script>");
            }
        }


        private void ConsultaDepartamento()
        {

            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nom_Dep], [ID_Departamento] FROM [DB_Planilla].[dbo].[departamento];";

            Conexion.Open();
            dr = com.ExecuteReader();
            DropDepartamento.Items.Clear();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListItem LI = new ListItem();
                    LI.Value = Convert.ToString((int)dr["ID_Departamento"]);
                    LI.Text = dr[0].ToString();
                    DropDepartamento.Items.Add(LI);
                }

            }
            Conexion.Close();

        }

        private void ConultarPuesto()
        {
            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nom_Puesto], [ID_Puesto] FROM [DB_Planilla].[dbo].[puesto];";

            Conexion.Open();
            dr = com.ExecuteReader();

            DropPuesto.Items.Clear();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListItem LI = new ListItem();
                    LI.Value = Convert.ToString((int)dr["ID_Puesto"]);
                    LI.Text = dr[0].ToString();
                    DropPuesto.Items.Add(LI);
                }

            }

            Conexion.Close();
        }

        protected void CalUniforme_SelectionChanged(object sender, EventArgs e)
        {
            lblUnif.Text = CalUniforme.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void CalVen_Ced_SelectionChanged(object sender, EventArgs e)
        {
            lblVen_Ced.Text = calven_ced.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            DateTime pastday = e.Day.Date;
            DateTime date = DateTime.Now;
            int year = date.Year;
            int month = date.Month;
            int day = date.Day;
            DateTime today = new DateTime(year, month, day);
            if (pastday.CompareTo(today) < 0)
            {
                e.Cell.BackColor = System.Drawing.Color.Gray;
                e.Day.IsSelectable = false;
            }
        }

        protected void Populate_MonthList()
        {
            //Add each month to the list
            var dtf = System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat;
            for (int i = 1; i <= 12; i++)
            {
                drpCalMonth.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
                DPDMonthUniforme.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
            }

            //Make the current month selected item in the list
            drpCalMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
            DPDMonthUniforme.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }


        protected void Populate_YearList()
        {
            //Year list can be changed by changing the lower and upper 
            //limits of the For statement    
            for (int intYear = DateTime.Now.Year - 20; intYear <= DateTime.Now.Year + 20; intYear++)
            {
                drpCalYear.Items.Add(intYear.ToString());
                DPDYearUniforme.Items.Add(intYear.ToString());
            }

            //Make the current year selected item in the list
            drpCalYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
            DPDYearUniforme.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }

        protected void Set_CalendarVen(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear.SelectedValue);
            int month = int.Parse(drpCalMonth.SelectedValue);
            calven_ced.TodaysDate = new DateTime(year, month, 1);
        }


        protected void Set_CalendarUniforme(object Sender, EventArgs e)
        {
            int year = int.Parse(DPDYearUniforme.SelectedValue);
            int month = int.Parse(DPDMonthUniforme.SelectedValue);
            CalUniforme.TodaysDate = new DateTime(year, month, 1);
        }

        protected void btnNueva_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ActualizarTrabajador.aspx");
        }



        protected void btnActua_Click(object sender, EventArgs e)
        {
            int temp1 = Int32.Parse(DropDepartamento.SelectedValue);
            int temp2 = Int32.Parse(DropPuesto.SelectedValue);

            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();

            if (BL_Trab.ConsultarTrabajador(txtCed.Text) != 0)
            {
                BL_Trab.ced = this.txtCed.Text;
                if (lblVen_Ced.Text != "")
                {
                    BL_Trab.ven_ced = calven_ced.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
                }
                else {
                    BL_Trab.ven_ced = lblVenCed.Text;
                }
               
                BL_Trab.nombre = this.txtNom.Text;
                BL_Trab.apellido1 = this.txtAp1.Text;
                BL_Trab.apellido2 = this.txtAp2.Text;
                BL_Trab.mail = this.txtMail.Text;
                BL_Trab.tel1 = this.txtTel1.Text;
                BL_Trab.tel2 = this.txtTel2.Text;
                BL_Trab.dir = this.txtDir.Text;
                BL_Trab.experiencia = this.txtExp.Value.ToString();
                BL_Trab.titulos = this.txtTitulos.Value.ToString();
                BL_Trab.num_seguro = Convert.ToInt32((txtNum_Seguro.Text));
                if (lblUnif.Text != "")
                {
                    BL_Trab.uniforme = CalUniforme.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
                }
                else {
                    BL_Trab.uniforme = lbluniforme.Text;
                }
                
                BL_Trab.estado_t = this.DropEstado_T.SelectedValue;
                BL_Trab.inact = DDLRecontratable.SelectedValue;
                BL_Trab.l_trabajo = txtL_Trabajo.Text;
                BL_Trab.est_civ = this.DropEst_Civ.SelectedValue;
                BL_Trab.nacionalidad = this.txtNacionalidad.Text;
                BL_Trab.id_departamento = temp1;
                BL_Trab.id_puesto = temp2;

                BL_Trab.ModifcarTrabajador();

                Response.Write("<script language='javascript'>alert('El trabajador fue actualizado correctamente');document.location.href='" + "/ActualizarTrabajador.aspx" + "'; </script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('La cedula " + txtCed.Text + " no existe en el sistema');</script>");
            }
        }

    
    }
}