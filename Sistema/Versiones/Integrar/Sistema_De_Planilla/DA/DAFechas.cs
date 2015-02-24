using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAFechas
    {

        SqlConnection Conexion = new SqlConnection();

        public TO.TOFechas Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * from Fechas_Trabajador where Horas = ced value as @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOFechas temp = new TO.TOFechas();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];
                    temp.F_Nac = (DateTime)read["F_Nac"];
                    temp.F_Ingreso = (DateTime)read["F_Ingreso"];
                    temp.F_Pruba = (DateTime)read["F_Prueba"];
                    temp.F_Salida = (DateTime)read["F_Salida"];
                }
            }
            Conexion.Close();

            return temp;

        }


        public void AgregarFechas(int ID, string ced, DateTime f_nac, DateTime f_ingreso, DateTime f_prueba, DateTime f_salida)
        {
            SqlCommand afec = new SqlCommand();
            afec.Connection = Conexion;

            afec.CommandText = "INSERT into Fechas_Trabajador(Trabajador_ID, Trabajador_Ced, F_Nac, F_Ingreso, F_Prueba, F_Salida)"
                + "VALUES (@Trabajador_ID, @Trabajador_Ced, @F_Nac, @F_Ingreso, @F_Prueba, @F_Salida)";

            afec.Parameters.AddWithValue("@Trabajador_ID",ID);
            afec.Parameters.AddWithValue("@Trabajador_Ced", ced);
            afec.Parameters.AddWithValue("@F_Nac", f_nac);
            afec.Parameters.AddWithValue("@F_Ingreso", f_ingreso);
            afec.Parameters.AddWithValue("@F_Prueba", f_prueba);
            afec.Parameters.AddWithValue("@F_Salida", f_salida);

            Conexion.Close();
        }

        public void ModificarFechas(string ced, DateTime f_nac, DateTime f_ingreso, DateTime f_prueba, DateTime f_salida)
        {
            SqlCommand modfec = new SqlCommand();
            modfec.Connection = Conexion;

            modfec.CommandText = "UPDATE Fechas_Trabajador SET Trabajador_ID = @Trabajador_ID, Trabajador_ID = @Trabajador_ID, F_Nac = @F_Nac, F_Ingreso = @F_Ingreso, F_Prueba = @F_Prueba, F_Salida = @F_Salida";

            modfec.Parameters.AddWithValue("@Trabajador_Ced", ced);
            modfec.Parameters.AddWithValue("@F_Nac", f_nac);
            modfec.Parameters.AddWithValue("@F_Ingreso", f_ingreso);
            modfec.Parameters.AddWithValue("@F_Prueba", f_prueba);
            modfec.Parameters.AddWithValue("@F_Salida", f_salida);

            Conexion.Close();
            
        }

        public void ElimarFecha(string ced)
        {
            SqlCommand elfec = new SqlCommand();
            elfec.Connection = Conexion;

            elfec.CommandText = "DELETE FROM Fechas_Trabajador WHERE Trabajador_Ced VALUES @Trabajador_Ced";

            elfec.Parameters.AddWithValue("@Trabajador_Ced", ced);

            Conexion.Close();

        }
    }
}
