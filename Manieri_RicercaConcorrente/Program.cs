using System;
using System.Threading;

namespace Manieri_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
            Console.WriteLine("Inserire il numero da ricercare nell'array");
            int n = int.Parse(Console.ReadLine());
            riempiArray(array);
            Thread t1 = new Thread(() => ricercaNumero(n,array));
            t1.Start();
            


            Console.WriteLine("Inserire un altro numero da ricercare nell'array");
            int n2 = int.Parse(Console.ReadLine());
            ricercaNumero(n2, array);
            Console.ReadLine();
        }

        static void riempiArray(int[] array)
        {
            var random = new Random();

            for (int i = 0; i <= 99; i++)
                array[i]=(random.Next(100)); 
            
        }

        static void ricercaNumero(int n, int[] array)
        {
            for(int i = 0; i <=99; i++)
            {
                if (array[i] == n)
                {
                    Console.WriteLine($"Trovato in posizione {i}");
                }
            }

        }
    }
}
