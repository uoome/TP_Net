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
    class PersonaAdapter : Adapter
    {
        public List<Personas> GetAll()
        {
            List<Personas> personas = new List<Personas>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas",sqlConn);
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas pers = new Personas();
                    pers.Nombre = (string)drPersonas["nombre"];
                    pers.Apellido = (string)drPersonas["apellido"];
                    pers.Direccion = (string)drPersonas["direccion"];
                    pers.Email = (string)drPersonas["email"];
                    pers.Telefono = (string)drPersonas["telefono"];
                    pers.Legajo = (string)drPersonas["legajo"];
                    // pers.TipoPersona = (TipoPersonas)drPersonas["tipo_persona"];
                    pers.IDPlan = (int)drPersonas["id_plan"];
                    pers.FechaDeNacimiento = (DateTime)drPersonas["fecha_nac"];

                    personas.Add(pers);

                }
                //Cerramos DataReader
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cargar la lista de Personas", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }
        public Personas GetOne(int ID)
        {
            Personas persona= new Personas();
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand("SELECT * FROM personas WHERE id_persona=@id_persona",sqlConn);
                cmdPersona.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
                SqlDataReader drPersona = cmdPersona.ExecuteReader();

                if (drPersona.Read())
                {
                    persona.Apellido = (string)drPersona["apellido"];
                    persona.Nombre = (string)drPersona["nombre"];
                    persona.Telefono = (string)drPersona["telefono"];
                    persona.Direccion = (string)drPersona["direccion"];
                    persona.Email = (string)drPersona["email"];
                    persona.IDPlan = (int)drPersona["id_plan"];
                    persona.Legajo = (string)drPersona["legajo"];
                    persona.FechaDeNacimiento = (DateTime)drPersona["fecha_nac"];
                    //persona.TipoPersona = (TipoPersona)drPersona["tipo_persona"];
                    persona.ID = (int)drPersona["id_persona"];

                }
                //Cerramos el DataReader
                drPersona.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer la persona", Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return persona;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDeletePers = new SqlCommand("DELETE personas WHERE id_persona=@id",sqlConn);
                cmdDeletePers.Parameters.Add("@id_persona", SqlDbType.Int).Value = ID;
                cmdDeletePers.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar al usuario", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Insert(Personas pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "INSERT INTO personas (nombre, apellido, email, telefono, id_plan, fecha_nac, legajo, tipo_persona"+
                    "VALUES(@nombre, @apellido, @email, @telefono, @id_plan, @fecha_nac, @legajo, @tipo_persona, @id_plan)", sqlConn);

                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value= pers.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pers.Apellido;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pers.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pers.Telefono;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.VarChar, 50).Value = pers.IDPlan;
                cmdInsert.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = pers.FechaDeNacimiento;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = pers.Legajo;
                cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.VarChar, 50).Value = pers.TipoPersona;

                cmdInsert.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la persona", ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Personas pers)
        {
            if (pers.State == BusinessEntity.States.Deleted)
            {
                this.Delete(pers.ID);
            }
            else if (pers.State == BusinessEntity.States.New)
            {
                this.Insert(pers);
            }
            else if (pers.State == BusinessEntity.States.Modified)
            {
                this.Update(pers);
            }
            pers.State = BusinessEntity.States.Unmodified;
        }
        public void Update(Personas pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE personas " +
                    "SET nombre=@nombre, direccion=@direccion, habilitado=@habilitado, apellido=@apellido, email=@email, "+
                    "telefono=@telefono, fecha_nac=@fecha_nac, legajo=@legajo, tipo_persona=@tipo_persona, id_plan=@id_plan "+ 
                    "WHERE id_persona=@id", sqlConn);

                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value = pers.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = pers.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pers.Apellido;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = pers.Direccion;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pers.Email;
                cmdSave.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = pers.Legajo;
                cmdSave.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = pers.FechaDeNacimiento;
                cmdSave.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pers.Telefono;
                cmdSave.Parameters.Add("@id_plan", SqlDbType.VarChar, 50).Value = pers.IDPlan;
                cmdSave.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = pers.TipoPersona;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

    }
}
