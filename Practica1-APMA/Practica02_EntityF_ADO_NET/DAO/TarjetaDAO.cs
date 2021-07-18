using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET.DAO
{
    class TarjetaDAO
    {
        public void ListaTarjeta()
        {
            Console.Clear();
            using (var db = new connBD_Practica1())
            {
                List<tbTarjeta> listatarjeta = db.tbTarjeta.ToList();
                Console.WriteLine("Id Tarjeta  \t   Numero de tarjeta \t Tipo tarjeta \t Modo Pago \t Fecha de Vencimiento \t idCliente");
                foreach (var item in listatarjeta)
                {
                    Console.WriteLine(item.idTarjeta + "\t\t" + item.numeroTarjeta + "\t" + item.tipoTarjeta + "\t\t" + item.modoPago + "\t" + item.fechaVencimiento + "\t\t" + item.idCliente);
                }

            }
        }

        public void RegistrarTarjeta()
        {
            Console.Clear();
            Console.WriteLine("Registrar Tarjeta: ");
            Console.WriteLine("Numero: ");
            string numerotarjeta = Console.ReadLine();
            Console.WriteLine("Tipo: ");
            string tipotarjeta = Console.ReadLine();
            Console.WriteLine("Modo: ");
            string modotarjeta = Console.ReadLine();
            Console.WriteLine("Fecha Vencimiento: ");
            string fechavencimientotarjeta = Console.ReadLine();
            Console.WriteLine("idcliente: ");
            int idclient = Convert.ToInt32(Console.ReadLine());

            tbTarjeta dattarjeta = new tbTarjeta { numeroTarjeta = numerotarjeta, tipoTarjeta = tipotarjeta, fechaVencimiento = fechavencimientotarjeta, idCliente = idclient };
            using (var db = new connBD_Practica1())
            {
                db.tbTarjeta.Add(dattarjeta);
                db.SaveChanges();
            }
        }

        public void EditarTarjeta()
        {
            Console.Clear();
            Console.WriteLine("Editar datos de la tarjeta: ");
            Console.Write("Ingrese el ID de la tarjeta: ");
            int idnewtarjeta = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese el nuevo Numero: ");
            string numeronewtarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Tipo: ");
            string tiponewtarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Modo: ");
            string modonewtarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo Fecha Vencimiento: ");
            string fechavencimientonewtarjeta = Console.ReadLine();
            Console.WriteLine("Ingrese el nuevo idcliente: ");
            int idnewclient = Convert.ToInt32(Console.ReadLine());
            using (var db = new connBD_Practica1())
            {
                tbTarjeta dattarjeta = db.tbTarjeta.Find(idnewtarjeta);
                dattarjeta.numeroTarjeta = numeronewtarjeta;
                dattarjeta.tipoTarjeta = tiponewtarjeta;
                dattarjeta.modoPago = modonewtarjeta;
                dattarjeta.fechaVencimiento = fechavencimientonewtarjeta;
                dattarjeta.idCliente = idnewclient;
                db.SaveChanges();
                Console.Write("El id tarjeta" + idnewtarjeta + " se registro con el numero " + numeronewtarjeta + " , tipo " + tiponewtarjeta + " , modo " + modonewtarjeta + " fecha vencimiento " + fechavencimientonewtarjeta + " y con el idcliente " + idnewclient + " satisfactoriamente.");
            }
        }
    }
}
