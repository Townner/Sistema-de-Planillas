using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOCalculos_Financieros
    {
        private int trabajador_id;
        private string trabajador_ced;
        private double ahorro;
        private double interes;
        private double m_prestamo;
        private double c_prest;
        private double a_quincenal;
        private double a_mensual1;
        private double a_mensual2;
        private double embar;
        private double adelan;
        private double otros;
        private double m_subcidio;
        private double s_subcidio;


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
        public double Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }
        public double Interes
        {
            get { return interes; }
            set { interes = value; }
        }
        public double M_Prestamo
        {
            get { return m_prestamo; }
            set { m_prestamo = value; }
        }
        public double C_Prest
        {
            get { return c_prest; }
            set { c_prest = value; }
        }

        public double A_Quincenal
        {
            get { return a_quincenal; }
            set { a_quincenal = value; }
        }
        public double A_Mensual1
        {
            get { return a_mensual1; }
            set { a_mensual1 = value; }
        }
        public double A_Mensual2
        {
            get { return a_mensual2; }
            set { a_mensual2 = value; }
        }

        public double Embar
        {
            get { return embar; }
            set { embar = value; }
        }
        public double Adelan
        {
            get { return adelan; }
            set { adelan = value; }
        }
        public double Otros
        {
            get { return otros; }
            set { otros = value; }
        }
        public double M_Subcidio
        {
            get { return m_subcidio; }
            set { m_subcidio = value; }
        }
        public double S_Subcidio
        {
            get { return s_subcidio; }
            set { s_subcidio = value; }
        }

    }
}
