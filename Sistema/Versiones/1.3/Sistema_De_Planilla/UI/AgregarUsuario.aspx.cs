using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AgregarUsuarioaspx : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            int c = CargarDatos();

             if (c != 0)
            {
                    BL.BLUsuario BL_Usr = new BL.BLUsuario();
                    BL_Usr.Trabajador_Ced = this.txtCed.Text;
                    BL_Usr.Id = this.txtID.Text;
                    BL_Usr.pass = this.txtPass.Text;
                    //BL_Usr.estado = this.DropEstado.SelectedValue;
                   // BL_Usr.tipo = this.DropTipo.SelectedValue;
                    BL_Usr.AgregarUsuario();

                    Response.Write("<script language='javascript'>alert('El usuario fue agregado correctamente');document.location.href='" + "/AgregarUsuario.aspx" + "'; </script>");
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El trabajador con la cedula " + txtCed.Text + " no esta registrado en el sistema');document.location.href='" + "/AgregarUsuario.aspx" + "'; </script>");
            }


        }

        private int CargarDatos()
        {
            int c = 0;
            BL.BLTrabjador BL_Trab = new BL.BLTrabjador();
            c = BL_Trab.ConsultarTrabajador(txtCed.Text);
            return c;
        }

    }
}