using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Web.Security;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
           int cont = 1;
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = "select * from dbo.usuario where ID = @Usuario and Pass = @Constrasena and Estado = 'Activo'";
            consulta.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            consulta.Parameters.AddWithValue("@Constrasena", txtContrasena.Text);

            conexion.Open();

            SqlDataReader reader = consulta.ExecuteReader();

            Boolean identificado = false;

            if (reader.HasRows)
                identificado = true;
            else
            {
                cont = 2;
            }
            conexion.Close();

            if (identificado)
            {
                FormsAuthentication.RedirectFromLoginPage
                 (txtUsuario.Text, CheckBox1.Checked);
                Response.Redirect("/Inicio.aspx");
            }
            else { 

                if (cont == 2)
                {
                    msgIncorrecto.Visible = true;

                }
                else
                {
                    msgDesactivado.Visible = true;
                }
             } 
        }
    }
}