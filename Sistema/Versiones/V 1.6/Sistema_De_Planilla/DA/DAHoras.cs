using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAHoras
    {

        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOHoras Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "SELECT * FROM dbo.Horas WHERE Trabajador_Ced = @Ced;";

            Search.Parameters.AddWithValue("@Ced", ced);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();
            TO.TOHoras temp = new TO.TOHoras();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];
                    temp.H_Permiso = (int)read["H_Permiso"];
                    temp.H_Extra = (int)read["H_Extra"];
                    temp.H_Incap = (int)read["H_Incap"];
                    temp.H_Laboradas = (int)read["H_Laboradas"];
                    temp.H_Subcidio = (int)read["H_Subsidio"];
                }
            }
            Conexion.Close();

            return temp;
        }

        public void AgragarHoras(TO.TOHoras TO_Horas)
        {
            SqlCommand ahora = new SqlCommand();
            ahora.Connection = Conexion;

            ahora.CommandText = "INSERT INTO Horas(Trabajador_ID, Trabajador_Ced, H_Permiso, H_Extra, H_Incap, H_Laboradas, H_SubsidiO) VALUES (@Trabajador_ID, @Trabajador_Ced, @H_Permiso, @H_Extra, @H_Incap, @H_Laboradas,@H_Subsidio);";

            ahora.Parameters.AddWithValue("@Trabajador_ID", TO_Horas.Trabajador_ID);
            ahora.Parameters.AddWithValue("@Trabajador_Ced", TO_Horas.Trabajador_Ced);
            ahora.Parameters.AddWithValue("@H_Permiso", TO_Horas.H_Permiso);
            ahora.Parameters.AddWithValue("@H_Extra", TO_Horas.H_Extra);
            ahora.Parameters.AddWithValue("@H_Incap", TO_Horas.H_Incap);
            ahora.Parameters.AddWithValue("@H_Laboradas", TO_Horas.H_Laboradas);
            ahora.Parameters.AddWithValue("@H_Subsidio", TO_Horas.H_Subcidio);

            Conexion.Open();
            ahora.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ModificarHoras(TO.TOHoras TO_Horas)
        {
            SqlCommand modhora = new SqlCommand();
            modhora.Connection = Conexion;

            modhora.CommandText = " UPDATE Horas SET H_Permiso = @H_Permiso , H_Extra = @H_Extra, H_Incap = @H_Incap, H_Laboradas = @H_Laboradas, H_Subsidio = @H_Subsidio "
                + " WHERE Trabajador_Ced = @Trabajador_Ced;";

            modhora.Parameters.AddWithValue("@Trabajador_Ced", TO_Horas.Trabajador_Ced);
            modhora.Parameters.AddWithValue("@H_Permiso", TO_Horas.H_Permiso);
            modhora.Parameters.AddWithValue("@H_Extra", TO_Horas.H_Extra);
            modhora.Parameters.AddWithValue("@H_Incap", TO_Horas.H_Incap);
            modhora.Parameters.AddWithValue("@H_Laboradas", TO_Horas.H_Laboradas);
            modhora.Parameters.AddWithValue("@H_Subsidio", TO_Horas.H_Subcidio);

            Conexion.Open();
            modhora.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ResetHoras()
        {
            SqlCommand Reset = new SqlCommand();
            Reset.Connection = Conexion;

            SqlCommand Select = new SqlCommand();
            Select.Connection = Conexion;

            Select.CommandText = "Select * from dbo.Horas";

            Conexion.Open();

            SqlDataReader read = Select.ExecuteReader();
            string ced = "";
            int Labo = 0;

            if (read.HasRows)
            {
                while (read.Read())
                {

               Reset.CommandText = " UPDATE Horas SET H_Permiso = @H_Permiso , H_Extra = @H_Extra, H_Incap = @H_Incap, H_Laboradas = @H_Labo, H_Subsidio = @H_Subsidio "
                + " WHERE Trabajador_Ced = @Ced; ";

                    ced = (string)read["Trabajador_Ced"];
                    Labo = (int)read["H_Laboradas"];

                    Reset.Parameters.Clear();

                    Reset.Parameters.AddWithValue("@Ced", ced);
                    Reset.Parameters.AddWithValue("@H_Permiso", 0);
                    Reset.Parameters.AddWithValue("@H_Extra", 0);
                    Reset.Parameters.AddWithValue("@H_Incap", 0);
                    Reset.Parameters.AddWithValue("@H_Labo", Labo);
                    Reset.Parameters.AddWithValue("@H_Subsidio", 0);

                    Reset.ExecuteNonQuery();
                }
            }
            Conexion.Close();
        }
    }
}
