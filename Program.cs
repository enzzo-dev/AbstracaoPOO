using System;
using AbstracaoPOO;

namespace AbstracaoPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            
            System.Console.WriteLine();

            Console.WriteLine("Digite o valor para pagar:");
            float valorProd = float.Parse(Console.ReadLine());
            System.Console.WriteLine(visa.Pagar(valorProd));

            System.Console.WriteLine();

            System.Console.WriteLine("Digite o acrescimo de limite:");
            visa.acrescimo = float.Parse( Console.ReadLine ());
            System.Console.WriteLine("Seu novo limite: ");
            Console.WriteLine(visa.AumentarLimite(5000, visa.acrescimo));

            System.Console.WriteLine($"O valor total é R${valorProd}, compre realizada em {visa.data}");

            
        }
    }
}
