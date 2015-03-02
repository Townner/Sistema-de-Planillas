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
            Insertar.CommandText = "insert into dbo.Usuarios(Trabajador_ID,Trabajador_Ced,ID,Pass,Estado,Tipo,Sesion) values (@ID,@Ced,@IDUser,@Pass,@Est,@Tipo,'Cerrada')";
            Insertar.Parameters.AddWithValue("@ID", getCedula(usr.Trabajador_Ced));
            Insertar.Parameters.AddWithValue("@Ced", usr.Trabajador_Ced);
            Insertar.Parameters.AddWithValue("@IDUser", usr.ID);
            Insertar.Parameters.AddWithValue("@Pass", usr.Pass);
            Insertar.Parameters.AddWithValue("@Est", usr.Estado);
            Insertar.Parameters.AddWithValue("@Tipo", usr.Tipo);

            conexion.Open();
            Insertar.ExecuteNonQuery();
            conexion.Close();
        }

        public int getCedula(string cedula) {
          
            SqlCommand getCedula = new SqlCommand();
            getCedula.Connection = conexion;
            getCedula.CommandText = "select ID from dbo.trabajador where Ced = @Ced";
            getCedula.Parameters.AddWithValue("@Ced", cedula);

           conexion.Open();

            SqlDataReader reader = getCedula.ExecuteReader();

            int temp = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    temp = (int)reader["ID"];
                }

            }
            else {
            }
            conexion.Close();

            return temp;
        }
        
        public void ModifcarUsuario(TO.TOUsuario usr)
        {
            if (usr.Estado != null)
            {
                SqlCommand updateEstado = new SqlCommand();
                updateEstado.Connection = conexion;
                updateEstado.CommandText = "update dbo.usuarios set Estado = @Est where Trabajador_Ced = @Ced";
                updateEstado.Parameters.AddWithValue("@Est", usr.Estado);
                updateEstado.Parameters.AddWithValue("@Ced", usr.Trabajador_Ced);

                conexion.Open();
                updateEstado.ExecuteNonQuery();
                conexion.Close();
            }
            
            if (usr.Tipo != null)
                {
                    SqlCommand updateTipo = new SqlCommand();
                    updateTipo.Connection = conexion;
                    updateTipo.CommandText = "update dbo.Usuarios set Tipo = @Tipo where Trabajador_Ced = @Ced";
                    updateTipo.Parameters.AddWithValue("@Tipo", usr.Tipo);
                    updateTipo.Parameters.AddWithValue("@Ced", usr.Trabajador_Ced);

                    conexion.Open();
                    updateTipo.ExecuteNonQuery();
                    conexion.Close();
                }
             
             if (usr.Pass != null) { 
                        SqlCommand updatePass = new SqlCommand();
                        updatePass.Connection = conexion;
                        updatePass.CommandText = "update dbo.Usuarios set Pass = @Pass where ID = @ID";
                        updatePass.Parameters.AddWithValue("@Pass", usr.Pass);
                        updatePass.Parameters.AddWithValue("@ID", usr.ID);

                        conexion.Open();
                        updatePass.ExecuteNonQuery();
                        conexion.Close();
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
            else {
            }
            conexion.Close();
            return temp;
        }

        public string ConsultarPassViejo(string ID)
        {
            SqlCommand Buscar = new SqlCommand();
            Buscar.Connection = conexion;
            Buscar.CommandText = "Select Pass from dbo.Usuarios where ID = @ID";
            Buscar.Parameters.AddWithValue("@ID", ID);

            conexion.Open();

            SqlDataReader reader = Buscar.ExecuteReader();

            string temp = "";

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    temp = (string)reader["Pass"];
                }

            }
            else
            {
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