using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_BibliotecaClases
{
    [Table("tbPais")]
    public class Pais
    {
        [Key]
        public int IdPais { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(50)] // especifica el tamaño del camp
        public string NombrePais { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(10)] // especifica el tamaño del camp
        public string CodigoPais { get; set; }

        public List<Viaje> Viaje { get; set; }
    }
}
