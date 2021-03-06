﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace UI
{
    public partial class ConsultarTrabajador : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            FormatoDataTable();
            btnNueva.Visible = false;
        }

        SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        DataTable Table = new DataTable();

        private void FormatoDataTable()
        {
            Table.Columns.Add("ID");
            Table.Columns.Add("Cedula");
            Table.Columns.Add("Vencimiento Cedula");
            Table.Columns.Add("Nombre");
            Table.Columns.Add("Apellido1");
            Table.Columns.Add("Apellido2");
            Table.Columns.Add("Correo");
            Table.Columns.Add("Celular");
            Table.Columns.Add("Telefono Fijo");
            Table.Columns.Add("Dirección");
            Table.Columns.Add("Experiencia");
            Table.Columns.Add("Titulos");
            Table.Columns.Add("Numero de Seguro");
            Table.Columns.Add("Fecha Entrega Uniforme");
            Table.Columns.Add("Estado");
            Table.Columns.Add("Contratable");
            Table.Columns.Add("Lugar De Trabajo");
            Table.Columns.Add("Estado Civil");
            Table.Columns.Add("Nacionalidad");
            Table.Columns.Add("ID Departamento");
            Table.Columns.Add("ID Puesto");

            GrdTrabGeneral.DataSource = Table;
            GrdTrabGeneral.DataBind();

            foreach (DataControlField column in GrdTrabGeneral.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }

        private BL.BLUsuario CargarDatos()
        {

            Table.Clear();

            BL.BLUsuario c = new BL.BLUsuario();
            c.ConsultarUsuario(txtCed.Text);

            Table.Rows.Add(c.Trabajador_Ced, c.Id, c.estado, c.tipo);

            GrdTrabGeneral.DataSource = Table;
            GrdTrabGeneral.DataBind();

            return c;
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            if (CargarDatos().Trabajador_Ced != null)
            {
                this.txtCed.Text = "";
                btnNueva.Visible = true;
                btnConsultar.Visible = false;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario con la cedula " + txtCed.Text + " no esta asignado a un usuario');document.location.href='" + "/EliminarUsuario.aspx" + "'; </script>");
            }
        }

        protected void btnNueva_Click1(object sender, EventArgs e)
        {
            GrdTrabGeneral.DataSource = null;
            btnNueva.Visible = false;
            btnConsultar.Visible = true;
        }
    }
}