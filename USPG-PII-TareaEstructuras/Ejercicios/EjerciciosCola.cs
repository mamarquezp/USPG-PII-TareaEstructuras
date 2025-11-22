using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USPG_PII_TareaEstructuras.Models;
using USPG_PII_TareaEstructuras.Core;

namespace USPG_PII_TareaEstructuras.Ejercicios
{
    internal static class EjerciciosCola
    {
        public static void SimulacionRestaurante()
        {
            Console.WriteLine("=== Cola Ej 1: Restaurante (Lista de Espera) ===");
            var colaEspera = new LinkedQueue<ClienteRestaurante>();

            // Llegada de 6 grupos de clientes
            Console.WriteLine("Llegando clientes al restaurante...");
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Familia Pérez", CantidadPersonas = 4, Reserva = true });
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Juan y Ana", CantidadPersonas = 2, Reserva = false });
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Grupo Oficina", CantidadPersonas = 8, Reserva = true });
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Sr. López", CantidadPersonas = 1, Reserva = false });
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Amigos Facu", CantidadPersonas = 5, Reserva = false });
            colaEspera.Enqueue(new ClienteRestaurante { Nombre = "Pareja García", CantidadPersonas = 2, Reserva = true });

            Console.WriteLine($"Clientes en sala de espera: {colaEspera.Count}");
            Console.WriteLine($"Próximo en pasar: {colaEspera.Peek()}");

            // Asignar mesa a 3 grupos (Dequeue)
            Console.WriteLine("\nAsignando mesas a 3 grupos...");
            Console.WriteLine($"Pasando a mesa: {colaEspera.Dequeue()}");
            Console.WriteLine($"Pasando a mesa: {colaEspera.Dequeue()}");
            Console.WriteLine($"Pasando a mesa: {colaEspera.Dequeue()}");

            // Mostrar quién sigue
            Console.WriteLine($"\nSiguiente grupo en espera: {colaEspera.Peek()}");

            // Total pendientes
            Console.WriteLine($"Total grupos esperando mesa: {colaEspera.Count}");
        }
        public static void EnvioPaquetes()
        {
            Console.WriteLine("=== Cola Ej 2: Control de Paquetes Bodega ===");
            var cola = new LinkedQueue<Paquete>();

            // Simulación de Cola/Queue
            Console.WriteLine("Recibiendo 6 paquetes...");
            cola.Enqueue(new Paquete { IdTracking = "PKG001", Peso = 2.5, Destino = "Zona 1" });
            cola.Enqueue(new Paquete { IdTracking = "PKG002", Peso = 10.0, Destino = "Zona 4" });
            cola.Enqueue(new Paquete { IdTracking = "PKG003", Peso = 0.5, Destino = "Zona 9" });
            cola.Enqueue(new Paquete { IdTracking = "PKG004", Peso = 5.2, Destino = "Zona 10" });
            cola.Enqueue(new Paquete { IdTracking = "PKG005", Peso = 3.0, Destino = "Zona 1" });
            cola.Enqueue(new Paquete { IdTracking = "PKG006", Peso = 1.2, Destino = "Zona 14" });

            Console.WriteLine($"Total en bodega: {cola.Count}");

            Console.WriteLine("\nDespachando 3 paquetes...");
            Console.WriteLine($"Enviado: {cola.Dequeue()}");
            Console.WriteLine($"Enviado: {cola.Dequeue()}");
            Console.WriteLine($"Enviado: {cola.Dequeue()}");

            Console.WriteLine($"\nPróximo a enviar: {cola.Peek()}");

            // Cálculo de peso pendiente
            double pesoTotal = 0;
            Console.WriteLine($"Paquetes restantes: {cola.Count}");
        }
    }
}
