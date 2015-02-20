using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLTrabjador
    {

        public void AgregarTrabajdor(int Id, string Nom, string Ap1, string Ap2, string Est_Civ
            , string Ced, string Nac, DateTime Ven_Ced, string Mail, string Tel1, string Tel2
            , string Dir, DateTime F_Nac, DateTime F_Ingreso, DateTime F_Pruba, DateTime F_Salida
            , int H_Permiso, int H_Extra, int H_Incap, int H_Labordas, double S_Base, double S_Bruto
            , double Ob_Pat, double S_Neto, double C_Prest, double Interes, double Ahorro, double Embar
            , double Adelan, double Otros, double S_Final, double Subsid, double A_Quincenal, double A_Mensual
            , int Puesto, string Exp, string Titulo, string Lic1, string Lic2, string Lic3, DateTime V_Lic1
            , DateTime V_Lic2, DateTime V_Lic3, int Num_Seguro, DateTime Uniformes, string Estado_T
            , string Inact, string L_Trabajo, string T_Usuario, int Depa)
        {
            TO.TOTrabajdor tb = new TO.TOTrabajdor();
            tb.Id = Id;
            tb.Nom = Nom;
            tb.Ap1 = Ap1;
            tb.Ap2 = Ap2;
            tb.Est_Civ = Est_Civ;
            tb.Ced = Ced;
            tb.Nac = Nac;
            tb.Ven_Ced = Ven_Ced;
            tb.Mail = Mail;
            tb.Tel1 = Tel1;
            tb.Tel2 = Tel2;
            tb.Dir = Dir;
            tb.Puesto = Puesto;
            tb.Exp = Exp;
            tb.Titulo = Titulo;
            tb.Num_Seguro = Num_Seguro;
            tb.Uniformes = Uniformes;
            tb.Estado_T = Estado_T;
            tb.Inact = Inact;
            tb.L_Trabajo = L_Trabajo;
            tb.T_Usuario = T_Usuario;
            tb.Depa = Depa;

            DA.DATrabajador datb = new DA.DATrabajador();
            datb.AgregarTrabajdor(tb);

        }


        public void ModifcarTrabajador(TO.TOTrabajdor trab)
        {
            DA.DATrabajador modtb = new DA.DATrabajador();
            modtb.ModifcarTrabajador(trab);
        }
        
        public void EliminarTrabajador(TO.TOTrabajdor trab)
        {
            DA.DATrabajador eltb = new DA.DATrabajador();
            eltb.EliminarTrabajador(trab);
        }
        
        public TO.TOTrabajdor ConsultarTrabajador(TO.TOTrabajdor trab)
        {
            DA.DATrabajador contb = new DA.DATrabajador();
            contb.ConsultarTrabajador(trab);

            throw new NotImplementedException();//////////////////////////////
        }
    }

}