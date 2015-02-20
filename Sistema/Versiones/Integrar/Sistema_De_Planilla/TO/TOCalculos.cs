using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOCalculos
    {
        private double imprenta;
        private int hijos;
        private int conyugue;
        private double cargas;
        private double s_bruto;
        private double s_neto;
        private double s_final;
        

        public double ImpRenta
        {
            get { return imprenta; }
            set { imprenta = value; }
        }
        public int Hijos
        {
            get { return hijos; }
            set { hijos = value; }
        }
        public int Conyugue
        {
            get { return conyugue; }
            set { conyugue = value; }
        }
        public double Cargas
        {
            get { return cargas; }
            set { cargas = value; }
        }
        public double S_Bruto
        {
            get { return s_bruto; }
            set { s_bruto = value; }
        }
        public double S_Neto
        {
            get { return s_neto; }
            set { s_neto = value; }
        }
        public double S_Final
        {
            get { return s_final; }
            set { s_final = value; }
        }
        
    }
}