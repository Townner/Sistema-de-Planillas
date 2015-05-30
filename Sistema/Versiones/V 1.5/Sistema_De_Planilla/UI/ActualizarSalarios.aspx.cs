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
                DDLConyuge.SelectedValue = conyuge;


                BL.BLCalculos_Financieros BL_Finan = new BL.BLCalculos_Financieros();
                BL_Finan.Search(txtCed.Text);

                txtMPrestamo.Text = Convert.ToString(BL_Finan.m_prestamo);
                txtCPrestamo.Text = Convert.ToString(BL_Finan.c_prest);
                txtIntereses.Text = Convert.ToString(BL_Finan.interes);
                txtAhorros.Text = Convert.ToString(BL_Finan.ahorro);
                txtEmbargos.Text = Convert.ToString(BL_Finan.embar);
                txtAdelantos.Text = Convert.ToString(BL_Finan.adelan);
                txtOtros.Text = Convert.ToString(BL_Finan.otros);
                txtMSubsidio.Text = Convert.ToString(BL_Finan.m_subcidio);
                txtAQuincenal.Text = Convert.ToString(BL_Finan.a_quincenal);
                txtAMensual1.Text = Convert.ToString(BL_Finan.a_mensual1);
                txtAMensual2.Text = Convert.ToString(BL_Finan.a_mensual2);
               

            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario " + txtCed.Text + " no existe en el sistema');document.location.href='" + "/ActualizarSalarios.aspx" + "'; </script>");
            }
            
            



            
        }

        protected void btnNueva_Click(object sender, EventArgs e)
        {
            Response.Redirect("/ActualizarSalarios.aspx");
        }

        protected void btnActua_Click(object sender, EventArgs e)
        {
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.Search(txtCed.Text);

            BL.BLCalculos BL_Calcu = new BL.BLCalculos();
            BL_Calcu.Search(txtCed.Text);

            BL.BLCalculos_Financieros BL_Finan = new BL.BLCalculos_Financieros();
            BL_Finan.Search(txtCed.Text);

            if (BL_Calcu.trabajador_ced == null && BL_Finan.trabajador_ced == null)
            {

                if (DDLConyuge.SelectedValue == "Si Tiene")
                {
                    BL_Calcu.conyugue = 1;
                }
                else
                {
                    BL_Calcu.conyugue = 0;
                }

                BL_Calcu.trabajador_id = BL_Trab.id;
                BL_Calcu.trabajador_ced = BL_Trab.ced;
                BL_Calcu.s_base = Convert.ToDouble(txtBase.Text);
                BL_Calcu.hijos_mayor = Convert.ToInt32(txtMayores.Text);
                BL_Calcu.hijos_menor = Convert.ToInt32(txtMenores.Text);

                BL_Calcu.imprenta = 0;
                BL_Calcu.ob_pat_nopen = 0;
                BL_Calcu.ob_pat_pen = 0;
                BL_Calcu.s_cargas = 0;
                BL_Calcu.s_extras = 0;
                BL_Calcu.s_incapcidad = 0;
                BL_Calcu.s_bruto = 0;
                BL_Calcu.s_neto = 0;
                BL_Calcu.s_final = 0;


                BL_Finan.trabajador_id = BL_Trab.id;
                BL_Finan.trabajador_ced = BL_Trab.ced;
                BL_Finan.m_prestamo = Convert.ToDouble(txtMPrestamo.Text);
                BL_Finan.c_prest = Convert.ToDouble(txtCPrestamo.Text);
                BL_Finan.interes = Convert.ToDouble(txtIntereses.Text);
                BL_Finan.ahorro = Convert.ToDouble(txtAhorros.Text);
                BL_Finan.embar = Convert.ToDouble(txtEmbargos.Text);
                BL_Finan.adelan = Convert.ToDouble(txtAdelantos.Text);
                BL_Finan.otros = Convert.ToDouble(txtOtros.Text);
                BL_Finan.m_subcidio = Convert.ToDouble(txtMSubsidio.Text);
                BL_Finan.a_quincenal = Convert.ToDouble(txtAQuincenal.Text);
                BL_Finan.a_mensual1 = Convert.ToDouble(txtAMensual1.Text);
                BL_Finan.a_mensual2 = Convert.ToDouble(txtAMensual2.Text);

                BL_Calcu.AgregarSalario();
                BL_Finan.AgregarCalculos();

                Response.Write("<script language='javascript'>alert('Se actualizo correctamente al trabajador');document.location.href='" + "/ActualizarSalarios.aspx" + "'; </script>");

            }
            else { //Ya tiene registros

                if (DDLConyuge.SelectedValue == "Si Tiene")
                {
                    BL_Calcu.conyugue = 1;
                }
                else
                {
                    BL_Calcu.conyugue = 0;
                }

                BL_Calcu.trabajador_id = BL_Trab.id;
                BL_Calcu.trabajador_ced = BL_Trab.ced;
                BL_Calcu.s_base = Convert.ToDouble(txtBase.Text);
                BL_Calcu.hijos_mayor = Convert.ToInt32(txtMayores.Text);
                BL_Calcu.hijos_menor = Convert.ToInt32(txtMenores.Text);

                BL_Finan.trabajador_id = BL_Trab.id;
                BL_Finan.trabajador_ced = BL_Trab.ced;
                BL_Finan.m_prestamo = Convert.ToDouble(txtMPrestamo.Text);
                BL_Finan.c_prest = Convert.ToDouble(txtCPrestamo.Text);
                BL_Finan.interes = Convert.ToDouble(txtIntereses.Text);
                BL_Finan.ahorro = Convert.ToDouble(txtAhorros.Text);
                BL_Finan.embar = Convert.ToDouble(txtEmbargos.Text);
                BL_Finan.adelan = Convert.ToDouble(txtAdelantos.Text);
                BL_Finan.otros = Convert.ToDouble(txtOtros.Text);
                BL_Finan.m_subcidio = Convert.ToDouble(txtMSubsidio.Text);
                BL_Finan.a_quincenal = Convert.ToDouble(txtAQuincenal.Text);
                BL_Finan.a_mensual1 = Convert.ToDouble(txtAMensual1.Text);
                BL_Finan.a_mensual2 = Convert.ToDouble(txtAMensual2.Text);

                BL_Calcu.ModificarCalculos(BL_Trab);
                BL_Finan.ModificarCalculos(BL_Trab);

                Response.Write("<script language='javascript'>alert('Se actualizo correctamente al trabajador');document.location.href='" + "/ActualizarSalarios.aspx" + "'; </script>");
             
            }
       

            
        }
    }
}