using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAPuesto
    {

        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOPuesto BuscarPuesto(string nombre)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM dbo.Puesto WHERE Nom_Puesto = @Nom";
            Search.Parameters.AddWithValue("@Nom", nombre);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();

            TO.TOPuesto temp = new TO.TOPuesto();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    temp.ID_Puesto = (int)read["ID_Puesto"];
                    temp.Nom_Puesto = (string)read["Nom_Puesto"];
                }
            }

            Conexion.Close();

            return temp;
        }


        public void AgregarPuesto(TO.TOPuesto TO_Puest)
        {

            SqlCommand Insert = new SqlCommand();
            Insert.Connection = Conexion;
            Insert.CommandText = "INSERT INTO dbo.Puesto (Nom_Puesto) VALUES (@nom)";
            Insert.Parameters.AddWithValue("@nom", TO_Puest.Nom_Puesto);

            Conexion.Open();
            Insert.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EditarPuesto(TO.TOPuesto TO_Puest, string oldname)
        {

            SqlCommand Update = new SqlCommand();
            Update.Connection = Conexion;
            Update.CommandText = "UPDATE dbo.Puesto SET Nom_Puesto = @nom WHERE  Nom_Puesto = @Old;";
            Update.Parameters.AddWithValue("@old", oldname);
            Update.Parameters.AddWithValue("@nom", TO_Puest.Nom_Puesto);

            Conexion.Open();
            Update.ExecuteNonQuery();
            Conexion.Close();
        }

        public int EliminarPuesto(string nombre)
        {
            int error = 0;
            SqlCommand Delete = new SqlCommand();
            Delete.Connection = Conexion;
            Delete.CommandText = "DELETE FROM dbo.Puesto WHERE Nom_Puesto = @Nom";
            Delete.Parameters.AddWithValue("@Nom", nombre);

            Conexion.Open();
            try
            {
                Delete.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                if (ex.Errors.Count > 0) // Assume the interesting stuff is in the first error
                {
                    switch (ex.Errors[0].Number)
                    {
                        case 547: // Foreign Key violation
                            error = 1;
                            // throw new InvalidOperationException("Your FK user-friendly description", ex);
                            break;
                        // other cases
                    }
                }
            }

            Conexion.Close();
            return error;
        }
    }
}
