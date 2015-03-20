using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace UI
{
    public partial class EliminarDepartamento : System.Web.UI.Page
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

            GrdDepartamento.DataSource = Table;
            GrdDepartamento.DataBind();

            foreach (DataControlField column in GrdDepartamento.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }

        private BL.BLDepartamento CargarDatos()
        {

            Table.Clear();

            BL.BLDepartamento BL_Dep = new BL.BLDepartamento();
            BL_Dep.BuscarDepartamento(txtNombre.Text);

            Table.Rows.Add(BL_Dep.id_departamento,BL_Dep.nom_departamento);

            GrdDepartamento.DataSource = Table;
            GrdDepartamento.DataBind();

            return BL_Dep;
        }


        protected void btnConsultar_Click(object sender, EventArgs e)
        {
             if (CargarDatos().nom_departamento != null)
            {
                btnEliminar.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El departamento con el nombre " + txtNombre.Text + " no existe en el sistema');document.location.href='" + "/EliminarDepartamento.aspx" + "'; </script>");
            }
        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            BL.BLDepartamento BL_Puest = new BL.BLDepartamento();
            BL_Puest.nom_departamento = this.txtNombre.Text;
            BL_Puest.EliminarDepartamento();

            Response.Write("<script language='javascript'>alert('El departamento fue eliminado correctamente');document.location.href='" + "/EliminarDepartamento.aspx" + "'; </script>");
        }
        }
    }