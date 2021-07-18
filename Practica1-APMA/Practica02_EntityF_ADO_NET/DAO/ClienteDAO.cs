using System;
using System.Collections.Generic;
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
            Console.Clear();
            Console.WriteLine("Lista de Cliente: ");
            string nombreCat = Console.ReadLine();
            tb_Categoria cat = new tb_Categoria { nombreCategoria = nombreCat };
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                db.tb_Categoria.Add(cat);
                db.SaveChanges();
            }
        }

        public void EditarCliente()
        {
            Console.Clear();
            Console.Write("Ingrese el ID de Categoria a editar: ");
            int idCat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingrese el nuevo nombre: ");
            string nombreCat = Console.ReadLine();
            using (var db = new BD_CONTACTABILIDADEntities())
            {
                tb_Categoria cat = db.tb_Categoria.Find(idCat);
                cat.nombreCategoria = nombreCat;
                db.SaveChanges();
                Console.Write("El registro con codigo " + idCat + " se edito correctamente.");
            }
        }
    }
}
