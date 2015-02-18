using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BL
{
    public class BLCalculos
    {

        public double CalculoSubcidio(double Subsidio)
        {
            double sub = 0;

            sub = Subsidio * asdfaads;

            DA.DACalculos calsub = new DA.DACalculos();
            calsub.CalculoSubcidio(sub);

            return sub;
        }

        public double CalculoAdicionalMensual()
        {
            double ad = 0;

            ad = 0;

            DA.DACalculos calcadmen = new DA.DACalculos();
            calcadmen.CalculoAdicionalMensual(ad);

            return ad;
        }

        public double CalculoAdicionalQuincenal()
        {
            double ad = 0;

            ad = 0;

            DA.DACalculos calcadquin = new DA.DACalculos();
            calcadquin.CalculoAdicionalQuincenal(ad);

            return ad;
        }

        public double CalculoIncapacida(double Incapacidad, double S_Bruto)
        {
            double inc = 0;

            inc = Incapacidad * (S_Bruto/160);

            DA.DACalculos calcincap = new DA.DACalculos();
            calcincap.CalculoIncapacida(inc);

            return inc;
        }

        public double CalculoHorasExtra(double H_Extra, double S_Bruto)
        {
            double hex = 0;

            hex = H_Extra * ((S_Bruto/160)*1.5);

            DA.DACalculos calchex = new DA.DACalculos();
            calchex.CalculoHorasExtra(hex);

            return hex;
        }

        public double CalculoSalarioFinal(double Cargas, double S_Bruto, int Hijos, int Conyugue, double H_Extra, double Incapacidad, double Subsidio)
        {
            double final = 0;

            final = CalculoSalarioNeto(Cargas, S_Bruto) + CalculoHorasExtra(H_Extra, S_Bruto) - CalculoAdicionalMensual() -
                CalculoAdicionalQuincenal() - CalculoImpuestoRenta(S_Bruto, Hijos, Conyugue) + CalculoIncapacida(Incapacidad, S_Bruto) +
                CalculoSubcidio(Subsidio);

            DA.DACalculos calcsdin = new DA.DACalculos();
            calcsdin.CalculoSalarioFinal(final);

            return final;
        }

        public double CalculoSalarioNeto(double Cargas, double S_Bruto)
        {
            double neto = 0;

            neto = S_Bruto - CalculoCargasPatronales(Cargas, S_Bruto);

            DA.DACalculos calsnto = new DA.DACalculos();
            calsnto.CalculoSalarioNeto(neto);

            return neto;
        }

        public double CalculoCargasPatronales(double Cargas, double S_Bruto)
        {
            double var = 0;

            var = (Cargas/100) * S_Bruto;

            DA.DACalculos calccpatron = new DA.DACalculos();
            calccpatron.CalculoCargasPatronales(var);

            return var;
        }

        public double CalculoImpuestoRenta(double S_Bruto, int Hijos, int Conyugue)
        {
            double varSB = 0, varH = 0, varC = 0, total = 0;
            if (S_Bruto > 1190000){
                varSB = S_Bruto * 0.15;
            }else if(S_Bruto < 1190000 && S_Bruto > 793000){
                varSB = S_Bruto * 0.1;
            }
            if (Hijos > 0)
            {
                varH = Hijos * 1490;
            }
            if(Conyugue > 0){
                varC = 2230;
            }

            total = varSB + varH + varC;

            DA.DACalculos calcimprent = new DA.DACalculos();
            calcimprent.CalculoImpuestoRenta(total);

            return total;
        }
    }
}