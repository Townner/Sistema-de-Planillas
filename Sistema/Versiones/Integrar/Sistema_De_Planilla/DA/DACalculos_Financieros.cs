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
            Search.CommandText = "Select * from Cargos_Financieros where Trabajador_Ced = ced value as @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos_Financieros temp = new TO.TOCalculos_Financieros();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.Ahorro = (double)read["Ahorros"];
                    temp.Interes = (double)read["Intereses"];
                    temp.M_Prestamo = (double)read["M_Prestamo"];
                    temp.C_Prest = (double)read["C_Prest"];
                    temp.A_Quincenal = (double)read["A_Quincenal"];
                    temp.A_Mensual1 = (double)read["A_Mensual"];
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

        public void CalculoInetresesPrestamo(TO.TOCalculos_Financieros calcf)
        {
            throw new NotImplementedException();
        }

        public void CalculoSubcidio(TO.TOCalculos_Financieros calcsub)
        {
            throw new NotImplementedException();
        }

        public void CalculoAdicionalMensual(TO.TOCalculos_Financieros calcamen)
        {
            throw new NotImplementedException();
        }

        public void CalculoAdicionalQuincenal(double p)
        {
            throw new NotImplementedException();
        }
    }
}
