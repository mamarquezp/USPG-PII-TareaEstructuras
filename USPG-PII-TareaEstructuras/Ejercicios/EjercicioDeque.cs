using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USPG_PII_TareaEstructuras.Core;
using USPG_PII_TareaEstructuras.Models;

namespace USPG_PII_TareaEstructuras.Ejercicios
{
    internal static class EjercicioDeque
    {
        public static void EditorFotos()
        {
            Console.WriteLine("=== Deque Ej 1: Editor de Fotos ===");
            var deque = new LinkedDeque<Foto>();

            // 5 imágenes al final
            Console.WriteLine("Cargando galería...");
            deque.InsertRear(new Foto { Nombre = "IMG_01.jpg", Resolucion = "1920x1080", Fecha = DateTime.Now });
            deque.InsertRear(new Foto { Nombre = "IMG_02.jpg", Resolucion = "1920x1080", Fecha = DateTime.Now });
            deque.InsertRear(new Foto { Nombre = "IMG_03.jpg", Resolucion = "4K", Fecha = DateTime.Now });
            deque.InsertRear(new Foto { Nombre = "IMG_04.jpg", Resolucion = "1080p", Fecha = DateTime.Now });
            deque.InsertRear(new Foto { Nombre = "IMG_05.jpg", Resolucion = "720p", Fecha = DateTime.Now });

            // Desplazar 2 izquierda
            Console.WriteLine("\nDeslizando 2 fotos a la izquierda...");
            Console.WriteLine($"Ocultada: {deque.DeleteFront()}");
            Console.WriteLine($"Ocultada: {deque.DeleteFront()}");

            // Nueva imagen al inicio
            Console.WriteLine("\nInsertando nueva foto al inicio...");
            deque.InsertFront(new Foto { Nombre = "EDIT_FINAL.png", Resolucion = "4K", Fecha = DateTime.Now });

            // Imagen actual
            Console.WriteLine($"\nFoto actual en visor: {deque.PeekFront()}");
        }

        public static void CarrilReversible()
        {
            Console.WriteLine("\n=== Deque Ej 2: Carril Reversible ===");
            var deque = new LinkedDeque<Vehiculo>();

            // Insertar ambos extremos
            Console.WriteLine("Ingresando vehículos...");
            deque.InsertFront(new Vehiculo { Placa = "P-123", Tipo = "Auto", HoraIngreso = DateTime.Now });
            deque.InsertRear(new Vehiculo { Placa = "M-555", Tipo = "Moto", HoraIngreso = DateTime.Now });
            deque.InsertFront(new Vehiculo { Placa = "C-999", Tipo = "Camión", HoraIngreso = DateTime.Now });
            deque.InsertRear(new Vehiculo { Placa = "P-444", Tipo = "Auto", HoraIngreso = DateTime.Now });

            // Salida de 3 por el frente
            Console.WriteLine("\nSalida de 3 vehículos (Frente)...");
            Console.WriteLine($"Salió: {deque.DeleteFront()}");
            Console.WriteLine($"Salió: {deque.DeleteFront()}");
            Console.WriteLine($"Salió: {deque.DeleteFront()}");

            // Insertar 2 atrás
            Console.WriteLine("\nLlegando 2 vehículos más por atrás...");
            deque.InsertRear(new Vehiculo { Placa = "P-888", Tipo = "Auto", HoraIngreso = DateTime.Now });
            deque.InsertRear(new Vehiculo { Placa = "M-111", Tipo = "Moto", HoraIngreso = DateTime.Now });

            // Estado final
            Console.WriteLine($"\nVehículos en carril: {deque.Count}");
            Console.WriteLine($"Primero en fila: {deque.PeekFront()}");
            Console.WriteLine($"Último en fila: {deque.PeekRear()}");
        }
    }
}
