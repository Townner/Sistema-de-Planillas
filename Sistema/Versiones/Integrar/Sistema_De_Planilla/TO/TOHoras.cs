using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOHoras
    {
        private int trabajador_id;
        private string trabajador_ced;
        private DateTime h_permiso;
        private DateTime h_extra;
        private DateTime h_incap;
        private DateTime h_laboradas;
        private DateTime subcidio;

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
        public DateTime H_Permiso
        {
            get { return h_permiso; }
            set { h_permiso = value; }
        }
        public DateTime H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }
        public DateTime H_Incap
        {
            get { return h_incap; }
            set { h_incap = value; }
        }
        public DateTime H_Laboradas
        {
            get { return h_laboradas; }
            set { h_laboradas = value; }
        }
        public DateTime Subcidio
        {
            get { return subcidio; }
            set { subcidio = value; }
        }
        
    }
}
