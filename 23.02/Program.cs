using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _23._02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //shte vivejdame cikil s 3 elementa,kato vitre v cikila shte vivejdame predmet i cas

            int[] cas = new int[3];
            string[] predmet = new string[3];
            //Vhod
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Predmet: ");
                predmet[i] = Console.ReadLine();
                Console.WriteLine("Cas: ");
                cas[i] = int.Parse(Console.ReadLine());
            }
            //Izhod 1
            for (int i = 0; i < 3; i++)
            {
                Console.Write(cas[i] + predmet[i]);
            }
            //Izhod 2
            for (int i = 0; i < 3; i++)
            {
                if (cas[i] >= 4)
                {
                    Console.WriteLine(cas[i] + predmet[i]);
                }
            }
            //Izhod 3; Sortirane ot malko kim golqmo
            Array.Sort(cas);
            for (int i = 0; i < 3; i++)
            {
            }
            //Izhod 4;
            Array.Sort(predmet);
            for (int i = 0; i < 3; i++)
            {
            }
            //Izhod 5
            Array.Reverse(cas);
            for (int i = 0; i < 3; i++)
            {
            }
            //Izhod 6
            string nov_predmet = "Matematika";
            for (int i = 0; i < 3; i++)
            {
                if (predmet[i] == nov_predmet)
                {
                }

            }
            //Izhod 7; Dannite na 2ya covek
            for (int i = 0; i < 2; i++)
            {
                predmet[i] = Console.ReadLine();
                cas[i]=int.Parse(Console.ReadLine());
            }
        }
    }
}
