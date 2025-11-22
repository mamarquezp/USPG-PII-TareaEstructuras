using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class Vehiculo
    {
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public DateTime HoraIngreso { get; set; }

        public override string ToString() => $"[Vehiculo] {Placa} ({Tipo}) - {HoraIngreso:HH:mm}";
    }
}
