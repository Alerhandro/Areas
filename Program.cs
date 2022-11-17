using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Areas
{
    class Program
    {
        static void Main(string[] args)
        {
            // autor:Alerhandro
            //calculo de areas
            //variaveis 

            Console.WriteLine("olá vamos calcular a area de um triangulo");
                        
            Console.WriteLine("Qual o tamanho da base");
            decimal Base = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("base; " + Base);

            Console.WriteLine("Qual a altura");
            decimal Altura = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("altura; " + Altura);

            
            decimal resultado = (Base * Altura) / 2;

            Console.WriteLine("area do triangulo; " + resultado);

            Console.WriteLine("agora um quadrado");

            Console.WriteLine("Qual a largura ");
            decimal largura = Convert.ToDecimal(Console.ReadLine());

            

            decimal Resultado = (largura * largura);

            Console.WriteLine("area do quadrado; " + Resultado);

            Console.ReadKey();










        }
    }
}
