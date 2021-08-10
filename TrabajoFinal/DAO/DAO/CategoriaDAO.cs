using DAO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class CategoriaDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD_ADO"].ConnectionString;  //conexion para ADO
        #endregion

        public void ListaCategoria()//EF
        {
            Console.Clear();
            using (var db = new connBD_EF())
            {
                List<tb_categoria_ticket> listacategoria = db.tb_categoria_ticket.ToList();
                Console.WriteLine("Id_Categoria \t Codigo_Categoria \t Categoria \t\t Subcategoria \t\t\t Elemento");
                foreach (var item in listacategoria)
                {
                    Console.WriteLine(item.idCategoria_ticket + "\t\t" + item.codigo_categoria_ticket + "\t\t\t" + item.nombre_categoria_ticket + "\t\t\t" + item.nombre_subcategoria_ticket + "\t\t" + item.nombre_elemento_ticket);
                }

            }
        }
    }
}
