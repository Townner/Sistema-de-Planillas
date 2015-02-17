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
            TODepartamento dep = new TODepartamento();
            dep.ID = ID;
            dep.Nombre = Nombre;

            DADepartamento crdep = new DADepartamento();
            crdep.CrearDepartamento(dep);
        }

        public void ModificarDeprtamento(TODepartamento departamento)
        {
            DADepartamento moddep = new DADepartamento();
            moddep.ModificarDeprtamento(departamento);
        }

        public TODepartamento ConsultarDepartameto(TODepartamento departamento)
        {
            DADepartamento condep = new DADepartamento();
            condep.ConsultarDepartameto(departamento);
            throw new NotImplementedException();
        }

        public void EliminarDepartamento(TODepartamento departamento)
        {
            DADepartamento eldep = new DADepartamento();
            eldep.EliminarDepartamento(departamento);
        }
    }
}