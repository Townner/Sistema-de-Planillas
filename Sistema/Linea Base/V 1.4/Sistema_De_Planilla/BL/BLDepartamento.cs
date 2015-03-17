using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLDepartamento
    {
        public int id_departamento;
        public string nom_departamento;

        public Boolean ExisteDepartamento()
        {
            Boolean bandera = false;

            TO.TODepartamento TO_Dep = new TO.TODepartamento();
            TO_Dep.Id_departamento = this.id_departamento;
            TO_Dep.Nom_departamento = this.nom_departamento;

            DA.DADepartamento sr = new DA.DADepartamento();
            if (sr.BuscarDepartamento(TO_Dep.Nom_departamento).Nom_departamento == this.nom_departamento)
            {
                bandera = true;
            }

            return bandera;
        }

        public void BuscarDepartamento(string nombre)
        {
            DA.DADepartamento sr = new DA.DADepartamento();
            this.id_departamento = sr.BuscarDepartamento(nombre).Id_departamento;
            this.nom_departamento = sr.BuscarDepartamento(nombre).Nom_departamento;
        }

        public void AgregarDepartamento()
        {
            TO.TODepartamento TO_Puest = new TO.TODepartamento();
            TO_Puest.Id_departamento = this.id_departamento;
            TO_Puest.Nom_departamento = this.nom_departamento;

            DA.DADepartamento apuest = new DA.DADepartamento();
            apuest.AgregarDepartamento(TO_Puest);
        }

        public void EditarDepartamento(string oldname)
        {
            TO.TODepartamento TO_Puest = new TO.TODepartamento();
            TO_Puest.Id_departamento = this.id_departamento;
            TO_Puest.Nom_departamento = this.nom_departamento;

            DA.DADepartamento edapln = new DA.DADepartamento();
            edapln.EditarDepartamento(TO_Puest, oldname);
        }

        public void EliminarDepartamento()
        {
            TO.TODepartamento TO_Puest = new TO.TODepartamento();
            TO_Puest.Nom_departamento = this.nom_departamento;

            DA.DADepartamento elapln = new DA.DADepartamento();
            elapln.EliminarDepartamento(TO_Puest.Nom_departamento);
        }
    }
}