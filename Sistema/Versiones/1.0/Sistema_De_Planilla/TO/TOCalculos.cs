using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
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
        private double h_extra;
        private double incapacidad;
        private double a_quincenal;
        private double a_mensual;
        private double subsidio;


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
        public double H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }
        public double Incapacidad
        {
            get { return incapacidad; }
            set { incapacidad = value; }
        }
        public double A_Quincenal
        {
            get { return a_quincenal; }
            set { a_quincenal = value; }
        }
        public double A_Mensual
        {
            get { return a_mensual; }
            set { a_mensual = value; }
        }
        public double Subsidio
        {
            get { return subsidio; }
            set { subsidio = value; }
        }

    }
}