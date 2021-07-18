using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_BibliotecaClases
{
    public class Cliente
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string ApellidosCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string DniCliente { get; set; }
    }
}
