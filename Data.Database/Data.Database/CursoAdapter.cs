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
                this.OpenConnection();
                SqlCommand cmdCursos = new SqlCommand("SELECT * FROM cursos", sqlConn);
                SqlDataReader drCursos = cmdCursos.ExecuteReader();

                while (drCursos.Read())
                {
                    Curso unCurso = new Curso();

                    unCurso.ID = (int)drCursos["id_curso"];
                    unCurso.IDMateria = (int)drCursos["id_materia"];
                    unCurso.IDComision = (int)drCursos["id_comision"];
                    unCurso.AnioCalendario = (int)drCursos["anio_calendario"];
                    unCurso.Cupo = (int)drCursos["cupo"];
                    unCurso.CupoDis = (int)drCursos["cupos_disponibles"];
                    //unCurso.Descripcion no esta en la BD ¿se agrega?
                    listaCursos.Add(unCurso);
                   
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
                SqlCommand cmdEstados = new SqlCommand("select distinct cur.id_curso, com.id_comision, mat.anio, mat.desc_materia, alu.condicion, alu.nota, pl.desc_plan from alumnos_inscripciones alu inner join personas per on alu.id_alumno = per.id_persona inner join cursos cur on cur.id_curso = alu.id_curso inner join materias mat on mat.id_materia = cur.id_materia inner join planes pl on pl.id_plan = mat.id_plan inner join comisiones com on com.id_comision = cur.id_comision where alu.id_alumno=@idPersona", sqlConn);

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
                SqlCommand cmdSave = new SqlCommand
                ("UPDATE cursos SET id_materia=@id_materia,id_comision=@id_comision,anio_calendario=@anio_calendario,cupo=@cupo, cupos_disponibles=@cupodis WHERE id_curso=@id", sqlConn);
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
                SqlCommand cmdInsertCurso = new SqlCommand("INSERT into cursos (id_materia, id_comision, cupo, anio_calendario, cupos_disponibles)"
                    + "VALUES (@id_materia, @id_comision, @cupo, @anio_calendario, @cupdis)", sqlConn);
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
    }
}
