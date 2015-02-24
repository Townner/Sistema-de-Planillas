using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace DA
{
    public class DATrabajador
    {
        SqlConnection Conexion = new SqlConnection();

        public TO.TOTrabajdor Search(string ced)
        {
            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select * from Trabajador where Ced = ced value as @ced";

            Search.Parameters.AddWithValue("@ced", ced);

            SqlDataReader read = Search.ExecuteReader();
            TO.TOTrabajdor temp = new TO.TOTrabajdor();

            if (read.Read())
            {
                while (read.Read())
                {
                    temp.ID = (int)read["ID"];
                    temp.Ced = (string)read["Ced"];
                    temp.Ven_Ced = (DateTime)read["Ven_Ced"];
                    temp.Nombre = (string)read["Nombre"];
                    temp.Apellido1 = (string)read["Apellido1"];
                    temp.Apellido2 = (string)read["Apellido2"];
                    temp.Mail = (string)read["Mail"];
                    temp.Tel1 = (string)read["Tel1"];
                    temp.Tel2 = (string)read["Tel2"];
                    temp.Dir = (string)read["Dir"];
                    temp.Experiencia = (string)read["Experiencia"];
                    temp.Titulos = (string)read["Titulos"];
                    temp.Num_Seguro = (int)read["Num_Seguro"];
                    temp.Uniforme = (DateTime)read["Uniforme"];
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




        public void AgregarTrabajdor(int id, string ced, DateTime ven_ced, string nombre, 
            string apellido1, string apellido2, string mail, string tel1, string tel2, 
            string dir, string experiencia, string titulos, int num_seguro, 
            DateTime uniforme, string estado_t, string inact, string l_trabajo, 
            string est_civ, string nacionalidad, int id_departamento, int id_puesto)
        {
            SqlCommand atrab = new SqlCommand();
            atrab.Connection = Conexion;
            atrab.CommandText = "INSERT into Trabajador(ID, Ced, Ven_Ced, Nombre, Apellido1"+
                ", Apellido2, Mail, Tel1, Tel2, Dir, Experiencia, Titulos, Num_Seguro, Uniforme" +
                ", Estado_t, Inact, L_Trabajo, Est_Civ, Nacionalidad, ID_Departamento, ID_Puesto)"+
                " values (@id, @ced, @ven_ced, @nombre, @apellido1, @apellido2, @mail, @tel1, @tel2"+
                ", @dir, @experiencia, @titulos, @num_seguro, @uniforme, @estad_t, @inact, @l_trabajo"+
                ", @est_civ, @nacionalidad, @id_departamento, @id_puesto)";
            
            atrab.Parameters.AddWithValue("@id,", id);
            atrab.Parameters.AddWithValue("@ced", ced);
            atrab.Parameters.AddWithValue("@ven_ced", ven_ced);
            atrab.Parameters.AddWithValue("@nombre", nombre);
            atrab.Parameters.AddWithValue("@apellido1", apellido1);
            atrab.Parameters.AddWithValue("@apellido2", apellido2);
            atrab.Parameters.AddWithValue("@mail", mail);
            atrab.Parameters.AddWithValue("@tel1", tel1);
            atrab.Parameters.AddWithValue("@tel2", tel2);
            atrab.Parameters.AddWithValue("@dir", dir);
            atrab.Parameters.AddWithValue("@experiencia", experiencia);
            atrab.Parameters.AddWithValue("@titulos", titulos);
            atrab.Parameters.AddWithValue("@num_seguro", num_seguro);
            atrab.Parameters.AddWithValue("@uniforme", uniforme);
            atrab.Parameters.AddWithValue("@estad_t", estado_t);
            atrab.Parameters.AddWithValue("@inact", inact);
            atrab.Parameters.AddWithValue("@l_trabajo", l_trabajo);
            atrab.Parameters.AddWithValue("@est_civ", est_civ);
            atrab.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            atrab.Parameters.AddWithValue("@id_departamento", id_departamento);
            atrab.Parameters.AddWithValue("@id_puesto", id_puesto);


            Conexion.Close();

        }


        public void ModifcarTrabajador(string ced, DateTime ven_ced, string nombre, string apellido1, string apellido2, string mail, string tel1, string tel2, string dir, string experiencia, string titulos, int num_seguro, DateTime uniforme, string estado_t, string inact, string l_trabajo, string est_civ, string nacionalidad, int id_departamento, int id_puesto)
        {
            SqlCommand modtrab = new SqlCommand();
            modtrab.Connection = Conexion;
            modtrab.CommandText = "UPDATE Trabajador(Ced, Ven_Ced, Nombre, Apellido1" +
                ", Apellido2, Mail, Tel1, Tel2, Dir, Experiencia, Titulos, Num_Seguro, Uniforme" +
                ", Estado_t, Inact, L_Trabajo, Est_Civ, Nacionalidad, ID_Departamento, ID_Puesto)" +
                " values (@ced, @ven_ced, @nombre, @apellido1, @apellido2, @mail, @tel1, @tel2" +
                ", @dir, @experiencia, @titulos, @num_seguro, @uniforme, @estad_t, @inact, @l_trabajo" +
                ", @est_civ, @nacionalidad, @id_departamento, @id_puesto)";

            modtrab.Parameters.AddWithValue("@ced", ced);
            modtrab.Parameters.AddWithValue("@ven_ced", ven_ced);
            modtrab.Parameters.AddWithValue("@nombre", nombre);
            modtrab.Parameters.AddWithValue("@apellido1", apellido1);
            modtrab.Parameters.AddWithValue("@apellido2", apellido2);
            modtrab.Parameters.AddWithValue("@mail", mail);
            modtrab.Parameters.AddWithValue("@tel1", tel1);
            modtrab.Parameters.AddWithValue("@tel2", tel2);
            modtrab.Parameters.AddWithValue("@dir", dir);
            modtrab.Parameters.AddWithValue("@experiencia", experiencia);
            modtrab.Parameters.AddWithValue("@titulos", titulos);
            modtrab.Parameters.AddWithValue("@num_seguro", num_seguro);
            modtrab.Parameters.AddWithValue("@uniforme", uniforme);
            modtrab.Parameters.AddWithValue("@estad_t", estado_t);
            modtrab.Parameters.AddWithValue("@inact", inact);
            modtrab.Parameters.AddWithValue("@l_trabajo", l_trabajo);
            modtrab.Parameters.AddWithValue("@est_civ", est_civ);
            modtrab.Parameters.AddWithValue("@nacionalidad", nacionalidad);
            modtrab.Parameters.AddWithValue("@id_departamento", id_departamento);
            modtrab.Parameters.AddWithValue("@id_puesto", id_puesto);

            Conexion.Close();
        }

        public void EliminarTrabajador(string ced, string estado_t, string inact)
        {
            SqlCommand eltrab = new SqlCommand();
            eltrab.Connection = Conexion;
            eltrab.CommandText = "UPDATE Trabajador(Ced, Estado_t, Inact)" +
                " values (@ced, @estad_t, @inact)";

            eltrab.Parameters.AddWithValue("@ced", ced);
            eltrab.Parameters.AddWithValue("@estad_t", estado_t);
            eltrab.Parameters.AddWithValue("@inact", inact);

            Conexion.Close();
        }
    }
}