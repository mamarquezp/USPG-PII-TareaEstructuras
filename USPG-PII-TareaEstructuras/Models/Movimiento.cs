using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class Movimiento
    {
        public string Accion { get; set; }
        public string Coordenada { get; set; }
        public int SegundoJuego { get; set; }

        public override string ToString() => $"[Movimiento] {Accion} en {Coordenada} (seg: {SegundoJuego})";
    }
}
