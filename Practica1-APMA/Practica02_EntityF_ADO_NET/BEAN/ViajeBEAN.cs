using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica02_EntityF_ADO_NET.BEAN
{
    public class ViajeBEAN
    {
        public int IdViaje { get; set; }
        public int IdTarjeta { get; set; }
        public int IdPais { get; set; }
        public DateTime Fechainicioviaje { get; set; }
        public DateTime Fechafinviaje { get; set; }
        public string EstadoViaje { get; set; }
    }
}
