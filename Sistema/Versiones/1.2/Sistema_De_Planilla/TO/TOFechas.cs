using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOFechas
    {
        private int ced;
        private DateTime f_nac;
        private DateTime f_ingreso;
        private DateTime f_prueba;
        private DateTime f_salida;
        
        public int Ced
        {
            get { return ced; }
            set { ced = value; }
        }
        public DateTime F_Nac
        {
            get { return f_nac; }
            set { f_nac = value; }
        }
        public DateTime F_Ingreso
        {
            get { return f_ingreso; }
            set { f_ingreso = value; }
        }
        public DateTime F_Pruba
        {
            get { return f_prueba; }
            set { f_prueba = value; }
        }
        public DateTime F_Salida
        {
            get { return f_salida; }
            set { f_salida = value; }
        }
    }
}
