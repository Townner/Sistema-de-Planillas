using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLHoras
    {
        public int trabajador_id;
        public string trabajador_ced;
        public int h_permiso;
        public int h_extra;
        public int h_incap;
        public int h_laboradas;
        public int subcidio;

        public void Search(string ced)
        {
            DA.DAHoras sr = new DA.DAHoras();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.h_permiso = sr.Search(ced).H_Permiso;
            this.h_extra = sr.Search(ced).H_Extra;
            this.h_incap = sr.Search(ced).H_Incap;
            this.h_laboradas = sr.Search(ced).H_Laboradas;
            this.subcidio = sr.Search(ced).Subcidio;

        }

        public void AgragarHoras(int id, string ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            DA.DAHoras ahora = new DA.DAHoras();
            ahora.AgragarHoras(id, ced, h_permiso, h_extra, h_incap, h_laboradas, subicidio);

        }
        public void ModificarHoras(int id, string ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            DA.DAHoras modhora = new DA.DAHoras();
            modhora.ModificarHoras(id, ced, h_permiso, h_extra, h_incap, h_laboradas, subicidio);
        }
        public void ElimarHora(string ced)
        {
            DA.DAHoras elhora = new DA.DAHoras();
            elhora.ElimarHora(ced);
        }
    }
}
