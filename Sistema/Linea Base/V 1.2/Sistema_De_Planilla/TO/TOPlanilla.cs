using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOPlanilla
    {
        private TOUsuario usuario;
        private TOTrabajdor trabjador;
        private TOCalculos calculos;

        public TOUsuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }
        public TOTrabajdor Trabajador
        {
            get { return trabjador; }
            set { trabjador = value; }
        }
        public TOCalculos Calculos
        {
            get { return calculos; }
            set { calculos = value; }
        }
       
    }
}