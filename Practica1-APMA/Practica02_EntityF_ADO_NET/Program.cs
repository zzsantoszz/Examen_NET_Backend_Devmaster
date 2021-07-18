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
                                    Console.Write("¿Desa volver al SUMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 2:
                                    clienteDAO.ListaCliente();
                                    clienteDAO.RegistrarCliente();
                                    Console.Write("¿Desa volver al SUMENU? (S/N) ");
                                    rpta2 = Console.ReadLine();
                                    break;

                                case 3:
                                    clienteDAO.EditarCliente();
                                    Console.Write("¿Desa volver al SUMENU? (S/N) ");
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
                        Console.Clear();
                        /*
                        RolBEAN rolBEAN = new RolBEAN();
                        Console.Write("Ingrese nombre de Rol: ");
                        rolBEAN.NombreRol = Console.ReadLine();
                        bool rptaReg = rolDAO.RegistrarRol(rolBEAN);
                        if (rptaReg)// if(rptaReg==true)
                        {
                            Console.WriteLine("Registrado Correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("Errir en registro de Rol");
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        */
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 3:
                        Console.Clear();
                        /*
                        RolBEAN rolBEAN2 = new RolBEAN();
                        Console.Write("Ingrese nombre de Rol: ");
                        rolBEAN2.NombreRol = Console.ReadLine();
                        List<RolBEAN> listaRol = rolDAO.RegistroListaRoles(rolBEAN2);
                        foreach (var item in listaRol)
                        {
                            Console.WriteLine(item.IdRol + "\t" + item.NombreRol);
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        */
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    case 4:
                        Console.Clear();
                        /*
                        Console.Write("Ingrese ID de Rol a buscar: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        RolBEAN rolBEAN3 = new RolBEAN();
                        rolBEAN3 = rolDAO.BuscarRolID(id);
                        if (rolBEAN3.IdRol == 0)
                        {
                            Console.WriteLine("Los registros con el Id en mencion no existen. ");
                        }
                        else
                        {
                            Console.WriteLine(rolBEAN3.IdRol + "  " + rolBEAN3.NombreRol);
                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        */
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        break;
                    default:
                        break;
                    case 5:
                        /*
                        using (var db = new connBD_CONTACTABILIDAD())
                        {
                            List<tb_Rol> listaRoles = db.tb_Rol.ToList();
                            foreach (var item in listaRoles)
                            {
                                Console.WriteLine(item.idRol + "\t" + item.nombreRol);
                            }

                        }
                        Console.Write("¿Desa continuar? (S/N) ");
                        rpta = Console.ReadLine();
                        */
                        break;
                    case 0:
                        rpta = "N";
                        break;
                }

            } while (rpta == "S" || rpta == "s");

        }
    }
}
