using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLPuesto
    {

        public int id_puesto;
        public string nom_puesto;

        public Boolean ExistePuesto()
        {
            Boolean bandera = false;

            TO.TOPuesto TO_Puest = new TO.TOPuesto();
            TO_Puest.ID_Puesto = this.id_puesto;
            TO_Puest.Nom_Puesto = this.nom_puesto;
            
            DA.DAPuesto sr = new DA.DAPuesto();
            if (sr.BuscarPuesto(TO_Puest.Nom_Puesto).Nom_Puesto == this.nom_puesto)
            {
                bandera = true;
            }

            return bandera;
        }

        public void BuscarPuesto(string nombre)
        {
            DA.DAPuesto sr = new DA.DAPuesto();
            this.id_puesto = sr.BuscarPuesto(nombre).ID_Puesto;
            this.nom_puesto = sr.BuscarPuesto(nombre).Nom_Puesto;
        }

        public void AgregarPuesto()
        {
            TO.TOPuesto TO_Puest = new TO.TOPuesto();
            TO_Puest.ID_Puesto = this.id_puesto;
            TO_Puest.Nom_Puesto = this.nom_puesto;

            DA.DAPuesto apuest = new DA.DAPuesto();
            apuest.AgregarPuesto(TO_Puest);
        }

        public void EditarPuesto(string oldname)
        {
            TO.TOPuesto TO_Puest = new TO.TOPuesto();
            TO_Puest.ID_Puesto = this.id_puesto;
            TO_Puest.Nom_Puesto = this.nom_puesto;

            DA.DAPuesto edapln = new DA.DAPuesto();
            edapln.EditarPuesto(TO_Puest, oldname);
        }

        public void EliminarPuesto()
        {
            TO.TOPuesto TO_Puest = new TO.TOPuesto();
            TO_Puest.Nom_Puesto = this.nom_puesto;

            DA.DAPuesto elapln = new DA.DAPuesto();
            elapln.EliminarPuesto(TO_Puest.Nom_Puesto);
        }
    }
    }

