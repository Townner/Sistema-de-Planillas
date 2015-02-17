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
            TOUsuario usr = new TOUsuario();
            usr.Id_Trabajador = id_trabajador;
            usr.ID = Id;
            usr.Pass = pass;
            usr.Estado = estado;
            usr.Tipo = tipo;

            DAUsuario dusr = new DAUsuario();
            dusr.AgregarUsuario(usr);

        }

        public void ModifcarUsuario(TOUsuario usr)
        {
            DAUsuario modusr = new DAUsuario();
            modusr.ModifcarUsuario(usr)
        }

        public void EliminarUsuario(TOUsuario usr)
        {
            DAUsuario elusr = new DAUsuario();
            elusr.EliminarUsuario(usr);
        }

        public TOUsuario ConsultarUsuario(TOUsuario usr)
        {
            DAUsuario conusr = new DAUsuario();
            conusr.ConsultarUsuario(usr);
            throw new NotImplementedException();
        }
    }
}