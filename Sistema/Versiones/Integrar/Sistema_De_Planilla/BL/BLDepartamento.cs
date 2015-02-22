using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLDepartamento
    {
        public int id;
        public string nombre;

        public void Search(int id)
        {
            DA.DADepartamento sr = new DA.DADepartamento();
            this.id = sr.Search(id).ID;
            this.nombre = sr.Search(id).Nombre;
        }

        public void CrearDepartamento(int ID, string Nombre)
        {
            
            this.id = ID;
            this.nombre = Nombre;

            DA.DADepartamento crdep = new DA.DADepartamento();
            crdep.CrearDepartamento(id, nombre);
        }

        public void ModificarDeprtamento(int id, string nombre)
        {
            DA.DADepartamento moddep = new DA.DADepartamento();
            moddep.Search(id);
            moddep.ModificarDeprtamento(nomber);
        }

        public void EliminarDepartamento(int id, string nombre)
        {
            DA.DADepartamento eldep = new DA.DADepartamento();
            eldep.Search(id);
            eldep.EliminarDepartamento(nombre);
        }
    }
}