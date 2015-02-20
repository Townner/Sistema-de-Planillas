using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rnd
{
    public class TOTrabajdor
    {
        private int ID;

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }

        private string nom;

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }

        private string ap1;

        public string Ap1
        {
            get { return ap1; }
            set { ap1 = value; }
        }

        private string ap2;

        public string Ap2
        {
            get { return ap2; }
            set { ap2 = value; }
        }

        private string est_civ;

        public string Est_Civ
        {
            get { return est_civ; }
            set { est_civ = value; }
        }

        private string ced;

        public string Ced
        {
            get { return ced; }
            set { ced = value; }
        }

        private string nac;

        public string Nac
        {
            get { return nac; }
            set { nac = value; }
        }

        private DateTime ven_ced;

        public DateTime Ven_Ced
        {
            get { return ven_ced; }
            set { ven_ced = value; }
        }
        private string mail;

        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }

        private string tel1;

        public string Tel1
        {
            get { return tel1; }
            set { tel1 = value; }
        }
        private string tel2;

        public string Tel2
        {
            get { return tel2; }
            set { tel2 = value; }
        }
        private string dir;

        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        private DateTime f_nac;

        public DateTime F_Nac
        {
            get { return f_nac; }
            set { f_nac = value; }
        }
        private DateTime f_ingreso;

        public DateTime F_Ingreso
        {
            get { return f_ingreso; }
            set { f_ingreso = value; }
        }
        private DateTime f_prueba;

        public DateTime F_Pruba
        {
            get { return f_prueba; }
            set { f_prueba = value; }
        }
        private DateTime f_salida;

        public DateTime F_Salida
        {
            get { return f_salida; }
            set { f_salida = value; }
        }
        private int h_permiso;

        public int H_Permiso
        {
            get { return h_permiso; }
            set { h_permiso = value; }
        }

        private int h_extra;

        public int H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }

        private int h_incap;

        public int H_Incap
        {
            get { return h_incap; }
            set { h_incap = value; }
        }

        private int h_laboradas;

        public int H_Labordas
        {
            get { return h_laboradas; }
            set { h_laboradas = value; }
        }

        private double s_base;

        public double S_Base
        {
            get { return s_base; }
            set { s_base = value; }
        }

        private double s_bruto;

        public double S_Bruto
        {
            get { return s_bruto; }
            set { s_bruto = value; }
        }

        private double ob_pat;

        public double Ob_Pat
        {
            get { return ob_pat; }
            set { ob_pat = value; }
        }

        private double s_net;

        public double S_Neto
        {
            get { return s_net; }
            set { s_net = value; }
        }

        private double c_prest;

        public double C_Prest
        {
            get { return c_prest; }
            set { c_prest = value; }
        }

        private double interes;

        public double Interes
        {
            get { return interes; }
            set { interes = value; }
        }

        private double ahorro;

        public double Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }

        private double embar;

        public double Embar
        {
            get { return embar; }
            set { embar = value; }
        }
        private double adelan;

        public double Adelan
        {
            get { return adelan; }
            set { adelan = value; }
        }
        private double otros;

        public double Otros
        {
            get { return otros; }
            set { otros = value; }
        }

        private double s_final;

        public double S_Final
        {
            get { return s_final; }
            set { s_final = value; }
        }

        private double subsid;

        public double Subsid
        {
            get { return subsid; }
            set { subsid = value; }
        }

        private double a_quincenal;

        public double A_Quincenal
        {
            get { return a_quincenal; }
            set { a_quincenal = value; }
        }

        private double a_mensual;

        public double A_Mensual
        {
            get { return a_mensual; }
            set { a_mensual = value; }
        }
        private int puesto;

        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        private string exp;

        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }

        private string titulo;

        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }

        private string lic1;

        public string Lic1
        {
            get { return lic1; }
            set { lic1 = value; }
        }

        private string lic2;

        public string Lic2
        {
            get { return lic2; }
            set { lic2 = value; }
        }
        private string lic3;

        public string Lic3
        {
            get { return lic3; }
            set { lic3 = value; }
        }

        private DateTime v_lic1;

        public DateTime V_Lic1
        {
            get { return v_lic1; }
            set { v_lic1 = value; }
        }

        private DateTime v_lic2;

        public DateTime V_Lic2
        {
            get { return v_lic2; }
            set { v_lic2 = value; }
        }
        private DateTime v_lic3;

        public DateTime V_Lic3
        {
            get { return v_lic3; }
            set { v_lic3 = value; }
        }

        private int num_seguro;

        public int Num_Seguro
        {
            get { return num_seguro; }
            set { num_seguro = value; }
        }

        private DateTime uniformes;

        public DateTime Uniformes
        {
            get { return uniformes; }
            set { uniformes = value; }
        }
        private string estado_t;

        public string Estado_T
        {
            get { return estado_t; }
            set { estado_t = value; }
        }
        private string inact;

        public string Inact
        {
            get { return inact; }
            set { inact = value; }
        }
        private String l_trabajo;

        public String L_Trabajo
        {
            get { return l_trabajo; }
            set { l_trabajo = value; }
        }
        private string t_usuario;

        public string T_Usuario
        {
            get { return t_usuario; }
            set { t_usuario = value; }
        }

        private int depa;

        public int Depa
        {
            get { return depa; }
            set { depa = value; }
        }

	
    }
}