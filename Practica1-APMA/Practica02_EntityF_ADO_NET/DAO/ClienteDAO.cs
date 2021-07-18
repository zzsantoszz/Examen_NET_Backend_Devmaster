using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET.DAO
{
    class ClienteDAO
    {
        public void ListaCliente()
        {
            Console.Clear();
            using (var db = new connBD_Practica1())
            {
                List<tbCliente> listaRoles = db.tbCliente.ToList();
                Console.WriteLine("Id Cliente     Nombre Cliente \t Apellidos Cliente \t Fecha Nacimiento \t DNI Cliente");
                foreach (var item in listaRoles)
                {
                    Console.WriteLine(item.idCliente + "\t\t" + item.nombreCliente + "\t" + item.apellidosCliente + "\t\t" + item.fechaNacimiento + "\t" + item.dniCliente);
                }

            }
        }

        public void RegistrarCliente()
        {
            string format = "MM/dd/yyyy";

            Console.Clear();
            Console.WriteLine("Registrar Cliente: ");
            Console.WriteLine("Nombre: ");
            string nombrecliente = Console.ReadLine();
            Console.WriteLine("Apellido: ");
            string apellidocliente = Console.ReadLine();
            Console.WriteLine("Fecha Nacimiento: ");
            string fechanacimiento = Console.ReadLine();
            DateTime dateTime = DateTime.ParseExact(fechanacimiento, format, CultureInfo.InvariantCulture);
            //Console.WriteLine(dateTime);
            Console.WriteLine("DNI: ");
            string dni = Console.ReadLine();

            tbCliente datcliente = new tbCliente { nombreCliente = nombrecliente, apellidosCliente = apellidocliente, fechaNacimiento = dateTime, dniCliente = dni };
            using (var db = new connBD_Practica1())
            {
                db.tbCliente.Add(datcliente);
                db.SaveChanges();
            }
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.WriteLine("Editar nombre de cliente: ");
            Console.Write("Ingrese el ID del Cliente: ");
            int idCliente = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo nombre de cliente: ");
            string nombrenewcliente = Console.ReadLine();
            using (var db = new connBD_Practica1())
            {
                tbCliente datcliente = db.tbCliente.Find(idCliente);
                datcliente.nombreCliente = nombrenewcliente;
                db.SaveChanges();
                Console.Write("El id cliente "+ idCliente +" se registro con el nombre " + nombrenewcliente + " satisfacotriamente.");
            }
        }
    }
}
