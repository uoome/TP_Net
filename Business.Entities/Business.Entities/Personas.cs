using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   namespace Business.Entities
{
    public class Personas : BusinessEntity
    {  

        public enum TiposPersonas {Administrador = 1, Usuario=2,Docente =3} ;

        private string _Legajo;
        private string _Apellido;
        private string _Nombre;
        private string _Email;
        private string _Telefono;
        private string _Direccion;
        private DateTime _FechaDeNacimiento;
        private int _IdPlan;
        private TiposPersonas _TipoDePersona;

        public string Direccion
        {
            get { return _Direccion; }
            set { _Direccion = value; }   
        }

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        public string Nombre
        {
            get { return _Nombre; }
            set { _Nombre = value; }
        }

        public string Apellido
        {
            get { return _Apellido; }
            set { _Apellido = value; }
        }

        public string Legajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }
        public int IDPlan
        {
            get { return _IdPlan; }
            set { _IdPlan = value; }
        }
        public DateTime FechaDeNacimiento
        {
            get { return _FechaDeNacimiento; }
            set { _FechaDeNacimiento = value; }
        }
        public string Telefono
        {
            get { return _Telefono; }
            set { _Telefono = value; }
        }

        public TiposPersonas TipoPersona
        {
            get { return _TipoDePersona; }
            set { _TipoDePersona = value; }
        }
    }
}
