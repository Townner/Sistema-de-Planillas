using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UI
{
    public partial class Actualizar_Licencias : System.Web.UI.Page
    {
        private SqlConnection Conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        protected void Page_Load(object sender, EventArgs e)
        {

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
            lblven_ced2.Text = calven_ced.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void CalVen_Ced3_SelectionChanged(object sender, EventArgs e)
        {
            lblven_ced3.Text = calven_ced.SelectedDate.ToString("yyyy-MM-dd");
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

            calven_ced.SelectedDate = BL_Lic.v_lic1;
            calven_ced2.SelectedDate = BL_Lic.v_lic2;
            calven_ced3.SelectedDate = BL_Lic.v_lic3;
            
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);
            
            if (BL_Trab.ced != "")
            {
                lblConfirm.Text = "Se ha verificado la informacion del trabajador " + BL_Trab.nombre + BL_Trab.apellido1 + BL_Trab.apellido2;
                lblConfirm.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarLicencias.aspx" + "'; </script>");
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            

            BL.BLLicencias BL_Lic = new BL.BLLicencias();

            if (0 == 0)
            {


                BL_Lic.ModifcarLicencia();


                Response.Write("<script language='javascript'>alert('El trabajador fue agregado correctamente');document.location.href='" + "/AgregarLicencias.aspx" + "'; </script>");

            }
            else
            {

                Response.Write("<script language='javascript'>alert('La cedula ya existe en el sistema revise los datos insertados');</script>");

            }            
        }






        
    }
}