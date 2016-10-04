using System;
using System.Collections.Generic;
using System.Text;
using Business.Entities;
using System.Data;
using System.Data.SqlClient;

namespace Data.Database
{
    public class UsuarioAdapter: Adapter
    {
        public List<Usuario> GetAll()
        {
            List<Usuario> usuarios = new List<Usuario>();

            //Abrimos conexion a la BD con el metodo creado en la clase Adapter
            try
            {
                this.OpenConnection();
                /*
                Creamos un objeto SqlCommand que sera la instancia SQL que utilizaremos 
                contra la BD, para realizar ABMC
                */
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios", sqlConn);
                /*
                Instanciamos un objeto DataReader que va traer los datos de la consulta del SqlCommand
                y los transforma a objeto
                */
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();
                /*
                El while siguiente, al usar Read() lee una fila de las devueltas por el comando sql, carga los datos en drUsuarios 
                para poder accederlo, devuelve true mientras haya podido leer datos y falso cuando el 
                siguiente registro esta vacio.
                Se usa while cuando hay mas de un registro, sino se utiliza un if.
                */
                while (drUsuarios.Read())
                {
                    //Creamos un objeto Usuario (capa entidades) para copiar los datos
                    //de la fila (registro) al objeto entidades
                    Usuario usr = new Usuario();
                    //copiamos datos del registro al objeto
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Email = (string)drUsuarios["email"];

                    //Agregamos el objeto cargado con datos a la lista
                    usuarios.Add(usr);
                }
                //Cerramos la conexion
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada =
                    new Exception("Error al recuperar la lista de usuarios",Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usuarios;
        }
        public Usuario GetOne(int ID)
        {
            Usuario usr = new Usuario();
            
            try
            {
                this.OpenConnection();
                //Armamos la consulta trayendo los datos del usuario que tiene id_usuario = ID 
                //siendo ID agregado al SqlCommand como @id
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE id_usuario=@id", sqlConn);
                cmdUsuarios.Parameters.Add("@id", SqlDbType.Int).Value=ID;
                //Siempre armar el SqlCommand y validar el tipo de dato, luego ejecutar el DataReader
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Email = (string)drUsuarios["email"];

                }
                //Cerramos la conexion
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }
        public Usuario GetOne(string nombre_us)
        {
            Usuario usr = new Usuario();

            try
            {
                this.OpenConnection();
                SqlCommand cmdUsuarios = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario=@nombre_usuario", sqlConn);
                cmdUsuarios.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = nombre_us;
                SqlDataReader drUsuarios = cmdUsuarios.ExecuteReader();

                if (drUsuarios.Read())
                {
                    usr.ID = (int)drUsuarios["id_usuario"];
                    usr.Clave = (string)drUsuarios["clave"];
                    usr.Nombre = (string)drUsuarios["nombre"];
                    usr.Apellido = (string)drUsuarios["apellido"];
                    usr.NombreUsuario = (string)drUsuarios["nombre_usuario"];
                    usr.Habilitado = (bool)drUsuarios["habilitado"];
                    usr.Email = (string)drUsuarios["email"];

                }
                //Cerramos la conexion
                drUsuarios.Close();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al recuperar la lista de usuarios", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
            return usr;
        }

        public void Delete(int ID)
        {
            try
            {
                this.OpenConnection();
                //Creamos sentencia de consulta sql y le asignamos un parametro
                SqlCommand cmdDelete = new SqlCommand("DELETE usuarios WHERE id_usuario=@id", sqlConn);
                cmdDelete.Parameters.Add("@id", SqlDbType.Int).Value = ID;
                //Ejecutamos la sentencia sql
                cmdDelete.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al eliminar al usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Update(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdSave = new SqlCommand(
                    "UPDATE usuarios " +
                    "SET nombre_usuario=@nombre_usuario, clave=@clave, habilitado=@habilitado, "+
                    "nombre=@nombre, apellido=@apellido, email=@email " +
                    "WHERE id_usuario=@id", sqlConn);
                cmdSave.Parameters.Add("@id", SqlDbType.Int).Value=usuario.ID;
                cmdSave.Parameters.Add("@nombre", SqlDbType.VarChar,50).Value = usuario.Nombre;
                cmdSave.Parameters.Add("@apellido", SqlDbType.VarChar,50).Value = usuario.Apellido;
                cmdSave.Parameters.Add("@nombre_usuario", SqlDbType.VarChar,50).Value = usuario.NombreUsuario;
                cmdSave.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                cmdSave.Parameters.Add("@email", SqlDbType.VarChar,50).Value = usuario.Email;
                cmdSave.Parameters.Add("@clave", SqlDbType.VarChar,50).Value = usuario.Clave;

                cmdSave.ExecuteNonQuery();
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al modificar datos del usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        protected void Insert(Usuario usuario)
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdInsert = new SqlCommand(
                    "INSERT INTO usuarios (nombre, apellido, nombre_usuario, clave, habilitado, email) " +
                    "VALUES (@nombre, @apellido, @nombre_usuario, @clave, @habilitado, @email)",sqlConn);
                //El select recupera el id asignado automaticamente por la BD
                
                cmdInsert.Parameters.Add("@nombre", SqlDbType.VarChar, 50).Value = usuario.Nombre;
                cmdInsert.Parameters.Add("@apellido",SqlDbType.VarChar, 50).Value = usuario.Apellido;
                cmdInsert.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = usuario.NombreUsuario;
                cmdInsert.Parameters.Add("@clave", SqlDbType.VarChar, 50).Value = usuario.Clave;
                cmdInsert.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = usuario.Email;
                cmdInsert.Parameters.Add("@habilitado", SqlDbType.Bit).Value = usuario.Habilitado;
                //Obtenemos el ID que asigno la BD automaticamente
                //usuario.ID= Decimal.ToInt32((decimal)cmdInsert.ExecuteScalar());

                cmdInsert.ExecuteNonQuery();
                
            }
            catch (Exception Ex)
            {
                Exception ExcepcionManejada = new Exception("Error al crear el usuario", Ex);
                throw ExcepcionManejada;
            }
            finally
            {
                this.CloseConnection();
            }
        }
        public void Save(Usuario usuario)
        {
            if(usuario.State == BusinessEntity.States.Deleted)
            {
                this.Delete(usuario.ID);
            }
            else if(usuario.State == BusinessEntity.States.New)
            {
                this.Insert(usuario);
            }
            else if(usuario.State == BusinessEntity.States.Modified)
            {
                this.Update(usuario);
            }
            usuario.State = BusinessEntity.States.Unmodified;
        }

        public bool ValidarUsuario(string nombUs) //Este metodo valida si existe el usuario en la BD
        {
            try
            {
                this.OpenConnection();
                SqlCommand cmdValidar = new SqlCommand("SELECT * FROM usuarios WHERE nombre_usuario=@nombre_usuario", sqlConn);
                cmdValidar.Parameters.Add("@nombre_usuario", SqlDbType.VarChar, 50).Value = nombUs;
                SqlDataReader drValidar= cmdValidar.ExecuteReader();
                
                //Al devolver la tabla pregunto si el primer registro esta vacío, si lo esta devuelvo false, sino devuelvo true
                if (drValidar.Read())
                {
                    return true;
                }
                else return false;
            }
            catch(Exception Ex)
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
