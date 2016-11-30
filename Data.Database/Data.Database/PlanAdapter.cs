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
    public class PlanAdapter : Adapter
    {
        public List<Plan> GetAll()
        {
            List<Plan> planes = new List<Plan>();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("select * from planes", sqlConn);
                SqlDataReader drPlanes = cmdPlanes.ExecuteReader();
                while (drPlanes.Read())
                {
                    Plan unPlan = new Plan();
                    unPlan.ID = (int)drPlanes["id_plan"];
                    unPlan.IDEspecialidad = (int)drPlanes["id_especialidad"];
                    unPlan.Descripcion = (string)drPlanes["desc_plan"];
                    planes.Add(unPlan);

                }
                drPlanes.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("No se pudo obtener la lista de planes: " +ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return planes;
        }
        public Business.Entities.Plan GetOne(int ID)
        {
            Plan unPlan = new Plan();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPlanes = new SqlCommand("SELECT * FROM planes WHERE id_plan=@id", sqlConn);
                cmdPlanes.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //Siempre armar el SqlCommand y validar el tipo de dato, luego ejecutar el DataReader
                SqlDataReader drPlan = cmdPlanes.ExecuteReader();

                if (drPlan.Read())
                {
                    unPlan.ID = (int)drPlan["id_plan"];
                    unPlan.Descripcion = (string)drPlan["desc_plan"];
                    unPlan.IDEspecialidad = (int)drPlan["id_especialidad"];
                }
                //Cerramos la conexion
                drPlan.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios: "+Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return unPlan;
        }

        public Plan GetOne(string dp, int ide)
        {
            Plan p = new Plan();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPlan = new SqlCommand("SELECT * FROM planes WHERE (desc_plan=@descrip and id_especialidad=@id_e)", sqlConn);
                cmdPlan.Parameters.Add("@descrip", SqlDbType.VarChar, 50).Value = dp;
                cmdPlan.Parameters.Add("@id_e", SqlDbType.Int).Value = ide;

                SqlDataReader drPlan = cmdPlan.ExecuteReader();

                if (drPlan.Read()) //Si encuentra algun registro
                {
                    p.ID = (int)drPlan["id_plan"];
                    p.Descripcion = (string)drPlan["desc_plan"];
                    p.IDEspecialidad = (int)drPlan["id_especialidad"];
                }
                drPlan.Close();

            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer el plan" + ex.Message, ex);
                throw ExcepcionManejada;
            }
            finally { this.CloseConnection(); }

            return p;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //Creamos sentencia de consulta sql y le asignamos un parametro
                SqlCommand cmdDelete = new SqlCommand("DELETE planes WHERE id_plan=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //Ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar al usuario: "+Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Plan unplan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE planes " +
                    "SET id_especialidad=@esp, desc_plan=@desc " +
                    "WHERE id_plan=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = unplan.ID;
                cmdSave.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = unplan.Descripcion;
                cmdSave.Parameters.Add("@esp", SqlDbType.Int).Value = unplan.ID;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario: "+Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Plan unplan)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "INSERT INTO planes (desc_plan, id_especialidad) " +
                    "VALUES (@desc , @id_especialidad)", sqlConn);
                //El select recupera el id asignado automaticamente por la BD

                cmdInsert.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = unplan.Descripcion;
                cmdInsert.Parameters.Add("@id_especialidad", SqlDbType.Int).Value = unplan.IDEspecialidad;
                //unplan.ID= Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

                cmdInsert.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el usuario:"+Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Plan unplan)
        {
            if (unplan.State == BusinessEntity.States.Deleted)
            {
                this.Delete(unplan.ID);
            }
            else if (unplan.State == BusinessEntity.States.New)
            {
                this.Insert(unplan);
            }
            else if (unplan.State == BusinessEntity.States.Modified)
            {
                this.Update(unplan);
            }
            else unplan.State = BusinessEntity.States.Unmodified;
        }

    }
}



 