using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOPlanilla
    {
        private TOUsuario usuario;
        private TOTrabajador trabjador;
        private TOCalculos calculos;
        private TOPrestamo prestamo;
        private TOAhorro ahorro;

        public TOUsuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public TOTrabajador Trabajador
        {
            get { return trabjador; }
            set { trabjador = value; }
        }
        public TOCalculos Calculos
        {
            get { return calculos; }
            set { calculos = value; }
        }
        public TOPrestamo Prestamo
        {
            get { return prestamo; }
            set { prestamo = value; }
        }
        public TOAhorro Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }
       
    }
}