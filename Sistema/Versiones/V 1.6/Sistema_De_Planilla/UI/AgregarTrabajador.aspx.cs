using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AgregarTrabajador : System.Web.UI.Page
    {
        private SqlConnection Conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaDepartamento();
            ConultarPuesto();
            RegexCed0.Enabled = false;

            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
            }

        }

        protected void btnTrab_Click(object sender, EventArgs e)
        {
            int c = CargaDatos();
            int temp1 = Int32.Parse(DropDepartamento.SelectedValue);
            int temp2 = Int32.Parse(DropPuesto.SelectedValue);

            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();

            if (BL_Trab.ConsultarTrabajador(txtCed.Text) == 0) {

                if (lblVen_Ced.Text != "" && lblUnif.Text != "")
                {
                    BL_Trab.id = c;
                    BL_Trab.ced = this.txtCed.Text;
                    BL_Trab.ven_ced = calven_ced.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
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
                    BL_Trab.uniforme = CalUniforme.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
                    BL_Trab.estado_t = this.DropEstado_T.SelectedValue;
                    BL_Trab.inact = "Contratable";
                    BL_Trab.l_trabajo = txtL_Trabajo.Text;
                    BL_Trab.est_civ = this.DropEst_Civ.SelectedValue;
                    BL_Trab.nacionalidad = this.txtNacionalidad.Text;
                    BL_Trab.id_departamento = temp1;
                    BL_Trab.id_puesto = temp2;
                    BL_Trab.AgregarTrabajdor();

                }
                else {
                    Response.Write("<script language='javascript'>alert('No se insertaron correctamente las fechas');</script>");
                }

            Response.Write("<script language='javascript'>alert('El trabajador fue agregado correctamente');document.location.href='" + "/AgregarTrabajador.aspx" + "'; </script>");

            }else{

                Response.Write("<script language='javascript'>alert('La cedula ya existe en el sistema revise los datos insertados');</script>");
            
            }            

        }

        private int CargaDatos()
        {
            int c = 0;
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            c = BL_Trab.ConsultarTrabajador(txtCed.Text);
            return c;
        }

        private void ConsultaDepartamento()
        {
            
            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nom_Dep], [ID_Departamento] FROM [DB_Planilla].[dbo].[departamento];";

            Conexion.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListItem LI = new ListItem();
                    LI.Value =  Convert.ToString((int)dr["ID_Departamento"]);
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
            for (int i = 1; i <= 12; i++){
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


        protected void Set_CalendarUniforme (object Sender, EventArgs e)
        {
            int year = int.Parse(DPDYearUniforme.SelectedValue);
            int month = int.Parse(DPDMonthUniforme.SelectedValue);
            CalUniforme.TodaysDate = new DateTime(year, month, 1);
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBResidencia.Checked == true)
            {
                RegexCed0.Enabled = true;
                RegexCed.Enabled = false;
            }
            else {
                RegexCed0.Enabled = false;
                RegexCed.Enabled = true;
            }
        }

    }
}