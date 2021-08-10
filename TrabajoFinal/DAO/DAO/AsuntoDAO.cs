using DAO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class AsuntoDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD_ADO"].ConnectionString;  //conexion para ADO
        #endregion

        public void ListaAsunto()//EF
        {
            Console.Clear();
            using (var db = new connBD_EF())
            {
                List<tb_asunto_ticket> listaasunto = db.tb_asunto_ticket.ToList();
                Console.WriteLine("Id_Asunto \t Codigo_Asunto \t\t Descripcion");
                foreach (var item in listaasunto)
                {
                    Console.WriteLine(item.idAsunto_ticket + "\t\t" + item.codigo_asunto + "\t\t\t" + item.asunto_descripcion_ticket);
                }

            }
        }

    }
}
