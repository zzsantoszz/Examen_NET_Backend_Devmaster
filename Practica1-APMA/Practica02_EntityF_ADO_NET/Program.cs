using Practica02_EntityF_ADO_NET.BEAN;
using Practica02_EntityF_ADO_NET.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET
{
    class Program
    {
        static void Main(string[] args)
        {
            string rpta = "N";

            ClienteDAO clienteDAO = new ClienteDAO();
            TarjetaDAO tarjetaDAO = new TarjetaDAO();
            PaisDAO paisDAO = new PaisDAO();
            ViajeDAO viajeDAO = new ViajeDAO();

            do
            {
                //RolDAO rolDAO = new RolDAO();
                Console.Clear();
                Console.WriteLine("-------- MENU GENERAL ------------");
                Console.WriteLine("1. CRUD Cliente - EF.");
                Console.WriteLine("2. CRUD Tarjeta - EF.");
                Console.WriteLine("3. CRUD Pais - EF.");
                Console.WriteLine("4. CRUD Viaje - ADO. NET.");
                Console.WriteLine("0. Salir.");
                Console.WriteLine("\nIngrese Opcion: ");
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        string rpta2 = "N";
                        do { 
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Cliente - EF ------------");
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
                                    clienteDAO.ListaCliente();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 2:
                                    clienteDAO.ListaCliente();
                                    clienteDAO.RegistrarCliente();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 3:
                                    clienteDAO.EditarCliente();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;
                                case 0:
                                    rpta2 = "N";
                                    break;
                            }
                        } while (rpta2 == "S" || rpta2 == "s") ;
                        rpta = "S";
                        break;
                    case 2:
                        string rpta3 = "N";
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Tarjeta - EF ------------");
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
                                    tarjetaDAO.ListaTarjeta();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 2:
                                    tarjetaDAO.ListaTarjeta();
                                    tarjetaDAO.RegistrarTarjeta();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta3 = Console.ReadLine();
                                    break;

                                case 3:
                                    tarjetaDAO.EditarTarjeta();
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
                            Console.WriteLine("-------- SUBMENU CRUD Pais - EF ------------");
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
                                    paisDAO.ListaPais();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 2:
                                    paisDAO.ListaPais();
                                    paisDAO.RegistrarPais();
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta4 = Console.ReadLine();
                                    break;

                                case 3:
                                    paisDAO.EditarPais();
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
                    case 4:
                        string rpta5 = "N";
                        do
                        {
                            Console.Clear();
                            Console.WriteLine("-------- SUBMENU CRUD Viaje - ADO. NET. ------------");
                            Console.WriteLine("1. Listar.");
                            Console.WriteLine("2. Registrar.");
                            Console.WriteLine("0. Volver.");
                            Console.WriteLine("\nIngrese Opcion: ");
                            int opcion2;
                            opcion2 = Convert.ToInt32(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    List<ViajeBEAN> listaViaje = new List<ViajeBEAN>();
                                    listaViaje = viajeDAO.listaViajes();
                                    Console.Clear();
                                    Console.WriteLine("Lista Viaje: ");
                                    foreach (var item in listaViaje)
                                    {
                                        Console.WriteLine(item.IdViaje + "\t" + item.IdTarjeta + "\t" + item.IdPais + "\t" + item.Fechainicioviaje + "\t" + item.Fechafinviaje + "\t" + item.EstadoViaje);
                                    }
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta5 = Console.ReadLine();
                                    break;

                                case 2:
                                    tarjetaDAO.ListaTarjeta();
                                    paisDAO.ListaPais();
                                    ViajeBEAN viajeBEAN2 = new ViajeBEAN();
                                    Console.Write("Ingrese idTarjeta: ");
                                    viajeBEAN2.IdViaje = Convert.ToInt32(Console.ReadLine());
                                    List<ViajeBEAN> listaRol = viajeDAO.RegistroListaViaje(viajeBEAN2);
                                    foreach (var item in listaRol)
                                    {
                                        Console.WriteLine(item.IdViaje + "\t" + item.IdTarjeta + "\t" + item.IdPais + "\t" + item.Fechainicioviaje + "\t" + item.Fechafinviaje + "\t" + item.EstadoViaje);
                                    }
                                    Console.Write("¿Desa volver al SUBMENU? (S/N) ");
                                    rpta5 = Console.ReadLine();
                                    break;
                                case 0:
                                    rpta5 = "N";
                                    break;
                            }
                        } while (rpta5 == "S" || rpta5 == "s");
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
