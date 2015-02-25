using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DACalculos_Financieros
    {

        SqlConnection Conexion = new SqlConnection();

        public TO.TOCalculos_Financieros Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM Cargos_Financieros where Trabajador_Ced = @ced;";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos_Financieros temp = new TO.TOCalculos_Financieros();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"];
                    temp.Ahorro = (double)read["Ahorros"];
                    temp.Interes = (double)read["Intereses"];
                    temp.M_Prestamo = (double)read["M_Prestamo"];
                    temp.C_Prest = (double)read["C_Prest"];
                    temp.A_Quincenal = (double)read["A_Quincenal"];
                    temp.A_Mensual1 = (double)read["A_Mensual1"];
                    temp.A_Mensual2 = (double)read["A_Mensual2"];
                    temp.Embar = (double)read["Embar"];
                    temp.Adelan = (double)read["Adelan"];
                    temp.Otros = (double)read["Otros"];
                    temp.M_Subcidio = (double)read["M_Subsidio"];
                    temp.S_Subcidio = (double)read["S_Subcdio"];
                }
            }
            Conexion.Close();

            return temp;
        }

        public void CalculoInetresesPrestamo(string ced, double interes)
        {
            SqlCommand calcintpres = new SqlCommand();
            calcintpres.Connection = Conexion;

            calcintpres.CommandText = "UPDATE Cargos_Financieros SET Intereses = @interes WHERE Trabajador_Ced = @ced;";

            calcintpres.Parameters.AddWithValue("@ced",ced);
            calcintpres.Parameters.AddWithValue("@interes", interes);

            Conexion.Close();
        }

        public void CalculoSubcidio(string ced, double s_subcidio)
        {
            SqlCommand calcsub = new SqlCommand();
            calcsub.Connection = Conexion;

            calcsub.CommandText = "UPDATE Cargos_Financieros SET S_Subcdio = @s_subcidio WHERE Trabajador_Ced = @ced;";

            calcsub.Parameters.AddWithValue("@ced", ced);
            calcsub.Parameters.AddWithValue("@s_subcidio", s_subcidio);

            Conexion.Close();
        }

        public void CalculoAdicionalMensual(string ced, double a_mensual1)
        {
            SqlCommand calcadmen = new SqlCommand();
            calcadmen.Connection = Conexion;

            calcadmen.CommandText = "UPDATE Cargos_Financieros SET @A_Mensual1 = @a_mensual1 WHERE Trabajador_Ced = @ced;";

            calcadmen.Parameters.AddWithValue("@ced", ced);
            calcadmen.Parameters.AddWithValue("@a_mensual1", a_mensual1);

            Conexion.Close();
        }

        public void CalculoAdicionalQuincenal(string ced,double a_quincenal)
        {
            SqlCommand calcadquin = new SqlCommand();
            calcadquin.Connection = Conexion;

            calcadquin.CommandText = "UPDATE Cargos_Financieros SET @A_Quincenal = @a_quincenal WHERE Trabajador_Ced = @ced;";

            calcadquin.Parameters.AddWithValue("@ced", ced);
            calcadquin.Parameters.AddWithValue("@a_quincenal", a_quincenal);

            Conexion.Close();
        }
    }
}
