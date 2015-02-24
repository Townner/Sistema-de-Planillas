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

        public void AgregarTrabajdor(TO.TOTrabajdor tb)
        {
            SqlCommand Agregar = new SqlCommand();
            Agregar.Connection = Conexion;
            Agregar.CommandText = "INSERT into Trabajador(ID, Ced, Ven_Ced, Nombre, Apellido1, Apellido2, "+
                "Nac, Est_Civ, Mail, Tel1, Tel2, Dir, Fechas_Trabajdor, Usuario_ID, ID_Horas_Salarios_ID, ID_Puesto, Experiencia, "+
                "Titulos, Num_Seguro, Uniforme, Estado_T, Inact, L_Trabajo, ID_Departamento) values (@Id, @Ced, @VC, @Nom, @Ap1, @Ap2, "+
                "@Nac, @EC, @M, @T1, @T2, @Dir, @FT, @UID, @IDHS, @IDP, @Exp, @Tit, @NSeg, @Unif, @EstT, @Inact, @LT, @IDDep)";
            
            Agregar.Parameters.AddWithValue("@ID,", tb.Id);
            Agregar.Parameters.AddWithValue("@Ced", tb.Ced);
            Agregar.Parameters.AddWithValue("@VC", tb.Ven_Ced);
            Agregar.Parameters.AddWithValue("@Nom", tb.Nom);
            Agregar.Parameters.AddWithValue("@Ap1", tb.Ap1);
            Agregar.Parameters.AddWithValue("@Ap2", tb.Ap2);
            Agregar.Parameters.AddWithValue("@Nac", tb.Nac);
            Agregar.Parameters.AddWithValue("@EC", tb.Est_Civ);
            Agregar.Parameters.AddWithValue("@M", tb.Mail);
            Agregar.Parameters.AddWithValue("@T1", tb.Tel1);
            Agregar.Parameters.AddWithValue("@T2", tb.Tel2);
            Agregar.Parameters.AddWithValue("@Dir", tb.Dir);
            Agregar.Parameters.AddWithValue("@FT", tb);
            Agregar.Parameters.AddWithValue("@UID", tb.T_Usuario);
            Agregar.Parameters.AddWithValue("@IDHS", tb);
            Agregar.Parameters.AddWithValue("@IDP", tb.Puesto);
            Agregar.Parameters.AddWithValue("@Exp", tb.Exp);
            Agregar.Parameters.AddWithValue("@Tit", tb.Titulo);
            Agregar.Parameters.AddWithValue("@NSeg", tb.Num_Seguro);
            Agregar.Parameters.AddWithValue("@Unif", tb.Uniformes);
            Agregar.Parameters.AddWithValue("@EstT", tb.Estado_T);
            Agregar.Parameters.AddWithValue("@Inact", tb.Inact);
            Agregar.Parameters.AddWithValue("@LT", tb.L_Trabajo);
            Agregar.Parameters.AddWithValue("@IDDep", tb.Depa);
            

            if(Conexion.State == ConnectionState.Closed){
                Conexion.Open();
            }

            Agregar.ExecuteNonQuery();

            if(Conexion.State != ConnectionState.Closed){
                Conexion.Open();
            }

        }

        public void ModifcarTrabajador(TO.TOTrabajdor trab)
        {
            throw new NotImplementedException();
        }

        public void EliminarTrabajador(TO.TOTrabajdor trab)
        {
            throw new NotImplementedException();
        }

        public void ConsultarTrabajador(TO.TOTrabajdor trab)
        {
            throw new NotImplementedException();
        }

        public System.Data.ConnectionState ConnctionState { get; set; }
    }
}