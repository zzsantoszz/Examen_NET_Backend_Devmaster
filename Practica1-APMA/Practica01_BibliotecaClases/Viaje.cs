using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica01_BibliotecaClases
{
    [Table("tbViaje")]
    public class Viaje
    {
        [Key]
        public int IdCliente { get; set; }
        public DateTime FechaInicioViaje { get; set; }
        public DateTime FechaFinViaje { get; set; }

        [Required] // especifica que el campo es requerido
        [StringLength(1)] // especifica el tamaño del camp
        public string EstadoViaje { get; set; }

        //clave foranea
        public int IdTarjeta { get; set; }
        public Tarjeta Tarjeta { get; set; }
        public int IdPais { get; set; }
        public Pais Pais { get; set; }
    }
}
