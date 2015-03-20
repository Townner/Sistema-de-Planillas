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
       
    }
}