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
        
        public void AgragarHoras(int id, string ced, int h_permiso, int h_extra, int h_incap, int h_laboradas, int subicidio)
        {
            SqlCommand ahora = new SqlCommand();
            ahora.Connection = Conexion;

            ahora.CommandText = "INSERT INTO Horas(Trabajador_ID, Trabajador_Ced, H_Permiso, H_Extra, H_Incap, H_Laboradas, H_SubsidiO) VALUES (Trabajador_ID = @Trabajador_ID, Trabajador_Ced = @Trabajador_Ced, H_Permiso = @H_Permiso, H_Extra = @H_Extra, H_Incap = @H_Incap, H_Laboradas = @H_Laboradas, H_Subsidio = @H_Subsidio);";

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

            modhora.CommandText = "UPDATE Horas SET H_Permiso = @H_Permiso , H_Extra = @H_Extra, H_Incap = @H_Incap, H_Laboradas = @H_Laboradas, H_Subsidio = @H_Subsidio)"
                + "WHERE Trabajador_Ced = @Trabajador_Ced;";

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

            int h_permiso;
            int h_extra;
            int h_incap;
            int h_laboradas;
            int subicidio;

            h_permiso = 0;
            h_extra = 0;
            h_incap = 0;
            h_laboradas = 0;
            subicidio = 0;

            elhora.CommandText = "UPDATE Horas SET H_Permiso = @H_Permiso , H_Extra = @H_Extra, H_Incap = @H_Incap, H_Laboradas = @H_Laboradas, H_Subsidio = @H_Subsidio)"
                + "WHERE Trabajador_Ced = @Trabajador_Ced;";

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
