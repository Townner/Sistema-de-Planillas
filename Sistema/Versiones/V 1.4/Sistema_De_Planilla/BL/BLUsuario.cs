using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLUsuario
    {
        public int Trabajador_ID;
        public string Trabajador_Ced;
        public string Id;
        public string pass;
        public string estado;
        public string tipo;
        public string sesion;

        public void AgregarUsuario()
        {
            TO.TOUsuario TO_Usr = new TO.TOUsuario();
            TO_Usr.Trabajador_Ced = this.Trabajador_Ced;
            TO_Usr.ID = this.Id;
            TO_Usr.Pass = this.pass;
            TO_Usr.Estado = this.estado;
            TO_Usr.Tipo = this.tipo;
            //TO_Usr.Sesion = this.sesion;
            
            DA.DAUsuario DA_Usr = new DA.DAUsuario();
            DA_Usr.AgregarUsuario(TO_Usr);

        }

        public void ModifcarUsuario()
        {
            TO.TOUsuario usr = new TO.TOUsuario();
            usr.Estado = this.estado;
            usr.Tipo = this.tipo;
            usr.Pass = this.pass;
            usr.Trabajador_Ced = this.Trabajador_Ced;

            DA.DAUsuario DA_Usuario = new DA.DAUsuario();
            DA_Usuario.ModifcarUsuario(usr);
        }

        public void EliminarUsuario(string Ced)
        {
            DA.DAUsuario DA_Usr = new DA.DAUsuario();
            DA_Usr.EliminarUsuario(Ced);
        }

        public void ConsultarUsuario(string Ced)
        {
            DA.DAUsuario DA_Usr = new DA.DAUsuario();
            this.Trabajador_Ced = DA_Usr.ConsultarUsuario(Ced).Trabajador_Ced;
            this.Id = DA_Usr.ConsultarUsuario(Ced).ID;
            this.tipo = DA_Usr.ConsultarUsuario(Ced).Tipo;
            this.estado = DA_Usr.ConsultarUsuario(Ced).Estado;
            
        }

        public void ConsultarPassViejo(string ID)
        {
            DA.DAUsuario DA_Usr = new DA.DAUsuario();
            this.pass = DA_Usr.ConsultarPassViejo(ID);
        }

        public void CambiarPass(string ID, string pass)
        {
            TO.TOUsuario TO_Usr = new TO.TOUsuario();
            TO_Usr.ID = ID;
            TO_Usr.Pass = pass;
            DA.DAUsuario DA_Usr = new DA.DAUsuario();
            DA_Usr.ModifcarUsuario(TO_Usr);
        }



        /*  public void IniciarSesion(string ID_usr)
        { 
            TO.TOUsuario usr = new TO.TOUsuario();
            usr.ID = ID_usr;

            DA.DAUsuario DA_usr = new DA.DAUsuario();
            DA_usr.IniciarSesion(usr);
        }*/

    }
}