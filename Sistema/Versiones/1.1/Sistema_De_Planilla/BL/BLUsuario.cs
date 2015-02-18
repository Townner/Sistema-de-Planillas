using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLUsuario
    {
        private int id_trabajador;
        private string Id;
        private string pass;
        private string estado;
        private string tipo;
        private string sesion;

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

        public void ModifcarUsuario()
        {
          
        }

        public void EliminarUsuario()
        {
            
          
        }

        public void ConsultarUsuario()
        {
          
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