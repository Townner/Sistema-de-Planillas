using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class ModificarCargarObreras : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CBPensionados_CheckedChanged(object sender, EventArgs e)
        {
            BL.BLCalculos BL_calc = new BL.BLCalculos();
            BL_calc.trabajador_ced
        }
    }
}