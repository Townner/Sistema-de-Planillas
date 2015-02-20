using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TOUsuario
    {
        private int id_trabajador;
        private string Id;
        private string pass;
        private string estado;
        private string tipo;

        public int Id_Trabajador
        {
            get { return id_trabajador; }
            set { id_trabajador = value; }
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
        
        
    }
}