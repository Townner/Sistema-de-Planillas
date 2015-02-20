using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DA
{
    public class DAUsuario
    {

        public void AgregarUsuario(TO.TOUsuario usr)
        {
            throw new NotImplementedException();
        }

        public void ModifcarUsuario(TO.TOUsuario usr)
        {
            throw new NotImplementedException();
        }

        public void EliminarUsuario(TO.TOUsuario usr)
        {
            throw new NotImplementedException();
        }

        public void ConsultarUsuario(TO.TOUsuario usr)
        {
            throw new NotImplementedException();
        }

        /* public void IniciarSesion(TO.TOUsuario usr){
            
        SqlCommand update = new SqlCommand();
        update.Connection = conexion;
        update.CommandText = "update dbo.usuario set Sesion = 'Abierta' where ID = @Usuario";
        update.Parameters.AddWithValue("@Usuario", usr.ID);

        conexion.Open();
        update.ExecuteNonQuery();
        conexion.Close();

    }*/
    }
}