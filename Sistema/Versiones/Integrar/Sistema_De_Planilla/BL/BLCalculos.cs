using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace BL
{
    public class BLCalculos
    {

        public int trabajador_id;
        public string trabajador_ced;
        public double imprenta;
        public int hijos;
        public int conyugue;
        public double cargas;
        public double s_cargas;
        public double s_extras;
        public double s_incapcidad;
        public double s_base;
        public double s_bruto;
        public double s_neto;
        public double s_final;

        public void Search(string ced)
        {
            DA.DACalculos sr = new DA.DACalculos();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.imprenta = sr.Search(ced).ImpRenta;
            this.hijos = sr.Search(ced).Hijos;
            this.conyugue = sr.Search(ced).Conyugue;
            this.cargas = sr.Search(ced).Cargas;
            this.s_cargas = sr.Search(ced).S_Cargas;
            this.s_extras = sr.Search(ced).S_Extras;
            this.s_incapcidad = sr.Search(ced).S_Incapacidad;
            this.s_base = sr.Search(ced).S_Base;
            this.s_bruto = sr.Search(ced).S_Bruto;
            this.s_neto = sr.Search(ced).S_Neto;
            this.s_final = sr.Search(ced).S_Final;
        }

        public double CalculoIncapacida()
        {
            TO.TOHoras h = new TO.TOHoras();
            
            this.s_incapcidad = h.H_Incap * (this.s_bruto/160);

            DA.DACalculos calcinca = new DA.DACalculos();
            calcinca.CalculoIncapacida(s_incapcidad);

            return s_incapcidad;
        }

        public double CalculoHorasExtra()
        {
            TO.TOHoras h = new TO.TOHoras();
            
            s_extras = h.H_Extra * ((s_bruto / 160) * 1.5);

            DA.DACalculos calchex = new DA.DACalculos();
            calchex.CalculoHorasExtra(s_extras);

            return s_extras;
        }

        public double CalculoImpuestoRenta()
                {
                    double varSB = 0, varH = 0, varC = 0, total = 0;
                    if (s_bruto > 1190000){
                        varSB = s_bruto * 0.15;
                    }
                    else if (s_bruto < 1190000 && s_bruto > 793000)
                    {
                        varSB = s_bruto * 0.1;
                    }
                    if (hijos > 0)
                    {
                        varH = hijos * 1490;
                    }
                    if(conyugue > 0){
                        varC = 2230;
                    }

                    imprenta = varSB + varH + varC;

                    DA.DACalculos calcimprent = new DA.DACalculos();
                    calcimprent.CalculoImpuestoRenta(imprenta);

                    return total;
                }

        public double CalculoCargasPatronales()
                {
                    s_cargas = (cargas/100) * s_bruto;

                    DA.DACalculos calccpatron = new DA.DACalculos();
                    calccpatron.CalculoCargasPatronales(s_cargas);

                    return s_cargas;
                }

        public double CalculoSalarioNeto()
                {
                    s_neto = s_bruto - CalculoCargasPatronales();

                    DA.DACalculos calsnto = new DA.DACalculos();
                    calsnto.CalculoSalarioNeto(s_neto);

                    return s_neto;
                }

        public double CalculoSalarioFinal()
        {
            BL.BLCalculos_Financieros cf = new BL.BLCalculos_Financieros();
            double aneto, hextra, cimprent, cincap;

            s_final = aneto + hextra - cimprent + cincap - cf.CalculoAdicionalMensual() - cf.CalculoAdicionalQuincenal() - cf.CalculoInetresesPrestamo() + cf.CalculoSubcidio();

            DA.DACalculos calcsdin = new DA.DACalculos();
            calcsdin.CalculoSalarioFinal(s_final);

            return s_final;
        }

        }
}