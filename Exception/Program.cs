using System;

namespace DivisionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("División de dos números");

            try
            {
                Console.Write("Ingresa el numerador: ");
                double numerador = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingresa el denominador: ");
                double denominador = Convert.ToDouble(Console.ReadLine());

                double resultado = Dividir(numerador, denominador);
                Console.WriteLine($"Resultado: {resultado}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Formato de número inválido.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ocurrió un error inesperado.");
                Console.WriteLine($"Detalles: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Proceso de división finalizado.");
            }
        }

        static double Dividir(double numerador, double denominador)
        {
            if (denominador == 0)
                throw new DivideByZeroException("El denominador no puede ser cero.");

            return numerador / denominador;
        }
    }
}
