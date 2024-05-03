using programa3._3.Class;
using System;

class Program
{
    static void Main(string[] args)
    {
        int numero;
        bool inputCorrecto = false;

        do
        {
            Console.WriteLine("Ingrese un número entre 1 y 99:");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error: Por favor ingrese un número válido.");
            }
            else if (numero < 1 || numero > 99)
            {
                Console.WriteLine("Error: El número debe estar entre 1 y 99.");
            }
            else
            {
                inputCorrecto = true;
            }
        } while (!inputCorrecto);

        string resultado = VerificadorNumero.VerificarDigitos(numero);
        Console.WriteLine(resultado);

        Console.ReadLine();
    }
}