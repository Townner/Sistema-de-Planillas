using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ActualizarHoras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RegexCed1.Enabled = false;
        }

        protected void btConsultarLic_Click(object sender, EventArgs e)
        {
            BL.BLHoras BL_Horas = new BL.BLHoras();
            BL_Horas.Search(txtCed.Text);

            txtPermiso.Text = Convert.ToString(BL_Horas.h_permiso);
            txtLaboradas.Text = Convert.ToString(BL_Horas.h_laboradas);
            txtIncapacidad.Text = Convert.ToString(BL_Horas.h_incap);
            txtSubsidio.Text = Convert.ToString(BL_Horas.h_subcidio);
            txtExtra.Text = Convert.ToString(BL_Horas.h_extra);
            
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);
            
            if (BL_Trab.ced != "")
            {
                lblConfirm.Text = "Se ha verificado la informacion del trabajador " + " " + BL_Trab.nombre + " " + BL_Trab.apellido1 + " " + BL_Trab.apellido2;
                lblConfirm.Visible = true;
                btnAgregar.Visible = true;
                btConsultarLic.Visible = false;
                btnNew.Visible = true;
                btnAgregar.Visible = true;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarHoras.aspx" + "'; </script>");
            }
        }


       protected void btnAgregar_Click(object sender, EventArgs e)
        {
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);
            
            BL.BLHoras BL_Horas = new BL.BLHoras();
            BL_Horas.Search(txtCed.Text);
           
                BL_Horas.h_extra = Convert.ToInt32(txtExtra.Text);
                BL_Horas.h_incap = Convert.ToInt32(txtIncapacidad.Text);
                BL_Horas.h_laboradas = Convert.ToInt32(txtLaboradas.Text);
                BL_Horas.h_permiso = Convert.ToInt32(txtPermiso.Text);
                BL_Horas.h_subcidio = Convert.ToInt32(txtSubsidio.Text);

            if (BL_Horas.trabajador_ced == null)
            {
                BL_Horas.AgregarHoras(BL_Trab);
            }
            else {
                BL_Horas.ModificarHoras(BL_Trab);
            }

            Response.Write("<script language='javascript'>alert('El trabajador fue actualizado correctamente');document.location.href='" + "/ActualizarHoras.aspx" + "'; </script>");
        }

        protected void btnNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ActualizarHoras.aspx");
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBResidencia.Checked == true)
            {
                RegexCed1.Enabled = true;
                RegexCed.Enabled = false;
            }
            else
            {
                RegexCed1.Enabled = false;
                RegexCed.Enabled = true;
            }
        }
    }
}