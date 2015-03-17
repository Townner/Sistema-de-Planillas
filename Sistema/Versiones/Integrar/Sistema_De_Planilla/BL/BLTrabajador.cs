using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BL
{
    public class BLTrabajador
    {
        public int id;
        public string ced;
        public string ven_ced;
        public string nombre;
        public string apellido1;
        public string apellido2;
        public string mail;
        public string tel1;
        public string tel2;
        public string dir;
        public string experiencia;
        public string titulos;
        public int num_seguro;
        public string uniforme;
        public string estado_t;
        public string inact;
        public string l_trabajo;
        public string est_civ;
        public string nacionalidad;
        public int id_departamento;
        public int id_puesto;



        public void Search(string ced)
        {
            DA.DATrabajador sr = new DA.DATrabajador();

            this.id = sr.Search(ced).ID ;
            this.ced = sr.Search(ced).Ced;
            this.ven_ced = sr.Search(ced).Ven_Ced;
            this.nombre = sr.Search(ced).Nombre;
            this.apellido1 = sr.Search(ced).Apellido1;
            this.apellido2 = sr.Search(ced).Apellido2;
            this.mail = sr.Search(ced).Mail;
            this.tel1 = sr.Search(ced).Tel1;
            this.tel2 = sr.Search(ced).Tel2;
            this.dir = sr.Search(ced).Dir;
            this.experiencia = sr.Search(ced).Experiencia;
            this.titulos = sr.Search(ced).Titulos;
            this.num_seguro = sr.Search(ced).Num_Seguro;
            this.uniforme = sr.Search(ced).Uniforme;
            this.estado_t = sr.Search(ced).Estado_t;
            this.inact = sr.Search(ced).Inact;
            this.l_trabajo = sr.Search(ced).L_Trabajo;
            this.est_civ = sr.Search(ced).Est_Civ;
            this.nacionalidad = sr.Search(ced).Nacionalidad;
            this.id_departamento = sr.Search(ced).ID_Departamento;
            this.id_puesto = sr.Search(ced).ID_Puesto;
        }


        public void AgregarTrabajdor()
        {
            TO.TOTrabajdor trab = new TO.TOTrabajdor();
            trab.ID = this.id;
            trab.Ced = this.ced;
            trab.Ven_Ced = this.ven_ced;
            trab.Nombre = this.nombre;
            trab.Apellido1 = this.apellido1;
            trab.Apellido2 = this.apellido2;
            trab.Mail = this.mail;
            trab.Tel1 = this.tel1;
            trab.Tel2 = this.tel2;
            trab.Dir = this.dir;
            trab.Experiencia = this.experiencia;
            trab.Titulos = this.titulos;
            trab.Num_Seguro = this.num_seguro;
            trab.Uniforme = this.uniforme;
            trab.Estado_t = this.estado_t;
            trab.Inact = this.inact;
            trab.L_Trabajo = this.l_trabajo;
            trab.Est_Civ = this.est_civ;
            trab.Nacionalidad = this.nacionalidad;
            trab.ID_Departamento = this.id_departamento;
            trab.ID_Puesto = this.id_puesto;

            DA.DATrabajador datb = new DA.DATrabajador();
            datb.AgregarTrabajdor(trab);

        }


        public void ModifcarTrabajador()
        {
            TO.TOTrabajdor trab = new TO.TOTrabajdor();
            trab.ID = this.id;
            trab.Ced = this.ced;
            trab.Ven_Ced = this.ven_ced;
            trab.Nombre = this.nombre;
            trab.Apellido1 = this.apellido1;
            trab.Apellido2 = this.apellido2;
            trab.Mail = this.mail;
            trab.Tel1 = this.tel1;
            trab.Tel2 = this.tel2;
            trab.Dir = this.dir;
            trab.Experiencia = this.experiencia;
            trab.Titulos = this.titulos;
            trab.Num_Seguro = this.num_seguro;
            trab.Uniforme = this.uniforme;
            trab.Estado_t = this.estado_t;
            trab.Inact = this.inact;
            trab.L_Trabajo = this.l_trabajo;
            trab.Est_Civ = this.est_civ;
            trab.Nacionalidad = this.nacionalidad;
            trab.ID_Departamento = this.id_departamento;
            trab.ID_Puesto = this.id_puesto;

            DA.DATrabajador modtb = new DA.DATrabajador();
            modtb.ModifcarTrabajador(trab);
        }
        
        public void EliminarTrabajador(string ced, string estado_t, string inact)
        {
            DA.DATrabajador eltb = new DA.DATrabajador();
            eltb.EliminarTrabajador(ced, estado_t, inact);
        }

        public int ConsultarTrabajador(string Ced)
        {
            DA.DATrabajador DA_Usr = new DA.DATrabajador();
            return this.id = DA_Usr.ConsultarTrabajador_ID(Ced);

        }

    }

}