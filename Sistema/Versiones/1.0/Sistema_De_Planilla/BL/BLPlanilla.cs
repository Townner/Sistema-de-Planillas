using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLPlanilla
    {
        public void AgregarPlanilla(TOUsuario usuario, TOTrabajdor trabajador
            , TOCalculos calculos, TOPrestamo prestamo, TOAhorro ahorro)
        {
            TOPlanilla pln = new TOPlanilla();
            pln.Usuario = usuario;
            pln.Trabajador = trabajador;
            pln.Calculos = calculos;
            pln.Prestamo = prestamo;
            pln.Ahorro = ahorro;

            DAPlanilla apln = new DAPlanilla();
            apln.AgregarPlanilla(pln);
        }

        public void EditarPlanilla(TOPlanilla planilla)
        {
            DAPlanilla edapln = new DAPlanilla();
            edapln.EditarPlanilla(planilla);
        }

        public TOPrestamo ConsultarPlanilla(TOPlanilla planilla)
        {
            DAPlanilla conapln = new DAPlanilla();
            conapln.ConsultarPlanilla(planilla);
            throw new NotImplementedException();
        }

        public void EliminarPlanilla(TOPlanilla planilla)
        {
            DAPlanilla elapln = new DAPlanilla();
            elapln.EliminarPlanilla(planilla);
        }
    }
}