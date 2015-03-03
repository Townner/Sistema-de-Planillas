using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TODepartamento
    {
        private int id;
        private string nombre;
        
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

    }
}