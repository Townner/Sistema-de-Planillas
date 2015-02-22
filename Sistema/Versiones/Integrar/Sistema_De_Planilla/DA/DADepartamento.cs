using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DA
{
    public class DADepartamento
    {
        SqlConnection Conexion = new SqlConnection();
        
        public TO.TODepartamento Search(int id)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * from Departamentos where ID_Departamento = ID value as @ID";

            Search.Parameters.AddWithValue("@ID", id);

            SqlDataReader read = Search.ExecuteReader();
            TO.TODepartamento temp = new TO.TODepartamento();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.ID = (int)read["ID_Departamento"];
                    temp.Nombre = (string)read["Nom_Dep"];
                }
            }
            Conexion.Close();

            return temp;
        }



        public void CrearDepartamento(int id, string nombre)
        {
            SqlCommand cdep = new SqlCommand();
            cdep.Connection = Conexion;

            cdep.CommandText = "INSERT into Departamentos values (@id, @nom)";

            cdep.Parameters.AddWithValue("@id", id);
            cdep.Parameters.AddWithValue("@nom",nombre);
            
            Conexion.Close();
        }

        public void ModificarDeprtamento(string nom)
        {
            SqlCommand moddep = new SqlCommand();
            moddep.Connection = Conexion;

            moddep.CommandText = "UPDATE @Nom_Dep from Departamentos values as @nom";

            moddep.Parameters.AddWithValue("@nom", nom);

            Conexion.Close();
        }

        public void EliminarDepartamento(string nom)
        {
            SqlCommand eldep = new SqlCommand();
            eldep.Connection = Conexion;
            // se tiene que validar la cantidad de trabajadores asignados (count) por departamento si tiene que no borre
            eldep.CommandText = "UPDATE @Nom_Dep from Departamentos values as @nom";

            eldep.Parameters.AddWithValue("@nom", nom);

            Conexion.Close();
        }
    }
}