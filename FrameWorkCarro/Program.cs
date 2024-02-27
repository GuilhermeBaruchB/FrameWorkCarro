using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrameWorkCarro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual o valor do combustível usado? ");
            int Valor = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual a distância percorrida na viagem? ");
            int Distância = int.Parse(Console.ReadLine());

            Console.WriteLine("Qual o consumo do seu veículo? ");
            int Consumo = int.Parse(Console.ReadLine());

            double resultado = (Distância /  Consumo) * Valor;

            Console.WriteLine("Você gastará: R$" + resultado);

            Console.ReadKey();
        }
    }
}
