using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o valor referente ao lado do quadrado: ");
            double lado = double.Parse(Console.ReadLine());

            double area = Math.Pow(lado, 2);

            double perimetro = lado * 4;

            Console.WriteLine($"Área: {area} e Perimetro: {perimetro}.");
        }
    }
}