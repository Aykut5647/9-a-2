using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _21._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //5 cisla celocisler tip
            int[] cisla= new int[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("");
                cisla[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(cisla[i]);
            }
            Console.WriteLine("Izhod bez posleden element");
            for (int i = 0; i < 4; i++ )
            {
                Console.WriteLine(cisla[i]);
            }
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(cisla[i]);
                Console.WriteLine();
            }
        }
    }
}
