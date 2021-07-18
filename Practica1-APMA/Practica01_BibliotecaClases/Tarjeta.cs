using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_BibliotecaClases
{
    [Table("tbTarjeta")]
    public class Tarjeta
    {
        [Key]
        public int IdTarjeta { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(30)] // especifica el tamaño del camp
        public string NumeroTarjeta { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(20)] // especifica el tamaño del camp
        public string TipoTarjeta { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(20)] // especifica el tamaño del camp
        public string ModoPago { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(10)] // especifica el tamaño del camp
        public string FechaVencimiento { get; set; }

        //clave foranea
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }
        public List<Viaje> Viaje { get; set; }

    }
}
