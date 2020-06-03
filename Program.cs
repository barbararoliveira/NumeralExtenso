using System;
using Humanizer; 

namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Olá usuário, vou ajudá-lo a escrever qualquer número inteiro por extenso.");
            Console.WriteLine(" Pressione enter para continuar:");
            Console.ReadKey();

            Console.WriteLine("Digite algum número:");
            string number = (Console.ReadLine());
            int number2 = Convert.ToInt32(number);
            string nextenso = number2.ToWords();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{number} => {nextenso}");
        }
    }
}