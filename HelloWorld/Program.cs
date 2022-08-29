using System;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual é o seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine($"\nOlá {nome} ");
            Console.WriteLine("Seja bem vindo ao meu perfil!!");
        }
    }
}
