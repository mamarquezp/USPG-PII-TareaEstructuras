
using USPG_PII_TareaEstructuras.Ejercicios;

namespace USPG_PII_TareaEstructuras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("=== TAREA ESTRUCTURAS DE DATOS ===");
                Console.WriteLine("1. Pilas - Ej 1: Historial Ventanas");
                Console.WriteLine("2. Pilas - Ej 2: Control Juego");
                Console.WriteLine("3. Colas - Ej 1: Cola Restaurante");
                Console.WriteLine("4. Colas - Ej 2: Paquetes Bodega");
                Console.WriteLine("5. Deque - Ej 1: Editor Fotos");
                Console.WriteLine("6. Deque - Ej 2: Carril Reversible");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione: ");

                switch (Console.ReadLine())
                {
                    case "1": EjerciciosPila.HistorialVentanas(); break;
                    case "2": EjerciciosPila.ControlJuego(); break;
                    case "3": EjerciciosCola.SimulacionRestaurante(); break;
                    case "4": EjerciciosCola.EnvioPaquetes(); break;
                    case "5": EjercicioDeque.EditorFotos(); break;
                    case "6": EjercicioDeque.CarrilReversible(); break;
                    case "0": salir = true; break;
                    default: Console.WriteLine("Opción inválida."); break;
                }

                if (!salir)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver...");
                    Console.ReadKey();
                }
            }
        }
    }
}
