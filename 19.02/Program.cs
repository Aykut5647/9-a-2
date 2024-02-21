using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Cikil s 5 elementa,
          
            int[] nomer = new int[5];
            string[] ime = new string[5];
            //vhod
            for (int i= 0; i<5 ; i++)
            { Console.WriteLine("Nomer; ");
               nomer[i]=int.Parse(Console.ReadLine());
                Console.WriteLine("Ime; ");
                ime[i]= Console.ReadLine();

            }
            //izhod
            for (int i=0; i<5; i++)
                
            {
                Console.WriteLine(nomer[i] + "/" + ime[i]);
            }
            //Izhod 2; Da iskara vsicki nomera nad 3
            for (int i = 0; i <5; i++)
            {
                if (nomer[i]>3)
                Console.WriteLine(nomer[i] + "/" + ime[i]);
            }
            //izhod 3
            Console.Write("Vivedi kakvo ime da tirsq;");
            string novoime=Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (ime[i] == novoime)
                {
                    Console.WriteLine(nomer[i] + ime[i]);
                }
                else
                {
                    Console.Write("Error");
                }
            }
        }
    }
}
