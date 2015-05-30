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
        public int h_subcidio;

        public void Search(string ced)
        {
            DA.DAHoras sr = new DA.DAHoras();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.h_permiso = sr.Search(ced).H_Permiso;
            this.h_extra = sr.Search(ced).H_Extra;
            this.h_incap = sr.Search(ced).H_Incap;
            this.h_laboradas = sr.Search(ced).H_Laboradas;
            this.h_subcidio = sr.Search(ced).H_Subcidio;

        }

        public void AgregarHoras(BL.BLTrabajador BL_Trab)
        {
            TO.TOHoras TO_Horas = new TO.TOHoras();
            TO_Horas.Trabajador_Ced = BL_Trab.ced;
            TO_Horas.Trabajador_ID = BL_Trab.id;
            TO_Horas.H_Extra = this.h_extra;
            TO_Horas.H_Incap = this.h_incap;
            TO_Horas.H_Laboradas = this.h_laboradas;
            TO_Horas.H_Permiso = this.h_permiso;
            TO_Horas.H_Subcidio = this.h_subcidio;

            DA.DAHoras ahora = new DA.DAHoras();
            ahora.AgragarHoras(TO_Horas);

        }
        public void ModificarHoras(BL.BLTrabajador BL_Trab)
        {
            TO.TOHoras TO_Horas = new TO.TOHoras();
            TO_Horas.Trabajador_Ced = BL_Trab.ced;
            TO_Horas.Trabajador_ID = BL_Trab.id;
            TO_Horas.H_Extra = this.h_extra;
            TO_Horas.H_Incap = this.h_incap;
            TO_Horas.H_Laboradas = this.h_laboradas;
            TO_Horas.H_Permiso = this.h_permiso;
            TO_Horas.H_Subcidio = this.h_subcidio;

            DA.DAHoras modhora = new DA.DAHoras();
            modhora.ModificarHoras(TO_Horas);
        }

        public void ResetHoras() {

            DA.DAHoras modhora = new DA.DAHoras();
            modhora.ResetHoras();
           
        }
        
    }
}
