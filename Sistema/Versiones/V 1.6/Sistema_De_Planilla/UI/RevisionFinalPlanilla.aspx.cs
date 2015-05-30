using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AprobarPlanilla : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Page.MaintainScrollPositionOnPostBack = true;
        }

        protected void btnAprobar_Click(object sender, EventArgs e)
        {
            if (CBPrimero.Checked || CBSegundo.Checked)
            {
                if (CBPrimero.Checked == true) { 
                    // 240 horas / salario base 

                
                }

                btnReset.Visible = true;
            }
            else
            { // end validacion del primer chech box

               Response.Write("<script language='javascript'>alert('Debe seleccionar al menos una quincena')</script>");
              
            }
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBPrimero.Checked == true)
            {
                CBSegundo.Enabled = false;
            }
            else
            {
                CBSegundo.Enabled = true;
            }
        }

        protected void cbPorcentual_CheckedChanged(object sender, EventArgs e)
        {
            
            if (CBSegundo.Checked == true)
            {
                CBPrimero.Enabled = false;
            }
            else
            {
                CBPrimero.Enabled = true;
            }
        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            BL.BLHoras BL_Horas = new BL.BLHoras();
            BL_Horas.ResetHoras();

            Response.Write("<script language='javascript'>alert('Se han inicializado todas las horas correctamente')</script>");

        }

    }
}