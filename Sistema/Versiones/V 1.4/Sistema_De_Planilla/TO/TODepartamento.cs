using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TO
{
    public class TODepartamento
    {
        private int id_departamento;
        private string nom_departamento;

        public int Id_departamento
        {
            get { return id_departamento; }
            set { id_departamento = value; }
        }
        public string Nom_departamento
        {
            get { return nom_departamento; }
            set { nom_departamento = value; }
        }

    }
}