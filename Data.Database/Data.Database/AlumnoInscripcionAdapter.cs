using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Business.Entities;


namespace Data.Database
{
   public class AlumnoInscripcionAdapter :Adapter 
    {
        public List<AlumnoInscripcion> GetAll ()
        {
            List<AlumnoInscripcion> Inscripciones = new List<AlumnoInscripcion>() ;

            try
            {
                this.OpenConnection();
                SqlCommand CmdAlumnosIns = new SqlCommand("SELECT * from alumnos_inscripciones", sqlConn);
                SqlDataReader drAlumnosIns = CmdAlumnosIns.ExecuteReader();
                while (drAlumnosIns.Read())
                {
                    AlumnoInscripcion al = new AlumnoInscripcion();
                    al.ID = (int)drAlumnosIns["id_alumno_inscripcion"];
                    al.IdAlumno = (int)drAlumnosIns["id_alumno"];
                    al.IdCurso = (int)drAlumnosIns["id_curso"];
                    al.Nota = (int)drAlumnosIns["nota"];
                    al.Condicion = (string)drAlumnosIns["condicion"];
                    Inscripciones.Add(al);

                }
                drAlumnosIns.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al recuperar la lista de inscripciones", ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return Inscripciones;


        }
        public AlumnoInscripcion GetOne (int ID)
        {
            AlumnoInscripcion al = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
               
                SqlCommand CmdAlumnosIns = new SqlCommand("Select * from alumnos_inscripciones where @id = id_alumno_inscripcion", sqlConn);
                CmdAlumnosIns.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnosIns = CmdAlumnosIns.ExecuteReader();
                if (drAlumnosIns.Read())
                {
                    al.ID = (int)drAlumnosIns["id_alumno_inscripcion"];
                    al.IdAlumno = (int)drAlumnosIns["id_alumno"];
                    al.IdCurso = (int)drAlumnosIns["id_curso"];
                    al.Nota = (int)drAlumnosIns["nota"];
                    al.Condicion = (string)drAlumnosIns["condicion"];

                }
                drAlumnosIns.Close();
            }

            catch( Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la inscripcion", ex);
                throw ExManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return al;

            }
        private AlumnoInscripcion Delete (int ID)
        {

        }

    }
}
