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
    public class MateriaAdapter : Adapter
    {
        public List<Materia> GetAll()
        {
            List<Materia> listadoMaterias = new List<Materia>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdMaterias = new SqlCommand("SELECT * FROM materias",sqlConn);
                SqlDataReader drMaterias = cmdMaterias.ExecuteReader();

                while (drMaterias.Read())
                {
                    Materia unaMateria = new Materia();
                    
                    unaMateria.ID = (int)drMaterias["id_materia"];
                    unaMateria.IDplan = (int)drMaterias["id_plan"];
                    unaMateria.Descripcion = (string)drMaterias["desc_materia"];
                    unaMateria.HSSemanales = (int)drMaterias["hs_semanales"];
                    unaMateria.HSTotales = (int)drMaterias["hs_totales"];

                    listadoMaterias.Add(unaMateria);
                }
                drMaterias.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la lista de materias: "+ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return listadoMaterias;
        }
        
        public Materia GetOne(int ID)
        {
            Materia unaMateria = new Materia();
            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("SELECT * FROM materias WHERE id_materia=@id",sqlConn);
                cmdMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                if (drMateria.Read())
                {
                    unaMateria.Descripcion = (string)drMateria["desc_materia"];
                    unaMateria.HSSemanales = (int)drMateria["hs_semanales"];
                    unaMateria.HSTotales = (int)drMateria["hs_totales"];
                    unaMateria.IDplan = (int)drMateria["id_plan"];
                    unaMateria.ID = (int)drMateria["id_materia"];

                }
                drMateria.Close();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la materia: "+ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return unaMateria;
        }

        public Materia GetOne(string descrip)
        {
            Materia mate = new Materia();

            try
            {
                this.OpenConnection();
                SqlCommand cmdMateria = new SqlCommand("SELECT * FROM materias WHERE desc_materia=@d", sqlConn);
                cmdMateria.Parameters.Add("@d", SqlDbType.VarChar, 50).Value = descrip;
                SqlDataReader drMateria = cmdMateria.ExecuteReader();

                if (drMateria.Read()) //Si encuentra algun registro
                {
                    mate.ID = (int)drMateria["id_materia"];
                    mate.Descripcion = (string)drMateria["desc_materia"];
                    mate.HSSemanales = (int)drMateria["hs_semanales"];
                    mate.HSTotales = (int)drMateria["hs_totales"];
                    mate.IDplan = (int)drMateria["id_plan"];
                }
                drMateria.Close();

            }
            catch(Exception ex)
            {
                Exception ExManejada = new Exception("Error al traer la materia: " + ex.Message, ex);
                throw ExManejada;
            }
            finally { this.CloseConnection(); }

            return mate;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDeleteMateria = new SqlCommand("DELETE materias WHERE id_materia=@id", sqlConn);
                cmdDeleteMateria.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDeleteMateria.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al eliminar la materia: "+ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                CloseConnection();
            }
        }

        protected void Insert(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsertMateria = new SqlCommand(
                    "INSERT INTO materias (desc_materia,hs_semanales, hs_totales,id_plan) " +
                    "VALUES(@id_materia, @desc_materia, @hs_sem, @hs_tot, @id_plan)",sqlConn);
                cmdInsertMateria.Parameters.Add("@desc_materia", SqlDbType.VarChar,50).Value = materia.ID;
                cmdInsertMateria.Parameters.Add("@hs_tot", SqlDbType.Int).Value = materia.HSTotales;
                cmdInsertMateria.Parameters.Add("@hs_sem", SqlDbType.Int).Value = materia.HSSemanales;
                cmdInsertMateria.Parameters.Add("@id_plan", SqlDbType.Int).Value = materia.IDplan;

                cmdInsertMateria.ExecuteNonQuery();


            } 
            catch(Exception ex)
            {
                Exception ExManejada = new Exception("Error al crear nueva materia: " + ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        protected void Update(Materia materia)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdUpdateMateria = new SqlCommand(
                    "UPDATE materias " +
                    "SET id_plan=@idplan, desc_materia=@desc, hs_totales=@hstot, hs_semanales=@hssem "+
                    "WHERE id_materia=@id", sqlConn);
                cmdUpdateMateria.Parameters.Add("@id", SqlDbType.Int).Value = materia.ID;
                cmdUpdateMateria.Parameters.Add("@desc", SqlDbType.VarChar,50).Value = materia.Descripcion;
                cmdUpdateMateria.Parameters.Add("@hssem", SqlDbType.Int).Value = materia.HSSemanales;
                cmdUpdateMateria.Parameters.Add("@hstot", SqlDbType.Int).Value = materia.HSTotales;
                cmdUpdateMateria.Parameters.Add("@idplan", SqlDbType.Int).Value = materia.IDplan;

                cmdUpdateMateria.ExecuteNonQuery();

                        
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al actualizar la materia: "+ex.Message, ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        
        public void Save(Materia materia)
        {
            if(materia.State == BusinessEntity.States.Deleted)
            {
                this.Delete(materia.ID);
            }
            else if(materia.State == BusinessEntity.States.New)
            {
                this.Insert(materia);
            }
            else if(materia.State == BusinessEntity.States.Modified)
            {
                this.Update(materia);
            }
            else materia.State = BusinessEntity.States.Unmodified;
        }
   }
    
}

