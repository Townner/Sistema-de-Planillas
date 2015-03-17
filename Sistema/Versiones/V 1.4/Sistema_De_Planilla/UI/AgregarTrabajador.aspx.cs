using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UI
{
    public partial class AgregarTrabajador : System.Web.UI.Page
    {
        private SqlConnection Conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);
        protected void Page_Load(object sender, EventArgs e)
        {
            ConsultaDepartamento();
            ConultarPuesto();

        }

        protected void btnTrab_Click(object sender, EventArgs e)
        {
            int c = CargaDatos();
            int temp1 = Int32.Parse(DropDepartamento.SelectedValue);
            int temp2 = Int32.Parse(DropPuesto.SelectedValue);

            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            BL_Trab.id = c;
            BL_Trab.ced = this.txtCed.Text;
            //BL_Trab.ven_ced = this.CalVen_Ced.SelectedDate;
            BL_Trab.ven_ced = this.lblVen_Ced.Text;
            BL_Trab.nombre = this.txtNom.Text;
            BL_Trab.apellido1 = this.txtAp1.Text;
            BL_Trab.apellido2 = this.txtAp2.Text;
            BL_Trab.mail = this.txtMail.Text;
            BL_Trab.tel1 = this.txtTel1.Text;
            BL_Trab.tel2 = this.txtTel2.Text;
            BL_Trab.dir = this.txtDir.Text;
            BL_Trab.experiencia = this.txtExp.Value.ToString();
            BL_Trab.titulos = this.txtTitulos.Value.ToString();
            BL_Trab.num_seguro = Convert.ToInt32((txtNum_Seguro.Text));
            //BL_Trab.uniforme = this.CalUniforme.SelectedDate;
            BL_Trab.uniforme = this.lblUnif.Text;
            BL_Trab.estado_t = this.DropEstado_T.SelectedValue;
            BL_Trab.inact = "Contratable";
            BL_Trab.l_trabajo = txtL_Trabajo.Text;
            BL_Trab.est_civ = this.DropEst_Civ.SelectedValue;
            BL_Trab.nacionalidad = this.txtNacionalidad.Text;
            BL_Trab.id_departamento = temp1;
            BL_Trab.id_puesto = temp2;
            BL_Trab.AgregarTrabajdor();
            
            
            Response.Write("<script language='javascript'>alert('El trabajador fue agregado correctamente');document.location.href='" + "/AgregarTrabajador.aspx" + "'; </script>");

        }

        private int CargaDatos()
        {
            int c = 0;
            BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
            c = BL_Trab.ConsultarTrabajador(txtCed.Text);
            return c;
        }

        private void ConsultaDepartamento()
        {
            
            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nom_Dep], [ID_Departamento] FROM [DB_Planilla].[dbo].[departamento];";

            Conexion.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListItem LI = new ListItem();
                    LI.Value =  Convert.ToString((int)dr["ID_Departamento"]);
                    LI.Text = dr[0].ToString();
                    DropDepartamento.Items.Add(LI);
                }

            }
            Conexion.Close();

        }

        private void ConultarPuesto()
        {   
            SqlDataReader dr;

            SqlCommand com = new SqlCommand();
            com.Connection = Conexion;
            com.CommandText = "SELECT [Nom_Puesto], [ID_Puesto] FROM [DB_Planilla].[dbo].[puesto];";

            Conexion.Open();
            dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    ListItem LI = new ListItem();
                    LI.Value = Convert.ToString((int)dr["ID_Puesto"]);
                    LI.Text = dr[0].ToString();
                    DropPuesto.Items.Add(LI);
                }

            }

            Conexion.Close();
        }

        protected void CalUniforme_SelectionChanged(object sender, EventArgs e)
        {
            lblUnif.Text = CalUniforme.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
        }

        protected void CalVen_Ced_SelectionChanged(object sender, EventArgs e)
        {
            lblVen_Ced.Text = CalVen_Ced.SelectedDate.ToString("yyyy-MM-dd hh:mm:ss.fff");
        }

        protected void txtCed_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtNum_Seguro_TextChanged(object sender, EventArgs e)
        {

        }


    }
}