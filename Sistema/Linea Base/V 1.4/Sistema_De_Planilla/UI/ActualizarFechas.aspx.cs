﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ActualizarFechas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Populate_MonthList();
                Populate_YearList();
            }
        }

        protected void btnConsul_Click(object sender, EventArgs e)
        {
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);

            if(BL_Trab.ced != "" ){

                BL.BLFechas BL_Fech = new BL.BLFechas();
                BL_Fech.Search(txtCed.Text);

                lblExito.Text = "Se ha verificado el trabajador" + " " + BL_Trab.nombre + " " +  BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblNac.Text = BL_Fech.f_nac;
                lblIngr.Text = BL_Fech.f_ingreso;
                lblPrueba.Text = BL_Fech.f_prueba;
                lblSalida.Text = BL_Fech.f_salida;

            }else{

                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarFechas.aspx" + "'; </script>");
            }

            
        }

        protected void btnAct_Click(object sender, EventArgs e)
        {
            
            BL.BLTrabajador BL_trab = new BL.BLTrabajador();
            BL_trab.Search(txtCed.Text);

            BL.BLFechas BL_Fech = new BL.BLFechas();
            BL_Fech.Search(txtCed.Text);


            BL_Fech.AgregarFechas(BL_trab);

            Response.Write("<script language='javascript'>alert('El usuario fue actualizado correctamente');document.location.href='" + "/ActualizarFechas.aspx" + "'; </script>");
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
                drpCalMonth0.Items.Add(new ListItem(dtf.GetMonthName(i), i.ToString()));
            }

            //Make the current month selected item in the list
            drpCalMonth.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
            drpCalMonth0.Items.FindByValue(DateTime.Now.Month.ToString()).Selected = true;
        }


        protected void Populate_YearList()
        {
            //Year list can be changed by changing the lower and upper 
            //limits of the For statement    
            for (int intYear = DateTime.Now.Year - 20; intYear <= DateTime.Now.Year + 20; intYear++)
            {
                drpCalYear.Items.Add(intYear.ToString());
                drpCalYear0.Items.Add(intYear.ToString());
            }

            //Make the current year selected item in the list
            drpCalYear.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
            drpCalYear0.Items.FindByValue(DateTime.Now.Year.ToString()).Selected = true;
        }



        protected void Set_CalendarIngreso(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear.SelectedValue);
            int month = int.Parse(drpCalMonth.SelectedValue);
            CalIngreso.TodaysDate = new DateTime(year, month, 1);
        }

        protected void Set_CalendarPrueba(object Sender, EventArgs e)
        {
            int year = int.Parse(drpCalYear.SelectedValue);
            int month = int.Parse(drpCalMonth.SelectedValue);
            CalIngreso.TodaysDate = new DateTime(year, month, 1);
        }

        protected void CalVen_Ced_SelectionChanged(object sender, EventArgs e)
        {
            lblNewIngr.Text = CalIngreso.SelectedDate.ToString("yyyy-MM-dd");
        }

        protected void CalFinal_Prueba_SelectionChanged(object sender, EventArgs e)
        {
            lblNewPrueba.Text = CalFinal_Prueba.SelectedDate.ToString("yyyy-MM-dd");
        }

    }
}