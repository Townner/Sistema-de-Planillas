using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLFechas
    {
        public int trabajador_id;
        public string trabajador_ced;
        public string f_nac;
        public string f_ingreso;
        public string f_prueba;
        public string f_salida;


        public void Search(string ced)
        {
            DA.DAFechas sr = new DA.DAFechas();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.f_nac = sr.Search(ced).F_Nac;
            this.f_ingreso = sr.Search(ced).F_Ingreso;
            this.f_prueba = sr.Search(ced).F_Pruba;
            this.f_salida = sr.Search(ced).F_Salida;
        }

        public void AgregarFechas(BL.BLTrabajador BL_Trab)
        {
            TO.TOFechas TO_Fech = new TO.TOFechas();
            TO.TOTrabajador TO_Trab = new TO.TOTrabajador();
            TO_Trab.ID = BL_Trab.id;
            TO_Trab.Ced = BL_Trab.ced;

            TO_Fech.F_Nac = Convert.ToDateTime(this.f_nac).ToLongDateString() ;
            TO_Fech.F_Ingreso = Convert.ToDateTime(this.f_ingreso).ToLongDateString();
            TO_Fech.F_Pruba = Convert.ToDateTime(this.f_prueba).ToLongDateString();
            TO_Fech.F_Salida = Convert.ToDateTime(this.f_salida).ToLongDateString();

            DA.DAFechas afecha = new DA.DAFechas();
            afecha.AgregarFechas(TO_Fech,TO_Trab);

        }
        public void ModificarFechas(int ID, string ced, DateTime f_nac, DateTime f_ingreso, DateTime f_prueba, DateTime f_salida)
        {
            DA.DAFechas modfecha = new DA.DAFechas();
            modfecha.ModificarFechas(ced, f_nac, f_ingreso, f_prueba, f_salida);
        }
        public void ElimarFecha(string ced)
        {
            DA.DAFechas elfecha = new DA.DAFechas();
            elfecha.ElimarFecha(ced);
        }

    }
}
