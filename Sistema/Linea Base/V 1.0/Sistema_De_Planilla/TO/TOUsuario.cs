using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
{
    public class TOUsuario
    {
        private int id_trabajador;

        public int Id_Trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
        }

        private string Id;

        public string ID
        {
            get { return Id; }
            set { Id = value; }
        }

        private string pass;

        public string Pass
        {
            get { return pass; }
            set { pass = value; }
        }

        private string estado;

        public string Estado
        {
            get { return estado; }
            set { estado = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        
        
    }
}