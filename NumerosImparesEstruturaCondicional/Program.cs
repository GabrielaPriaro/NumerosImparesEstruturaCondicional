//obs: Utilizando Estrutura Condicional For:
//Problema "sequencia_impares" (adaptado de URI 1067)
//Leia um valor inteiro X. Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o X, se for o caso. 

namespace NumerosImparesEstruturaCondicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;

            Console.Write("Digite o valor de X: ");
            x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++) 
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
