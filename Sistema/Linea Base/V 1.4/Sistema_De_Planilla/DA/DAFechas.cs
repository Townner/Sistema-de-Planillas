using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DAFechas
    {

        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOFechas Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM dbo.Fechas_Trabajador WHERE (Trabajador_Ced = @ced);";

            Search.Parameters.AddWithValue("@ced", ced);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();
            TO.TOFechas temp = new TO.TOFechas();

            int fieldCount = read.FieldCount;
            object[] fieldValues = new object[fieldCount];
            string[] headers = new string[fieldCount];

            if (read.HasRows)
            {
                while (read.Read())
                {

                    read.GetValues(fieldValues);
                    string value = "";

                    for (int fieldCounter = 0; fieldCounter < fieldCount; fieldCounter++)
                    {
                        value = fieldValues[fieldCounter].ToString();
                        if (value == "")
                            fieldValues[fieldCounter] = "N/A";
                    }
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];

                    if (fieldValues[2].ToString() != "N/A")
                    {

                        temp.F_Nac = Convert.ToDateTime(read["F_Nac"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.F_Nac = fieldValues[2].ToString();
                    }

                    if (fieldValues[3].ToString() != "N/A")
                    {

                        temp.F_Ingreso = Convert.ToDateTime(read["F_Ingreso"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.F_Ingreso = fieldValues[3].ToString();
                    }

                    if (fieldValues[4].ToString() != "N/A")
                    {

                        temp.F_Pruba = Convert.ToDateTime(read["F_Prueba"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.F_Pruba = fieldValues[4].ToString();
                    }


                    if (fieldValues[5].ToString() != "N/A")
                    {

                        temp.F_Salida = Convert.ToDateTime(read["F_Salida"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.F_Salida = fieldValues[5].ToString();
                    }
                }
            }
            Conexion.Close();

            return temp;

        }


        public void AgregarFechas(TO.TOFechas TO_Fech, TO.TOTrabajador TO_Trab)
        {
            SqlCommand Insert = new SqlCommand();
            Insert.Connection = Conexion;

            Insert.CommandText = "INSERT INTO Fechas_Trabajador(Trabajador_ID, Trabajador_Ced, F_Nac, F_Ingreso, F_Prueba, F_Salida) VALUES (@ID, @Ced, @F_Nac, @F_Ingreso, @F_Prueba, @F_Salida);";

            Insert.Parameters.AddWithValue("@ID", TO_Trab.ID);
            Insert.Parameters.AddWithValue("@Ced", TO_Trab.Ced);
            Insert.Parameters.AddWithValue("@F_Nac", TO_Fech.F_Nac);
            Insert.Parameters.AddWithValue("@F_Ingreso", TO_Fech.F_Ingreso);
            Insert.Parameters.AddWithValue("@F_Prueba", TO_Fech.F_Pruba);
            Insert.Parameters.AddWithValue("@F_Salida", TO_Fech.F_Salida);

            Conexion.Open();
            Insert.ExecuteNonQuery();
            Conexion.Close();
        }

        public void ModificarFechas(string ced, DateTime f_nac, DateTime f_ingreso, DateTime f_prueba, DateTime f_salida)
        {
            SqlCommand modfec = new SqlCommand();
            modfec.Connection = Conexion;

            modfec.CommandText = "UPDATE Fechas_Trabajador SET Trabajador_ID = @Trabajador_ID, Trabajador_ID = @Trabajador_ID, F_Nac = @F_Nac, F_Ingreso = @F_Ingreso, F_Prueba = @F_Prueba, F_Salida = @F_Salida;";

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

            elfec.CommandText = "DELETE FROM Fechas_Trabajador WHERE Trabajador_Ced = @Trabajador_Ced;";

            elfec.Parameters.AddWithValue("@Trabajador_Ced", ced);

            Conexion.Close();

        }
    }
}
