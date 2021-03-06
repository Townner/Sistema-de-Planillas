﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLPlanilla
    {
        public void AgregarPlanilla(TO.TOUsuario usuario, TO.TOTrabajador trabajador
            , TO.TOCalculos calculos)
        {
            TO.TOPlanilla pln = new TO.TOPlanilla();
            pln.Usuario = usuario;
            pln.Trabajador = trabajador;
            pln.Calculos = calculos;

            DA.DAPlanilla apln = new DA.DAPlanilla();
            apln.AgregarPlanilla(pln);
        }

        public void EditarPlanilla(TO.TOPlanilla planilla)
        {
            DA.DAPlanilla edapln = new DA.DAPlanilla();
            edapln.EditarPlanilla(planilla);
        }

        public TO.TOCalculos_Financieros ConsultarPlanilla(TO.TOPlanilla planilla)
        {
            DA.DAPlanilla conapln = new DA.DAPlanilla();
            conapln.ConsultarPlanilla(planilla);
            throw new NotImplementedException();
        }

        public void EliminarPlanilla(TO.TOPlanilla planilla)
        {
            DA.DAPlanilla elapln = new DA.DAPlanilla();
            elapln.EliminarPlanilla(planilla);
        }
    }
}