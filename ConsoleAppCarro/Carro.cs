using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppCarro
{
    public class Carro
    {
        //os campos são com letra minúscula e as propriedades com maiúscula.
        public int numeroDeRodas;
        public string modelo;
        public int numeroDePortas;
        public int velocidade = 0;
        public bool ligado = false;

        //os métodos também são com letras maiúsculas
        public void Acelera(int velocidadeAMais)
        {
            velocidade += velocidadeAMais;
            Console.WriteLine("Velocidade: " + velocidade + "Km/h");
        }
        public void Freia()
        {
            velocidade -= 10;
            if(velocidade < 0)
            {
                velocidade = 0;
            }
            Console.WriteLine("Velocidade: " + velocidade + "Km/h");
        }
        public void Liga()
        {

            ligado = true;
            Console.WriteLine("Ligou");
        }
        public void Desliga()
        {

            ligado = false;
            Console.WriteLine("Desligou");
        }
    }
}
