using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;

namespace Data.Database
{
     public class ComisionAdapter : Adapter
    {
        public List<Object> GetAllComisionesMaterias(int Id)
        {
            List<Object> listaGrillaComision = new List<Object>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComisiones = new SqlCommand("select cur.id_curso, com.desc_comision, cur.cupo from comisiones com inner join materias mat on com.id_plan = mat.id_plan inner join cursos cur on cur.id_materia = mat.id_materia where mat.id_materia = @id_mat ", sqlConn);
                cmdComisiones.Parameters.Add("@id_mat", SqlDbType.Int).Value = Id;
                SqlDataReader drComi = cmdComisiones.ExecuteReader();
                while (drComi.Read())
                {
                    listaGrillaComision.Add(new
                    {
                        id_cur = (int)drComi["id_curso"],
                        desc_comi = (string)drComi["desc_comision"],
                        cupo = (int)drComi["cupo"],
                    });
                }
                drComi.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la lista de comisiones y materias " + ex.Message);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return listaGrillaComision;
        }
        public List<Comision> GetAll()
        {
            List<Comision> ListaCom = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("SELECT * FROM comisiones ", sqlConn);
                SqlDataReader drCom = cmdComision.ExecuteReader();

                while(drCom.Read())
                {
                    Comision Com = new Comision();
                    Com.ID = (int)drCom["id_comision"];
                    Com.Descripcion = (string)drCom["desc_comision"];
                    Com.AnioEspecialidad = (int)drCom["anio_especialidad"];
                    Com.IDPlan = (int)drCom["id_plan"];
                    ListaCom.Add(Com);
                }
                drCom.Close();

             }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la lista de comisiones" + ex.Message);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }

            return ListaCom;

        }
        public Comision GetOne(int id)
        {
            Comision Com = new Comision();

            try
            {
                this.OpenConnection();
                SqlCommand CmdCom = new SqlCommand("SELECT * FROM comisiones WHERE id_comision = @id",sqlConn);
                CmdCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader drComi = CmdCom.ExecuteReader();
                if (drComi.Read())
                {
                    Com.ID = (int)drComi["id_comision"];
                    Com.Descripcion = (string)drComi["desc_comision"];
                    Com.AnioEspecialidad = (int)drComi["anio_especialidad"];
                    Com.IDPlan = (int)drComi["id_plan"];

                }
                drComi.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la comision" + ex.Message);
                throw ExManejada;
            } 
            finally { this.CloseConnection(); }

            return Com;

        }

        public Comision GetOne(string d)
        {
            Comision Com = new Comision();

            try
            {
                this.OpenConnection();
                SqlCommand CmdCom = new SqlCommand("SELECT * FROM comisiones WHERE desc_comision = @descrip", sqlConn);
                CmdCom.Parameters.Add("@descrip", SqlDbType.VarChar,50).Value = d;
                SqlDataReader drComi = CmdCom.ExecuteReader();
                if (drComi.Read())
                {
                    Com.ID = (int)drComi["id_comision"];
                    Com.Descripcion = (string)drComi["desc_comision"];
                    Com.AnioEspecialidad = (int)drComi["anio_especialidad"];
                    Com.IDPlan = (int)drComi["id_plan"];

                }
                drComi.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la comision" + ex.Message);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }

            return Com;

        }
        public void Delete(int id)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdCom = new SqlCommand("DELETE comisiones WHERE id_comision = @id ",sqlConn);
                cmdCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdCom.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExMan = new Exception("No se pudo eliminar la comison: " + ex.Message, ex);
                throw ExMan;
            } 
            finally { this.CloseConnection(); }

        }
        public void Save(Comision com)
        {
            if(com.State == BusinessEntity.States.New)
            {
                Insert(com);
            }
            if(com.State == BusinessEntity.States.Modified)
            {
                Update(com);
            }
            if(com.State == BusinessEntity.States.Deleted)
            {
                Delete(com.ID);
            }
            com.State = BusinessEntity.States.Unmodified;


        }
        protected void Insert(Comision com)
        {
            try
            {
                this.OpenConnection();
                SqlCommand CmdCom = new SqlCommand(
                    "INSERT INTO comisiones (id_plan,desc_comision,anio_especialidad) " +
                    "VALUES (@idp,@desc,@anio)", sqlConn);
                CmdCom.Parameters.Add("@idp", SqlDbType.Int).Value = com.IDPlan;
                CmdCom.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = com.Descripcion;
                CmdCom.Parameters.Add("@anio", SqlDbType.Int).Value = com.AnioEspecialidad;
                CmdCom.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExMan = new Exception("No se pudo crear la comision" + ex.Message);
                throw ExMan;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        protected void Update(Comision com)
        {
            try {
                this.OpenConnection();
                SqlCommand CmdCom = new SqlCommand(
                    "UPDATE comisiones "+ 
                    "SET id_plan=@idplan , anio_especialidades=@anio, desc_comision= @com "+
                    "WJERE id_comision=@id", sqlConn);

                CmdCom.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;
                CmdCom.Parameters.Add("@com", SqlDbType.VarChar, 50).Value = com.Descripcion;
                CmdCom.Parameters.Add("@anio", SqlDbType.Int).Value = com.AnioEspecialidad;
                CmdCom.Parameters.Add("@idplan", SqlDbType.Int).Value = com.IDPlan;
            } 
            catch(Exception ex)
            {
                Exception ExM = new Exception("No se pudo actualizar la comision" + ex);
                throw ExM;
            }
            finally { this.CloseConnection(); }
        }

        public int TraerSiguienteID()
        {
            int siguiente = 0;
            try
            {
                this.OpenConnection();
                SqlCommand cmdComi = new SqlCommand(
                    "SELECT max(c.id_comision) as ultimo_id " +
                    "FROM comisiones c ", sqlConn);
                SqlDataReader drComi = cmdComi.ExecuteReader();

                if (drComi.Read())
                    siguiente = ((int)drComi["ultimo_id"]) + 1;

                drComi.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer el siguiente ID " + ex.Message, ex);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }
            return siguiente;
        }
    }
}
