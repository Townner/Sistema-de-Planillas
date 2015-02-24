using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO
{
    public class TOLicencias
    {
        private int trabajador_id;
        private string trabajador_ced;
        private string lic1;
        private string lic2;
        private string lic3;
        private DateTime v_lic1;
        private DateTime v_lic2;
        private DateTime v_lic3;

        public int Trabajador_ID
        {
            get { return trabajador_id; }
            set { trabajador_id = value; }
        }

        public string Trabajador_Ced
        {
            get { return trabajador_ced; }
            set { trabajador_ced = value; }
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
    }
}
