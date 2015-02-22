using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DA
{
    public class DAUsuario
    {
        private SqlConnection conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public void AgregarUsuario(TO.TOUsuario usr)
        {
            SqlCommand Insertar = new SqlCommand();
            Insertar.Connection = conexion;
            Insertar.CommandText = "insert into dbo.Usuarios(Trabajador_ID,Trabajador_Ced,ID,Pass,Estado,Tipo,Sesion) values (NULL,@Ced,@ID,@Pas,@Est,@Tipo,'Cerrada')";
            Insertar.Parameters.AddWithValue("@Ced", usr.Trabajador_Ced);
            Insertar.Parameters.AddWithValue("@ID", usr.ID);
            Insertar.Parameters.AddWithValue("@Pas", usr.Pass);
            Insertar.Parameters.AddWithValue("@Est", usr.Estado);
            Insertar.Parameters.AddWithValue("@Tipo", usr.Tipo);

            conexion.Open();
            Insertar.ExecuteNonQuery();
            conexion.Close();
        }

        public void ModifcarUsuario(TO.TOUsuario usr)
        {
            if (usr.Estado != null)
            {
                SqlCommand update = new SqlCommand();
                update.Connection = conexion;
                update.CommandText = "update dbo.Usuarios set Estado = @Est where ID = @ID";
                update.Parameters.AddWithValue("@Est", usr.Estado);
                update.Parameters.AddWithValue("@ID", usr.ID);

                conexion.Open();
                update.ExecuteNonQuery();
                conexion.Close();
            }
            else {
                if (usr.Tipo != null)
                {
                    SqlCommand update = new SqlCommand();
                    update.Connection = conexion;
                    update.CommandText = "update dbo.Usuarios set Tipo = @Tipo where ID = @ID";
                    update.Parameters.AddWithValue("@Tipo", usr.Estado);
                    update.Parameters.AddWithValue("@ID", usr.ID);

                    conexion.Open();
                    update.ExecuteNonQuery();
                    conexion.Close();
                }
                else {
                    if (usr.Pass != null) { 
                        SqlCommand update = new SqlCommand();
                        update.Connection = conexion;
                        update.CommandText = "update dbo.Usuarios set Pass = @Pass where ID = @ID";
                        update.Parameters.AddWithValue("@Pass", usr.Estado);
                        update.Parameters.AddWithValue("@ID", usr.ID);

                        conexion.Open();
                        update.ExecuteNonQuery();
                        conexion.Close();
                    } 
                }
            }    
        }

        public void EliminarUsuario(string ced)
        {
            SqlCommand Eliminar = new SqlCommand();
            Eliminar.Connection = conexion;
            Eliminar.CommandText = "Delete from dbo.Usuarios where Trabajador_Ced = @Ced";
            Eliminar.Parameters.AddWithValue("@Ced", ced);

            conexion.Open();
            Eliminar.ExecuteNonQuery();
            conexion.Close();
        }

        public TO.TOUsuario ConsultarUsuario(string ced)
        {
            SqlCommand Buscar = new SqlCommand();
            Buscar.Connection = conexion;
            Buscar.CommandText = "Select Trabajador_Ced,ID,Estado,Tipo from dbo.Usuarios where Trabajador_Ced = @Ced";
            Buscar.Parameters.AddWithValue("@Ced", ced);

            conexion.Open();

            SqlDataReader reader = Buscar.ExecuteReader();

            TO.TOUsuario temp = new TO.TOUsuario();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    temp.Trabajador_Ced = (string)reader["Trabajador_Ced"];
                    temp.ID = (string)reader["ID"];
                    temp.Estado = (string)reader["Estado"];
                    temp.Tipo = (string)reader["Tipo"];
                }

            }
            conexion.Close();
            return temp;
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