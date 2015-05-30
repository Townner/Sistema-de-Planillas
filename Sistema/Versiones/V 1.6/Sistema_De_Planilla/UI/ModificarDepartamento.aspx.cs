using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ModificarDepartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnModificar.Visible = false;
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            lblModificar.Visible = true;
            btnModificar.Visible = true;
            txtNombreNew.Visible = true;

            BL.BLDepartamento BL_Puest = new BL.BLDepartamento();
            BL_Puest.BuscarDepartamento(txtNombreOld.Text);

            txtNombreNew.Text = BL_Puest.nom_departamento;

            btnConsulta.Text = "Nueva Consulta";

            if (BL_Puest.nom_departamento == null)
            {
                Response.Write("<script language='javascript'>alert('El Departamento con el nombre " + txtNombreOld.Text + " no existe');document.location.href='" + "/ModificarDepartamento.aspx" + "'; </script>");
            }
            else
            {

            } 
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            BL.BLDepartamento BL_Dep = new BL.BLDepartamento();
            BL_Dep.nom_departamento = this.txtNombreNew.Text;
            BL_Dep.EditarDepartamento(this.txtNombreOld.Text);

            Response.Write("<script>alert('Departamento modificado correctamente');document.location.href='" + "/ModificarDepartamento.aspx" + "'; </script>");
        }
    }
}