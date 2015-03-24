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
        public int hijos_menor;
        public int hijos_mayor;
        public int conyugue;
        public double ob_pat_pen;
        public double ob_pat_nopen;
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
            this.hijos_menor = sr.Search(ced).Hijos_Menor;
            this.hijos_mayor = sr.Search(ced).Hijos_Mayor;
            this.conyugue = sr.Search(ced).Conyugue;
            this.ob_pat_nopen = sr.Search(ced).Ob_Pat_NoPen;
            this.ob_pat_pen = sr.Search(ced).Ob_Pat_Pen;
            this.s_cargas = sr.Search(ced).S_Cargas;
            this.s_extras = sr.Search(ced).S_Extras;
            this.s_incapcidad = sr.Search(ced).S_Incapacidad;
            this.s_base = sr.Search(ced).S_Base;
            this.s_bruto = sr.Search(ced).S_Bruto;
            this.s_neto = sr.Search(ced).S_Neto;
            this.s_final = sr.Search(ced).S_Final;
        }

        public double CalculoIncapacida(string ced)
        {
            TO.TOHoras h = new TO.TOHoras();

            this.s_incapcidad = h.H_Incap * (this.s_bruto / 160);

            DA.DACalculos calcinca = new DA.DACalculos();
            calcinca.CalculoIncapacida(ced, s_incapcidad);

            return s_incapcidad;
        }

        public double CalculoHorasExtra(string ced)
        {
            TO.TOHoras h = new TO.TOHoras();

            s_extras = h.H_Extra * ((s_bruto / 160) * 1.5);

            DA.DACalculos calchex = new DA.DACalculos();
            calchex.CalculoHorasExtra(ced, s_extras);

            return s_extras;
        }

       /* public double CalculoImpuestoRenta(string ced)
        {
            double varSB = 0, varH = 0, varC = 0, total = 0;
            if (s_bruto > 1190000)
            {
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
            if (conyugue > 0)
            {
                varC = 2230;
            }

            imprenta = varSB + varH + varC;

            DA.DACalculos calcimprent = new DA.DACalculos();
            calcimprent.CalculoImpuestoRenta(ced, imprenta);

            return total;
        }*/

        public double CalculoCargasPatronales(string ced) // REVISAR!!!
        {
           // s_cargas = (cargas / 100) * s_bruto;

            DA.DACalculos calccpatron = new DA.DACalculos();
            calccpatron.CalculoCargasPatronales(ced, s_cargas);

            return s_cargas;
        }

        public double CalculoSalarioNeto(string ced)
        {
            s_neto = s_bruto - CalculoCargasPatronales(ced);

            DA.DACalculos calsnto = new DA.DACalculos();
            calsnto.CalculoSalarioNeto(ced, s_neto);

            return s_neto;
        }

        public double CalculoSalarioFinal(string ced, double monto)
        {
            BL.BLCalculos_Financieros cf = new BL.BLCalculos_Financieros();


            s_final = s_bruto + CalculoHorasExtra(ced) - /*CalculoImpuestoRenta(ced)*/ + CalculoIncapacida(ced) - cf.CalculoAdicionalMensual(ced, monto) - cf.CalculoAdicionalQuincenal(ced, monto) - cf.CalculoInetresesPrestamo(ced) + cf.CalculoSubcidio(ced);

            DA.DACalculos calcsdin = new DA.DACalculos();
            calcsdin.CalculoSalarioFinal(ced, s_final);

            return s_final;
        }

        public void CalculoAumentoSalarioBase(int mis, int jar, int cho)
        {
            TO.TOCalculos TO_Calcu = new TO.TOCalculos();
            TO_Calcu.S_Base = this.s_base;

            DA.DACalculos DA_Calcu = new DA.DACalculos();
            DA_Calcu.CalculoAumentoSalarioBase(TO_Calcu, mis, jar, cho);
        }

        public void CalculoAumentoSalarioBasePorcentual(int mis, int jar, int cho)
        {
            TO.TOCalculos TO_Calcu = new TO.TOCalculos();
            TO_Calcu.S_Base = this.s_base;

            DA.DACalculos DA_Calcu = new DA.DACalculos();
            DA_Calcu.CalculoAumentoSalarioBasePorcentual(TO_Calcu, mis, jar, cho);
        }

        public void BuscarCargasObreras(int pen, int NoPen){

            if (pen == 1)
            {
                DA.DACalculos DA_Calc = new DA.DACalculos();
                this.ob_pat_pen = DA_Calc.BuscarCargarObreras(pen, NoPen);

            }
            else {

                DA.DACalculos DA_Calc = new DA.DACalculos();
                this.ob_pat_nopen = DA_Calc.BuscarCargarObreras(pen, NoPen);
            }
          
        }

        public void ActualizarCargas(int pen, int NoPen, double monto)
        {

                DA.DACalculos DA_Calc = new DA.DACalculos();
                DA_Calc.ActualizarCargas(pen, NoPen,monto);
        }

      }
    }
