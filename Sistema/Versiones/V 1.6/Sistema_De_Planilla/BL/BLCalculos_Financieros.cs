using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLCalculos_Financieros
    {
        public int trabajador_id;
        public string trabajador_ced;
        public double ahorro;
        public double interes;
        public double m_prestamo;
        public double c_prest;
        public double a_quincenal;
        public double a_mensual1;
        public double a_mensual2;
        public double embar;
        public double adelan;
        public double otros;
        public double m_subcidio;
        public double s_subcidio;
        
        public void Search(string ced)
        {
            DA.DACalculos_Financieros sr = new DA.DACalculos_Financieros();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.ahorro = sr.Search(ced).Ahorro;
            this.interes = sr.Search(ced).Interes;
            this.m_prestamo = sr.Search(ced).M_Prestamo;
            this.c_prest = sr.Search(ced).C_Prest;
            this.a_quincenal = sr.Search(ced).A_Quincenal;
            this.a_mensual1 = sr.Search(ced).A_Mensual1;
            this.a_mensual2 = sr.Search(ced).A_Mensual2;
            this.embar = sr.Search(ced).Embar;
            this.adelan = sr.Search(ced).Adelan;
            this.otros = sr.Search(ced).Otros;
            this.m_subcidio = sr.Search(ced).M_Subcidio;
            this.s_subcidio = sr.Search(ced).S_Subcidio;

        }

        public void AgregarCalculos()
        {

            TO.TOCalculos_Financieros TO_Calcu = new TO.TOCalculos_Financieros();
            TO_Calcu.Trabajador_ID = this.trabajador_id;
            TO_Calcu.Trabajador_Ced = this.trabajador_ced;
            TO_Calcu.M_Prestamo = this.m_prestamo;
            TO_Calcu.C_Prest = this.c_prest;
            TO_Calcu.Interes = this.interes;
            TO_Calcu.Ahorro = this.ahorro;
            TO_Calcu.Embar = this.embar;
            TO_Calcu.Adelan = this.adelan;
            TO_Calcu.Otros = this.otros;
            TO_Calcu.M_Subcidio = this.m_subcidio;
            TO_Calcu.A_Quincenal = this.a_quincenal;
            TO_Calcu.A_Mensual1 = this.a_mensual1;
            TO_Calcu.A_Mensual2 = this.a_mensual2;

            DA.DACalculos_Financieros afecha = new DA.DACalculos_Financieros();
            afecha.AgregarCalculos(TO_Calcu);
        }

        public void ModificarCalculos(BL.BLTrabajador BL_Trab)
        {
            TO.TOCalculos_Financieros TO_Calcu = new TO.TOCalculos_Financieros();
            TO_Calcu.Trabajador_ID = this.trabajador_id;
            TO_Calcu.Trabajador_Ced = this.trabajador_ced;
            TO_Calcu.M_Prestamo = this.m_prestamo;
            TO_Calcu.C_Prest = this.c_prest;
            TO_Calcu.Interes = this.interes;
            TO_Calcu.Ahorro = this.ahorro;
            TO_Calcu.Embar = this.embar;
            TO_Calcu.Adelan = this.adelan;
            TO_Calcu.Otros = this.otros;
            TO_Calcu.M_Subcidio = this.m_subcidio;
            TO_Calcu.A_Quincenal = this.a_quincenal;
            TO_Calcu.A_Mensual1 = this.a_mensual1;
            TO_Calcu.A_Mensual2 = this.a_mensual2;


            DA.DACalculos_Financieros ModCalculos = new DA.DACalculos_Financieros();
            ModCalculos.ModificarCalculos(TO_Calcu);
        }

        public double CalculoInetresesPrestamo(string ced)
        {            
            interes = m_prestamo * ( c_prest / 100);

            DA.DACalculos_Financieros calcintpres = new DA.DACalculos_Financieros();
            calcintpres.CalculoInetresesPrestamo(ced, interes);

            return interes;
        }

        public double CalculoSubcidio(string ced)
        {
            TO.TOHoras h = new TO.TOHoras();

            s_subcidio = h.H_Subcidio * m_subcidio;

            DA.DACalculos_Financieros calsub = new DA.DACalculos_Financieros();
            calsub.CalculoSubcidio(ced, s_subcidio);

            return s_subcidio;
        }


        public double CalculoAdicionalMensual(string ced, double monto)
        {
            if (a_mensual1 == 0 && a_mensual2 == 0)
            {
                a_mensual1 = monto / 2;
                a_mensual2 = monto / 2;
            }
            else if (a_mensual1 == 0 && a_mensual2 != 0)
            {
                a_mensual1 = a_mensual2;
                a_mensual2 = 0;
            }
            
            DA.DACalculos_Financieros calcadmen = new DA.DACalculos_Financieros();
            calcadmen.CalculoAdicionalMensual(ced, a_mensual1);

            return a_mensual1;
        }

        public double CalculoAdicionalQuincenal(string ced, double monto)
        {
            if (a_quincenal == 0)
            {
                a_quincenal = monto;
            }
            else if (a_quincenal != 0)
            {
                a_quincenal = 0;
            }
            
            DA.DACalculos_Financieros calcadquin = new DA.DACalculos_Financieros();
            calcadquin.CalculoAdicionalQuincenal(ced, a_quincenal);

            return a_quincenal;
        }
    }
}
