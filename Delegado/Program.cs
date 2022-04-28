using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegado
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isPrimoOrNot = delegate (int numero)
             {
                 int cont = 0;
                 for (int i = 1; i <= numero; i++)
                 {
                     if (numero % i == 0)
                     {
                         cont++;
                     }
                 }
                 if (cont == 2)
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             };
            int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int index = 0;
            for (int i=0;i < numeros.Length;i++)
            {
                if (isPrimoOrNot(numeros[i]))
                {
                    //Console.WriteLine($"Indice: { index} y su nummero {numeros[i]}");
                    index++;
                }
                Console.WriteLine($"Indice: { index} y su nummero {numeros[i]}");
            }
            //for (int i=0;i<=numeros.Length;i++)
            //{
            //    Console.WriteLine($"Indice: { index} y su nummero {numeros[i]}");
            //}
            Console.ReadLine();
        }
    }
}
