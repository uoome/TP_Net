﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Data.Database;

namespace Business.Logic
{
    public class UsuarioLogic : BusinessLogic
    {
        private Data.Database.UsuarioAdapter _UsuarioData;
        public Data.Database.UsuarioAdapter UsuarioData
        {
            set { _UsuarioData = value; } get { return _UsuarioData; }
        }

        public UsuarioLogic()
        {
          UsuarioData = new Data.Database.UsuarioAdapter();
        }

        public List <Usuario>  GetAll() 
        {
            return UsuarioData.GetAll();
        }

        public Usuario GetOne (int ID)
        {
            return UsuarioData.GetOne(ID);
        }
        public Usuario GetOne(string nombreUs)
        {
            return UsuarioData.GetOne(nombreUs);
        }

        public void Delete (int ID)
        {
            UsuarioData.Delete(ID);
        }

        public void Save(Business.Entities.Usuario usr)
        {
            UsuarioData.Save(usr);
        }
        public bool ExisteUs(string nombUs) //Este metodo llama al metodo de validacion de usuario de la capa de datos
        {
            return UsuarioData.ValidarUsuario(nombUs);
        }

    }
}
