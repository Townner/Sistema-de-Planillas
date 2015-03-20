using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UI
{
    public partial class AumentoSalarioBase : System.Web.UI.Page
    {
       private SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);
       private int mis = 0;
       private int jar = 0;
       private int cho = 0;

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (cbNumerico.Checked == true)
            {
                cbPorcentual.Enabled = false;
                txtNumerico.Visible = true;
            }
            else {
                cbPorcentual.Enabled = true;
                txtNumerico.Visible = false;
            }
        }

        protected void cbPorcentual_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPorcentual.Checked == true)
            {
                cbNumerico.Enabled = false;
                txtProcentual.Visible = true;
                lblProcent.Visible = true;
            }
            else
            {
                cbNumerico.Enabled = true;
                txtProcentual.Visible = false;
                lblProcent.Visible = false;
            }
        }

        protected void btnAplicar_Click(object sender, EventArgs e)
        {
            if (CBMisce.Checked || CBJar.Checked || CBChof.Checked)
            {
                if (cbNumerico.Checked || cbPorcentual.Checked)
                {

                    if (CBMisce.Checked == true)
                    {

                        mis = mis + 1;

                        if (cbNumerico.Checked == true)
                        {

                            if (txtNumerico.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo numerico');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = Convert.ToDouble(this.txtNumerico.Text);

                                BL_Calcu.CalculoAumentoSalarioBase(mis, jar, cho);

                            }
                        }

                        if (cbPorcentual.Checked == true)
                        {

                            if (txtProcentual.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo porcentual');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = (double.Parse(this.txtProcentual.Text) / 100);

                                BL_Calcu.CalculoAumentoSalarioBasePorcentual(mis, jar, cho);

                            }


                        }
                        mis = mis - 1;


                    } // End if Miscelaneos

                    if (CBJar.Checked == true)
                    {

                        jar = jar + 1;

                        if (cbNumerico.Checked == true)
                        {
                            if (txtNumerico.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo numerico');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = Convert.ToDouble(this.txtNumerico.Text);

                                BL_Calcu.CalculoAumentoSalarioBase(mis, jar, cho);

                            }
                        }

                        if (cbPorcentual.Checked == true)
                        {
                            if (txtProcentual.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo procentual');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = (double.Parse(this.txtProcentual.Text) / 100);

                                BL_Calcu.CalculoAumentoSalarioBasePorcentual(mis, jar, cho);
                            }
                        }

                        jar = jar - 1;
                    } // End if Jardineros

                    if (CBChof.Checked == true)
                    {

                        cho = cho + 1;

                        if (cbNumerico.Checked == true)
                        {
                            if (txtNumerico.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo numerico');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = Convert.ToDouble(this.txtNumerico.Text);

                                BL_Calcu.CalculoAumentoSalarioBase(mis, jar, cho);

                            }
                        }

                        if (cbPorcentual.Checked == true)
                        {
                            if (txtProcentual.Text == "")
                            {
                                Response.Write("<script language='javascript'>alert('Inserte un valor en el campo porcentual');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                            }
                            else
                            {

                                BL.BLCalculos BL_Calcu = new BL.BLCalculos();
                                BL_Calcu.s_base = (double.Parse(this.txtProcentual.Text) / 100);

                                BL_Calcu.CalculoAumentoSalarioBasePorcentual(mis, jar, cho);

                            }


                        }
                        cho = cho - 1;
                    } // End if Jardineros

                    Response.Write("<script language='javascript'>alert('El aumento de " + txtNumerico.Text + " se a aplicado correctamente a los trabajadores');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");
                }
                else
                { // end validacion de segundo check box

                    Response.Write("<script language='javascript'>alert('Debe seleccionar al menos un valor a aumentar');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");

                }
            }
            else
            { // end validacion del primer chech box

                Response.Write("<script language='javascript'>alert('Debe seleccionar al menos un puesto');document.location.href='" + "/AumentoSalarioBase.aspx" + "'; </script>");

            }
          }

      }
    }
