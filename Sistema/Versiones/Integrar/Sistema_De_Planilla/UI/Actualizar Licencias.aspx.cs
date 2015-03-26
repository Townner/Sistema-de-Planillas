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
            string temp = "";
            
            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Trabajador_ID], [Trabajador_Ced], [Licencia_1], [Licencia_2], [Licencia_3], [F_Vencimiento_1],"+
                " [F_Vencimiento_2], [F_Vencimiento_3] FROM [DB_Planilla].[dbo].[licencia]  WHERE [Trabajador_Ced] = @Ced;";

            com.Parameters.AddWithValue("@ced", txtCed.Text);

            Conexion.Open();
            dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    temp = (string)dr["[Trabajador_Ced]"];
                    calven_ced.SelectedDate = Convert.ToDateTime(dr["[F_Vencimiento_1]"]);
                    calven_ced2.SelectedDate = Convert.ToDateTime(dr["[F_Vencimiento_2]"]);
                    calven_ced3.SelectedDate = Convert.ToDateTime(dr["[F_Vencimiento_3]"]);
                }

            }
            Conexion.Close();



            lblConfirm.Text = consultarNombre(txtCed.Text)+", cedula" + temp;
            lblConfirm.Visible = true;
        }

        protected string consultarNombre(string ced)
        {
            string temp = "";
            string nom = "";
            string ap1 = "";
            string ap2 = "";


            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nombre], [Apellido1], [Apellido2] FROM [trabajador] WHERE [Ced] = @Ced;";

            com.Parameters.AddWithValue("@ced", ced);

            Conexion.Open();
            dr = com.ExecuteReader();

            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    nom = (string)dr["[Nombre]"];
                    ap1 = (string)dr["[Apellido1]"];
                    ap2 = (string)dr["[Apellido2]"];
                }

            }
            Conexion.Close();

            temp = "Se ha verificado la informacion del usuario " + nom + ap1 + ap2;

            return temp;
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