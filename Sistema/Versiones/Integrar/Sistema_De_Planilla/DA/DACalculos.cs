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
            Search.CommandText = "Select * from Salarios where Trabajador_Ced = ced value as @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos temp = new TO.TOCalculos();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.ImpRenta = (double)read["Ahorros"];
                    
                }
            }
            Conexion.Close();

            return temp;
        }
 

        public void CalculoIncapacida(double inc)
        {
            throw new NotImplementedException();
        }

        public void CalculoHorasExtra(double hex)
        {
            throw new NotImplementedException();
        }

        public void CalculoSalarioFinal(double final)
        {
            throw new NotImplementedException();
        }

        public void CalculoSalarioNeto(double neto)
        {
            throw new NotImplementedException();
        }

        public void CalculoCargasPatronales(double var)
        {
            throw new NotImplementedException();
        }

        public void CalculoImpuestoRenta(double total)
        {
            throw new NotImplementedException();
        }
    }
}