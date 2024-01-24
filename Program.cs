using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppTabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada = 0;

            Console.WriteLine("Escolha um número para ver a tabuada:");
            tabuada = int.Parse(Console.ReadLine());

            for (int numero = 0; numero <=10; numero++) 
            {
                Console.WriteLine($"{tabuada} x {numero} = {tabuada * numero}");
            }

            Console.ReadKey();
        }
    }
}
