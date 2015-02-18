using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLDepartamento
    {
        public void CrearDepartamento(int ID, string Nombre)
        {
            TO.TODepartamento dep = new TO.TODepartamento();
            dep.ID = ID;
            dep.Nombre = Nombre;

            DA.DADepartamento crdep = new DA.DADepartamento();
            crdep.CrearDepartamento(dep);
        }

        public void ModificarDeprtamento(TO.TODepartamento departamento)
        {
            DA.DADepartamento moddep = new DA.DADepartamento();
            moddep.ModificarDeprtamento(departamento);
        }

        public TO.TODepartamento ConsultarDepartameto(TO.TODepartamento departamento)
        {
            DA.DADepartamento condep = new DA.DADepartamento();
            condep.ConsultarDepartameto(departamento);
            throw new NotImplementedException();
        }

        public void EliminarDepartamento(TO.TODepartamento departamento)
        {
            DA.DADepartamento eldep = new DA.DADepartamento();
            eldep.EliminarDepartamento(departamento);
        }
    }
}