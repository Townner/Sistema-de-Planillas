using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ModificarPuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            lblModificar.Visible = true;
            btnModificar.Visible = true;
            txtNombreNew.Visible = true;

            BL.BLPuesto BL_Puest = new BL.BLPuesto();
            BL_Puest.BuscarPuesto(txtNombreOld.Text);

            txtNombreNew.Text = BL_Puest.nom_puesto;

            btnConsulta.Text = "Nueva Consulta";

            if (BL_Puest.nom_puesto == null)
            {
                Response.Write("<script language='javascript'>alert('El puesto con el nombre" + txtNombreOld.Text + " no existe');document.location.href='" + "/ModificarPuesto.aspx" + "'; </script>");
            }
            else
            {

            } 
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            BL.BLPuesto BL_Puest = new BL.BLPuesto();
            BL_Puest.nom_puesto = this.txtNombreNew.Text;
            BL_Puest.EditarPuesto(this.txtNombreOld.Text);

            Response.Write("<script>alert('Puesto modificado correctamente');document.location.href='" + "/ModificarPuesto.aspx" + "'; </script>");
        }
    }
}