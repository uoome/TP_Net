﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Entities
{   //Esta clase contiene elementos básicos que compartiran las entidades de nuestro sistema, que heredarán de ella
    public class BusinessEntity
    {
        private int _ID;
        private States _State;
        public BusinessEntity()
        {
            this.State = States.New;
        }
        public int ID 
        {  get {return _ID ; }
           set {_ID = value ;}
        }

        public States State
        {
            get { return _State; }
            set { _State = value; }      
        }   
         public enum States
         {
             Deleted,
             New,
             Modified,
             Unmodified
         }
    }
}
