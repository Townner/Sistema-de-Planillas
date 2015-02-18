using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLPrestamo
    {
        public void NuevaPrestamo(double prestamo)
        {
            TO.TOPrestamo pres = new TO.TOPrestamo();
            pres.Prestamo = prestamo;

            DA.DAPrestamo dpres = new DA.DAPrestamo();
            dpres.AprobarPrestamo(pres);
        }
        
        public void EditarPrestamo(TO.TOPrestamo pres)
        {
            DA.DAPrestamo edpres = new DA.DAPrestamo();
            edpres.EditarPrestamo(pres);
        }
        
        public TO.TOPrestamo ConsultarPrestamo(TO.TOPrestamo pres)
        {
            DA.DAPrestamo conpres = new DA.DAPrestamo();
            conpres.ConsultarPlanilla(pres);
            throw new NotImplementedException();
        }

        public void EliminarPrestamo(TO.TOPrestamo pres)
        {
            DA.DAPrestamo elpres = new DA.DAPrestamo();
            elpres.EliminarPrestamo(pres);
        }

        public double CalculoIntereses(double S_Bruto, double Interes)
        {
            double var = 0.0;

            var = S_Bruto * (Interes/100);

            DA.DAPrestamo calcint = new DA.DAPrestamo();
            calcint.CalculoIntereses(S_Bruto, Interes);

            return var;
        }

        

        

       
    }
}