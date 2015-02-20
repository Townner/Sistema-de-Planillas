using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
{
    public class TOPlanilla
    {
        private TOUsuario usuario;

        public TOUsuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        private TOTrabajdor trabjador;

        public TOTrabajdor Trabajador
        {
            get { return trabjador; }
            set { trabjador = value; }
        }
        private TOCalculos calculos;

        public TOCalculos Calculos
        {
            get { return calculos; }
            set { calculos = value; }
        }
        private TOPrestamo prestamo;

        public TOPrestamo Prestamo
        {
            get { return prestamo; }
            set { prestamo = value; }
        }
        private TOAhorro ahorro;

        public TOAhorro Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }
       
    }
}