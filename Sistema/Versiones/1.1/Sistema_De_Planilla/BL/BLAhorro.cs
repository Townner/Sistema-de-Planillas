using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLAhorro
    {
        public void AgregarAhrro(double ahorro)
        {
            TO.TOAhorro ahr = new TO.TOAhorro();
            ahr.Ahorro = ahorro;

            DA.DAAhorro aahr = new DA.DAAhorro();
            aahr.AgregarAhrro(ahr);
        }

        public void EditarAhorro(TO.TOAhorro ahorro)
        {
            DA.DAAhorro edahr = new DA.DAAhorro();
            edahr.EditarAhorro(ahorro);
        }

        public TO.TOAhorro ConsultarAhorro(TO.TOAhorro ahorro)
        {
            DA.DAAhorro conahr = new DA.DAAhorro();
            conahr.ConsultarAhorro(ahorro);
            throw new NotImplementedException();
        }

        public void ElimianrAhorro(TO.TOAhorro ahorro)
        {
            DA.DAAhorro elahr = new DA.DAAhorro();
            elahr.ElimianrAhorro(ahorro);
        }
    }
}