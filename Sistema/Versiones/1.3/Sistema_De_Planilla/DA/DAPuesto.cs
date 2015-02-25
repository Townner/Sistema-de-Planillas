using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAPuesto
    {

        SqlConnection Conexion = new SqlConnection();

        public TO.TOPuesto Search(int id)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM Licencia WHERE ID_Puestos = @id";

            Search.Parameters.AddWithValue("@id", id);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOPuesto temp = new TO.TOPuesto();

            if (read.Read())
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

        public void AgregarPuesto(int id, string nom)
        {

            SqlCommand apuest = new SqlCommand();
            apuest.Connection = Conexion;

            apuest.CommandText = "INSERT INTO Licencia (ID_Puesto, Nom_Puesto) VALUES ID_Puesto = @id, Nom_Puesto = @nom;";

            apuest.Parameters.AddWithValue("@id", id);
            apuest.Parameters.AddWithValue("@nom", nom);

            Conexion.Close();
        }

        public void EditarPuesto(int id, string nom)
        {

            SqlCommand editpuest = new SqlCommand();
            editpuest.Connection = Conexion;

            editpuest.CommandText = "UPDATE Puestos SET Nom_Puesto = @nom WHERE  ID_Puesto = @id;";

            editpuest.Parameters.AddWithValue("@id", id);
            editpuest.Parameters.AddWithValue("@nom", nom);

            Conexion.Close();
        }

        public void EliminarPuesto(int id)
        {
            SqlCommand elpuest = new SqlCommand();
            elpuest.Connection = Conexion;

            elpuest.CommandText = "DELETE FROM Puestos WHERE ID_Puesto = @id";

            elpuest.Parameters.AddWithValue("@id", id);

            Conexion.Close();
        }
    }
}
