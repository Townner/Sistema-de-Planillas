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
        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOCalculos Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * FROM dbo.Salarios WHERE Trabajador_Ced = @ced;";
            Search.Parameters.AddWithValue("@ced", ced);
            
            Conexion.Open();
            SqlDataReader read = Search.ExecuteReader();
            TO.TOCalculos temp = new TO.TOCalculos();

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

                        temp.S_Base = Convert.ToDouble(read["S_Base"]); ;
                    }
                    else
                    {
                        temp.S_Base =  Convert.ToDouble(fieldValues[2].ToString());
                    }
                    //
                    if (fieldValues[3].ToString() != "N/A")
                    {

                        temp.S_Bruto = Convert.ToDouble(read["S_Bruto"]); ;
                    }
                    else
                    {
                        temp.S_Bruto = Convert.ToDouble(fieldValues[3].ToString());
                    }
                    //
                    if (fieldValues[4].ToString() != "N/A")
                    {

                        temp.Ob_Pat_NoPen = Convert.ToDouble(read["Ob_Pat_NoPen"]); ;
                    }
                    else
                    {
                        temp.Ob_Pat_NoPen = Convert.ToDouble(fieldValues[4].ToString());
                    }
                    //
                    if (fieldValues[5].ToString() != "N/A")
                    {

                        temp.Ob_Pat_Pen = Convert.ToDouble(read["Ob_Pat_Pen"]); ;
                    }
                    else
                    {
                        temp.Ob_Pat_Pen = Convert.ToDouble(fieldValues[5].ToString());
                    }
                    //
                    if (fieldValues[6].ToString() != "N/A")
                    {

                        temp.S_Cargas = Convert.ToDouble(read["S_Ob_Pat"]); ;
                    }
                    else
                    {
                        temp.S_Cargas = Convert.ToDouble(fieldValues[6].ToString());
                    }
                    //
                    if (fieldValues[7].ToString() != "N/A")
                    {

                        temp.S_Neto = Convert.ToDouble(read["S_Neto"]); ;
                    }
                    else
                    {
                        temp.S_Neto = Convert.ToDouble(fieldValues[7].ToString());
                    }
                    //
                    if (fieldValues[8].ToString() != "N/A")
                    {

                        temp.S_Final = Convert.ToDouble(read["S_Final"]); ;
                    }
                    else
                    {
                        temp.S_Final = Convert.ToDouble(fieldValues[8].ToString());
                    }
                    //
                    if (fieldValues[9].ToString() != "N/A")
                    {

                        temp.ImpRenta = Convert.ToDouble(read["S_ImpRenta"]); ;
                    }
                    else
                    {
                        temp.ImpRenta = Convert.ToDouble(fieldValues[9].ToString());
                    }
                    //
                    if (fieldValues[10].ToString() != "N/A")
                    {

                        temp.S_Incapacidad = Convert.ToDouble(read["S_Incapacidad"]); ;
                    }
                    else
                    {
                        temp.S_Incapacidad = Convert.ToDouble(fieldValues[10].ToString());
                    }
                    //

                    if (fieldValues[11].ToString() != "N/A")
                    {

                        temp.S_Extras = Convert.ToDouble(read["S_Extras"]); ;
                    }
                    else
                    {
                        temp.S_Extras = Convert.ToDouble(fieldValues[11].ToString());
                    }
                    //
                    if (fieldValues[12].ToString() != "N/A")
                    {

                        temp.Hijos_Menor = (int)read["Hijos_Menor"]; ;
                    }
                    else
                    {
                        temp.Hijos_Menor = Convert.ToInt32(fieldValues[12].ToString());
                    }
                    //
                    if (fieldValues[13].ToString() != "N/A")
                    {

                        temp.Hijos_Mayor = (int)read["Hijos_Mayor"]; ;
                    }
                    else
                    {
                        temp.Hijos_Mayor = Convert.ToInt32(fieldValues[13].ToString());
                    }
                    //
                    if (fieldValues[14].ToString() != "N/A")
                    {

                        temp.Conyugue = (int)read["Conyuge"]; ;
                    }
                    else
                    {
                        temp.Conyugue = Convert.ToInt32(fieldValues[14].ToString());
                    }
                    //
                }
            }
            Conexion.Close();

            return temp;

        }

        public void AgregarSalario(TO.TOCalculos TO_Fech, TO.TOTrabajador TO_Trab)
        {
            SqlCommand Insert = new SqlCommand();
            Insert.Connection = Conexion;

            Insert.CommandText = " INSERT INTO Fechas_Trabajador(Trabajador_ID, Trabajador_Ced, F_Nac, F_Ingreso, F_Prueba, F_Salida) " +
                " VALUES (@ID, @Ced, CONVERT(Datetime, @F_Nac), CONVERT(Datetime, @F_Ingreso), CONVERT(Datetime, @F_Prueba), CONVERT(Datetime, @F_Salida));";

            Insert.Parameters.AddWithValue("@ID", TO_Trab.ID);
            Insert.Parameters.AddWithValue("@Ced", TO_Trab.Ced);

            if (TO_Fech.F_Nac == "N/A" || TO_Fech.F_Nac == "")
            {
                Insert.Parameters.AddWithValue("@F_Nac", DBNull.Value);
            }
            else
            {
                Insert.Parameters.AddWithValue("@F_Nac", TO_Fech.F_Nac);
            }
            //
            if (TO_Fech.F_Ingreso == "N/A" || TO_Fech.F_Ingreso == "")
            {
                Insert.Parameters.AddWithValue("@F_Ingreso", DBNull.Value);
            }
            else
            {
                Insert.Parameters.AddWithValue("@F_Ingreso", TO_Fech.F_Ingreso);
            }
            //
            if (TO_Fech.F_Pruba == "N/A" || TO_Fech.F_Pruba == "")
            {
                Insert.Parameters.AddWithValue("@F_Prueba", DBNull.Value);
            }
            else
            {
                Insert.Parameters.AddWithValue("@F_Prueba", TO_Fech.F_Pruba);
            }
            //
            if (TO_Fech.F_Salida == "N/A" || TO_Fech.F_Salida == "")
            {
                Insert.Parameters.AddWithValue("@F_Salida", DBNull.Value);
            }
            else
            {
                Insert.Parameters.AddWithValue("@F_Salida", TO_Fech.F_Salida);
            }

            Conexion.Open();
            Insert.ExecuteNonQuery();
            Conexion.Close();
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

        //----------------------------------------------//

       /* public double GetSalarioBase(int ID)
        {

            SqlCommand ConsultaSalarioBase = new SqlCommand();
            ConsultaSalarioBase.Connection = Conexion;
            ConsultaSalarioBase.CommandText = "select S_Base from dbo.salarios where Trabajador_ID = @ID";
            ConsultaSalarioBase.Parameters.AddWithValue("@ID", ID);

            Conexion.Open();

            SqlDataReader RSalarioBase = ConsultaSalarioBase.ExecuteReader();

            double S_Base = 0;

            if (RSalarioBase.HasRows)
            {
                while (RSalarioBase.Read())
                {
                    S_Base = (double)RSalarioBase["S_Base"];
                }
            }

            Conexion.Close();

            return S_Base;

        }*/


        public void UpdateSalarioBase(int ID, TO.TOCalculos TO_Calcu, double S_Base)
        {
            double s_base = 0;

            s_base = ((S_Base) + (TO_Calcu.S_Base));

            SqlCommand UpdateSalario = new SqlCommand();
            UpdateSalario.Connection = Conexion;
            UpdateSalario.CommandText = "UPDATE dbo.salarios SET S_Base = @s_base WHERE Trabajador_ID = @ID;";
            UpdateSalario.Parameters.AddWithValue("@ID", ID);
            UpdateSalario.Parameters.AddWithValue("@s_base", s_base);

            UpdateSalario.ExecuteNonQuery();
        }

        public void UpdateSalarioBasePorcentual(int ID, TO.TOCalculos TO_Calcu, double S_Base)
        {
            double s_base = 0;

            s_base = ((S_Base) * (TO_Calcu.S_Base + 1));

            SqlCommand UpdateSalario = new SqlCommand();
            UpdateSalario.Connection = Conexion;
            UpdateSalario.CommandText = "UPDATE dbo.salarios SET S_Base = @s_base WHERE Trabajador_ID = @ID;";
            UpdateSalario.Parameters.AddWithValue("@ID", ID);
            UpdateSalario.Parameters.AddWithValue("@s_base", s_base);

            UpdateSalario.ExecuteNonQuery();
        }


        public int GetPuesto(string nom) {

            SqlCommand ConsultaPuesto = new SqlCommand();
            ConsultaPuesto.Connection = Conexion;

            ConsultaPuesto.CommandText = "select ID_Puesto from dbo.puesto where Nom_Puesto = @Nom";
            ConsultaPuesto.Parameters.AddWithValue("@Nom", nom);

            Conexion.Open();

            SqlDataReader readerPuesto = ConsultaPuesto.ExecuteReader();

            int ID_Puesto = 0;

            if (readerPuesto.HasRows)
            {
                while (readerPuesto.Read())
                {
                    ID_Puesto = (int)readerPuesto["ID_Puesto"];
                }
            }

            Conexion.Close();

            return ID_Puesto;
        
        }

        public void CalculoAumentoSalarioBase(TO.TOCalculos TO_Calc, int mis, int jar, int cho) {

            if (mis == 1) 
            { 

            SqlCommand ConsultaEmpleado = new SqlCommand();
            ConsultaEmpleado.Connection = Conexion;

            ConsultaEmpleado.CommandText = " SELECT trabajador.ID, salarios.S_Base " + 
            " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
            " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                " Where puesto.ID_Puesto = @ID ";
            ConsultaEmpleado.Parameters.AddWithValue("@ID", GetPuesto("Misceláneo"));

            Conexion.Open();

            SqlDataReader readerEmpleado = ConsultaEmpleado.ExecuteReader();

            if (readerEmpleado.HasRows)
            {
                while (readerEmpleado.Read())
                {
                    UpdateSalarioBase((int)readerEmpleado["ID"],TO_Calc,Convert.ToDouble(readerEmpleado["S_Base"]));
                }
            }

            Conexion.Close();

            } // End if 1

            if (jar == 1)
            {

                SqlCommand ConsultaEmpleados = new SqlCommand();
                ConsultaEmpleados.Connection = Conexion;

                ConsultaEmpleados.CommandText =  " SELECT trabajador.ID, salarios.S_Base " + 
            " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
            " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                " Where puesto.ID_Puesto = @ID ";
                ConsultaEmpleados.Parameters.AddWithValue("@ID", GetPuesto("Jardinero"));

                Conexion.Open();

                SqlDataReader readerEmpleado = ConsultaEmpleados.ExecuteReader();

                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())
                    {
                        UpdateSalarioBase((int)readerEmpleado["ID"], TO_Calc, Convert.ToDouble(readerEmpleado["S_Base"]));
                    }
                }

                Conexion.Close();

            }// End if 2

            if (cho == 1)
            {

                SqlCommand ConsultaEmpleados = new SqlCommand();
                ConsultaEmpleados.Connection = Conexion;

                ConsultaEmpleados.CommandText = " SELECT trabajador.ID, salarios.S_Base " + 
            " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
            " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                " Where puesto.ID_Puesto = @ID ";
                ConsultaEmpleados.Parameters.AddWithValue("@ID", GetPuesto("Chofer"));

                Conexion.Open();

                SqlDataReader readerEmpleado = ConsultaEmpleados.ExecuteReader();

                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())
                    {
                        UpdateSalarioBase((int)readerEmpleado["ID"], TO_Calc, Convert.ToDouble(readerEmpleado["S_Base"]));
                    }
                }

                Conexion.Close();
            }// End if 3

        }

        public void CalculoAumentoSalarioBasePorcentual(TO.TOCalculos TO_Calc, int mis, int jar, int cho)
        {

            if (mis == 1)
            {

                SqlCommand ConsultaEmpleado = new SqlCommand();
                ConsultaEmpleado.Connection = Conexion;

                ConsultaEmpleado.CommandText = " SELECT trabajador.ID, salarios.S_Base " +
                " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
                " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                    " Where puesto.ID_Puesto = @ID ";
                ConsultaEmpleado.Parameters.AddWithValue("@ID", GetPuesto("Misceláneo"));

                Conexion.Open();

                SqlDataReader readerEmpleado = ConsultaEmpleado.ExecuteReader();

                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())
                    {
                        UpdateSalarioBasePorcentual((int)readerEmpleado["ID"], TO_Calc, Convert.ToDouble(readerEmpleado["S_Base"]));
                    }
                }

                Conexion.Close();

            } // End if 1

            if (jar == 1)
            {

                SqlCommand ConsultaEmpleados = new SqlCommand();
                ConsultaEmpleados.Connection = Conexion;

                ConsultaEmpleados.CommandText = " SELECT trabajador.ID, salarios.S_Base " +
            " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
            " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                " Where puesto.ID_Puesto = @ID ";
                ConsultaEmpleados.Parameters.AddWithValue("@ID", GetPuesto("Jardinero"));

                Conexion.Open();

                SqlDataReader readerEmpleado = ConsultaEmpleados.ExecuteReader();

                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())
                    {
                        UpdateSalarioBasePorcentual((int)readerEmpleado["ID"], TO_Calc, Convert.ToDouble(readerEmpleado["S_Base"]));
                    }
                }

                Conexion.Close();

            }// End if 2

            if (cho == 1)
            {

                SqlCommand ConsultaEmpleados = new SqlCommand();
                ConsultaEmpleados.Connection = Conexion;

                ConsultaEmpleados.CommandText = " SELECT trabajador.ID, salarios.S_Base " +
            " FROM trabajador INNER JOIN salarios ON trabajador.ID = salarios.Trabajador_ID AND trabajador.Ced = salarios.Trabajador_Ced INNER JOIN " +
            " puesto ON trabajador.ID_Puesto = puesto.ID_Puesto " +
                " Where puesto.ID_Puesto = @ID ";
                ConsultaEmpleados.Parameters.AddWithValue("@ID", GetPuesto("Chofer"));

                Conexion.Open();

                SqlDataReader readerEmpleado = ConsultaEmpleados.ExecuteReader();

                if (readerEmpleado.HasRows)
                {
                    while (readerEmpleado.Read())
                    {
                        UpdateSalarioBasePorcentual((int)readerEmpleado["ID"], TO_Calc, Convert.ToDouble(readerEmpleado["S_Base"]));
                    }
                }

                Conexion.Close();
            }// End if 3
        }

        public double BuscarCargarObreras(int Pen, int NoPen) {

            if(Pen == 1){
            
            SqlCommand ConsultaCargarPen = new SqlCommand();
            ConsultaCargarPen.Connection = Conexion;

            ConsultaCargarPen.CommandText = "select Trabajador_ID, Ob_Pat_Pen from salarios where Ob_Pat_Pen != 0";

            Conexion.Open();

            SqlDataReader readerPuesto = ConsultaCargarPen.ExecuteReader();

            double CargaObreraPen = 0;

            if (readerPuesto.HasRows)
            {
                while (readerPuesto.Read())
                {
                    CargaObreraPen = Convert.ToDouble(readerPuesto["Ob_Pat_Pen"]);
                }
            }

            Conexion.Close();

            return CargaObreraPen;
            }

            if (NoPen == 1) {

                SqlCommand ConsultaCargarNoPen = new SqlCommand();
                ConsultaCargarNoPen.Connection = Conexion;

                ConsultaCargarNoPen.CommandText = "select Trabajador_ID, Ob_Pat_NoPen from salarios where Ob_Pat_NoPen != 0";

                Conexion.Open();

                SqlDataReader readerPuesto = ConsultaCargarNoPen.ExecuteReader();

                double CargaObreraNoPen = 0;

                if (readerPuesto.HasRows)
                {
                    while (readerPuesto.Read())
                    {
                        CargaObreraNoPen = Convert.ToDouble(readerPuesto["Ob_Pat_NoPen"]);
                    }
                }

                Conexion.Close();

                return CargaObreraNoPen;
            }

            return 0;
        }

        public void updateCargas(int ID, double Monto, int pen) {

            if (pen == 1)
            {
                SqlCommand UpdateCargas = new SqlCommand();
                UpdateCargas.Connection = Conexion;
                UpdateCargas.CommandText = "update salarios set Ob_Pat_Pen = @Monto where Trabajador_ID = @ID";
                UpdateCargas.Parameters.AddWithValue("@ID", ID);
                UpdateCargas.Parameters.AddWithValue("@Monto", Monto);
                UpdateCargas.ExecuteNonQuery();

            }
            else {
                SqlCommand UpdateCargas = new SqlCommand();
                UpdateCargas.Connection = Conexion;
                UpdateCargas.CommandText = "update salarios set Ob_Pat_NoPen = @Monto where Trabajador_ID = @ID";
                UpdateCargas.Parameters.AddWithValue("@ID", ID);
                UpdateCargas.Parameters.AddWithValue("@Monto", Monto);

                UpdateCargas.ExecuteNonQuery();
            
            }
            
        }
        public void ActualizarCargas(int Pen, int NoPen, double monto) {

            if (Pen == 1)
            {

                SqlCommand ConsultaCargarPen = new SqlCommand();
                ConsultaCargarPen.Connection = Conexion;

                ConsultaCargarPen.CommandText = "select Trabajador_ID, Ob_Pat_Pen from salarios where Ob_Pat_Pen != 0";

                Conexion.Open();

                SqlDataReader readerCargas = ConsultaCargarPen.ExecuteReader();

                if (readerCargas.HasRows)
                {
                    while (readerCargas.Read())
                    {
                        updateCargas((int)readerCargas["Trabajador_ID"], monto,Pen);
                    }
                }

                Conexion.Close();
            }

            if (NoPen == 1)
            {

                SqlCommand ConsultaCargarNoPen = new SqlCommand();
                ConsultaCargarNoPen.Connection = Conexion;

                ConsultaCargarNoPen.CommandText = "select Trabajador_ID, Ob_Pat_NoPen from salarios where Ob_Pat_NoPen != 0";

                Conexion.Open();

                SqlDataReader readerCargas = ConsultaCargarNoPen.ExecuteReader();

                if (readerCargas.HasRows)
                {
                    while (readerCargas.Read())
                    {
                        updateCargas((int)readerCargas["Trabajador_ID"], monto, Pen);
                    }
                }

                Conexion.Close();

            }

        }

    }
}