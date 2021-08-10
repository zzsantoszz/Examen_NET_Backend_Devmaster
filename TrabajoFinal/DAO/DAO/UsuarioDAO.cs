using DAO.Modelo;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO.DAO
{
    public class UsuarioDAO
    {
        #region Cadena Conexión
        string _stringConnection = ConfigurationManager.ConnectionStrings["connBD_ADO"].ConnectionString;  //conexion para ADO
        #endregion

        public void ListaUsuario()//EF
        {
            Console.Clear();
            using (var db = new connBD_EF())
            {
                List<tb_usuario> listacliente = db.tb_usuario.ToList();
                Console.WriteLine("Id Usuario \t Codigo_Usuario \t User \t\t Tipo_usuario \t\t\t Estado");
                foreach (var item in listacliente)
                {
                    Console.WriteLine(item.idUsuario + "\t\t" + item.cod_usuario + "\t\t\t" + item.user_acceso + "\t\t\t" + item.idTipo_usuario + "\t\t" + item.estado_usuario);
                }

            }
        }

    }
}
