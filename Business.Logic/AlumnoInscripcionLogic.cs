﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Database;
using Business.Entities;

namespace Business.Logic
{
    public class AlumnoInscripcionLogic: BusinessLogic 
    {

        private AlumnoInscripcionAdapter _alumnoInscripcionData;
            public AlumnoInscripcionAdapter AlumnoInscripcionData
        {
            get { return _alumnoInscripcionData; }
            set { _alumnoInscripcionData = value; }
        }

        public AlumnoInscripcionLogic()
        {
            AlumnoInscripcionData = new AlumnoInscripcionAdapter();
        } 
        public List<AlumnoInscripcion> GetAll()
        {
            return AlumnoInscripcionData.GetAll();
        }

        public List<AlumnoInscripcion>GetAll(int idAlu)
        {
            return AlumnoInscripcionData.GetAll(idAlu);
        }
        public AlumnoInscripcion GetOne(int ID)
        {
            return AlumnoInscripcionData.GetOne(ID);
        }
        public void Delete(  int ID)
        {
          AlumnoInscripcionData.Delete(ID);
        }
        public void Save(AlumnoInscripcion alu)
        {
            AlumnoInscripcionData.Save(alu);
        }
        public int GetID(int idCur, int idPer)
        {
            return AlumnoInscripcionData.GetID(idCur, idPer);
        }
        public void UpdateInscr(AlumnoInscripcion docCurso)
        {
            AlumnoInscripcionData.UpdateInscr(docCurso);
        }




    }
}
