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
                            Console.WriteLine("3. Actualizar.");
                            Console.WriteLine("0. Volver.");
                            Console.WriteLine("\nIngrese Opcion: ");
                            int opcion2;
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    usuarioDAO.ListaUsuario();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 2:
                                    //clienteDAO.ListaCliente();
                                    //clienteDAO.RegistrarCliente();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 3:
                                    //clienteDAO.EditarCliente();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
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
                                    //tarjetaDAO.ListaTarjeta();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 2:
                                    //tarjetaDAO.ListaTarjeta();
                                    //tarjetaDAO.RegistrarTarjeta();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 3:
                                    //tarjetaDAO.EditarTarjeta();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
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
                                    //paisDAO.ListaPais();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 2:
                                    //paisDAO.ListaPais();
                                    //paisDAO.RegistrarPais();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 3:
                                    //paisDAO.EditarPais();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
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
