using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLLicencias
    {
        public int trabajador_id;
        public string trabajador_ced;
        public string lic1;
        public string lic2;
        public string lic3;
        public DateTime v_lic1;
        public DateTime v_lic2;
        public DateTime v_lic3;

        public void Search(string ced)
        {
            DA.DALicencias sr = new DA.DALicencias();
            this.trabajador_id = sr.Search(ced).Trabajador_ID;
            this.trabajador_ced = sr.Search(ced).Trabajador_Ced;
            this.lic1 = sr.Search(ced).Lic1;
            this.lic2 = sr.Search(ced).Lic2;
            this.lic3 = sr.Search(ced).Lic3;
            this.v_lic1 = sr.Search(ced).V_Lic1;
            this.v_lic2 = sr.Search(ced).V_Lic2;
            this.v_lic3 = sr.Search(ced).V_Lic3;

        }

        public void AgregarLicencia()
        {
            TO.TOLicencias lic = new TO.TOLicencias();
            lic.Trabajador_ID = this.trabajador_id;
            lic.Trabajador_Ced = this.trabajador_ced;
            lic.Lic1 = this.lic1;
            lic.Lic2 = this.lic2;
            lic.Lic3 = this.lic3;
            lic.V_Lic1 = this.v_lic1;
            lic.V_Lic2 = this.v_lic2;
            lic.V_Lic3 = this.v_lic3;

            DA.DALicencias alic = new DA.DALicencias();
            alic.AgregarLicencia(lic);
        }

        public void ModifcarLicencia()
        {
            TO.TOLicencias lic = new TO.TOLicencias();
            lic.Trabajador_ID = this.trabajador_id;
            lic.Trabajador_Ced = this.trabajador_ced;
            lic.Lic1 = this.lic1;
            lic.Lic2 = this.lic2;
            lic.Lic3 = this.lic3;
            lic.V_Lic1 = this.v_lic1;
            lic.V_Lic2 = this.v_lic2;
            lic.V_Lic3 = this.v_lic3;

            DA.DALicencias modlic = new DA.DALicencias();
            modlic.ModifcarLicencia(lic);
        }

        public void EliminarLicencia(string ced)
        {
            DA.DALicencias elimlic = new DA.DALicencias();
            elimlic.EliminarLicencia(ced);
        }
    }
}
