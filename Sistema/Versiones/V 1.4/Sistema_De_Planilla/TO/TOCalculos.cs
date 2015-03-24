using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOCalculos
    {
        private int trabajadr_id;
        private string trabajador_ced;
        private double imprenta;
        private int hijos_menor; 
        private int hijos_mayor;
        private int conyugue;
        private double ob_pat_pen;   
        private double ob_pat_nopen;
        private double s_final;
        private double s_cargas;
        private double s_extras;
        private double s_incapcidad;
        private double s_base;
        private double s_bruto;
        private double s_neto;
       


        public int Hijos_Mayor
        {
            get { return hijos_mayor; }
            set { hijos_mayor = value; }
        }
        

        public double Ob_Pat_NoPen
        {
            get { return ob_pat_nopen; }
            set { ob_pat_nopen = value; }
        }
        
        public int Trabajador_ID
        {
            get { return trabajadr_id; }
            set { trabajadr_id = value; }
        }
        public string Trabajador_Ced
        {
            get { return trabajador_ced; }
            set { trabajador_ced = value; }
        }
        public double ImpRenta
        {
            get { return imprenta; }
            set { imprenta = value; }
        }
        public int Hijos_Menor
        {
            get { return hijos_menor; }
            set { hijos_menor = value; }
        }
        public int Conyugue
        {
            get { return conyugue; }
            set { conyugue = value; }
        }
        public double S_Incapacidad
        {
            get { return s_incapcidad; }
            set { s_incapcidad = value; }
        }
        public double Ob_Pat_Pen
        {
            get { return ob_pat_pen; }
            set { ob_pat_pen = value; }
        }
        public double S_Cargas
        {
            get { return s_cargas; }
            set { s_cargas = value; }
        }
        public double S_Extras
        {
            get { return s_extras; }
            set { s_extras = value; }
        }
        public double S_Base
        {
            get { return s_base; }
            set { s_base = value; }
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