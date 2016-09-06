using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Entities;
using Business.Logic;

namespace UI.Consola
{
    public class Usuarios
    {
        private Business.Logic.UsuarioLogic _UsuarioNegocio;

        public Business.Logic.UsuarioLogic UsuarioNegocio { set { _UsuarioNegocio = value; } get { return _UsuarioNegocio; } }

        public Usuarios()
        {
            UsuarioNegocio = new Business.Logic.UsuarioLogic(); 
        }

        public void Menu ()
        {
            int i;
            do
            {
                Console.WriteLine("Menu: \n1-Listado General \n2-Consulta \n3-Agregar \n4-Modificar \n5-Eliminar \n6-Salir");
                i = (int.Parse(Console.ReadLine()));
                switch (i)
                {
                    case 1:
                        this.ListadoGeneral();
                        break;
                    case 2: this.Consultar();
                        break;
                    case 4: this.Modificar();
                        break;
                    case 3: this.Agregar();
                        break;
                    case 5: this.Eliminar();
                        break;


                }
            } while (i != 6);
        }

        
        public void ListadoGeneral()
        {


           Console.Clear();
           foreach (Usuario usr in UsuarioNegocio.GetAll()) 
           {
               MostrarDatos(usr);
           }

        }

        public void MostrarDatos(Usuario usr)
        {
            Console.WriteLine("Usuario: {0}", usr.ID);
            Console.WriteLine("\t\tNombre: {0}", usr.Nombre);
            Console.WriteLine("\t\tApellido: {0}", usr.Apellido);
            Console.WriteLine("\t\tNombre de Usuario: {0}", usr.NombreUsuario);
            Console.WriteLine("\t\tClave: {0}", usr.Clave);
            Console.WriteLine("\t\tEmail: {0}", usr.Email);
            Console.WriteLine("\t\tHabilitado: {0}", usr.Habilitado);
            Console.WriteLine();
        }

        public void Consultar()
        {
            try
            {

                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a consultar ");
                int ID = int.Parse(Console.ReadLine());
                this.MostrarDatos(UsuarioNegocio.GetOne(ID));
            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("El ID ingresado debe ser un entero ");
            }

            catch (Exception e)
            {
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();
            }
        }
        public void Modificar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a modificar");
                int ID = int.Parse(Console.ReadLine());
                Usuario usuario = UsuarioNegocio.GetOne(ID);
                Console.WriteLine("Ingrese nombre ");
                usuario.Nombre = Console.ReadLine();
                Console.WriteLine("Ingrese Apellido");
                usuario.Apellido = Console.ReadLine();
                Console.WriteLine("Ingrese nombre de usuario");
                usuario.NombreUsuario = Console.ReadLine();
                Console.WriteLine("Ingrese clave ");
                usuario.Clave = Console.ReadLine();
                Console.WriteLine("Ingrese Email");
                usuario.Email = Console.ReadLine();
                Console.WriteLine("Ingrese habilitacion de usuario (1-Si / Otro -No) : ");
                usuario.Habilitado = (Console.ReadLine() == "1");
                usuario.State = BusinessEntity.States.Modified;
                UsuarioNegocio.Save(usuario);

            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("El ID ingresado debe ser un numero ");



            }
            catch (Exception e)
            {


                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();
            }
       }
        public void Agregar ()
        {
            Usuario usuario = new Usuario();
            Console.Clear();
            
            Console.WriteLine("Ingrese nombre ");
            usuario.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese Apellido");
            usuario.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese nombre de usuario");
            usuario.NombreUsuario = Console.ReadLine();
            Console.WriteLine("Ingrese clave ");
            usuario.Clave = Console.ReadLine();
            Console.WriteLine("Ingrese Email");
            usuario.Email = Console.ReadLine();
            Console.WriteLine("Ingrese habilitacion de usuario (1-Si / Otro -No) : ");
            usuario.Habilitado = (Console.ReadLine() == "1");
            usuario.State = BusinessEntity.States.New ;

            UsuarioNegocio.Save(usuario);
            Console.WriteLine();
            Console.WriteLine("El ID: {0}", usuario.ID);

        }
        public void Eliminar()
        {
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese el ID del usuario a eliminar");
                int ID = int.Parse(Console.ReadLine());
                UsuarioNegocio.Delete(ID);


            }
            catch (FormatException fe)
            {
                Console.WriteLine();
                Console.WriteLine("El ID ingresado debe ser un numero ");
                
            }
            catch (Exception e)
            {
                
                Console.WriteLine();
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Presione una tecla para continuar ");
                Console.ReadKey();

            }

        }

    }
}
