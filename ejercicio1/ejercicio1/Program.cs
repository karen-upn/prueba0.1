using System;

namespace ejercicio5
{
    internal class Program
    {
        // Función para validar la nota
        static bool EsNotaValida(int nota)
        {
            return nota >= 0 && nota <= 20;
        }

        // Función para clasificar la nota
        static string ClasificarNota(int nota)
        {
            if (nota >= 18 && nota <= 20)
                return "Excelente";
            else if (nota >= 14 && nota <= 17)
                return "Bueno";
            else if (nota >= 11 && nota <= 13)
                return "Regular";
            else
                return "Desaprobado";
        }

        // Procedimiento para mostrar el reporte
        static void MostrarReporte(int nota, string clasificacion)
        {
            Console.WriteLine("Nota ingresada: " + nota);
            Console.WriteLine("Clasificación: " + clasificacion);
        }

        // Punto de entrada del programa
        static void Main(string[] args)
        {
            Console.Write("Ingrese la nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (EsNotaValida(nota))
            {
                string clasificacion = ClasificarNota(nota);
                MostrarReporte(nota, clasificacion);
            }
            else
            {
                Console.WriteLine("Error: la nota debe estar entre 0 y 20.");
            }
        }
    }
}
