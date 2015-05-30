using System;
using System.Data.SqlClient;
using System.Globalization;

namespace DA
{
    public class DATrabajador
    {
        SqlConnection Conexion = new SqlConnection(DA.Properties.Settings.Default.ConString);

        public TO.TOTrabajador Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * from dbo.trabajador where Ced = @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            Conexion.Open();

            SqlDataReader read = Search.ExecuteReader();
            TO.TOTrabajador temp = new TO.TOTrabajador();

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

                    temp.ID = (int)read["ID"];
                    temp.Ced = (string)read["Ced"];
                    temp.Ven_Ced = Convert.ToDateTime(read["Ven_Ced"]).ToString("yyyy-MM-dd");
                    temp.Nombre = (string)read["Nombre"];
                    temp.Apellido1 = (string)read["Apellido1"];
                    temp.Apellido2 = (string)read["Apellido2"];

                    if (fieldValues[6].ToString() != "N/A")
                    {
                        temp.Mail = (string)read["Mail"];
                    }
                    else {
                        temp.Mail = fieldValues[6].ToString();
                    }

                    if (fieldValues[7].ToString() != "N/A")
                    {
                        temp.Tel1 = (string)read["Tel1"];
                    }
                    else
                    {
                        temp.Tel1 = fieldValues[7].ToString();
                    }

                    if (fieldValues[8].ToString() != "N/A")
                    {
                        temp.Tel2 = (string)read["Tel2"];
                    }
                    else
                    {
                        temp.Tel2 = fieldValues[8].ToString();
                    }
                    temp.Dir = (string)read["Dir"];

                    if (fieldValues[10].ToString() != "N/A")
                    {
                        temp.Experiencia = (string)read["Experiencia"];
                    }
                    else
                    {
                        temp.Experiencia = fieldValues[10].ToString();
                    }
                    if (fieldValues[11].ToString() != "N/A")
                    {
                        temp.Titulos = (string)read["Titulos"];
                    }
                    else
                    {
                        temp.Titulos = fieldValues[11].ToString();
                    }
                    temp.Num_Seguro = Convert.ToInt32(read["Num_Seguro"]);
                    temp.Uniforme = Convert.ToDateTime(read["Uniforme"]).ToString("yyyy-MM-dd");
                    temp.Estado_t = (string)read["Estado_t"];
                    temp.Inact = (string)read["Inact"];
                    temp.L_Trabajo = (string)read["L_Trabajo"];
                    temp.Est_Civ = (string)read["Est_Civ"];
                    temp.Nacionalidad = (string)read["Nacionalidad"];
                    temp.ID_Departamento = (int)read["ID_Departamento"];
                    temp.ID_Puesto = (int)read["ID_Puesto"];
                }
            }
            Conexion.Close();

            return temp;
        }

        public int getID(string cedula)
        {

            SqlCommand getCedula = new SqlCommand();
            getCedula.Connection = Conexion;
            getCedula.CommandText = "select ID from dbo.trabajador where Ced = @Ced";
            getCedula.Parameters.AddWithValue("@Ced", cedula);

            Conexion.Open();

            SqlDataReader reader = getCedula.ExecuteReader();

            int temp = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    temp = (int)reader["ID"];
                }

            }
            else
            {
            }
            Conexion.Close();

            return temp;
        }
        

        public void AgregarTrabajdor(TO.TOTrabajador trab)
        {
            SqlCommand atrab = new SqlCommand();
            atrab.Connection = Conexion;
            atrab.CommandText = "INSERT INTO trabajador(Ced , Ven_Ced , Nombre , Apellido1 , Apellido2 , Mail , Tel1 , Tel2 , Dir , Experiencia , Titulos , Num_Seguro , Uniforme , Estado_T "
                + " , Inact , L_Trabajo , Est_Civ , Nacionalidad , ID_Departamento , ID_Puesto ) values (@ced , CONVERT(Datetime, @ven_ced), @nombre , @apellido1 , @apellido2 , @mail , @tel1 , @tel2 "
                + " , @dir , @experiencia, @titulos, @num_seguro , CONVERT(Datetime, @uniforme) , @estado_t , @inact , @l_trabajo , @est_civ , @nacionalidad, @id_departamento , @id_puesto);";

            atrab.Parameters.AddWithValue("@ced", trab.Ced);
            atrab.Parameters.AddWithValue("@ven_ced", trab.Ven_Ced);
            atrab.Parameters.AddWithValue("@nombre", trab.Nombre);
            atrab.Parameters.AddWithValue("@apellido1", trab.Apellido1);
            atrab.Parameters.AddWithValue("@apellido2", trab.Apellido2);
            atrab.Parameters.AddWithValue("@mail", trab.Mail);
            atrab.Parameters.AddWithValue("@tel1", trab.Tel1);
            atrab.Parameters.AddWithValue("@tel2", trab.Tel2); 
            atrab.Parameters.AddWithValue("@dir", trab.Dir);
            atrab.Parameters.AddWithValue("@experiencia", trab.Experiencia);
            atrab.Parameters.AddWithValue("@titulos", trab.Titulos);
            atrab.Parameters.AddWithValue("@num_seguro", trab.Num_Seguro);
            atrab.Parameters.AddWithValue("@uniforme", trab.Uniforme);
            atrab.Parameters.AddWithValue("@estado_t", trab.Estado_t);
            atrab.Parameters.AddWithValue("@inact", trab.Inact);
            atrab.Parameters.AddWithValue("@l_trabajo", trab.L_Trabajo);
            atrab.Parameters.AddWithValue("@est_civ", trab.Est_Civ);
            atrab.Parameters.AddWithValue("@nacionalidad", trab.Nacionalidad);
            atrab.Parameters.AddWithValue("@id_departamento", trab.ID_Departamento);
            atrab.Parameters.AddWithValue("@id_puesto", trab.ID_Puesto);

            Conexion.Open();
            atrab.ExecuteNonQuery();
            Conexion.Close();

        }

       


        public void ModifcarTrabajador(TO.TOTrabajador trab)
        {
            SqlCommand modtrab = new SqlCommand();
            modtrab.Connection = Conexion;
            modtrab.CommandText = " UPDATE dbo.Trabajador SET Ced = @ced, Ven_Ced = CONVERT(Datetime, @ven_ced), Nombre = @nombre, Apellido1 = @apellido1 " +
                " , Apellido2 = @apellido2, Mail = @mail, Tel1 = @tel1, Tel2 = @tel2, Dir = @dir, Experiencia = @experiencia, Titulos = @titulos, Num_Seguro = @num_seguro, Uniforme = CONVERT(Datetime, @uniforme) " +
                " , Estado_t = @estado_t, Inact = @inact, L_Trabajo = @l_trabajo, Est_Civ = @est_civ, Nacionalidad = @nacionalidad, ID_Departamento = @id_departamento, ID_Puesto = @id_puesto WHERE Ced = @ced;";

            modtrab.Parameters.AddWithValue("@ced", trab.Ced);
            modtrab.Parameters.AddWithValue("@ven_ced", trab.Ven_Ced);
            modtrab.Parameters.AddWithValue("@nombre", trab.Nombre);
            modtrab.Parameters.AddWithValue("@apellido1", trab.Apellido1);
            modtrab.Parameters.AddWithValue("@apellido2", trab.Apellido2);
            modtrab.Parameters.AddWithValue("@mail", trab.Mail);
            modtrab.Parameters.AddWithValue("@tel1", trab.Tel1);
            modtrab.Parameters.AddWithValue("@tel2", trab.Tel2);
            modtrab.Parameters.AddWithValue("@dir", trab.Dir);
            modtrab.Parameters.AddWithValue("@experiencia", trab.Experiencia);
            modtrab.Parameters.AddWithValue("@titulos", trab.Titulos);
            modtrab.Parameters.AddWithValue("@num_seguro", trab.Num_Seguro);
            modtrab.Parameters.AddWithValue("@uniforme", trab.Uniforme);
            modtrab.Parameters.AddWithValue("@estado_t", trab.Estado_t);
            modtrab.Parameters.AddWithValue("@inact", trab.Inact);
            modtrab.Parameters.AddWithValue("@l_trabajo", trab.L_Trabajo);
            modtrab.Parameters.AddWithValue("@est_civ", trab.Est_Civ);
            modtrab.Parameters.AddWithValue("@nacionalidad", trab.Nacionalidad);
            modtrab.Parameters.AddWithValue("@id_departamento", trab.ID_Departamento);
            modtrab.Parameters.AddWithValue("@id_puesto", trab.ID_Puesto);

            Conexion.Open();
            modtrab.ExecuteNonQuery();
            Conexion.Close();
        }

        public void EliminarTrabajador(string ced, string estado_t, string inact)
        {
            SqlCommand eltrab = new SqlCommand();
            eltrab.Connection = Conexion;
            eltrab.CommandText = "UPDATE Trabajador SET Estado_t = @estado_t, Inact = @inact WHERE Ced = @ced";

            eltrab.Parameters.AddWithValue("@ced", ced);
            eltrab.Parameters.AddWithValue("@estado_t", estado_t);
            eltrab.Parameters.AddWithValue("@inact", inact);
            
            Conexion.Open();
            eltrab.ExecuteNonQuery();
            Conexion.Close();
        }

        public int ConsultarTrabajador_ID(string ced)
        {
            SqlCommand Buscar = new SqlCommand();
            Buscar.Connection = Conexion;
            Buscar.CommandText = "select ID from dbo.trabajador where Ced = @Ced";
            Buscar.Parameters.AddWithValue("@Ced", ced);

            Conexion.Open();

            SqlDataReader reader = Buscar.ExecuteReader();

            int temp = 0;

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    temp = (int)reader["ID"];
                }

            }
            else
            {

            }
            Conexion.Close();
            return temp;
        }

    }
}