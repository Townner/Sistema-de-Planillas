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
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);
            
            if (BL_Trab.ced != "")
            {
                lblConfirm.Text = "Se ha verificado la informacion del trabajador " + " " + BL_Trab.nombre + " " + BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblConfirm.Visible = true;
                btnNueva.Visible = true;
                btnConsultar.Visible = false;
                btnActua.Visible = true;

                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                BL_Calcu.Search(txtCed.Text);

                string conyuge = "";

                if(BL_Calcu.conyugue == 1){
                    conyuge = "Si Tiene";
                }else{
                    conyuge = "No Tiene";
                }

                txtBase.Text = Convert.ToString(BL_Calcu.s_base);
                txtMayores.Text = Convert.ToString(BL_Calcu.hijos_mayor);
                txtMenores.Text = Convert.ToString(BL_Calcu.hijos_menor);
                txtConyuge.Text = conyuge;

                BL.BLCalculos_Financieros BL_Finan = new BL.BLCalculos_Financieros();


            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarLicencias.aspx" + "'; </script>");
            }
            
            



            
        }

        protected void btnNueva_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ActualizarTrabajador.aspx");
        }

        protected void btnActua_Click(object sender, EventArgs e)
        {

        }
    }
}