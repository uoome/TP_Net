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
    { public List<Comision> GetAll()
        { List<Comision> ListaCom = new List<Comision>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdComision = new SqlCommand("select * from comisiones ", sqlConn);
                SqlDataReader ComReader = cmdComision.ExecuteReader();
                while(ComReader.Read())
                {
                    Comision Com = new Comision();
                    Com.ID = (int)ComReader["id_comision"];
                    Com.Descripcion = (string)ComReader["desc_comision"];
                    Com.AnioEspecialidad = (int)ComReader["anio_especialidad"];
                    ListaCom.Add(Com);
                }
                ComReader.Close();
             }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la lista de comisiones" + ex.Message);
                throw ExManejada;
            }
            finally
            {
                CloseConnection();
            }
            return ListaCom;


        }
       public Comision GetOne(int id)
        {
            try { this.OpenConnection();
                Comision Com = new Comision();

                SqlCommand CmdCom = new SqlCommand("select * from comisiones where id_comision = @id");
                CmdCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataReader comRed = CmdCom.ExecuteReader();
                if (comRed.Read())
                {
                    Com.ID = (int)comRed["id_comision"];
                    Com.Descripcion = (string)comRed["desc_comision"];
                    Com.AnioEspecialidad = (int)comRed["anio_especialidad"];
                   


                }
                comRed.Close();
                return Com;
            }
            catch (Exception ex) { Exception ExManejada = new Exception("no se pudo obtener la comision" + ex.Message);
                throw ExManejada;
            } 
            finally { this.CloseConnection(); }


        }
        public void Delete(int id)
        {

            try {
                this.OpenConnection();
                SqlCommand cmdCom = new SqlCommand("delete comisiones where id_comision = @id ");
                cmdCom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                cmdCom.ExecuteNonQuery();

            }
            catch(Exception ex)
            { Exception ExMan = new Exception("No se pudo eliminar la comison" + ex.Message);
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
                SqlCommand CmdCom = new SqlCommand("insert into comisiones(id_plan,desc_comision,anio_especialidad) " +
                    "values(@idp,@desc,@anio)", sqlConn);
                CmdCom.Parameters.Add("@idp", SqlDbType.Int).Value = com.IdPlan;
                CmdCom.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = com.Descripcion;
                CmdCom.Parameters.Add("@anio", SqlDbType.Int).Value = com.AnioEspecialidad;
                CmdCom.ExecuteNonQuery();


            }
            catch(Exception ex) { Exception ExMan = new Exception("No se pudo crear la comision" + ex.Message);
                throw ExMan;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Comision com)
        {
            try { this.OpenConnection();
                SqlCommand CmdCom = new SqlCommand("update comisiones set id_plan = @idplan , anio_especialidades = @anio " +
                     "desc_comision =  @com "+
                     "where id_comision=@id", sqlConn);
                CmdCom.Parameters.Add("@id", SqlDbType.Int).Value = com.ID;

                CmdCom.Parameters.Add("@com", SqlDbType.VarChar, 50).Value = com.Descripcion;

                CmdCom.Parameters.Add("@anio", SqlDbType.Int).Value = com.AnioEspecialidad;

                CmdCom.Parameters.Add("@idplan", SqlDbType.Int).Value = com.IdPlan;
            } 
            catch(Exception ex) { Exception ExM = new Exception("No se pudo actualizar la comision" + ex);
                throw ExM;
            }
            finally { this.CloseConnection(); }
        }

    }
}
