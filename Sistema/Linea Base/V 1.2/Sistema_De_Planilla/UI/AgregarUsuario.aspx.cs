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
            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.Trabajador_Ced = this.txtCed.Text;
            BL_Usr.Id = this.txtID.Text;
            BL_Usr.estado = this.DropEstado.SelectedValue;
            BL_Usr.tipo = this.DropTipo.SelectedValue;
            BL_Usr.AgregarUsuario();

            txtCed.Text = "";
            txtID.Text = "";
            txtPass.Text = "";
            DropEstado.SelectedValue = "Default";
            DropTipo.SelectedValue = "Default";

        }
    }
}