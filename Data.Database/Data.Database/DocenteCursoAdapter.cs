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
    public class DocenteCursoAdapter: Adapter
    {
        public List<DocenteCurso> GetAll()
        {
            List<DocenteCurso> listaDocentesCursos = new List<DocenteCurso>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand("SELECT * FROM docentes_cursos", sqlConn);
                SqlDataReader drDictado = cmdDictado.ExecuteReader();

                while (drDictado.Read())
                {
                    DocenteCurso dc = new DocenteCurso();

                    dc.ID = (int)drDictado["id_dictado"];
                    dc.IdCurso = (int)drDictado["id_curso"];
                    dc.IdDocente = (int)drDictado["id_docente"];
                    dc.Cargo = (DocenteCurso.TiposCargos)drDictado["cargo"];

                    listaDocentesCursos.Add(dc);
                }
                drDictado.Close();
                
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al traer los dictados" + ex.Message);
                throw exManejada;
            }
            finally { this.CloseConnection(); }

            return listaDocentesCursos;
        }

        public DocenteCurso GetOne(int idDictado)
        {
            DocenteCurso dc = new DocenteCurso();

            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand("SELECT * FROM docentes_cursos WHERE id_curso=@id", sqlConn);
                cmdDictado.Parameters.Add("@id", SqlDbType.Int).Value = idDictado;
                SqlDataReader drDictado = cmdDictado.ExecuteReader();

                if (drDictado.Read())
                {
                    dc.ID = (int)drDictado["id_dictado"];
                    dc.IdCurso = (int)drDictado["id_curso"];
                    dc.IdDocente = (int)drDictado["id_docente"];
                    dc.Cargo = (DocenteCurso.TiposCargos)drDictado["cargo"];

                }
                drDictado.Close();
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al traer el dictado" + ex.Message);
                throw exManejada;
            }
            finally { this.CloseConnection(); }

            return dc;
        }

        public void Insert(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand(
                    "INSERT INTO docentes_cursos (id_curso, id_docente, cargo) " +
                    "VALUES (@curso, @doc, @car)", sqlConn);
                cmdDictado.Parameters.Add("@curso", SqlDbType.Int).Value = dc.IdCurso;
                cmdDictado.Parameters.Add("@doc", SqlDbType.Int).Value = dc.IdDocente;
                cmdDictado.Parameters.Add("@car", SqlDbType.Int).Value = dc.Cargo;

                cmdDictado.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al insertar el dictado" + ex.Message);
                throw exManejada;
            }
            finally { this.CloseConnection(); }
        }

        public void Update(DocenteCurso dc)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand(
                    "UPDATE docentes_cursos " +
                    "SET id_curso=@cur, id_docente=@doc, cargo=@car " +
                    "WHERE id_dictado=@id", sqlConn);

                cmdDictado.Parameters.Add("@id", SqlDbType.Int).Value = dc.ID;
                cmdDictado.Parameters.Add("@cur", SqlDbType.Int).Value = dc.IdCurso;
                cmdDictado.Parameters.Add("@doc", SqlDbType.Int).Value = dc.IdDocente;
                cmdDictado.Parameters.Add("@car", SqlDbType.Int).Value = dc.Cargo;

                cmdDictado.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al modificar datos del dictado" +ex.Message);
                throw exManejada;
            }
            finally { this.CloseConnection(); }
        }

        public void Delete(int idDictado)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand("DELETE FROM docentes_cursos WHERE id_dictado=@id", sqlConn);
                cmdDictado.Parameters.Add("@id", SqlDbType.Int).Value = idDictado;

                cmdDictado.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al eliminar el dictado" + ex.Message);
                throw exManejada;

            }
            finally { this.CloseConnection(); }

        }

        public void Save(DocenteCurso dc)
        {
            switch (dc.State)
            {
                case BusinessEntity.States.New:
                    this.Insert(dc);
                    break;
                case BusinessEntity.States.Modified:
                    this.Update(dc);
                    break;
                case BusinessEntity.States.Deleted:
                    this.Delete(dc.ID);
                    break;
                default:
                    dc.State = BusinessEntity.States.Unmodified; 
                    break;
            }
        }

        public int TraerSiguienteID()
        {
            int siguiente = 0;

            try
            {
                this.OpenConnection();
                SqlCommand cmdDictado = new SqlCommand("SELECT max(dc.id_dictado) as ultimo_id FROM docentes_cursos dc", sqlConn);
                SqlDataReader drDictado = cmdDictado.ExecuteReader();

                if (drDictado.Read())
                    siguiente = ((int)drDictado["ultimo_id"]) + 1;

                drDictado.Close();
            }
            catch(Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer el ultimo ID " + ex.Message, ex);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }
            return siguiente;
        }
        
    }
}
