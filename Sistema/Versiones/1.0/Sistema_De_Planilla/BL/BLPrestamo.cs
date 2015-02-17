using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using rnd.TOPrestamo;

namespace rnd
{
    public class BLPrestamo
    {
        public void NuevaPrestamo(double prestamo)
        {
            TOPrestamo pres = new TOPrestamo();
            pres.Prestamo = prestamo;
            
            DAPrestamo dpres = new DAPrestamo();
            dpres.AprobarPrestamo(pres);
        }
        
        public void EditarPrestamo(DAPrestamo pres)
        {
            DAPrestamo edpres = new DAPrestamo();
            edpres.EditarPrestamo(pres);
        }
        
        public DAPrestamo ConsultarPrestamo(DAPrestamo pres)
        {
            DAPrestamo conpres = new DAPrestamo();
            conpres.ConsultarPlanilla(pres);
            throw new NotImplementedException();
        }

        public void EliminarPrestamo(DAPrestamo pres)
        {
            DAPrestamo elpres = new DAPrestamo();
            elpres.EliminarPrestamo(pres);
        }

        public double CalculoIntereses()
        {
            throw new NotImplementedException();
        }

        

        

       
    }
}