using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AgregarDepartamento : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReg_Click(object sender, EventArgs e)
        {
            BL.BLDepartamento BL_Dep = new BL.BLDepartamento();
            BL_Dep.nom_departamento = this.txtNombre.Text;
            BL_Dep.AgregarDepartamento();

            Response.Write("<script language='javascript'>alert('El departamento fue agregado correctamente');document.location.href='" + "/AgregarDepartamento.aspx" + "'; </script>");
        
        }
    }
}