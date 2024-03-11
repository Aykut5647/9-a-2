using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] nomer = new int[n];
            string[] ime = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine();
            }
            Console.WriteLine("Normalen izhod");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nomer; ");
                nomer[i] = int.Parse(Console.ReadLine());
                Console.WriteLine("Ime; ");
                ime[i] = Console.ReadLine();

            }
            Console.WriteLine("Sortirane po nomer");
            for (int i = 0; i < nomer.Length - 1; i++)
            {
                for (int j = 0; j < nomer.Length - 1; j++)
                {
                    if (nomer[j] > nomer[j + 1])
                    {
                        int swapInt = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapInt;
                    }
                }
            }
            for (int i = 0; i < nomer.Length; i++)
            {
                Console.Write(nomer[i] + " ");
            }
            
            Console.WriteLine("Sortirane po nomer v nizhodqsht");
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (nomer[j] < nomer[j + 1])
                    {
                        int swapInt1 = nomer[j];
                        nomer[j] = nomer[j + 1];
                        nomer[j + 1] = swapInt1;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write(nomer[i] + " ");
            }

            Console.WriteLine("Sortirane po nomer(prqka selekciq)");
            for (int i = 1; i < nomer.Length; i++)
            {
                int k = i;

                for (int j = i + 1; j < nomer.Length; j++)
                {
                    if (nomer[j] < nomer[k])
                        k = j;
                }
                int swapInt2 = nomer[i];
                nomer[i] = nomer[k];
                nomer[k] = swapInt2;
            }
            Console.WriteLine(string.Join(" ", nomer ));
            Console.WriteLine(string.Join(" ",  ime));
        }
       

    }
}
