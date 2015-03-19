using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ModificarCargarObreras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CBPensionados_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPensionados.Checked == true)
            {
                BL.BLCalculos BL_calc = new BL.BLCalculos();
                BL_calc.BuscarCargasObreras(1, 0);

                txtActual.Text = Convert.ToString(BL_calc.ob_pat_pen);
                CBNoPensionados.Enabled = false;
            }
            else {
                CBNoPensionados.Enabled = true;
                txtActual.Text = "";
                txtNuevo.Text = "";
            }
            
        }

        protected void CBNoPensionados_CheckedChanged(object sender, EventArgs e)
        {
            if (CBNoPensionados.Checked == true)
            {
                BL.BLCalculos BL_calc = new BL.BLCalculos();
                BL_calc.BuscarCargasObreras(0, 1);

                txtActual.Text = Convert.ToString(BL_calc.ob_pat_nopen);
                CBPensionados.Enabled = false;
            }
            else
            {
                CBPensionados.Enabled = true;
                txtActual.Text = "";
                txtNuevo.Text = "";
            }
        }

        protected void btnAplicar_Click(object sender, EventArgs e)
        {
            if (CBPensionados.Checked || CBNoPensionados.Checked)
            {

                if (CBPensionados.Checked == true)
                {
                    if (txtNuevo.Text != "")
                    {
                        BL.BLCalculos BL_calc = new BL.BLCalculos();
                        BL_calc.ActualizarCargas(1, 0, Convert.ToDouble(txtNuevo.Text));

                    }
                    else {
                        Response.Write("<script language='javascript'>alert('Debe insertar un valor valido en el nuevo valor');document.location.href='" + "/ModificarCargasObreras.aspx" + "'; </script>");
                    }
                    
                }
                else
                {

                    if (txtNuevo.Text != "")
                    {
                        BL.BLCalculos BL_calc = new BL.BLCalculos();
                        BL_calc.ActualizarCargas(0, 1, Convert.ToDouble(txtNuevo.Text));

                    }
                    else
                    {
                        Response.Write("<script language='javascript'>alert('Debe insertar un valor valido en el nuevo valor'); document.location.href='" + "/ModificarCargasObreras.aspx" + "'; </script>");
                    }
                    
                }

                Response.Write("<script language='javascript'>alert('Se a aplicado el cambio satisfactoriamente');document.location.href='" + "/ModificarCargasObreras.aspx" + "'; </script>");
            }
            else {

                Response.Write("<script language='javascript'>alert('Debe seleccionar al menos un tipo');</script>");
            
            }
           
        }
    }
}