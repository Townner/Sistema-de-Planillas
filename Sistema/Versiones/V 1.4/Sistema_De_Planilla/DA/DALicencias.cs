using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DALicencias
    {

        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOLicencias Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM Licencia WHERE Trabajador_Ced = @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();
            TO.TOLicencias temp = new TO.TOLicencias();

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
                        temp.Lic1 = (string)read["Licencia_1"];
                    }
                    else
                    {
                        temp.Lic1 = fieldValues[2].ToString();
                    }

                    if (fieldValues[3].ToString() != "N/A")
                    {
                        temp.Lic2 = (string)read["Licencia_2"];
                    }
                    else
                    {
                        temp.Lic2 = fieldValues[3].ToString();
                    }

                    if (fieldValues[4].ToString() != "N/A"){
                    
                        temp.Lic3 = (string)read["Licencia_3"];
                    }
                    else
                    {
                        temp.Lic3 = fieldValues[4].ToString();
                    }

                    if (fieldValues[5].ToString() != "N/A")
                    {

                        temp.V_Lic1 = Convert.ToDateTime(read["F_Vencimiento_1"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.V_Lic1 = fieldValues[5].ToString();
                    }

                    if (fieldValues[6].ToString() != "N/A")
                    {

                        temp.V_Lic2 = Convert.ToDateTime(read["F_Vencimiento_2"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.V_Lic2 = fieldValues[6].ToString();
                    }


                    if (fieldValues[7].ToString() != "N/A")
                    {

                        temp.V_Lic3 = Convert.ToDateTime(read["F_Vencimiento_3"]).ToString("yyyy-MM-dd");
                    }
                    else
                    {
                        temp.V_Lic3 = fieldValues[7].ToString();
                    }
                }
            }
            Conexion.Close();

            return temp;
        }


        public void AgregarLicencia(int id, string ced, string lic1, string lic2, string lic3, DateTime vlic1, DateTime vlic2, DateTime vlic3)
        {
            SqlCommand alic = new SqlCommand();
            alic.Connection = Conexion;

            alic.CommandText = "INSERT INTO Licencia (Trabajador_ID, Trabajador_Ced, Licencia_1, Licencia_2, Licencia_3, F_Vencimiento_1, F_Vencimiento_2, F_Vencimiento_3)"
                + " VALUES (Trabajador_ID = @id, Trabajador_Ced = @ced, Licencia_1 = @lic1, Licencia_2 = @lic2, Licencia_3 = @lic3, F_Vencimiento_1 = @vlic1, F_Vencimiento_2 = @vlic2, F_Vencimiento_3 = @vlic3)";

            alic.Parameters.AddWithValue("@id", id);
            alic.Parameters.AddWithValue("@ced", ced);
            alic.Parameters.AddWithValue("@lic1", lic1);
            alic.Parameters.AddWithValue("@lic2", lic2);
            alic.Parameters.AddWithValue("@lic3", lic3);
            alic.Parameters.AddWithValue("@vlic1", vlic1);
            alic.Parameters.AddWithValue("@vlic2", vlic2);
            alic.Parameters.AddWithValue("@vlic3", vlic3);

            Conexion.Close();
        }

        public void ModifcarLicencia(string ced, string lic1, string lic2, string lic3, DateTime vlic1, DateTime vlic2, DateTime vlic3)
        {
            SqlCommand modlic = new SqlCommand();
            modlic.Connection = Conexion;

            modlic.CommandText = "UPDATE Licencia SET Licencia_1 = @lic1, Licencia_2 = @lic2, Licencia_3 = @lic3, F_Vencimiento_1 = @vlic1, F_Vencimiento_2 = @vlic2, F_Vencimiento_3 = @vlic3 WHERE Trabajador_Ced = @ced;";

            modlic.Parameters.AddWithValue("@ced", ced);
            modlic.Parameters.AddWithValue("@lic1", lic1);
            modlic.Parameters.AddWithValue("@lic2", lic2);
            modlic.Parameters.AddWithValue("@lic3", lic3);
            modlic.Parameters.AddWithValue("@vlic1", vlic1);
            modlic.Parameters.AddWithValue("@vlic2", vlic2);
            modlic.Parameters.AddWithValue("@vlic3", vlic3);

            Conexion.Close();
        }



        public void EliminarLicencia(string ced)
        {
            SqlCommand ellic = new SqlCommand();
            ellic.Connection = Conexion;

            string lic1;
            string lic2;
            string lic3;
            DateTime v_lic1;
            DateTime v_lic2;
            DateTime v_lic3;

            lic1 = lic2 = lic3 = "";
            v_lic1 = v_lic2 = v_lic3 = new DateTime(1900, 01, 01, 00, 00, 00);


            ellic.CommandText = "UPDATE Licencia SET Licencia_1 = @lic1, Licencia_2 = @lic2, Licencia_3 = @lic3, F_Vencimiento_1 = @vlic1, F_Vencimiento_2 = @vlic2, F_Vencimiento_3 = @vlic3 WHERE Trabajador_Ced = @ced;";

            ellic.Parameters.AddWithValue("@ced", ced);
            ellic.Parameters.AddWithValue("@lic1", lic1);
            ellic.Parameters.AddWithValue("@lic2", lic2);
            ellic.Parameters.AddWithValue("@lic3", lic3);
            ellic.Parameters.AddWithValue("@vlic1", v_lic1);
            ellic.Parameters.AddWithValue("@vlic2", v_lic2);
            ellic.Parameters.AddWithValue("@vlic3", v_lic3);

            Conexion.Close();
        }
    }
}
