using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLCalculos_Financieros
    {
        private string ced;
        private double ahorro;
        private double interes;
        private double m_prestamo;
        private double c_prest;
        private double a_quincenal;
        private double a_mensual1;
        private double a_mensual2;
        private double embar;
        private double adelan;
        private double otros;
        private double m_subcidio;
        private double s_subcidio;
        
        public TO.TOCalculos_Financieros Search(string ced)
        {
            DA.DACalculos_Financieros bp = new DA.DACalculos_Financieros();

            return bp.Search(ced);

        }

        public double CalculoInetresesPrestamo(string ced)
        {            
            TO.TOCalculos_Financieros calintpres = new TO.TOCalculos_Financieros();
            
            calintpres = Search(ced);

            calintpres.Interes = calintpres.M_Prestamo * ( calintpres.C_Prest / 100);

            DA.DACalculos_Financieros calcintpres = new DA.DACalculos_Financieros();
            calcintpres.CalculoInetresesPrestamo(calintpres);

            return calintpres.Interes;
        }

        public double CalculoSubcidio(string ced, int h_sub)
        {
            TO.TOCalculos_Financieros calcsub = new TO.TOCalculos_Financieros();

            calcsub = Search(ced);

            calcsub.S_Subcidio = h_sub * calcsub.M_Subcidio;

            DA.DACalculos_Financieros calsub = new DA.DACalculos_Financieros();
            calsub.CalculoSubcidio(calcsub);

            return calcsub.S_Subcidio;
        }


        public double CalculoAdicionalMensual(string ced, double monto)
        {
            TO.TOCalculos_Financieros calcamen = new TO.TOCalculos_Financieros();
            
            calcamen = Search(ced);

            if (calcamen.A_Mensual1 == 0 && calcamen.A_Mensual2 == 0)
            {
                calcamen.A_Mensual1 = monto / 2;
                calcamen.A_Mensual2 = monto / 2;
            }
            else if (calcamen.A_Mensual1 == 0 && calcamen.A_Mensual2 != 0)
            {
                calcamen.A_Mensual1 = calcamen.A_Mensual2;
                calcamen.A_Mensual2 = 0;
            }
            
            DA.DACalculos_Financieros calcadmen = new DA.DACalculos_Financieros();
            calcadmen.CalculoAdicionalMensual(calcamen);

            return calcamen.A_Mensual1;
        }

        public double CalculoAdicionalQuincenal(string ced, double monto)
        {
            TO.TOCalculos_Financieros calcqiun = new TO.TOCalculos_Financieros();

            if (calcqiun.A_Quincenal == 0)
            {
                calcqiun.A_Quincenal = monto;
            }
            else if (calcqiun.A_Quincenal != 0)
            {
                calcqiun.A_Quincenal = 0;
            }
            


            DA.DACalculos_Financieros calcadquin = new DA.DACalculos_Financieros();
            calcadquin.CalculoAdicionalQuincenal(calcqiun.A_Quincenal);

            return calcqiun.A_Quincenal;
        }
    }
}
