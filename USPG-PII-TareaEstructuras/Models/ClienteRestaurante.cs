using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USPG_PII_TareaEstructuras.Models
{
    internal class ClienteRestaurante
    {
        public string Nombre { get; set; }
        public int CantidadPersonas { get; set; }
        public bool Reserva { get; set; } // Si tiene reserva o no

        public override string ToString()
        {
            string tipo = Reserva ? "(Con Reserva)" : "(Sin Reserva)";
            return $"[Cliente] {Nombre} - Mesa para {CantidadPersonas} {tipo}";
        }
    }
}
