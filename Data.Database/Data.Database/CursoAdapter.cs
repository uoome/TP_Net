using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class CursoAdapter: Adapter
    {
       
        public List<Curso> GetAll()
        {
            List<Curso> listaCursos = new List<Curso>();

            try
            {
                OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM cursos", sqlConn);
                SqlDataReader drCurso = cmdCurso.ExecuteReader();

                while (drCurso.Read())
                {
                    Curso c = new Curso();

                    c.ID = (int)drCurso["id_curso"];
                    c.IDComision = (int)drCurso["id_comision"];
                    c.IDMateria = (int)drCurso["id_materia"];
                    c.AnioCalendario = (int)drCurso["anio_calendario"];
                    c.Cupo = (int)drCurso["cupo"];
                    c.CupoDis = (int)drCurso["cupos_disponibles"];

                    listaCursos.Add(c);
                }
                drCurso.Close();

            }
            catch(Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la lista de cursos " + ex.Message, ex);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }

            return listaCursos;

        }

        public List<Object> GetAllNuevo() //Se modifico el metodo utilizando nueva consulta sql para simplicidad de codigo en otras areas
        {
            List<Object> listaCursos = new List<Object>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand(
                    "SELECT c.id_curso, c.anio_calendario, c.cupo, c.cupos_disponibles, com.desc_comision, m.desc_materia "+
                    "FROM cursos c "+
                    "INNER JOIN materias m on c.id_materia = m.id_materia "+
                    "INNER JOIN comisiones com on com.id_comision = c.id_comision "+
                    "ORDER BY c.id_curso", sqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    listaCursos.Add(new
                    {
                        id_curso = (int)drCursos["id_curso"],
                        anio_calend = (int)drCursos["anio_calendario"],
                        cupo = (int)drCursos["cupo"],
                        cupo_disp = (int)drCursos["cupos_disponibles"],
                        comision = (string)drCursos["desc_comision"],
                        materia = (string)drCursos["desc_materia"],
                    });
                }

                drCursos.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada= new Exception("Error al traer la lista de crusos" +ex.Message,ex);
                throw ExcepcionManejada;
            }
            finally
            {
               this.CloseConnection();
            }

            return listaCursos;
        } 

        public List<Object> GetAllEstadosCursos(int ID)
        {
            List<Object> listaGrilla = new List<Object>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdEstados = new SqlCommand(
                   "SELECT DISTINCT cur.id_curso, com.id_comision, mat.anio, mat.desc_materia, alu.condicion, alu.nota, pl.desc_plan "+
                   "FROM alumnos_inscripciones alu "+
                   "INNER JOIN personas per ON alu.id_alumno = per.id_persona "+
                   "INNER JOIN cursos cur ON cur.id_curso = alu.id_curso " +
                   "INNER JOIN materias mat ON mat.id_materia = cur.id_materia " +
                   "INNER JOIN planes pl ON pl.id_plan = mat.id_plan " +
                   "INNER JOIN comisiones com ON com.id_comision = cur.id_comision " +
                   "WHERE alu.id_alumno = 3", sqlConn);

                cmdEstados.Parameters.Add("@idPersona", SqlDbType.Int).Value = ID;
                SqlDataReader drEstados = cmdEstados.ExecuteReader();
                while (drEstados.Read())
                {
                    if (drEstados["nota"].ToString() == "")
                    {
                        listaGrilla.Add(new
                        {
                            curs = (int)drEstados["id_curso"],
                            com = (int)drEstados["id_comision"],
                            año = (int)drEstados["anio"],
                            desc_materia = (string)drEstados["desc_materia"],
                            estado = (AlumnoInscripcion.TiposCondiciones)drEstados["condicion"],
                            nota = "Sin nota",
                            desc_plan = (string)drEstados["desc_plan"],
                        });
                    }
                    else
                    {
                        listaGrilla.Add(new
                        {
                            curs = (int)drEstados["id_curso"],
                            com = (int)drEstados["id_comision"],
                            año = (int)drEstados["anio"],
                            desc_materia = (string)drEstados["desc_materia"],
                            estado = (AlumnoInscripcion.TiposCondiciones)drEstados["condicion"],
                            nota = (string)drEstados["nota"],
                            desc_plan = (string)drEstados["desc_plan"],
                        });
                    }
                }
                drEstados.Close();
                
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cargar la lista de Estados" + Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return listaGrilla;
        }

        public Curso GetOne(int ID)
        {
            Curso cur = new Curso();
            try
            {
                this.OpenConnection();
                SqlCommand cmdCurso = new SqlCommand("SELECT * FROM cursos WHERE id_curso=@id", sqlConn);
                cmdCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drCurso = cmdCurso.ExecuteReader();
                
                if(drCurso.Read())
                {
                    cur.ID = (int)drCurso["id_curso"];
                    //cur.Descripcion = (int)drCurso["descripcion"];
                    cur.Cupo = (int)drCurso["cupo"];
                    cur.AnioCalendario = (int)drCurso["anio_calendario"];
                    cur.IDMateria = (int)drCurso["id_materia"];
                    cur.IDComision = (int)drCurso["id_comision"];
                    cur.CupoDis = (int)drCurso["cupos_disponibles"];


                }

                drCurso.Close();
            }
            catch(Exception ex)

            {
                Exception ExcepcionManejada = new Exception("Error al cargar el curso" + ex.Message, ex);
                throw ExcepcionManejada;


            }
            finally
            {
                this.CloseConnection();

            }
            return cur;
        }

        public void Delete (int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDeleteCurso = new SqlCommand("DELETE cursos WHERE id_curso=@id", sqlConn);
                cmdDeleteCurso.Parameters.Add("@id", SqlDbType.Int).Value = ID;

                cmdDeleteCurso.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso" + ex.Message, ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso curso)
        {
            try
            {
                OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE cursos "+
                    "SET id_materia=@id_materia,id_comision=@id_comision,anio_calendario=@anio_calendario,cupo=@cupo, cupos_disponibles=@cupodis "+
                    "WHERE id_curso=@id", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = curso.ID;
                cmdSave.Parameters.Add("@id_materia", SqlDbType.Int).Value = curso.IDMateria;
                cmdSave.Parameters.Add("@id_comision", SqlDbType.Int).Value = curso.IDComision;
                cmdSave.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = curso.AnioCalendario;
                cmdSave.Parameters.Add("@cupo", SqlDbType.Int).Value = curso.Cupo;
                cmdSave.Parameters.Add("@cupodis", SqlDbType.Int).Value = curso.CupoDis;
                cmdSave.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception excepcionManejada = new Exception("Error al modificar datos del  usuario: " + ex.Message, ex);
                throw excepcionManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Insert(Curso cur)    
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsertCurso = new SqlCommand(
                    "INSERT INTO cursos (id_materia, id_comision, cupo, anio_calendario, cupos_disponibles) "+ 
                    "VALUES (@id_materia, @id_comision, @cupo, @anio_calendario, @cupdis)", sqlConn);
                cmdInsertCurso.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdInsertCurso.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdInsertCurso.Parameters.Add("@cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdInsertCurso.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdInsertCurso.Parameters.Add("@cupdis", SqlDbType.Int).Value = cur.CupoDis;
                
                cmdInsertCurso.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al crear el curso" + ex.Message , ex);
                throw ExManejada;

            }
            finally
            {
                CloseConnection();
            }
        }

        public void Save(Curso cur)
        {
            if (cur.State == BusinessEntity.States.Deleted)
            {
                this.Delete(cur.ID);
            }
            else if (cur.State == BusinessEntity.States.New)
            {
                this.Insert(cur);
            }
            else if (cur.State == BusinessEntity.States.Modified)
            {
                this.Update(cur);
            }
            else cur.State = BusinessEntity.States.Unmodified;

        }

        public int TraerSiguienteID()
        {
            int siguiente = 0;

            try
            {
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("select max(c.id_curso) as ultimo_id from cursos c", sqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                if (drCursos.Read())
                    siguiente = ((int)drCursos["ultimo_id"]) + 1;

                drCursos.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al recuperar el ultimo ID " + ex.Message, ex);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }

            return siguiente;
        }
    }
}
