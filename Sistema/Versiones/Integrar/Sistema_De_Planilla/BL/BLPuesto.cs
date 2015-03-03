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

        public void Search(int id)
        {
            DA.DAPuesto sr = new DA.DAPuesto();
            this.id_puesto = sr.Search(id).ID_Puesto;
            this.nom_puesto = sr.Search(id).Nom_Puesto;
        }

        public void AgregarPuesto(int id, string nom)
        {
            DA.DAPuesto apuest = new DA.DAPuesto();
            apuest.AgregarPuesto(id, nom);
        }

        public void EditarPuesto(int id, string nom)
        {
            DA.DAPuesto edapln = new DA.DAPuesto();
            edapln.EditarPuesto(id, nom);
        }

        public void EliminarPuesto(int id)
        {
            DA.DAPuesto elapln = new DA.DAPuesto();
            elapln.EliminarPuesto(id);
        }
    }
    }

