using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
{
    public class TOCalculos
    {
        private double imprenta;

        public double ImpRenta
        {
            get { return imprenta; }
            set { imprenta = value; }
        }
        private int hijos;

        public int Hijos
        {
            get { return hijos; }
            set { hijos = value; }
        }
        private int conyugue;

        public int Conyugue
        {
            get { return conyugue; }
            set { conyugue = value; }
        }
        private double cargas;

        public double Cargas
        {
            get { return cargas; }
            set { cargas = value; }
        }

        private double s_bruto;

        public double S_Bruto
        {
            get { return s_bruto; }
            set { s_bruto = value; }
        }
        private double s_neto;

        public double S_Neto
        {
            get { return s_neto; }
            set { s_neto = value; }
        }
        private double s_final;

        public double S_Final
        {
            get { return s_final; }
            set { s_final = value; }
        }
        private double h_extra;

        public double H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }

        private double incapacidad;

        public double Incapacidad
        {
            get { return incapacidad; }
            set { incapacidad = value; }
        }

        private double a_quincenal;

        public double A_Quincenal
        {
            get { return a_quincenal; }
            set { a_quincenal = value; }
        }
        private double a_mensual;

        public double A_Mensual
        {
            get { return a_mensual; }
            set { a_mensual = value; }
        }
        private double subsidio;

        public double Subsidio
        {
            get { return subsidio; }
            set { subsidio = value; }
        }

    }
}