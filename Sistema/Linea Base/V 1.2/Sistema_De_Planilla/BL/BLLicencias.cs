using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class BLLicencias
    {
        public void AgregarLicencia(int id, string lic1, string lic2, string lic3)
        {
            TO.TOLicencias lic = new TO.TOLicencias();
            lic.ID_Trabajador = id;
            lic.Lic1 = lic1;
            lic.Lic2 = lic2;
            lic.Lic3 = lic3;

            DA.DALicencias alic = new DA.DALicencias();
            alic.AgregarLicencia(lic);
        }  

        public void ModifcarLicencia(TO.TOLicencias lic)
        {
            DA.DALicencias modlic = new DA.DALicencias();
            modlic.ModifcarLicencia(lic);
        }

        public TO.TOLicencias ConsularLicencias(TO.TOLicencias lic)
        {
            DA.DALicencias conlic = new DA.DALicencias();
            conlic.ConsularLicencias(lic);
            throw new NotImplementedException();
        }

        public void EliminarLicencia(TO.TOLicencias lic)
        {
            DA.DALicencias elimlic = new DA.DALicencias();
            elimlic.EliminarLicencia(lic);
        }
    }
}
