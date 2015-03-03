using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOUsuario
    {
        private int trabajador_ID;   
        private string trabajador_Ced;
        private string Id;
        private string pass;
        private string estado;
        private string tipo;
        private string sesion;

        public int Trabajador_ID
        {
            get { return trabajador_ID; }
            set { trabajador_ID = value; }
        }

        public string Trabajador_Ced
        {
            get { return trabajador_Ced; }
            set { trabajador_Ced = value; }
        }
        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }
        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }
        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }


        public string Sesion
        {
            get { return sesion; }
            set { sesion = value; }
        }

    }
}