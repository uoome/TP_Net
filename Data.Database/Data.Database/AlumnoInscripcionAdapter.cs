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
                SqlCommand CmdAlumnosIns = new SqlCommand("SELECT * FROM alumnos_inscripciones", sqlConn);
                SqlDataReader drAlumnosIns = CmdAlumnosIns.ExecuteReader();
                while (drAlumnosIns.Read())
                {
                    AlumnoInscripcion al = new AlumnoInscripcion();
                    al.ID = (int)drAlumnosIns["id_inscripcion"];
                    al.IdAlumno = (int)drAlumnosIns["id_alumno"];
                    al.IdCurso = (int)drAlumnosIns["id_curso"];
                    al.Nota = (int)drAlumnosIns["nota"];
                    al.Condicion = (AlumnoInscripcion.TiposCondiciones)drAlumnosIns["condicion"];
                    Inscripciones.Add(al);
                    

                }
                drAlumnosIns.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al recuperar la lista de inscripciones" + ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return Inscripciones;


        }

        public List<AlumnoInscripcion> GetAll(int idAlu)
        {
            List<AlumnoInscripcion> listaInscrip = new List<AlumnoInscripcion>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdAluInsc = new SqlCommand("SELECT * FROM alumnos_inscripciones WHERE id_alumno=@idAlu", sqlConn);
                cmdAluInsc.Parameters.Add("@idAlu", SqlDbType.Int).Value = idAlu;
                SqlDataReader drAluInsc = cmdAluInsc.ExecuteReader();

                while (drAluInsc.Read())
                {
                    AlumnoInscripcion al = new AlumnoInscripcion();
                    al.ID = (int)drAluInsc["id_inscripcion"];
                    al.IdAlumno = (int)drAluInsc["id_alumno"];
                    al.IdCurso = (int)drAluInsc["id_curso"];
                    al.Nota = (int)drAluInsc["nota"];
                    //al.Condicion = al.StringACondicion((string)drAluInsc["condicion"]);
                    al.Condicion = (AlumnoInscripcion.TiposCondiciones)drAluInsc["condicion"];

                    listaInscrip.Add(al);
                    
                }
                drAluInsc.Close();
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al cargar la lista" + ex.Message);
                throw exManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return listaInscrip;
        }
        public AlumnoInscripcion GetOne (int ID)
        {
            AlumnoInscripcion al = new AlumnoInscripcion();
            try
            {
                this.OpenConnection();
               
                SqlCommand CmdAlumnosIns = new SqlCommand("Select * from alumnos_inscripciones where @id = id_inscripcion", sqlConn);
                CmdAlumnosIns.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drAlumnosIns = CmdAlumnosIns.ExecuteReader();
                if (drAlumnosIns.Read())
                {
                    al.ID = (int)drAlumnosIns["id_inscripcion"];
                    al.IdAlumno = (int)drAlumnosIns["id_alumno"];
                    al.IdCurso = (int)drAlumnosIns["id_curso"];
                    al.Nota = (int)drAlumnosIns["nota"];
                    al.Condicion = (AlumnoInscripcion.TiposCondiciones)drAlumnosIns["condicion"];

                }
                drAlumnosIns.Close();
            }

            catch( Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la inscripcion" + ex.Message, ex);
                throw ExManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return al;

            }
        public void Delete (int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdAluInscri = new SqlCommand("Delete alumnos_inscripciones where id_inscripcion = @id",sqlConn);
                cmdAluInscri.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdAluInscri.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo eliminar la inscripcion del alumno" +ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
                        
        }
        protected void Update(AlumnoInscripcion Alu )
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdateAlu = new SqlCommand("Update alumnos_inscripciones set " +
                                                         "condicion = @cond, id_alumno@id_alu, id_curso = @ id_cur , nota= @nota " +
                                                         "where id_inscripcion = @id ", sqlConn);
                cmdUpdateAlu.Parameters.Add("@id", SqlDbType.Int).Value = Alu.ID;
                cmdUpdateAlu.Parameters.Add("@cond", SqlDbType.VarChar, 50).Value = Alu.Condicion;
                cmdUpdateAlu.Parameters.Add("@id_alu", SqlDbType.Int).Value = Alu.IdAlumno;
                cmdUpdateAlu.Parameters.Add("@nota", SqlDbType.VarChar, 50).Value = Alu.Nota;
                cmdUpdateAlu.Parameters.Add("id_cur", SqlDbType.Int).Value = Alu.IdCurso;

                cmdUpdateAlu.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("No se pudo actualizar la inscripcion" + ex.Message,ex);
                throw exManejada;
            }
            finally
            {
                this.CloseConnection();   
            }
            
        }
        protected void Insert(AlumnoInscripcion Alu)
        {
            try
            {
                this.OpenConnection();
                SqlCommand CmdInsert = new SqlCommand("insert into alumnos_inscripciones(id_alumno, id_curso, condicion, nota)" +
                                                       "values (@varId_alu,@varId_curso, @varCond, @varNota)", sqlConn);
                CmdInsert.Parameters.Add("@varId_alu", SqlDbType.Int).Value = Alu.IdAlumno;
                CmdInsert.Parameters.Add("@varId_curso", SqlDbType.Int).Value = Alu.IdCurso;
                CmdInsert.Parameters.Add("@varCond ", SqlDbType.Int).Value = Alu.Condicion;
                CmdInsert.Parameters.Add("@varNota", SqlDbType.VarChar,50).Value = Alu.Nota;
                CmdInsert.ExecuteNonQuery();
            }
        
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo crear la inscripcion" + ex.Message, ex);
                    throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            
            
        }
        public void Save(AlumnoInscripcion Alu)
        {
            if (Alu.State == BusinessEntity.States.Deleted)
            { this.Delete(Alu.ID); } else
                if (Alu.State == BusinessEntity.States.New)
            {
                this.Insert(Alu);
            } else if (Alu.State == BusinessEntity.States.Modified)
            { this.Update(Alu); }
            else Alu.State = BusinessEntity.States.Unmodified;
        } 


    }
}
