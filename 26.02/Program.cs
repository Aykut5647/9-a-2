using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            double[] cena = new double[n];            
            int[] broy = new int[n];   
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Ime;");
                ime[i] = Console.ReadLine();
                Console.WriteLine("Cena;");
                cena[i] = double.Parse(Console.ReadLine());
                Console.WriteLine("Broy;");
                broy[i] = int.Parse(Console.ReadLine());
            }
            //Izhod 1
            for (int i = 0;i<n;i++)
            {
                Console.WriteLine(ime[i] + "/" + cena[i] + "/" + broy[i]) ;
            }
            //Izhod 2
            int pitieta = int.Parse(Console.ReadLine());
            for (int i = 0; i <= cena.Length; i++)
            {
                if (cena[i] > 2.50)
                {
                    Console.WriteLine(pitieta++);
                }
                
            } 
            //Izhod 3
            for (int i=0; i<n;i++)
            {
                if (cena[n] == 2)
                {
                    Console.WriteLine("Kafe");
                }
            }
            //Izhod 4
            Array.Sort(ime);
            for(int i=0; i < n; i++)
            {
            }
            //Izhod 5

            for (int i=0;i<n;i++)
            {

            }
            //Izhod 6
            int[] arr = { 1, 2, 3, 4 };
            int firstValue = 0;
            int middleValue = arr.Length / 2;
            int lastValue=arr.Length-1;
            for (int i=0;i<=arr.Length-1;i++)
            {
                Console.WriteLine(arr);
            }
            //Izhod 7
            for (int i = 0; i<n; i++)
            {
                Console.WriteLine();
            }

        }

    }
}
