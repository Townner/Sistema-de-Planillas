using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UI
{
    public partial class EliminarPuesto : System.Web.UI.Page
    {
        DataTable Table = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            FormatoDataTable();
        }

        private void FormatoDataTable()
        {
            Table.Columns.Add("ID");
            Table.Columns.Add("Nombre");

            GrdPuestos.DataSource = Table;
            GrdPuestos.DataBind();

            foreach (DataControlField column in GrdPuestos.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }

        private BL.BLPuesto CargarDatos()
        {

            Table.Clear();

            BL.BLPuesto BL_Puest = new BL.BLPuesto();
            BL_Puest.BuscarPuesto(txtNombre.Text);

            Table.Rows.Add(BL_Puest.id_puesto,BL_Puest.nom_puesto);

            GrdPuestos.DataSource = Table;
            GrdPuestos.DataBind();

            return BL_Puest;
        }


        protected void btnReg_Click(object sender, EventArgs e)
        {
            BL.BLPuesto BL_Puest = new BL.BLPuesto();
            BL_Puest.nom_puesto = this.txtNombre.Text;
            BL_Puest.EliminarPuesto();

            Response.Write("<script language='javascript'>alert('El puesto fue eliminado correctamente');document.location.href='" + "/EliminarPuesto.aspx" + "'; </script>");
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (CargarDatos().nom_puesto != null)
            {
                btnEliminar.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El puesto con el nombre " + txtNombre.Text + " no existe en el sistema');document.location.href='" + "/EliminarPuesto.aspx" + "'; </script>");
            }
        }
    }
}