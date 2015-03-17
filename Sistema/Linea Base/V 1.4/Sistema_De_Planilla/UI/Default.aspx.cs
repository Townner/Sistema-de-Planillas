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
            string Tipo = "";
            string Estado = "";
            // Identifica el tipo de usuario

            int cont = 1; // Indica si hay que mostrar algun msj

            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = "select * from dbo.usuarios where ID = @Usuario and Pass = @Constrasena and Sesion = 'Cerrada'";
            consulta.Parameters.AddWithValue("@Usuario", txtUsuario.Text);
            consulta.Parameters.AddWithValue("@Constrasena", txtContrasena.Text);

            conexion.Open();

            SqlDataReader reader = consulta.ExecuteReader();

            Boolean identificado = false;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                Tipo = (string)reader["Tipo"];
                Estado = (string)reader["Estado"];
                identificado = true;
                }

               /* BL.BLUsuario BL_Usr = new BL.BLUsuario(); // Para analizar si tiene una sesion abierta
                BL_Usr.IniciarSesion(txtUsuario.Text);*/
            }else
            {
                cont = 2;
            }
            conexion.Close();

            if (Estado == "Desactivado")
            {
                Response.Write("<script>alert(' Usuario Desactivado')</script>");

            }else{

            if (identificado && Tipo == "Administrador")
            {
                /* FormsAuthentication.RedirectFromLoginPage //Autentificacion por forms
                  (txtUsuario.Text, CBSesion.Checked);*/
                // Response.Redirect("/Inicio.aspx?field1="+this.txtUsuario.Text);
                Session["UserName"] = txtUsuario.Text; // se crea variable de sesion para ID del user
                Session["Type"] = Tipo;
                Response.Redirect("/InicioAdmin.aspx");
            }else { 
                if (identificado && Tipo == "Recursos Humanos")
                {
                Session["UserName"] = txtUsuario.Text; // se crea variable de sesion para ID del user
                Session["Type"] = Tipo;
                Response.Redirect("/InicioRH.aspx");
                }else{
                  if (identificado && Tipo == "Financiero")
                {
                Session["UserName"] = txtUsuario.Text; // se crea variable de sesion para ID del user
                Session["Type"] = Tipo;
                Response.Redirect("/InicioFI.aspx");
                }else { 
                if (cont == 2)
                {
                    Response.Write("<script>alert('Usuario o Contraseña Incorrecto')</script>");

                }
               } 
              } 
            }
           }
            
        }
    }
}