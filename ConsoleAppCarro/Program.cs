using System;

namespace ConsoleAppCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
           var carro = new Carro();
            carro.Liga();
            carro.Acelera(30);
            carro.Acelera(60);

            Console.WriteLine(carro.ligado);
            Console.WriteLine(carro.velocidade);

            var carro2 = new Carro();
            carro2.Liga();
         
            carro2.Acelera(110);


            Console.WriteLine(carro2.velocidade);


            Console.ReadLine();

        }
    }
}
