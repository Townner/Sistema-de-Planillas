using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace UI
{
    public partial class CosultarUsuario : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            FormatoDataTable();
        }

        SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);
       
        DataTable Table = new DataTable();

        private void FormatoDataTable()
        {
            Table.Columns.Add("Cedula");
            Table.Columns.Add("Usuario");
            Table.Columns.Add("Estado");
            Table.Columns.Add("Tipo");

            GrdUsers.DataSource = Table;
            GrdUsers.DataBind();

            foreach (DataControlField column in GrdUsers.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }

        private BL.BLUsuario CargarDatos()
        {

            Table.Clear();

            BL.BLUsuario c = new BL.BLUsuario();
            c.ConsultarUsuario(txtCed.Text);

            Table.Rows.Add(c.Trabajador_Ced, c.Id, c.estado, c.tipo);

            GrdUsers.DataSource = Table;
            GrdUsers.DataBind();

            return c;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (CargarDatos().Trabajador_Ced != null)
            {
                btnDelete.Visible = true;
            }
            else {
                Response.Write("<script language='javascript'>alert('El usuario con la cedula " + txtCed.Text + " no esta asignado a un usuario');document.location.href='" + "/EliminarUsuario.aspx" + "'; </script>");
            }
            
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.EliminarUsuario(txtCed.Text);
            btnDelete.Visible = false;

            Response.Write("<script>alert('Usuario eliminado correctamente');document.location.href='" + "/EliminarUsuario.aspx" + "'; </script>");
        }
    }
    }
