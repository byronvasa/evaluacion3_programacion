using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidoresDMModels
{
    public class Lectura
    {
        public int MedidorNumeroSerie { get; set; }
        public DateTime Fecha { get; set; }
        public TimeSpan Hora { get; set; }
        public decimal ValorConsumo { get; set; }
    }
}