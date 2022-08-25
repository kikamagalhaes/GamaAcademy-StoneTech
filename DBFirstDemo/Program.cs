using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFirstDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db = new LojaEntities())
            {
                //criando clientes e pedidos 
                Cliente cliente1 = new Cliente();
                {
                    Nome = "Tralala";
                    Email = "tralala@lontol.com";

                };
                db.Clientes.Add(cliente1);
                db.SaveChanges();

                Cliente cliente2 = new Cliente();
                {
                    Nome = "Ligoligo";
                    Email = "ligoligo@lileco.com";

                };
                db.Clientes.Add(cliente2);
                db.SaveChanges();

                Cliente cliente3 = new Cliente();
                {
                    Nome = "Telos";
                    Email = "telos@nunbol.com";

                };
                db.Clientes.Add(cliente3);
                db.SaveChanges();

                cliente1.Pedidoes.Add(new Pedido
                {
                    Item = "mesa",
                    Preco = 500
                });

                cliente2.Pedidoes.Add(new Pedido
                {
                    Item = "computador",
                    Preco = 1000
                });

                cliente3.Pedidoes.Add(new Pedido
                {
                    Item = "bola",
                    Preco = 20
                });

                db.SaveChanges();

                //LINQ = LANGUAGE INTEGRATED QUERY
                var query = from c in db.Clientes.Include("Pedidoes")
                            select c;

                foreach (var item in query)
                {
                    Console.WriteLine($"Cliente: {cliente.Nome}");
                    Console.WriteLine("Pedidos:");
                    Console.WriteLine("===========");
                    foreach (var p in cliente.Pedidoes)
                    {
                        Console.WriteLine($"Item: {p.Item}, Preço: {p.Preco}");
                    }

                }
                Console.WriteLine("Pressione qualquer tecla...");
                Console.ReadKey();
            }
        }
    }
}

