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
    public class PersonaAdapter : Adapter
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
                    pers.ID = (int)drPersonas["id_persona"];
                    pers.Nombre = (string)drPersonas["nombre"];
                    pers.Apellido = (string)drPersonas["apellido"];
                    pers.Direccion = (string)drPersonas["direccion"];
                    pers.Email = (string)drPersonas["email"];
                    pers.Telefono = (string)drPersonas["telefono"];
                    pers.Legajo = (int)drPersonas["legajo"];
                    pers.TipoPersona = (Personas.TiposPersonas)drPersonas["tipo_persona"];
                    pers.IDPlan = (int)drPersonas["id_plan"];
                    pers.FechaDeNacimiento = (DateTime)drPersonas["fecha_nac"];
                    pers.Habilitado = (bool)drPersonas["habilitado"];
                    pers.NombreUsuario = (string)drPersonas["nombre_usuario"];
                    pers.Clave = (string)drPersonas["clave"];
                    pers.CambiaCLave = (string)drPersonas["cambia_clave"];

                    personas.Add(pers);

                }
                //Cerramos DataReader
                drPersonas.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cargar la lista de Personas" +Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return personas;
        }
        public List<Object> GetAllEstados(int ID)
        {
            List<Object> listaGrilla = new List<Object>();

            try
            {
                this.OpenConnection();
                SqlCommand cmdEstados = new SqlCommand("select mat.anio, mat.desc_materia, alu.condicion, alu.nota,pla.desc_plan from alumnos_inscripciones alu inner join personas per on alu.id_alumno = per.id_persona inner join cursos cur on cur.id_curso = alu.id_curso inner join materias mat on mat.id_materia = cur.id_materia inner join planes pla on pla.id_plan = mat.id_plan where alu.id_alumno = @idPersona", sqlConn);

                cmdEstados.Parameters.Add("@idPersona", SqlDbType.Int).Value = ID;
                SqlDataReader drEstados = cmdEstados.ExecuteReader();
                while (drEstados.Read())
                {
                    if (drEstados["nota"].ToString() == "")
                    {
                        listaGrilla.Add(new
                        {
                            año = (int)drEstados["anio"],
                            desc_materia = (string)drEstados["desc_materia"],
                            estado = (AlumnoInscripcion.TiposCondiciones)drEstados["condicion"],
                            nota = "Sin nota",
                            desc_plan = (string)drEstados["desc_plan"],
                        });
                    }
                    else
                    {
                        listaGrilla.Add(new
                        {
                            año = (int)drEstados["anio"],
                            desc_materia = (string)drEstados["desc_materia"],
                            estado = (AlumnoInscripcion.TiposCondiciones)drEstados["condicion"],
                            nota = (string)drEstados["nota"],
                            desc_plan = (string)drEstados["desc_plan"],
                        });
                    }
                }
                drEstados.Close();


            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al cargar la lista de Estados" + Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return listaGrilla;
        }
        public List<Personas> GetAll(Personas.TiposPersonas tipoPers)
        {
            List<Personas> listaPers = new List<Personas>();

            try
            {
                this.OpenConnection();

                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas WHERE tipo_persona in (@tipo_pers)", sqlConn);
                cmdPersonas.Parameters.Add("@tipo_pers", SqlDbType.Int).Value = tipoPers;
                SqlDataReader drPersonas = cmdPersonas.ExecuteReader();

                while (drPersonas.Read())
                {
                    Personas pers = new Personas();
                    pers.ID = (int)drPersonas["id_persona"];
                    pers.Nombre = (string)drPersonas["nombre"];
                    pers.Apellido = (string)drPersonas["apellido"];
                    pers.Direccion = (string)drPersonas["direccion"];
                    pers.Email = (string)drPersonas["email"];
                    pers.Telefono = (string)drPersonas["telefono"];
                    pers.Legajo = (int)drPersonas["legajo"];
                    pers.TipoPersona = (Personas.TiposPersonas)drPersonas["tipo_persona"];
                    pers.IDPlan = (int)drPersonas["id_plan"];
                    pers.FechaDeNacimiento = (DateTime)drPersonas["fecha_nac"];
                    pers.Habilitado = (bool)drPersonas["habilitado"];
                    pers.NombreUsuario = (string)drPersonas["nombre_usuario"];
                    pers.Clave = (string)drPersonas["clave"];
                    pers.CambiaCLave = (string)drPersonas["cambia_clave"];

                    listaPers.Add(pers);
                }

                drPersonas.Close();

            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al traer la lista de personas" + ex.Message);
                throw (exManejada);
            }
            finally
            {
                this.CloseConnection();
            }

            return listaPers;

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
                    persona.Legajo = (int)drPersona["legajo"];
                    persona.FechaDeNacimiento = (DateTime)drPersona["fecha_nac"];
                    persona.TipoPersona = (Personas.TiposPersonas)drPersona["tipo_persona"];
                    persona.ID = (int)drPersona["id_persona"];
                    persona.Habilitado = (bool)drPersona["habilitado"];
                    persona.NombreUsuario = (string)drPersona["nombre_usuario"];
                    persona.Clave = (string)drPersona["clave"];
                    persona.CambiaCLave = (string)drPersona["cambia_clave"];


                }
                //Cerramos el DataReader
                drPersona.Close();

            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al traer la persona" + Ex.Message, Ex);
            }
            finally
            {
                this.CloseConnection();
            }
            return persona;
        }

        public Personas GetOne(string nombUs)
        {
            Personas persona = new Personas();

            try
            {
                this.OpenConnection();
                SqlCommand cmdPersonas = new SqlCommand("SELECT * FROM personas WHERE nombre_usuario=@nombre_usuario", sqlConn);
                cmdPersonas.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombUs;
                SqlDataReader drPersona = cmdPersonas.ExecuteReader();

                if (drPersona.Read())
                {
                    persona.Apellido = (string)drPersona["apellido"];
                    persona.Nombre = (string)drPersona["nombre"];
                    persona.Telefono = (string)drPersona["telefono"];
                    persona.Direccion = (string)drPersona["direccion"];
                    persona.Email = (string)drPersona["email"];
                    persona.IDPlan = (int)drPersona["id_plan"];
                    persona.Legajo = (int)drPersona["legajo"];
                    persona.FechaDeNacimiento = (DateTime)drPersona["fecha_nac"];
                    persona.TipoPersona = (Personas.TiposPersonas)drPersona["tipo_persona"];
                    persona.ID = (int)drPersona["id_persona"];
                    persona.Habilitado = (bool)drPersona["habilitado"];
                    persona.NombreUsuario = (string)drPersona["nombre_usuario"];
                    persona.Clave = (string)drPersona["clave"];
                    persona.CambiaCLave = (string)drPersona["cambia_clave"];

                }
                //Cerramos la conexion
                drPersona.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios" + Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return persona;
        }

        public int TraerDocente(string nombreDocente)
        {
            int idDocente=-1;
            try
            {
                this.OpenConnection();
                SqlCommand cmdPersona = new SqlCommand(
                    "SELECT id_persona FROM personas WHERE concat(apellido, ' ', nombre)in(@persona)", sqlConn);
                cmdPersona.Parameters.Add("@persona", SqlDbType.VarChar, 50).Value = nombreDocente;
                SqlDataReader drPersona = cmdPersona.ExecuteReader();

                if(drPersona.Read())
                    idDocente = (int)drPersona["id_persona"];

                drPersona.Close();
            }
            catch (Exception ex)
            {
                Exception exManejada = new Exception("Error al traer el ID de la persona" +ex.Message);
                throw exManejada;
            }
            finally { this.CloseConnection(); }

            return idDocente;
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
            else pers.State = BusinessEntity.States.Unmodified;
        }
        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdDeletePers = new SqlCommand("DELETE personas WHERE id_persona=@id",sqlConn);
                cmdDeletePers.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                cmdDeletePers.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar al usuario" + ex.Message, ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Personas pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "INSERT INTO personas (nombre, apellido, email, telefono, id_plan, fecha_nac, legajo, tipo_persona, nombre_usuario, clave, cambia_clave, habilitado, direccion) "+
                    "VALUES (@nombre, @apellido, @email, @telefono, @id_plan, @fecha_nac, @legajo, @tipo_persona, @nomUs, @clave, @cambiaClave, @habi, @direc)", sqlConn);

                //cmdInsert.Parameters.Add("@Identity", SqlDbType.Int, 32, "id_persona");
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value= pers.Nombre;
                cmdInsert.Parameters.Add("@apellido", SqlDbType.VarChar, 50).Value = pers.Apellido;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = pers.Email;
                cmdInsert.Parameters.Add("@telefono", SqlDbType.VarChar, 50).Value = pers.Telefono;
                cmdInsert.Parameters.Add("@id_plan", SqlDbType.VarChar, 50).Value = pers.IDPlan;
                cmdInsert.Parameters.Add("@fecha_nac", SqlDbType.VarChar, 50).Value = pers.FechaDeNacimiento;
                cmdInsert.Parameters.Add("@legajo", SqlDbType.VarChar, 50).Value = pers.Legajo;
                cmdInsert.Parameters.Add("@tipo_persona", SqlDbType.Int).Value = pers.TipoPersona;
                cmdInsert.Parameters.Add("@nomUs", SqlDbType.VarChar, 50).Value = pers.NombreUsuario;
                cmdInsert.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value=pers.Clave;
                cmdInsert.Parameters.Add("@cambiaClave", SqlDbType.VarChar, 50).Value = pers.CambiaCLave;
                cmdInsert.Parameters.Add("@habi", SqlDbType.Bit).Value = pers.Habilitado;
                cmdInsert.Parameters.Add("@direc", SqlDbType.VarChar, 50).Value = pers.Direccion;

                cmdInsert.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear la persona" + ex.Message, ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Personas pers)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE personas " +
                    "SET nombre=@nombre, direccion=@direccion, apellido=@apellido, email=@email, "+
                    "telefono=@telefono, fecha_nac=@fecha_nac, legajo=@legajo, tipo_persona=@tipo_persona, id_plan=@id_plan, "+
                    "nombre_usuario=@nombUs, clave=@clave, cambia_clave=@cambClav, habilitado=@habi "+ 
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
                cmdSave.Parameters.Add("@nombUs", SqlDbType.VarChar, 50).Value = pers.NombreUsuario;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = pers.Clave;
                cmdSave.Parameters.Add("@cambClav", SqlDbType.VarChar, 50).Value = pers.CambiaCLave;
                cmdSave.Parameters.Add("@habi", SqlDbType.Bit).Value = pers.Habilitado;
                cmdSave.Parameters.Add("@direccion", SqlDbType.VarChar, 50).Value = pers.Direccion;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos de la persona" + Ex.Message, Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }

        }

        public bool ValidarUsuario(string nombUs) //Este metodo valida si existe el usuario en la BD
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdValidar = new SqlCommand("SELECT * FROM personas WHERE nombre_usuario=@nombre_usuario", sqlConn);
                cmdValidar.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombUs;
                SqlDataReader drValidar = cmdValidar.ExecuteReader();

                //Al devolver la tabla pregunto si el primer registro esta vacío, si lo esta devuelvo false, sino devuelvo true
                if (drValidar.Read())
                {
                    return true;
                }
                else return false;
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al buscar el usuario en la BD", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }

    }
}
