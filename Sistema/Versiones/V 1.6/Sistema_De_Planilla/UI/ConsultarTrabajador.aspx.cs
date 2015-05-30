using System;
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
            FormatoDataTableTrabGeneral();
            FormatoDataTableTrabDetalle();
            FormatoDataTableHoras();
            FormatoDataTableFechas();
            FormatoDataTableLicencias();
            FormatoDataTableSalario();
            FormatoDataTableCargos();
            btnNueva.Visible = false;
            RegexCed0.Enabled = false;
        }

        SqlConnection conexion = new SqlConnection(UI.Properties.Settings.Default.ConString);

        DataTable TableTrab = new DataTable();
        DataTable TableTrabDetalle = new DataTable();
        DataTable TableHoras = new DataTable();
        DataTable TableFechas = new DataTable();
        DataTable TableLicencias = new DataTable();
        DataTable TableSalario = new DataTable();
        DataTable TableCargos = new DataTable();

        private void FormatoDataTableTrabGeneral()
        {
            TableTrab.Columns.Add("ID");
            TableTrab.Columns.Add("Cedula");
            TableTrab.Columns.Add("Vencimiento Cedula");
            TableTrab.Columns.Add("Nombre");
            TableTrab.Columns.Add("Apellido1");
            TableTrab.Columns.Add("Apellido2");
            TableTrab.Columns.Add("Correo");
            TableTrab.Columns.Add("Celular");
            TableTrab.Columns.Add("Telefono Fijo");
            TableTrab.Columns.Add("Dirección");
            //Table.Columns.Add("Experiencia");
            //Table.Columns.Add("Titulos");
            TableTrab.Columns.Add("Numero de Seguro");
            TableTrab.Columns.Add("Fecha Entrega Uniforme");
            TableTrab.Columns.Add("Estado");
            TableTrab.Columns.Add("Contratable");
            TableTrab.Columns.Add("Lugar De Trabajo");
            TableTrab.Columns.Add("Estado Civil");
            TableTrab.Columns.Add("Nacionalidad");
            TableTrab.Columns.Add("ID Departamento");
            TableTrab.Columns.Add("ID Puesto");

            GrdTrabGeneral.DataSource = TableTrab;
            GrdTrabGeneral.DataBind();

            foreach (DataControlField column in GrdTrabGeneral.Columns)
            {
                column.ItemStyle.Width = 100;
            }
        }
     
        private BL.BLTrabajador CargarDatosGeneral()
        {

            TableTrab.Clear();

            BL.BLTrabajador BL_trab = new BL.BLTrabajador();
            BL_trab.Search(txtCed.Text);

            TableTrab.Rows.Add(BL_trab.id, BL_trab.ced, BL_trab.ven_ced, BL_trab.nombre, BL_trab.apellido1, BL_trab.apellido2, BL_trab.mail, BL_trab.tel1, BL_trab.tel2, BL_trab.dir,/*BL_trab.experiencia,BL_trab.titulos,*/ BL_trab.num_seguro,
                BL_trab.uniforme,BL_trab.estado_t,BL_trab.inact,BL_trab.l_trabajo,BL_trab.est_civ,BL_trab.nacionalidad,BL_trab.id_departamento,BL_trab.id_puesto);


            GrdTrabGeneral.DataSource = TableTrab;
            GrdTrabGeneral.DataBind();

            return BL_trab;
        }

       private void FormatoDataTableTrabDetalle()
            {
                TableTrabDetalle.Columns.Add("Experiencia");
                TableTrabDetalle.Columns.Add("Titulos");

                GrdTrabDetalle.DataSource = TableTrabDetalle;
                GrdTrabDetalle.DataBind();

                foreach (DataControlField column in GrdTrabGeneral.Columns)
                {
                    column.ItemStyle.Width = 100;
                }
            }

       private BL.BLTrabajador CargarDatosTrabDetalle()
       {

           TableTrabDetalle.Clear();

           BL.BLTrabajador BL_trab = new BL.BLTrabajador();
           BL_trab.Search(txtCed.Text);

           TableTrabDetalle.Rows.Add(BL_trab.experiencia, BL_trab.titulos);

           GrdTrabDetalle.DataSource = TableTrabDetalle;
           GrdTrabDetalle.DataBind();

           return BL_trab;
       }

       private void FormatoDataTableHoras(){
        
           TableHoras.Columns.Add("Horas Permiso");
           TableHoras.Columns.Add("Horas Extra");
           TableHoras.Columns.Add("Horas Incapacidad");
           TableHoras.Columns.Add("Horas Laborales");
           TableHoras.Columns.Add("Horas Subsidio");

           GRHoras.DataSource = TableHoras;
           GRHoras.DataBind();

           foreach (DataControlField column in GRFechas.Columns)
           {
               column.ItemStyle.Width = 100;
           }
       }

       private BL.BLHoras CargarDatosHoras()
       {

           TableHoras.Clear();

           BL.BLHoras BL_Horas = new BL.BLHoras();
           BL_Horas.Search(txtCed.Text);

           TableHoras.Rows.Add(BL_Horas.h_permiso, BL_Horas.h_permiso, BL_Horas.h_incap, BL_Horas.h_laboradas, BL_Horas.h_subcidio);

           GRHoras.DataSource = TableHoras;
           GRHoras.DataBind();

           return BL_Horas;
       }

       private void FormatoDataTableFechas()
       {
           TableFechas.Columns.Add("Fecha Nacimiento");
           TableFechas.Columns.Add("Fecha de Ingreso");
           TableFechas.Columns.Add("Fecha Final Prueba");
           TableFechas.Columns.Add("Fecha Salida");

           GRFechas.DataSource = TableFechas;
           GRFechas.DataBind();

           foreach (DataControlField column in GRFechas.Columns)
           {
               column.ItemStyle.Width = 100;
           }
       }

       private BL.BLFechas CargarDatosFechas()
       {
           TableFechas.Clear();

           BL.BLFechas BL_Fechas = new BL.BLFechas();
           BL_Fechas.Search(txtCed.Text);

           TableFechas.Rows.Add(BL_Fechas.f_nac, BL_Fechas.f_ingreso, BL_Fechas.f_prueba, BL_Fechas.f_salida);

           GRFechas.DataSource = TableFechas;
           GRFechas.DataBind();

           return BL_Fechas;
       }

       private void FormatoDataTableLicencias()
       {
           TableLicencias.Columns.Add("Licencia 1");
           TableLicencias.Columns.Add("Fecha de Vencimiento 1");
           TableLicencias.Columns.Add("Licencia 2");
           TableLicencias.Columns.Add("Fecha de Vencimiento 2");
           TableLicencias.Columns.Add("Licencia 3");
           TableLicencias.Columns.Add("Fecha de Vencimiento 3");

           GRLicencias.DataSource = TableLicencias;
           GRLicencias.DataBind();

           foreach (DataControlField column in GRFechas.Columns)
           {
               column.ItemStyle.Width = 100;
           }
       }

       private BL.BLLicencias CargarDatosLicencias()
       {
           TableLicencias.Clear();

           BL.BLLicencias BL_Lic = new BL.BLLicencias();
           BL_Lic.Search(txtCed.Text);

           TableLicencias.Rows.Add(BL_Lic.lic1, BL_Lic.v_lic1, BL_Lic.lic2, BL_Lic.v_lic2, BL_Lic.lic3, BL_Lic.v_lic3);

           GRLicencias.DataSource = TableLicencias;
           GRLicencias.DataBind();

           return BL_Lic;
       }

       private void FormatoDataTableSalario()
       {
           TableSalario.Columns.Add("Salario Base");
           TableSalario.Columns.Add("Salario Bruto");
           TableSalario.Columns.Add("Obli.Patro - No Pensionados");
           TableSalario.Columns.Add("Obli.Patro - Pensionados");
           TableSalario.Columns.Add("Saldo Oblig.Patronales");
           TableSalario.Columns.Add("Salario Neto");
           TableSalario.Columns.Add("Salario Final");
           TableSalario.Columns.Add("Saldo Imp.Renta");
           TableSalario.Columns.Add("Saldo Incapacidad");
           TableSalario.Columns.Add("Saldo Extras");
           TableSalario.Columns.Add("Hijos Menores de Edad");
           TableSalario.Columns.Add("Hijos Mayores de Edad");
           TableSalario.Columns.Add("Conyuge");

           GRSalario.DataSource = TableSalario;
           GRSalario.DataBind();

           foreach (DataControlField column in GRFechas.Columns)
           {
               column.ItemStyle.Width = 100;
           }
       }

       private BL.BLCalculos CargarDatosSalario()
       {
           TableSalario.Clear();

           BL.BLCalculos BL_Calcu = new BL.BLCalculos();
           BL_Calcu.Search(txtCed.Text);
           string Conyuge = "";

           if (BL_Calcu.conyugue == 1) {
               Conyuge = "Si";
           }
           TableSalario.Rows.Add(BL_Calcu.s_base, BL_Calcu.s_bruto, BL_Calcu.ob_pat_nopen, BL_Calcu.ob_pat_pen,
               BL_Calcu.s_cargas, BL_Calcu.s_neto, BL_Calcu.s_final, BL_Calcu.imprenta, BL_Calcu.s_incapcidad, BL_Calcu.s_extras,
               BL_Calcu.hijos_menor, BL_Calcu.hijos_mayor, Conyuge);

           GRSalario.DataSource = TableSalario;
           GRSalario.DataBind();

           return BL_Calcu;
       }

       private void FormatoDataTableCargos()
       {
           TableCargos.Columns.Add("Monto Prestado");
           TableCargos.Columns.Add("Cuota Prestado");
           TableCargos.Columns.Add("Intereses");
           TableCargos.Columns.Add("Ahorros");
           TableCargos.Columns.Add("Embargos");
           TableCargos.Columns.Add("Adelantos");
           TableCargos.Columns.Add("Otros");
           TableCargos.Columns.Add("Monto Subsidio");
           TableCargos.Columns.Add("Saldo Subsidio");
           TableCargos.Columns.Add("Adicional Quincinal");
           TableCargos.Columns.Add("Adicional Mensual 1");
           TableCargos.Columns.Add("Adicional Mensual 2");

           GRCargos.DataSource = TableCargos;
           GRCargos.DataBind();

           foreach (DataControlField column in GRFechas.Columns)
           {
               column.ItemStyle.Width = 100;
           }
       }

       private BL.BLCalculos_Financieros CargarDatosCargos()
       {
           TableCargos.Clear();

           BL.BLCalculos_Financieros BL_Cargos = new BL.BLCalculos_Financieros();
           BL_Cargos.Search(txtCed.Text);

           TableCargos.Rows.Add(BL_Cargos.m_prestamo, BL_Cargos.c_prest, BL_Cargos.interes, BL_Cargos.ahorro,
               BL_Cargos.embar, BL_Cargos.adelan, BL_Cargos.otros, BL_Cargos.m_subcidio, BL_Cargos.s_subcidio, BL_Cargos.a_quincenal,
               BL_Cargos.a_mensual1, BL_Cargos.a_mensual2);

           GRCargos.DataSource = TableCargos;
           GRCargos.DataBind();

           return BL_Cargos;
       }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {

            if (CargarDatosGeneral().ced != null)
            {
                CargarDatosTrabDetalle();
                CargarDatosHoras();
                CargarDatosFechas();
                CargarDatosLicencias();
                CargarDatosSalario();
                CargarDatosCargos();
                this.txtCed.Text = "";
                btnNueva.Visible = true;
                btnConsultar.Visible = false;
            }
            else
            {
                Response.Write("<script language='javascript'>alert('El usuario con la cedula " + txtCed.Text + " no esta asignado a un usuario');document.location.href='" + "/ConsultarTrabajador.aspx" + "'; </script>");
            }
        }

        protected void btnNueva_Click1(object sender, EventArgs e)
        {
            GrdTrabGeneral.DataSource = null;
            GrdTrabDetalle.DataSource = null;
            GRHoras.DataSource = null;
            GRFechas.DataSource = null;
            GRLicencias.DataSource = null;
            GRSalario.DataSource = null;
            GRCargos.DataSource = null;
            btnNueva.Visible = false;
            btnConsultar.Visible = true;
        }

        protected void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (CBResidencia.Checked == true)
            {
                RegexCed0.Enabled = true;
                RegexCed.Enabled = false;
            }
            else
            {
                RegexCed0.Enabled = false;
                RegexCed.Enabled = true;
            }
        }
    }
}