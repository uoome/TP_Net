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
    class DocenteCursoAdapter: Adapter
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

        
    }
}
