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


                }

                drCurso.Close();
            }
            catch(Exception ex)

            {
                Exception ExcepcionManejada = new Exception("Error al cargar el curso", ex);
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
                Exception ExcepcionManejada = new Exception("Error al eliminar el curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdateCurso = new SqlCommand(
                    "UPDATE cursos "+
                    "SET id_materia=@id_materia, id_comision@id_comision, anio_calendario=@anio_calendario, cupo=@cupo "+
                    "WHERE id_curso=@id", sqlConn);
                cmdUpdateCurso.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdUpdateCurso.Parameters.Add("id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdUpdateCurso.Parameters.Add("anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdUpdateCurso.Parameters.Add("cupo", SqlDbType.Int).Value = cur.Cupo;
               // cmdUpdateCurso.Parameters.Add("descripcion", SqlDbType.String).Value = cur.Descripcion;

                cmdUpdateCurso.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar el curso", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Insert(Curso cur)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsertCurso = new SqlCommand("INSERT into cursos (id_materia, id_comision, cupo, anio_calendario)"
                    + "VALUES (@id_materia, @id_comision, @cupo, @anio_calendario)", sqlConn);
                cmdInsertCurso.Parameters.Add("@id_materia", SqlDbType.Int).Value = cur.IDMateria;
                cmdInsertCurso.Parameters.Add("@id_comision", SqlDbType.Int).Value = cur.IDComision;
                cmdInsertCurso.Parameters.Add("@id_cupo", SqlDbType.Int).Value = cur.Cupo;
                cmdInsertCurso.Parameters.Add("@anio_calendario", SqlDbType.Int).Value = cur.AnioCalendario;
                cmdInsertCurso.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al crear el curso", ex);
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
