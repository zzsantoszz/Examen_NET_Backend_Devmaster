using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET.DAO
{
    class PaisDAO
    {
        public void ListaPais()
        {
            Console.Clear();
            using (var db = new connBD_Practica1())
            {
                List<tbPais> listapais = db.tbPais.ToList();
                Console.WriteLine("Id Pais  \t   Nombre Pais \t Codigo Pais");
                foreach (var item in listapais)
                {
                    Console.WriteLine(item.idPais + "\t\t" + item.nombrePais + "\t" + item.codigoPais);
                }

            }
        }

        public void RegistrarPais()
        {
            Console.Clear();
            Console.WriteLine("Registrar Pis: ");
            Console.WriteLine("Nombre: ");
            string nombrepais = Console.ReadLine();
            Console.WriteLine("Codigo: ");
            string codigopais = Console.ReadLine();

            tbPais datpais = new tbPais { nombrePais = nombrepais, codigoPais = codigopais };
            using (var db = new connBD_Practica1())
            {
                db.tbPais.Add(datpais);
                db.SaveChanges();
            }
        }

        public void EditarPais()
        {
            Console.Clear();
            Console.WriteLine("Editar datos del Pais: ");
            Console.Write("Ingrese el ID del Pais: ");
            int idpais = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo nombre del Pais: ");
            string nombrenewpais = Console.ReadLine();
            Console.Write("Ingrese el nuevo codigo del Pais: ");
            string codigonewpais = Console.ReadLine();
            using (var db = new connBD_Practica1())
            {
                tbPais datpais = db.tbPais.Find(idpais);
                datpais.nombrePais = nombrenewpais;
                datpais.codigoPais = codigonewpais;
                db.SaveChanges();
                Console.Write("El id pais" + idpais + " se registro con el nombre " + nombrenewpais + " y con el codigo pais " + codigonewpais + " satisfactoriamente.");
            }
        }
    }
}
