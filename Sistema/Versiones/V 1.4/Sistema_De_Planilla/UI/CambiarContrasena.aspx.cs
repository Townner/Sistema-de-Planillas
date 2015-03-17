using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI.Images
{
    public partial class CambiarContrasena : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            BL.BLUsuario BL_Usr = new BL.BLUsuario();
            BL_Usr.ConsultarPassViejo((string)Session["UserName"]);

            if (BL_Usr.pass == txtViejo.Text)
            {
                BL.BLUsuario BL_UsrNew = new BL.BLUsuario();
                BL_UsrNew.CambiarPass((string)Session["UserName"], txtNew.Text);

                Response.Write("<script language='javascript'>alert('Su contraseña se ha cambiado satisfactoriamente');document.location.href='" + "/CambiarContrasena.aspx" + "'; </script>");
            }
            else {

                Response.Write("<script language='javascript'>alert('Su antigua contraseña no coincide');document.location.href='" + "/CambiarContrasena.aspx" + "'; </script>");
            
            }
        }
    }
}