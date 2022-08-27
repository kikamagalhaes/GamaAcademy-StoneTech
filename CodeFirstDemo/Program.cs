using CodeFirstDemo.DAL;
using System;

namespace CodeFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando e inicializando o banco de dados à partir do código C#...");
            using (var db = new EscolaContext())
            {
                new EscolaInitializer().InitializeDatabase(db);
            }
            Console.WriteLine("Concluído!");
            Console.ReadKey();
        }
    }
}
