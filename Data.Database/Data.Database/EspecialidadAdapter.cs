﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;
using Business.Entities;


namespace Data.Database
{
    public class EspecialidadAdapter: Adapter 

    {
        public List<Especialidad> GetAll()
        {
            List<Especialidad> especialidades = new List<Especialidad> ();
            try
            {
                this.OpenConnection();
                SqlCommand CmdEspecialidades = new SqlCommand("SELECT * from especialidades", sqlConn);
                SqlDataReader drEspecialidad = CmdEspecialidades.ExecuteReader();
                while (drEspecialidad.Read())
                {
                    Especialidad esp = new Especialidad();
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["descripcion"];
                    especialidades.Add(esp);
                }
                this.CloseConnection(); 
            
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("No se pudo mostrar las especialidades", ex);
                throw exManejada;

            }
            finally
            {
                this.CloseConnection();
            }
            return especialidades;

        }
        public Especialidad GetOne(int ID)
        {
            Especialidad esp = new Especialidad();
            try
            {
                this.OpenConnection();
                SqlCommand CmdEspecialidad = new SqlCommand("SELECT especialidad WHERE id_especialidad=@id", sqlConn);
               CmdEspecialidad.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                SqlDataReader drEspecialidad = CmdEspecialidad.ExecuteReader();

                if(drEspecialidad.Read())
                {
                    esp.ID = (int)drEspecialidad["id_especialidad"];
                    esp.Descripcion = (string)drEspecialidad["especialidad"];
                }
                this.CloseConnection();




            }
            catch (Exception ex)
            { Exception ExManejada = new Exception("Error al traer la especialidad", ex);
                throw ExManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return esp;

            }
        public void Delete(int ID)
        {
          try
            {
                this.OpenConnection();
                SqlCommand CmdDelete = new SqlCommand("DELETE especialidades WHERE id_especialidad=@id", sqlConn);
                CmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                CmdDelete.ExecuteNonQuery();

                 

            }
            catch (Exception ex)
            { Exception exManejada = new Exception("Error al eliminar la especialidad", ex );
                throw exManejada;

            }
            finally
            {
                this.CloseConnection();
            }

        }
        protected void Update(Especialidad Esp)

        {
            try
            {
                this.OpenConnection();
                SqlCommand CmdUpdate = new SqlCommand("UPDATE especialidades " +
                    "SET descripcion = @desc WHERE id_especialidad = @id", sqlConn);
                CmdUpdate.Parameters.Add("@id", SqlDbType.Int).Value = Esp.ID;
                CmdUpdate.Parameters.Add("@desc", SqlDbType.VarChar, 50).Value = Esp.Descripcion;
                CmdUpdate.ExecuteNonQuery();
                 

            }
           catch(Exception ex)
            {
                Exception ExManejada = new Exception("Error al actualizar especialidad", ex);
                throw ExManejada;


            }
            finally
            {
                this.CloseConnection();
            }

        }
        protected void Insert(Especialidad Esp)
        {
            try
            {
                this.OpenConnection();
                SqlCommand CmdInsert = new SqlCommand("INSERT into especialidades" +
                              " (descripcion) VALUES (@descripcion) ", sqlConn);
                CmdInsert.Parameters.Add("@descripcion", SqlDbType.VarChar, 50).Value = Esp.Descripcion;

                CmdInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExManejada = new Exception("Error al crear una especialidad", ex);
                throw ExManejada;

            }
            finally
            {
                this.CloseConnection();

            }
        }
        public void Save(Especialidad esp)
        {
            if(esp.State == BusinessEntity.States.Deleted )
            {
                this.Delete(esp.ID);
            } else
            if(esp.State == BusinessEntity.States.New)
            {
                this.Insert(esp);

            } else
                if(esp.State == BusinessEntity.States.Modified)
            {
                this.Update(esp);
            }
            else
            { esp.State = BusinessEntity.States.Unmodified; }

        }

    }
}