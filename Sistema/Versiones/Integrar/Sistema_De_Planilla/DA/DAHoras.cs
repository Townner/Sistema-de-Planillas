using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAHoras
    {

        SqlConnection Conexion = new SqlConnection();

        public TO.TOHoras Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * from Horas where Trabajador_Ced = Ced  value as @Ced";

            Search.Parameters.AddWithValue("@Ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOHoras temp = new TO.TOHoras();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];
                    temp.H_Permiso = (DateTime)read["H_Permiso"];
                    temp.H_Extra = (DateTime)read["H_Extra"];
                    temp.H_Incap = (DateTime)read["H_Incap"];
                    temp.H_Laboradas = (DateTime)read["H_Laboradas"];
                    temp.Subcidio = (DateTime)read["H_Subsidio"];
                }
            }
            Conexion.Close();

            return temp;
        }
        
        public void AgragarHoras(int id, string ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            SqlCommand ahora = new SqlCommand();
            ahora.Connection = Conexion;

            ahora.CommandText = "INSERT INTO Horas(Trabajador_ID, Trabajador_Ced, H_Permiso, H_Extra, H_Incap, H_Laboradas, H_Subsidio)"
                + " VALUES (@Trabajador_ID, @Trabajador_Ced, @H_Permiso, @H_Extra, @H_Incap, @H_Laboradas, @H_Subsidio )";

            ahora.Parameters.AddWithValue("@Trabajador_ID", id);
            ahora.Parameters.AddWithValue("@Trabajador_Ced", ced);
            ahora.Parameters.AddWithValue("@H_Permiso", h_permiso);
            ahora.Parameters.AddWithValue("@H_Extra", h_extra);
            ahora.Parameters.AddWithValue("@H_Incap", h_incap);
            ahora.Parameters.AddWithValue("@H_Laboradas", h_laboradas);
            ahora.Parameters.AddWithValue("@H_Subsidio", subicidio);

            Conexion.Close();
        }

        public void ModificarHoras(int id, string ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            SqlCommand modhora = new SqlCommand();
            modhora.Connection = Conexion;

            modhora.CommandText = "UPDATE Horas (H_Permiso, H_Extra, H_Incap, H_Laboradas, H_Subsidio)"
                + "WHERE Trabajador_Ced = @Trabajador_Ced" 
                + " VALUES (@H_Permiso, @H_Extra, @H_Incap, @H_Laboradas, @H_Subsidio )";

            modhora.Parameters.AddWithValue("@Trabajador_Ced", ced);
            modhora.Parameters.AddWithValue("@H_Permiso", h_permiso);
            modhora.Parameters.AddWithValue("@H_Extra", h_extra);
            modhora.Parameters.AddWithValue("@H_Incap", h_incap);
            modhora.Parameters.AddWithValue("@H_Laboradas", h_laboradas);
            modhora.Parameters.AddWithValue("@H_Subsidio", subicidio);

            Conexion.Close();
        }

        public void ElimarHora(string ced)
        {
            SqlCommand elhora = new SqlCommand();
            elhora.Connection = Conexion;

            DateTime h_permiso;
            DateTime h_extra;
            DateTime h_incap;
            DateTime h_laboradas;
            DateTime subicidio;

            h_permiso = new DateTime(1900, 01, 01, 00 , 00, 00);
            h_extra = new DateTime(1900, 01, 01, 00 , 00, 00);
            h_incap = new DateTime(1900, 01, 01, 00 , 00, 00);
            h_laboradas = new DateTime(1900, 01, 01, 00 , 00, 00);
            subicidio = new DateTime(1900, 01, 01, 00, 00, 00);
           
            elhora.CommandText = "UPDATE Horas SET(H_Permiso, H_Extra, H_Incap, H_Laboradas, H_Subsidio)"
                + "WHERE Trabajador_Ced = @Trabajador_Ced"
                + " VALUES (@H_Permiso, @H_Extra, @H_Incap, @H_Laboradas, @H_Subsidio )";

            elhora.Parameters.AddWithValue("@Trabajador_Ced", ced);
            elhora.Parameters.AddWithValue("@H_Permiso", h_permiso);
            elhora.Parameters.AddWithValue("@H_Extra", h_extra);
            elhora.Parameters.AddWithValue("@H_Incap", h_incap);
            elhora.Parameters.AddWithValue("@H_Laboradas", h_laboradas);
            elhora.Parameters.AddWithValue("@H_Subsidio", subicidio);

            //SE DEBEN PONER TODAS LAS FECHAS EN 2015-02-24 10:43:47.847

            Conexion.Close();
        }
    }
}
