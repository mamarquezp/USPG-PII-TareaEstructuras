using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class Ventana
    {
        public string Nombre { get; set; }
        public string Usuario { get; set; }
        public DateTime HoraApertura { get; set; }

        public override string ToString() => $"[Ventana] {Nombre} - {Usuario} ({HoraApertura:HH:mm:ss})";
    }
}
