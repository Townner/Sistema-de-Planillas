using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLUsuario
    {
        public void AgregarUsuario(int id_trabajador, string Id,
            string pass, string estado, string tipo)
        {
            TO.TOUsuario usr = new TO.TOUsuario();
            usr.Id_Trabajador = id_trabajador;
            usr.ID = Id;
            usr.Pass = pass;
            usr.Estado = estado;
            usr.Tipo = tipo;

            DA.DAUsuario dusr = new DA.DAUsuario();
            dusr.AgregarUsuario(usr);

        }

        public void ModifcarUsuario(TO.TOUsuario usr)
        {
            DA.DAUsuario modusr = new DA.DAUsuario();
            modusr.ModifcarUsuario(usr);
        }

        public void EliminarUsuario(TO.TOUsuario usr)
        {
            DA.DAUsuario elusr = new DA.DAUsuario();
            elusr.EliminarUsuario(usr);
        }

        public TO.TOUsuario ConsultarUsuario(TO.TOUsuario usr)
        {
            DA.DAUsuario conusr = new DA.DAUsuario();
            conusr.ConsultarUsuario(usr);
            throw new NotImplementedException();
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