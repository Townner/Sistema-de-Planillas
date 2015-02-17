using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
{
    public class BLAhorro
    {
        public void AgregarAhrro(double ahorro)
        {
            TOAhorro ahr = new TOAhorro();
            ahr.Ahorro = ahorro;

            DAAhorro aahr = new DAAhorro();
            aahr.AgregarAhrro(ahr);
        }

        public void EditarAhorro(TOAhorro ahorro)
        {
            DAAhorro edahr = new DAAhorro();
            edahr.EditarAhorro(ahorro);
        }

        public TOAhorro ConsultarAhorro(TOAhorro ahorro)
        {
            DAAhorro conahr = new DAAhorro();
            conahr.ConsultarAhorro(ahorro);
            throw new NotImplementedException();
        }

        public void ElimianrAhorro(TOAhorro ahorro)
        {
            DAAhorro elahr = new DAAhorro();
            elahr.ElimianrAhorro(ahorro);
        }
    }
}