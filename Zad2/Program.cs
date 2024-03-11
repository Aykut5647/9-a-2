using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolko cisla shte vivejdash");
            int k =int.Parse(Console.ReadLine());
            Console.WriteLine("Kolko cisla shte previrtame");
            int n= int.Parse(Console.ReadLine());
            int r=int.Parse(Console.ReadLine());
            int[] sum= new int[k];
            for (int i = n-1; i <= k; i++)
            {
                sum[i] = 0;
                k = (i + r) % n;
                for (r=1;)
                for (k=1;)
                
               
            }

        }
    }
}
