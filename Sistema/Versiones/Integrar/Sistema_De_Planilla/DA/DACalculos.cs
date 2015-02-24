using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace DA
{
    public class DACalculos
    {
        SqlConnection Conexion = new SqlConnection();

        public TO.TOCalculos Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM Salarios WHERE Trabajador_Ced = @ced;";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos temp = new TO.TOCalculos();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];
                    temp.ImpRenta = (double)read["S_ImpRenta"];
                    temp.Hijos = (int)read["Hijos"];
                    temp.Conyugue = (int)read["Conyugue"];
                    temp.Cargas = (double)read["Ob_Pat"];
                    temp.S_Cargas = (double)read["S_Ob_Pat"];
                    temp.S_Extras = (double)read["S_Extra"];
                    temp.S_Incapacidad = (double)read["S_Incapacidad"];
                    temp.S_Base = (double)read["S_Base"];
                    temp.S_Bruto = (double)read["S_Bruto"];
                    temp.S_Neto = (double)read["S_Neto"];
                    temp.S_Final = (double)read["S_Final"];
                }
            }
            Conexion.Close();

            return temp;

        }

        public void CalculoIncapacida(string ced, double s_incapcidad)
        {
            SqlCommand calcincap = new SqlCommand();
            calcincap.Connection = Conexion;

            calcincap.CommandText = "UPDATE Salarios SET S_Incapacidad = @incap WHERE Trabajador_Ced = @ced;";

            calcincap.Parameters.AddWithValue("@ced", ced);
            calcincap.Parameters.AddWithValue("@incap", s_incapcidad);

            Conexion.Close();
        }
        public void CalculoHorasExtra(string ced ,double s_extras)
        {
            SqlCommand caclhex = new SqlCommand();
            caclhex.Connection = Conexion;

            caclhex.CommandText = "UPDATE Salarios SET S_Extra = @hex WHERE Trabajador_Ced = @ced; ";

            caclhex.Parameters.AddWithValue("@ced", ced);
            caclhex.Parameters.AddWithValue("@hex", s_extras);

            Conexion.Close();
        }
        public void CalculoImpuestoRenta(string ced, double imprenta)
        {
            SqlCommand caclimprent = new SqlCommand();
            caclimprent.Connection = Conexion;

            caclimprent.CommandText = "UPDATE Salarios SET S_ImpRenta = @imprenta WHERE Trabajador_Ced = @ced;";

            caclimprent.Parameters.AddWithValue("@imprenta", imprenta);

            Conexion.Close();
        }
        public void CalculoCargasPatronales(string ced, double s_cargas)
        {
            SqlCommand calccpat = new SqlCommand();
            calccpat.Connection = Conexion;

            calccpat.CommandText = "UPDATE @S_Ob_Pat from Salarios values as @s_carga WHERE Trabajador_Ced = @ced;";

            calccpat.Parameters.AddWithValue("@ced", ced);
            calccpat.Parameters.AddWithValue("@s_carga", s_cargas);

            Conexion.Close();
        }
        public void CalculoSalarioNeto(string ced, double s_neto)
        {
            SqlCommand calccpat = new SqlCommand();
            calccpat.Connection = Conexion;

            calccpat.CommandText = "UPDATE Salarios SET S_Neto = @s_neto WHERE Trabajador_Ced = @ced;";

            calccpat.Parameters.AddWithValue("@ced", ced);
            calccpat.Parameters.AddWithValue("@s_neto", s_neto);

            Conexion.Close();
        }

        public void CalculoSalarioFinal(string ced, double s_final)
        {
            SqlCommand calccpat = new SqlCommand();
            calccpat.Connection = Conexion;

            calccpat.CommandText = "UPDATE Salarios SET S_Final = @s_final WHERE Trabajador_Ced = @ced;";

            calccpat.Parameters.AddWithValue("@ced", ced);
            calccpat.Parameters.AddWithValue("@s_final", s_final);

            Conexion.Close();
        }
    }
}