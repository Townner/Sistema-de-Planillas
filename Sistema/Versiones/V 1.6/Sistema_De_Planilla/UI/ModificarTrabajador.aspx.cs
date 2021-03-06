﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace UI
{
    public partial class ModificarTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btnCons_Click(object sender, EventArgs e)
        {
            CargaDatos();
            if (true)
            {
                BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
                this.txtCed.Text = BL_Trab.ced;
                this.lblVen_Ced.Text = BL_Trab.ven_ced.ToString();
                this.txtNom.Text = BL_Trab.nombre;
                this.txtAp1.Text = BL_Trab.apellido1;
                this.txtAp2.Text = BL_Trab.apellido2;
                this.txtMail.Text = BL_Trab.mail;
                this.txtTel1.Text = BL_Trab.tel1;
                this.txtTel2.Text = BL_Trab.tel2;
                this.txtDir.Text = BL_Trab.dir;
                this.txtExp.Text = BL_Trab.experiencia;
                this.txtTitulos.Text = BL_Trab.titulos;
                this.txtNum_Seguro.Text = Convert.ToString(BL_Trab.num_seguro);
                this.lblVen_Ced.Text = BL_Trab.uniforme.ToString();
                this.DropEstado_T.Text = BL_Trab.estado_t;
                this.DropInact.Text = BL_Trab.inact;
                this.DropEst_Civ.Text = BL_Trab.est_civ;
                this.txtNacionalidad.Text = BL_Trab.nacionalidad;
                this.DropDepartamento.DataSource = BL_Trab.id_departamento;
                this.DropPuesto.DataSource = BL_Trab.id_puesto;
            }
        }

        protected void btnMod_Click(object sender, EventArgs e)
        {
            int c = CargaDatos();
            if (true)
            {
                BL.BLTrabajador BL_Trab = new BL.BLTrabajador();
                BL_Trab.id = c;
                BL_Trab.ced = this.txtCed.Text;
                BL_Trab.ven_ced = this.lblVen_Ced.Text;
                BL_Trab.nombre = this.txtNom.Text;
                BL_Trab.apellido1 = this.txtAp1.Text;
                BL_Trab.apellido2 = this.txtAp2.Text;
                BL_Trab.mail = this.txtMail.Text;
                BL_Trab.tel1 = this.txtTel1.Text;
                BL_Trab.tel2 = this.txtTel2.Text;
                BL_Trab.dir = this.txtDir.Text;
                BL_Trab.experiencia = this.txtExp.Text;
                BL_Trab.titulos = this.txtTitulos.Text;
                BL_Trab.num_seguro = Convert.ToInt32((txtNum_Seguro.Text));
                //BL_Trab.uniforme = this.lblUnif.text;
                BL_Trab.estado_t = this.DropEstado_T.Text;
                BL_Trab.inact = this.DropInact.Text;
                BL_Trab.est_civ = this.DropEst_Civ.Text;
                BL_Trab.nacionalidad = this.txtNacionalidad.Text;
                BL_Trab.id_departamento = Convert.ToInt32(DropDepartamento.Text);
                BL_Trab.id_puesto = Convert.ToInt32(DropPuesto.Text);
            }
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
            SqlConnection Conexion = new SqlConnection();

            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select Nom_Dep from Departamentos";

            SqlDataReader read = Search.ExecuteReader();

            if (read.Read())
            {
                while (read.Read())
                {
                    DropDepartamento.DataSource = read;
                    DropDepartamento.DataValueField = "Nom_Dep";
                    DropDepartamento.DataTextField = "Nom_Dep";
                    DropDepartamento.DataBind();
                }
            }
            Conexion.Close();

        }

        private void ConultarPuest()
        {
            SqlConnection Conexion = new SqlConnection();

            SqlCommand Search = new SqlCommand();
            Search.Connection = Conexion;
            Search.CommandText = "Select Nom_Puesto from Puesto";

            SqlDataReader read = Search.ExecuteReader();

            if (read.Read())
            {
                while (read.Read())
                {
                    DropDepartamento.DataSource = read;
                    DropDepartamento.DataValueField = "Nom_Puesto";
                    DropDepartamento.DataTextField = "Nom_Puesto";
                    DropDepartamento.DataBind();
                }
            }
            Conexion.Close();
        }

        protected void CalUniforme_SelectionChanged(object sender, EventArgs e)
        {
            Label1.Text = CalUniforme.SelectedDate.ToString();
        }

        protected void CalVen_Ced_SelectionChanged(object sender, EventArgs e)
        {
            lblVen_Ced.Text = CalVen_Ced.SelectedDate.ToString();
        }




    }
}