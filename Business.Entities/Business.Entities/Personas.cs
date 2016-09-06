using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

   namespace Business.Entities
{
    public class Personas : BusinessEntity
    {  

        public enum TiposPersonas {Administrador = 1, Usuario=2,Docente =3} ;
        

        private string _legajo;

        private string _apellido;
        private string _nombre;
        private string _email;
        private string _telefono;
        private string _direccion;
        private DateTime _fechaDeNacimiento;
        private int _idPlan;
        private TiposPersonas _tipoDePersona;

        public string Direccion
        {
            get
            {
                return _direccion; //if (TipoPersona == TiposPersonas.Administrador) if (TipoPersona = 1)
            }

            set
            {
                _direccion = value;

            }
        }

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;

            }
        }

        public string Nombre
        {
            get
            {
                return _nombre;
            }

            set
            {
                _nombre = value;

            }
        }

        public string Apellido
        {
            get
            {
                return _apellido;

            }

            set
            {
                _apellido = value;

            }
        }

        public string Legajo
        {
            get
            {
                return _legajo;



            }

            set
            {
                _legajo = value;


            }
        }


        public int IDPlan
        {
            get
            {
                return _idPlan;

            }

            set
            {
                _idPlan = value;

            }
        }

        public DateTime FechaDeNacimiento
        {
            get
            {
                return _fechaDeNacimiento;
            }

            set
            {
                _fechaDeNacimiento = value;
            }
        }

        public string Telefono
        {
            get
            {
                return _telefono;
            }

            set
            {
                _telefono = value;
            }
        }

        public TiposPersonas TipoPersona
        {
            get
            {
                return _tipoDePersona;

            }

            set
            {
                _tipoDePersona = value;

            }
        }
    }
}
