﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace UI
{
    public partial class Master_Page : System.Web.UI.MasterPage
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           // lblUser.Text = Request.QueryString["field1"];
            lblUser.Text = (string)Session["UserName"]; // Carga ID del user por medio de variable de session
            string tipo = (string)Session["Type"]; // Carga el tipo de usario
            if (tipo == "RH")
            {
                Admin.Visible = false;
                Users.Visible = false;
                ReportesFI.Visible = false;
            }
            else {
                if (tipo == "Admin")
                {
                    ReportesFI.Visible = false;
                }
                else {
                    if (tipo == "FI") {
                        Trabajadores.Visible = false;
                        Reportes.Visible = false;
                        Admin.Visible = false;
                        Users.Visible = false;
                    }
                }
            
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
           // FormsAuthentication.SignOut(); // Cierre de sesion 
            Response.Redirect("Default.aspx");
        }
    }
}