using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        // private SqlConnection conexion = new SqlConnection(Proyecto.Properties.Settings.Default.ConString);


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Login_Click(object sender, EventArgs e)
        {
           /* int cont = 1;
            SqlCommand consulta = new SqlCommand();
            consulta.Connection = conexion;
            consulta.CommandText = "select * from Proyecto_Usuarios where Usuario = @Usuario and Contrasena = @Constrasena and Estado = 1";
            consulta.Parameters.AddWithValue("@Usuario", iUsuario.Text);
            consulta.Parameters.AddWithValue("@Constrasena", iContrasena.Text);

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
                Response.Redirect("/Inicio.aspx");
            else

                if (cont == 2)
                {
                    MSJ.Visible = true;

                }
                else
                {
                    MSJ1.Visible = true;
                }
                */
        }
    }
}