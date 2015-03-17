using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AgregarPuesto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            BL.BLPuesto BL_Puest = new BL.BLPuesto();
            BL_Puest.nom_puesto = this.txtNombre.Text;
            BL_Puest.AgregarPuesto();

            Response.Write("<script language='javascript'>alert('El puesto fue agregado correctamente');document.location.href='" + "/AgregarPuesto.aspx" + "'; </script>");
        }
    }
}