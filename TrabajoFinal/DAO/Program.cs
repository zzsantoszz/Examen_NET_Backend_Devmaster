using DAO.BEAN;
using DAO.DAO;
using DAO.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    class Program
    {
        static void Main(string[] args)
        {
            //connBD_EF connDB = new connBD_EF();
            /*List<tb_usuario> listusuario = new List<tb_usuario>();
            using (var db = new connBD_EF())
            {
                listusuario = db.tb_usuario.ToList();
            }
            Console.WriteLine("Lista de Usuario");
            foreach (var item in listusuario)
            {
                Console.WriteLine(item.cod_usuario + " " + item.user_acceso);
            }
            */
            string rpta = "N";

            UsuarioDAO usuarioDAO = new UsuarioDAO();
            CategoriaDAO categoriaDAO = new CategoriaDAO();
            AsuntoDAO asuntoDAO = new AsuntoDAO();

            do
            {
                //RolDAO rolDAO = new RolDAO();
                Console.Clear();
                Console.WriteLine("-------- MENU GENERAL ------------");
                Console.WriteLine("1. CRUD Usuario.");
                Console.WriteLine("2. CRUD Categoria.");
                Console.WriteLine("3. CRUD Asunto.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("\nIngrese Opcion: ");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        string rpta2 = "N";
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Usuario ------------");
                            Console.WriteLine("1. Listar.");
                            Console.WriteLine("2. Registrar.");
                            Console.WriteLine("4. Registrar y listar.");
                            Console.WriteLine("3. Actualizar.");
                            Console.WriteLine("5. Buscar.");
                            Console.WriteLine("0. Volver.");
                            Console.WriteLine("\nIngrese Opcion: ");
                            int opcion2;
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    //usuarioDAO.ListaUsuario();//EF
                                    List<UsuarioBEAN> listausuario = new List<UsuarioBEAN>();
                                    listausuario = usuarioDAO.listaUsuario_ADO();
                                    Console.Clear();
                                    Console.WriteLine("Lista Usuario: ");
                                    Console.WriteLine("\nUsername \t\t Tipo_usuario\n");
                                    foreach (var item in listausuario)
                                    {
                                        Console.WriteLine(item.user_name + "\t\t\t" + item.tipo_usuario);
                                    }
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 2:
                                    Console.Clear();
                                    UsuarioBEAN usuarioBEAN = new UsuarioBEAN();
                                    Console.Write("Ingrese el username: ");
                                    usuarioBEAN.user_name = Console.ReadLine();
                                    Console.Write("Ingrese el pass: ");
                                    usuarioBEAN.pass_name = Console.ReadLine();
                                    Console.Write("Ingrese el tipo de usuario: ");
                                    usuarioBEAN.tipo_usuario = Console.ReadLine();
                                    bool rptaReg = usuarioDAO.registoUsuario_ADO(usuarioBEAN);
                                    if (rptaReg)
                                    {
                                        Console.WriteLine("Registrado correctamente.");                                       
                                    }
                                    else
                                    {
                                        Console.WriteLine("Error en el registro de Usuario.");
                                    }

                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;
                                case 4:
                                    Console.Clear();
                                    UsuarioBEAN usuarioBEAN2 = new UsuarioBEAN();
                                    Console.Write("Ingrese el username: ");
                                    usuarioBEAN2.user_name = Console.ReadLine();
                                    Console.Write("Ingrese el pass: ");
                                    usuarioBEAN2.pass_name = Console.ReadLine();
                                    Console.Write("Ingrese el tipo de usuario: ");
                                    usuarioBEAN2.tipo_usuario = Console.ReadLine();
                                    
                                    List<UsuarioBEAN> listausuario2 = usuarioDAO.registroListadoUsuario(usuarioBEAN2);
                                    Console.WriteLine("\nUsername \t\t Tipo_usuario\n");
                                    foreach (var item in listausuario2)
                                    {
                                        Console.WriteLine(item.user_name + "\t\t\t" + item.tipo_usuario);
                                    }

                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;
                                case 3:
                                    //
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;
                                case 5:
                                    //
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;
                                case 0:
                                    rpta2 = "N";
                                    break;
                            }
                        } while (rpta2 == "S" || rpta2 == "s");
                        rpta = "S";
                        break;
                    case 2:
                        string rpta3 = "N";
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Categoria ------------");
                            Console.WriteLine("1. Listar.");
                            Console.WriteLine("2. Registrar.");
                            Console.WriteLine("3. Actualizar.");
                            Console.WriteLine("0. Volver.");
                            Console.WriteLine("\nIngrese Opcion: ");
                            int opcion2;
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    categoriaDAO.ListaCategoria();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 2:
                                    //tarjetaDAO.ListaTarjeta();
                                    //tarjetaDAO.RegistrarTarjeta();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 3:
                                    //tarjetaDAO.EditarTarjeta();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;
                                case 0:
                                    rpta3 = "N";
                                    break;
                            }
                        } while (rpta3 == "S" || rpta3 == "s");
                        rpta = "S";
                        break;
                    case 3:
                        string rpta4 = "N";
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Asunto ------------");
                            Console.WriteLine("1. Listar.");
                            Console.WriteLine("2. Registrar.");
                            Console.WriteLine("3. Actualizar.");
                            Console.WriteLine("0. Volver.");
                            Console.WriteLine("\nIngrese Opcion: ");
                            int opcion2;
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    asuntoDAO.ListaAsunto();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 2:
                                    //paisDAO.ListaPais();
                                    //paisDAO.RegistrarPais();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 3:
                                    //paisDAO.EditarPais();
                                    Console.Write("\n¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;
                                case 0:
                                    rpta2 = "N";
                                    break;
                            }
                        } while (rpta4 == "S" || rpta4 == "s");
                        rpta = "S";
                        break;
                    default:
                        break;
                    case 0:
                        rpta = "N";
                        break;
                }
            } while (rpta == "S" || rpta == "s");
        }
    }
}
