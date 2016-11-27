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
                    Com.IdPlan = (int)drCom["id_plan"];
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
                    Com.IdPlan = (int)drComi["id_plan"];

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
                SqlCommand cmdCom = new SqlCommand("DELETE comisiones WHERE id_comision = @id ");
                cmdCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdCom.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExMan = new Exception("No se pudo eliminar la comison" + ex.Message);
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
                CmdCom.Parameters.Add("@idp", SqlDbType.Int).Value = com.IdPlan;
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
                CmdCom.Parameters.Add("@idplan", SqlDbType.Int).Value = com.IdPlan;
            } 
            catch(Exception ex)
            {
                Exception ExM = new Exception("No se pudo actualizar la comision" + ex);
                throw ExM;
            }
            finally { this.CloseConnection(); }
        }

    }
}
