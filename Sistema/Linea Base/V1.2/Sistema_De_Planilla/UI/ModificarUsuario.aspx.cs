using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Images
{
    public partial class ModificarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblModificar.Visible = false;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            lblModificar.Visible = true;
            btnUpdate.Visible = true;

            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.ConsultarUsuario(txtCed.Text);

            DropEstado.SelectedValue = BL_Usr.estado;
            DropTipo.SelectedValue = BL_Usr.tipo;

            if (BL_Usr.estado == null)
            {
                Response.Write("<script language='javascript'>alert('El usuario con la cedula " + txtCed.Text + " no existe')</script>");
            }
            else { 
               btnConsultar.Text = "Consultar de nuevo";
            } 
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.estado = this.DropEstado.SelectedValue;
            BL_Usr.tipo = this.DropTipo.SelectedValue;
            BL_Usr.ModifcarUsuario();

            txtCed.Text = "";

            Response.Write("<script>alert('Usuario modificado correctamente')</script>");
        }
    }
}