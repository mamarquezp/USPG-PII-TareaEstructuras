using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USPG_PII_TareaEstructuras.Models;
using USPG_PII_TareaEstructuras.Core;

namespace USPG_PII_TareaEstructuras.Ejercicios
{
    internal static class EjerciciosPila
    {
        public static void HistorialVentanas()
        {
            Console.WriteLine("=== Pila Ej 1: Historial de Ventanas ===");
            var pila = new LinkedStack<Ventana>();

            // Simula 6 ventanas
            pila.Push(new Ventana { Nombre = "Inicio", Usuario = "User1", HoraApertura = DateTime.Now });
            pila.Push(new Ventana { Nombre = "Perfil", Usuario = "User1", HoraApertura = DateTime.Now.AddMinutes(1) });
            pila.Push(new Ventana { Nombre = "Configuración", Usuario = "User1", HoraApertura = DateTime.Now.AddMinutes(2) });
            pila.Push(new Ventana { Nombre = "Reportes", Usuario = "User1", HoraApertura = DateTime.Now.AddMinutes(5) });
            pila.Push(new Ventana { Nombre = "Detalle Reporte", Usuario = "User1", HoraApertura = DateTime.Now.AddMinutes(6) });
            pila.Push(new Ventana { Nombre = "Ayuda", Usuario = "User1", HoraApertura = DateTime.Now.AddMinutes(10) });

            Console.WriteLine($"Ventana actual (Peek): {pila.Peek()}");

            // Cierra 3 ventanas
            Console.WriteLine("\nCerrando 3 ventanas...");
            Console.WriteLine($"Cerrada: {pila.Pop()}");
            Console.WriteLine($"Cerrada: {pila.Pop()}");
            Console.WriteLine($"Cerrada: {pila.Pop()}");

            // Ventana activa
            Console.WriteLine($"\nVentana activa actual: {pila.Peek()}");

            // Restantes
            Console.WriteLine($"Total ventanas en historial: {pila.Count}");
        }

        public static void ControlJuego()
        {
            Console.WriteLine("\n=== Pila Ej 2: Control de Estados Juego ===");
            var pila = new LinkedStack<Movimiento>();

            // 8 movimientos
            string[] acciones = { "Mover N", "Saltar", "Atacar", "Mover E", "Cubrir", "Poción", "Mover S", "Ulti" };
            for (int i = 0; i < 8; i++)
            {
                pila.Push(new Movimiento { Accion = acciones[i], Coordenada = $"{10 + i},{20 + i}", SegundoJuego = i * 5 });
            }

            Console.WriteLine($"Movimiento actual: {pila.Peek()}");

            // Deshacer 4
            Console.WriteLine("\nDeshaciendo 4 jugadas...");
            for (int i = 0; i < 4; i++) Console.WriteLine($"Undo: {pila.Pop()}");

            // Estado actual
            Console.WriteLine($"\nEstado actual del jugador: {pila.Peek()}");

            // Restantes
            Console.WriteLine($"Movimientos en memoria: {pila.Count}");
        }
    }
}
