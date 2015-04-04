using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DA
{
    public class DADepartamento
    {
        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TODepartamento BuscarDepartamento(string nombre)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM dbo.Departamento WHERE Nom_Dep = @Nom";
            Search.Parameters.AddWithValue("@Nom", nombre);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();

            TO.TODepartamento temp = new TO.TODepartamento();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    temp.Id_departamento = (int)read["ID_Departamento"];
                    temp.Nom_departamento = (string)read["Nom_Dep"];
                }
            }

            Conexion.Close();

            return temp;
        }


        public void AgregarDepartamento(TO.TODepartamento TO_Dep)
        {

            SqlCommand Insert = new SqlCommand();
            Insert.Connection = Conexion;
            Insert.CommandText = "INSERT INTO dbo.Departamento (Nom_Dep) VALUES (@nom)";
            Insert.Parameters.AddWithValue("@nom", TO_Dep.Nom_departamento);

            Conexion.Open();
            Insert.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarDepartamento(TO.TODepartamento TO_Dep, string oldname)
        {

            SqlCommand Update = new SqlCommand();
            Update.Connection = Conexion;
            Update.CommandText = "UPDATE dbo.Departamento SET Nom_Dep = @nom WHERE  Nom_Dep = @Old;";
            Update.Parameters.AddWithValue("@old", oldname);
            Update.Parameters.AddWithValue("@nom", TO_Dep.Nom_departamento);

            Conexion.Open();
            Update.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarDepartamento(string nombre)
        {
            SqlCommand Delete = new SqlCommand();
            Delete.Connection = Conexion;
            Delete.CommandText = "DELETE FROM dbo.Departamento WHERE Nom_Dep = @Nom";
            Delete.Parameters.AddWithValue("@Nom", nombre);

            Conexion.Open();
            Delete.ExecuteNonQuery();
            Conexion.Close();
        }
    }
}

       /* public void EliminarDepartamento(string nom)
        {
            SqlCommand eldep = new SqlCommand();
            eldep.Connection = Conexion;
            // se tiene que validar la cantidad de trabajadores asignados (count) por departamento si tiene que no borre
            eldep.CommandText = "DELETE FROM Nom_Dep = @Nom_Dep from Departamentos;";

            eldep.Parameters.AddWithValue("@Nom_Dep", nom);

            Conexion.Close();
        }*/
    
