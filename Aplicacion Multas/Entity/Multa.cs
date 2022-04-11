using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Aplicacion_Multas.Entity
{
    public class Multa
    {
        public int Id { get; set; }
        public int DNI { get; set; }
        public DateTime FechaDeInfraccion { get; set; } 
        public double Importe { get; set; }
        public DateTime? FechaDePagoDeInfraccion { get; set; }
    }
}
