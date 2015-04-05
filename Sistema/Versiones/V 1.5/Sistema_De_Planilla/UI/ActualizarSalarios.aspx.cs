using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ActualizarSalarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            BL.BLCalculos BL_Lic = new BL.BLCalculos();
            BL_Lic.Search(txtCed.Text);

            lblActual.Text = BL_Lic.v_lic1;
            lblActual0.Text = BL_Lic.v_lic2;
            lblActual1.Text = BL_Lic.v_lic3;

            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);

            if (BL_Trab.ced != "")
            {
                lblConfirm.Text = "Se ha verificado la informacion del trabajador " + " " + BL_Trab.nombre + " " + BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblConfirm.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarLicencias.aspx" + "'; </script>");
            }
        }
    }
}