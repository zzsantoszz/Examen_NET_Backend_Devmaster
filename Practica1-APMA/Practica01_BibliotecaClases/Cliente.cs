using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_BibliotecaClases
{
    [Table("tbCliente")]
    public class Cliente
    {
        [Key]
        public int IdCliente { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(50)] // especifica el tamaño del camp
        public string NombreCliente { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(50)] // especifica el tamaño del camp
         public string ApellidosCliente { get; set; }
        public DateTime FechaNacimiento { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(15)] // especifica el tamaño del camp
        public string DniCliente { get; set; }

        public List<Tarjeta> Tarjeta { get; set; }
    }
}
