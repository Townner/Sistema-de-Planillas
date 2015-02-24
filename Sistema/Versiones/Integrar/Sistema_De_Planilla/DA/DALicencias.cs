using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DALicencias
    {

        SqlConnection Conexion = new SqlConnection();

        public TO.TOLicencias Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM Licencia WHERE Trabajador_Ced = @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOLicencias temp = new TO.TOLicencias();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["ID_Departamento"];
                    temp.Trabajador_Ced = (string)read["Nom_Dep"];
                    temp.Lic1 = (string)read["Licencia_1"];
                    temp.Lic2 = (string)read["Licencia_2"];
                    temp.Lic3 = (string)read["Licencia_3"];
                    temp.V_Lic1 = (DateTime)read["F_Vencimiento_1"];
                    temp.V_Lic2 = (DateTime)read["F_Vencimiento_2"];
                    temp.V_Lic3 = (DateTime)read["F_Vencimiento_3"];
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
