using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace DA
{
    public class DACalculos_Financieros
    {

        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOCalculos_Financieros Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM dbo.Cargos_Financieros where Trabajador_Ced = @ced;";

            Search.Parameters.AddWithValue("@ced", ced);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos_Financieros temp = new TO.TOCalculos_Financieros();

            if (read.HasRows)
            {
                while (read.Read())
                {
                    temp.Trabajador_ID = (int)read["Trabajador_ID"];
                    temp.Trabajador_Ced = (string)read["Trabajador_Ced"]; 
                    temp.M_Prestamo = Convert.ToDouble(read["M_Prestamo"]);
                    temp.C_Prest = Convert.ToDouble(read["C_Prest"]); 
                    temp.Interes = Convert.ToDouble(read["Intereses"]);
                    temp.Ahorro = Convert.ToDouble(read["Ahorros"]);
                    temp.Embar = Convert.ToDouble(read["Embar"]); 
                    temp.Adelan = Convert.ToDouble(read["Adelan"]);
                    temp.Otros = Convert.ToDouble(read["Otros"]);
                    temp.M_Subcidio = Convert.ToDouble(read["M_Subsidio"]);
                    temp.S_Subcidio = Convert.ToDouble(read["S_Subsidio"]);
                    temp.A_Quincenal = Convert.ToDouble(read["A_Quincenal"]);
                    temp.A_Mensual1 = Convert.ToDouble(read["A_Mensual1"]);
                    temp.A_Mensual2 = Convert.ToDouble(read["A_Mensual2"]);
                }
            }
            Conexion.Close();

            return temp;
        }

       public void AgregarCalculos(TO.TOCalculos_Financieros TO_Caculos)
        {
            SqlCommand Insert = new SqlCommand();
            Insert.Connection = Conexion;

            Insert.CommandText = " INSERT INTO dbo.Cargos_Financieros(Trabajador_ID, Trabajador_Ced, M_Prestamo, C_Prest, Intereses, Ahorros, Embar, Adelan, Otros, M_Subsidio, S_Subsidio, A_Quincenal, A_Mensual1, A_Mensual2) " +
                " VALUES (@ID,@Ced,@MPres,@CPres,@Int,@Aho,@Emb,@Ade,@Otros,@Msub,@SSub,@AQui,@AM1,@AM2);";

            Insert.Parameters.AddWithValue("@ID", TO_Caculos.Trabajador_ID);
            Insert.Parameters.AddWithValue("@Ced", TO_Caculos.Trabajador_Ced);
            Insert.Parameters.AddWithValue("@MPres", TO_Caculos.M_Prestamo);
            Insert.Parameters.AddWithValue("@CPres", TO_Caculos.C_Prest);
            Insert.Parameters.AddWithValue("@Int", TO_Caculos.Interes);
            Insert.Parameters.AddWithValue("@Aho", TO_Caculos.Ahorro);
            Insert.Parameters.AddWithValue("@Emb", TO_Caculos.Embar);
            Insert.Parameters.AddWithValue("@Ade", TO_Caculos.Adelan);
            Insert.Parameters.AddWithValue("@Otros", TO_Caculos.Otros);
            Insert.Parameters.AddWithValue("@MSub", TO_Caculos.M_Subcidio);
            Insert.Parameters.AddWithValue("@SSub", TO_Caculos.S_Subcidio);
            Insert.Parameters.AddWithValue("@AQui", TO_Caculos.A_Quincenal);
            Insert.Parameters.AddWithValue("@AM1", TO_Caculos.A_Mensual1);
            Insert.Parameters.AddWithValue("@AM2", TO_Caculos.A_Mensual2);

            Conexion.Open();
            Insert.ExecuteNonQuery();
            Conexion.Close();
       }

     public void ModificarCalculos(TO.TOCalculos_Financieros TO_Calcu)
       {
           SqlCommand modfec = new SqlCommand();
           modfec.Connection = Conexion;

           modfec.CommandText = "UPDATE dbo.Cargos_Financieros SET M_Prestamo = @MPres, C_Prest = @CPres, Intereses = @Int, Ahorros = @Aho, " 
               + " Embar = @Emb, Adelan = @Ade, Otros = @Otros, M_Subsidio = @MSub, S_Subsidio = @SSub, A_Quincenal = @AQui,"
               + " A_Mensual1 = @AM1 , A_Mensual2 = @AM2 WHERE Trabajador_Ced = @ced";

           modfec.Parameters.AddWithValue("@Ced", TO_Calcu.Trabajador_Ced);
           modfec.Parameters.AddWithValue("@MPres", TO_Calcu.M_Prestamo);
           modfec.Parameters.AddWithValue("@CPres", TO_Calcu.C_Prest);
           modfec.Parameters.AddWithValue("@Int", TO_Calcu.Interes);
           modfec.Parameters.AddWithValue("@Aho", TO_Calcu.Ahorro);
           modfec.Parameters.AddWithValue("@Emb", TO_Calcu.Embar);
           modfec.Parameters.AddWithValue("@Ade", TO_Calcu.Adelan);
           modfec.Parameters.AddWithValue("@Otros", TO_Calcu.Otros);
           modfec.Parameters.AddWithValue("@MSub", TO_Calcu.M_Subcidio);
           modfec.Parameters.AddWithValue("@SSub", TO_Calcu.S_Subcidio);
           modfec.Parameters.AddWithValue("@AQui", TO_Calcu.A_Quincenal);
           modfec.Parameters.AddWithValue("@AM1", TO_Calcu.A_Mensual1);
           modfec.Parameters.AddWithValue("@AM2", TO_Calcu.A_Mensual2);

           Conexion.Open();
           modfec.ExecuteNonQuery();
           Conexion.Close();
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
