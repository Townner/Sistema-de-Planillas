using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UI
{
    public partial class ActualizarLicencias : System.Web.UI.Page
    {
        private SqlConnection Conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        protected void Page_Load(object sender, EventArgs e)
        {
            RegexCed1.Enabled = false;

            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
            }
        }

            
        protected void CalVen_Ced_SelectionChanged(object sender, EventArgs e)
        {
            lblVen_Ced.Text = calven_ced.SelectedDate.ToString("yyyy-MM-dd");
        }


        protected void CalVen_Ced2_SelectionChanged(object sender, EventArgs e)
        {
            lblven_ced2.Text = calven_ced2.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void CalVen_Ced3_SelectionChanged(object sender, EventArgs e)
        {
           lblven_ced3.Text = calven_ced3.SelectedDate.ToString("yyyy-MM-dd");
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
                drpCalMonth2.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
                drpCalMonth3.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
            }
               
            //Make the current month selected item in the list
            drpCalMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
            drpCalMonth2.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
            drpCalMonth3.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }


        protected void Populate_YearList()
        {
            //Year list can be changed by changing the lower and upper 
            //limits of the For statement    
            for (int intYear = DateTime.Now.Year - 20; intYear <= DateTime.Now.Year + 20; intYear++)
            {
                drpCalYear.Items.Add(intYear.ToString());
                drpCalYear2.Items.Add(intYear.ToString());
                drpCalYear3.Items.Add(intYear.ToString());              
            }

            //Make the current year selected item in the list
            drpCalYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
            drpCalYear2.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
            drpCalYear3.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;  
        }

        protected void Set_CalendarVen(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear.SelectedValue);
            int month = int.Parse(drpCalMonth.SelectedValue);
            calven_ced.TodaysDate = new DateTime(year, month, 1);
        }

        protected void Set_CalendarVen2(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear2.SelectedValue);
            int month = int.Parse(drpCalMonth2.SelectedValue);
            calven_ced2.TodaysDate = new DateTime(year, month, 1);
        }

        protected void Set_CalendarVen3(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear3.SelectedValue);
            int month = int.Parse(drpCalMonth3.SelectedValue);
            calven_ced3.TodaysDate = new DateTime(year, month, 1);
        }


       protected void btConsultarLic_Click(object sender, EventArgs e)
        {

            BL.BLLicencias BL_Lic = new BL.BLLicencias();
            BL_Lic.Search(txtCed.Text);

            if (BL_Lic.lic1 == "N/A")
            {
                DropTipo_Lic.SelectedValue = "N/A";
            }
            else {
                DropTipo_Lic.SelectedValue = BL_Lic.lic1;
            }

            if (BL_Lic.lic2 == "N/A")
            {
                DropTipo_Lic0.SelectedValue = "N/A";
            }
            else {
                DropTipo_Lic0.SelectedValue = BL_Lic.lic2;
            }

            if (BL_Lic.lic3 == "N/A")
            {
                DropTipo_Lic1.SelectedValue = "N/A";
            }
            else {
                DropTipo_Lic1.SelectedValue = BL_Lic.lic3;
               
            }

            lblActual.Text = BL_Lic.v_lic1;
            lblActual0.Text = BL_Lic.v_lic2;
            lblActual1.Text = BL_Lic.v_lic3;
            
           BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);
            
            if (BL_Trab.ced != "")
            {
                lblConfirm.Text = "Se ha verificado la informacion del trabajador " + " " + BL_Trab.nombre + " " + BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblConfirm.Visible = true;
                btnAgregar.Visible = true;
                btConsultarLic.Visible = false;
                btnNew.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarLicencias.aspx" + "'; </script>");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            
            BL.BLTrabajador BL_trab = new BL.BLTrabajador();
            BL_trab.Search(txtCed.Text);
            
            BL.BLLicencias BL_Lic = new BL.BLLicencias();
            BL_Lic.Search(txtCed.Text);

           if (DropTipo_Lic.SelectedValue == "N/A" && (lblActual.Text == "N/A"))
            {
                BL_Lic.lic1 = DropTipo_Lic.SelectedValue;
                BL_Lic.v_lic1 = lblVen_Ced.Text;
            }
            else
            {
                if (lblVen_Ced.Text != "")
                {
                    BL_Lic.lic1 = DropTipo_Lic.SelectedValue;
                    BL_Lic.v_lic1 = lblVen_Ced.Text;
                }
                else { 
                    BL_Lic.lic1 = DropTipo_Lic.SelectedValue;
                    BL_Lic.v_lic1 = lblActual.Text;
                }
                
            }

           if (DropTipo_Lic0.SelectedValue == "N/A" && (lblActual0.Text == "N/A"))
            {
                BL_Lic.lic2 = DropTipo_Lic0.SelectedValue;
                BL_Lic.v_lic2 = lblven_ced2.Text;
            }
            else
            {
                if (lblven_ced2.Text != "")
                {
                    BL_Lic.lic2 = DropTipo_Lic0.SelectedValue;
                    BL_Lic.v_lic2 = lblven_ced2.Text;
                }
                else { 
                    BL_Lic.lic2 = DropTipo_Lic0.SelectedValue;
                    BL_Lic.v_lic2 = lblActual0.Text;
                }
                
            }

           if (DropTipo_Lic1.SelectedValue == "N/A" && (lblActual1.Text == "N/A"))
            {
                BL_Lic.lic3 = DropTipo_Lic1.SelectedValue;
                BL_Lic.v_lic3 = lblven_ced3.Text;
            }
            else
            {
                if (lblven_ced3.Text != "")
                {
                    BL_Lic.lic3 = DropTipo_Lic1.SelectedValue;
                    BL_Lic.v_lic3 = lblven_ced3.Text;
                }
                else { 
                    BL_Lic.lic3 = DropTipo_Lic1.SelectedValue;
                    BL_Lic.v_lic3 = lblActual1.Text;
                }
                
            }

            if (BL_Lic.trabajador_ced == null)
            {
                BL_Lic.AgregarLicencia(BL_trab);
            }
            else {
                BL_Lic.ModifcarLicencia(BL_trab);
            }

            Response.Write("<script language='javascript'>alert('El trabajador fue actualizado correctamente');document.location.href='" + "/ActualizarLicencias.aspx" + "'; </script>");

            }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ActualizarLicencias.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBResidencia.Checked == true)
            {
                RegexCed1.Enabled = true;
                RegexCed.Enabled = false;
            }
            else
            {
                RegexCed1.Enabled = false;
                RegexCed.Enabled = true;
            }
        }
                   
        }

    }
