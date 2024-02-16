using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko dushi shte vivejdash?; ");
            int n=int.Parse(Console.ReadLine());
            string[] ime = new string[n];
            string[] items;


            for (int i = 0; i < n;i++)
            {
                Console.Write("Vivedi trite imena; ");
                ime[i] = Console.ReadLine();
                items = ime[i].Split(' ').ToArray();
               // string[] ime = Console.ReadLine().Split(' ').ToArray();
                Console.WriteLine("ime[{0}] = {1}", i, items[i]);
                Console.WriteLine("ime[{0}] = {1}", i + 1, items[i+1]);
                Console.WriteLine("ime[{0}] = {1}", i + 2, items[i+2]);
            }
            //Izhod 2: Izvejdane na elementi ot posledniq do pirviq
            for (int i = n - 1; i > 0; i--)
            { 
                
                items = ime[i].Split(' ').ToArray();
                Console.WriteLine("ime[{0}] = {1}", i + 2, items[i + 2]);
                Console.WriteLine("ime[{0}] = {1}", i + 1, ime[i + 1]);
                Console.WriteLine("ime[{0}] = {1}", i, items[i]);
            }
            //Izhod 3:
            for (int i = 0; i < n; i++)
            {
               
                items = ime[i].Split(' ').ToArray();
                Console.WriteLine("ime[{0}] = {1}", i, items[i]);
                Console.WriteLine("ime[{0}] = {1}", i + 2, items[i + 2]);
            }
        }
    }
}
