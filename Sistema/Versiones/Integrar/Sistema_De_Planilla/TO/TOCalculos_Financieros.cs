using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOCalculos_Financieros
    {
        private double id_trabajador;
        private double ahorro;
        private double interes;
        private double prestamo;
        private double c_prest;
        private double a_quincenal;
        private double a_mensual;
        private double embar;
        private double adelan;
        private double otros;
        private double subicidio;

        public double ID_trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
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
        public double Prestamo
        {
            get { return prestamo; }
            set { prestamo = value; }
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
        public double A_Mensual
        {
            get { return a_mensual; }
            set { a_mensual = value; }
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
        public double Subcidio
        {
            get { return subicidio; }
            set { subicidio = value; }
        }
    }
}
