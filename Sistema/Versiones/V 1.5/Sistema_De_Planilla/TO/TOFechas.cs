using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOFechas
    {
        private int trabajador_id;
        private string trabajador_ced;
        private string f_nac;
        private string f_ingreso;
        private string f_prueba;
        private string f_salida;

        public int Trabajador_ID
        {
            get { return trabajador_id; }
            set { trabajador_id = value; }
        }
        public string Trabajador_Ced
        {
            get { return trabajador_ced; }
            set { trabajador_ced = value; }
        }
        public string F_Nac
        {
            get { return f_nac; }
            set { f_nac = value; }
        }
        public string F_Ingreso
        {
            get { return f_ingreso; }
            set { f_ingreso = value; }
        }
        public string F_Pruba
        {
            get { return f_prueba; }
            set { f_prueba = value; }
        }
        public string F_Salida
        {
            get { return f_salida; }
            set { f_salida = value; }
        }
    }
}
