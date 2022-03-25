using System;
using System.Linq;

namespace ArrayTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] array2 = { 3, 8, 9, 6, 8, 5 };
            int[] array3 = { 4, 8, 6, 1, 3, 7 };

            CalculaCombinacoes(array1, alvo: 10);
            Console.WriteLine();

            CalculaCombinacoes(array2, alvo: 10);
            Console.WriteLine();

            CalculaCombinacoes(array3, alvo: 7);
            Console.ReadKey();
        }
        private static void CalculaCombinacoes(int[] array, int alvo)
        {
            int qtde = 0;

            foreach (var item in array)
            {
                foreach (var value in array.Skip(Array.IndexOf(array, item) + 1).Where(x => x + item == alvo))
                {
                    qtde++;
                    Console.WriteLine($"Combinação--> Posição: [{Array.IndexOf(array, item)} , {Array.IndexOf(array, value)}] Valores:[{item} , {value}]");
                }
            }
            Console.WriteLine($"");
            Console.WriteLine($"---------------------------");
            Console.WriteLine($"Total de combinações:{qtde}");
        }
    }
}
