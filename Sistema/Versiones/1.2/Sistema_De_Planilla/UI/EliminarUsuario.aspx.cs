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
            //FormatoDataTable();
        }

        SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);
       
        DataTable Table = new DataTable();

        private void FormatoDataTable()
        {
            Table.Columns.Add("Cedula");
            Table.Columns.Add("ID");
            Table.Columns.Add("Estado");
            Table.Columns.Add("Tipo");
        }

        private void CargarDatos()
        {

            Table.Clear();

            BL.BLUsuario c = new BL.BLUsuario();
            c.ConsultarUsuario(txtCed.Text);

            Table.Rows.Add(c.Trabajador_Ced, c.Id, c.estado, c.tipo);
            
            GrdUsers.DataSource = Table;
            GrdUsers.DataBind();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            CargarDatos();
            this.txtCed.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.EliminarUsuario(txtCed.Text);
            Response.Write("<script>alert('Usuario eliminado correctamente')</script>");
        }
    }
    }
