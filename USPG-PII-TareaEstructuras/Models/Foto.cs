using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class Foto
    {
        public string Nombre { get; set; }
        public string Resolucion { get; set; }
        public DateTime Fecha { get; set; }

        public override string ToString() => $"[Foto] {Nombre} ({Resolucion})";
    }
}
