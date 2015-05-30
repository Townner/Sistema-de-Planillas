using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UI
{
    public partial class DesactivarTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormatoDataTable();
        }

        DataTable Table = new DataTable();

        private void FormatoDataTable()
        {
            Table.Columns.Add("Nombre");
            Table.Columns.Add("Apellido 1");
            Table.Columns.Add("Apellido 2");
            Table.Columns.Add("Cedula");

            GrdTrab.DataSource = Table;
            GrdTrab.DataBind();

            foreach (DataControlField column in GrdTrab.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }

        private BL.BLTrabajador CargarDatos()
        {

            Table.Clear();

            BL.BLTrabajador c = new BL.BLTrabajador();
            c.Search(txtCed.Text);

            Table.Rows.Add(c.nombre, c.apellido1, c.apellido2, c.ced);

            DDLRecon.SelectedValue = c.inact;
            DDLEstado.SelectedValue = c.estado_t;

            GrdTrab.DataSource = Table;
            GrdTrab.DataBind();

            return c;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (CargarDatos().ced != null)
            {
                btnDelete.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El trabajador con la cedula " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/DesactivarTrabajador.aspx" + "'; </script>");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BL.BLTrabajador BL_trab = new BL.BLTrabajador();
            BL_trab.Search(txtCed.Text);
            BL_trab.estado_t = this.DDLEstado.SelectedValue;
            BL_trab.inact = this.DDLRecon.SelectedValue;
            BL_trab.ModifcarTrabajador();

            Response.Write("<script language='javascript'>alert('Se a actualizado satisfactoriamente el trabajador con la cedula " + txtCed.Text + "');document.location.href='" + "/DesactivarTrabajador.aspx" + "'; </script>");
        }
    }
}