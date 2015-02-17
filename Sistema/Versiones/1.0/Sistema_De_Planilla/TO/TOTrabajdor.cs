using System;

namespace rnd
{
    public class TOTrabajdor
    {
        private int ID;
        private string nom;
        private string ap1;
        private string ap2;
        private string est_civ;
        private string ced;
        private string nac;
        private DateTime ven_ced;
        private string mail;
        private string tel1;
        private string tel2;
        private string dir;
        private DateTime f_nac;
        private DateTime f_ingreso;
        private DateTime f_prueba;
        private DateTime f_salida;
        private int h_permiso;
        private int h_extra;
        private int h_incap;
        private int h_laboradas;
        private double s_base;
        private double s_bruto;
        private double ob_pat;
        private double s_net;
        private double c_prest;
        private double interes;
        private double ahorro;
        private double embar;
        private double adelan;
        private double otros;
        private double s_final;
        private double subsid;
        private double a_quincenal;
        private double a_mensual;
        private int puesto;
        private string exp;
        private string titulo;
        private string lic1;
        private string lic2;
        private string lic3;
        private DateTime v_lic1;
        private DateTime v_lic2;
        private DateTime v_lic3;
        private int num_seguro;
        private DateTime uniformes;
        private string estado_t;
        private string inact;
        private String l_trabajo;
        private string t_usuario;
        private int depa;

        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Ap1
        {
            get { return ap1; }
            set { ap1 = value; }
        }
        public string Ap2
        {
            get { return ap2; }
            set { ap2 = value; }
        }
        public string Est_Civ
        {
            get { return est_civ; }
            set { est_civ = value; }
        }
        public string Ced
        {
            get { return ced; }
            set { ced = value; }
        }
        public string Nac
        {
            get { return nac; }
            set { nac = value; }
        }
        public DateTime Ven_Ced
        {
            get { return ven_ced; }
            set { ven_ced = value; }
        }
        public string Mail
        {
            get { return mail; }
            set { mail = value; }
        }
        public string Tel1
        {
            get { return tel1; }
            set { tel1 = value; }
        }
        public string Tel2
        {
            get { return tel2; }
            set { tel2 = value; }
        }
        public string Dir
        {
            get { return dir; }
            set { dir = value; }
        }
        public DateTime F_Nac
        {
            get { return f_nac; }
            set { f_nac = value; }
        }
        public DateTime F_Ingreso
        {
            get { return f_ingreso; }
            set { f_ingreso = value; }
        }
        public DateTime F_Pruba
        {
            get { return f_prueba; }
            set { f_prueba = value; }
        }
        public DateTime F_Salida
        {
            get { return f_salida; }
            set { f_salida = value; }
        }
        public int H_Permiso
        {
            get { return h_permiso; }
            set { h_permiso = value; }
        }
        public int H_Extra
        {
            get { return h_extra; }
            set { h_extra = value; }
        }
        public int H_Incap
        {
            get { return h_incap; }
            set { h_incap = value; }
        }
        public int H_Labordas
        {
            get { return h_laboradas; }
            set { h_laboradas = value; }
        }
        public double S_Base
        {
            get { return s_base; }
            set { s_base = value; }
        }
        public double S_Bruto
        {
            get { return s_bruto; }
            set { s_bruto = value; }
        }
        public double Ob_Pat
        {
            get { return ob_pat; }
            set { ob_pat = value; }
        }
        public double S_Neto
        {
            get { return s_net; }
            set { s_net = value; }
        }
        public double C_Prest
        {
            get { return c_prest; }
            set { c_prest = value; }
        }
        public double Interes
        {
            get { return interes; }
            set { interes = value; }
        }
        public double Ahorro
        {
            get { return ahorro; }
            set { ahorro = value; }
        }
        public double Embar
        {
            get { return embar; }
            set { embar = value; }
        }
        public double Adelan
        {
            get { return adelan; }
            set { adelan = value; }
        }
        public double Otros
        {
            get { return otros; }
            set { otros = value; }
        }
        public double S_Final
        {
            get { return s_final; }
            set { s_final = value; }
        }
        public double Subsid
        {
            get { return subsid; }
            set { subsid = value; }
        }
        public double A_Quincenal
        {
            get { return a_quincenal; }
            set { a_quincenal = value; }
        }
        public double A_Mensual
        {
            get { return a_mensual; }
            set { a_mensual = value; }
        }
        public int Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        public string Exp
        {
            get { return exp; }
            set { exp = value; }
        }
        public string Titulo
        {
            get { return titulo; }
            set { titulo = value; }
        }
        public string Lic1
        {
            get { return lic1; }
            set { lic1 = value; }
        }
        public string Lic2
        {
            get { return lic2; }
            set { lic2 = value; }
        }
        public string Lic3
        {
            get { return lic3; }
            set { lic3 = value; }
        }
        public DateTime V_Lic1
        {
            get { return v_lic1; }
            set { v_lic1 = value; }
        }
        public DateTime V_Lic2
        {
            get { return v_lic2; }
            set { v_lic2 = value; }
        }
        public DateTime V_Lic3
        {
            get { return v_lic3; }
            set { v_lic3 = value; }
        }
        public int Num_Seguro
        {
            get { return num_seguro; }
            set { num_seguro = value; }
        }
        public DateTime Uniformes
        {
            get { return uniformes; }
            set { uniformes = value; }
        }
        public string Estado_T
        {
            get { return estado_t; }
            set { estado_t = value; }
        }
        public string Inact
        {
            get { return inact; }
            set { inact = value; }
        }
        public string L_Trabajo
        {
            get { return l_trabajo; }
            set { l_trabajo = value; }
        }
        public string T_Usuario
        {
            get { return t_usuario; }
            set { t_usuario = value; }
        }
        public int Depa
        {
            get { return depa; }
            set { depa = value; }
        }


    }
}