using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class Paquete
    {
        public string IdTracking { get; set; }
        public double Peso { get; set; }
        public string Destino { get; set; }

        public override string ToString() => $"[Paquete] {IdTracking} - {Peso}kg a {Destino}";
    }
}
