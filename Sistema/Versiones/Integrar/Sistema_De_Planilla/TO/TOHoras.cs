using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOHoras
    {
        private int ced;
        private int h_permiso;
        private int h_extra;
        private int h_incap;
        private int h_laboradas;
        private int subcidio;


        public int Ced
        {
            get { return ced; }
            set { ced = value; }
        }
        public int H_Permiso
        {
            get { return h_permiso; }
            set { h_permiso = value; }
        }
        public int H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }
        public int H_Incap
        {
            get { return h_incap; }
            set { h_incap = value; }
        }
        public int H_Laboradas
        {
            get { return h_laboradas; }
            set { h_laboradas = value; }
        }
        public int Subcidio
        {
            get { return subcidio; }
            set { subcidio = value; }
        }
        
    }
}
