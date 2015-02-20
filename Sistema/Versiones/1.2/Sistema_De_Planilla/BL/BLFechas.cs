using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLFechas
    {
        public void AgregarFechas(int ced, DateTime f_nac, DateTime f_ingreso, DateTime f_prueba, DateTime f_salida)
        {
            TO.TOFechas fecha = new TO.TOFechas();
            fecha.Ced = ced;
            fecha.F_Nac = f_nac;
            fecha.F_Ingreso = f_ingreso;
            fecha.F_Pruba = f_prueba;
            fecha.F_Salida = f_salida;

            DA.DAFechas afecha = new DA.DAFechas();
            afecha.AgregarFechas(fecha);

        }
        public void ModificarFechas(TO.TOFechas fecha)
        {
            DA.DAFechas modfecha = new DA.DAFechas();
            modfecha.ModificarFechas(fecha);
        }
        public TO.TOHoras ConsultarFecha(TO.TOFechas fecha)
        {
            DA.DAFechas consfecha = new DA.DAFechas();
            consfecha.ConsultarFecha(fecha);
            throw new NotFiniteNumberException();
        }
        public void ElimarFecha(TO.TOFechas fecha)
        {
            DA.DAFechas elfecha = new DA.DAFechas();
            elfecha.ElimarFecha(fecha);
        }

    }
}
