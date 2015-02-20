using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    class BLPuesto
    {

        public void AgregarPuesto(int id, string nom)
        {

            TO.TOPuesto puesto = new TO.TOPuesto();
            puesto.ID_Puesto = id;


            DA.DAPuesto apuest = new DA.DAPuesto();
            apuest.AgregarPuesto(puesto);
        }

        public void EditarPuesto(TO.TOPuesto puesto)
        {
            DA.DAPuesto edapln = new DA.DAPuesto();
            edapln.EditarPuesto(puesto);
        }

        public TO.TOPuesto ConsultarPuesto(TO.TOPuesto puesto)
        {
            DA.DAPuesto conapln = new DA.DAPuesto();
            conapln.ConsultarPlanilla(puesto);
            throw new NotImplementedException();
        }

        public void EliminarPuesto(TO.TOPuesto puesto)
        {
            DA.DAPuesto elapln = new DA.DAPuesto();
            elapln.EliminarPuesto(puesto);
        }
    }
    }

