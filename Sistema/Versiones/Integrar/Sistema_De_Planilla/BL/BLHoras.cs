using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLHoras
    {
        public void AgragarHoras(int ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            TO.TOHoras hora = new TO.TOHoras();
            hora.Ced = ced;
            hora.H_Permiso = h_permiso;
            hora.H_Extra = h_extra;
            hora.H_Incap = h_incap;
            hora.H_Laboradas = h_laboradas;
            hora.Subcidio = subicidio;

            DA.DAHoras ahora = new DA.DAHoras();
            ahora.AgragarHoras(hora);

        }
        public void ModificarHoras(TO.TOHoras horas)
        {
            DA.DAHoras modhora = new DA.DAHoras();
            modhora.ModificarHoras(horas);
        }
        public TO.TOHoras ConsultarHora(TO.TOHoras horas)
        {
            DA.DAHoras conshra = new DA.DAHoras();
            conshra.ConsultarHora(horas);
            throw new NotFiniteNumberException();
        }
        public void ElimarHora(TO.TOHoras horas)
        {
            DA.DAHoras elhora = new DA.DAHoras();
            elhora.ElimarHora(horas);
        }
    }
}
