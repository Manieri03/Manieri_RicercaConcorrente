using System;

namespace Manieri_RicercaConcorrente
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[100];
        }

        static void riempiArray(int[] array)
        {
            var random = new Random();

            for (int i = 0; i <= 99; i++)
                array[i]=(random.Next(100)); 
            
        }
    }
}
