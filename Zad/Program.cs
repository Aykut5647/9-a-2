using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Zadelqne na pamet
            double[] pari = new double[2];
            string[] vid_Zakuska = new string[2];
            //Vhod
            for (int i = 0;i < vid_Zakuska.Length;i++) 
            {
                Console.WriteLine("Vivedi zakuska;");
                vid_Zakuska[i]= Console.ReadLine();
                Console.WriteLine("Vivedi pari");
                pari[2]=double.Parse(Console.ReadLine()) ;
            }
            //Izhod
            for (int i = 0; i <2; i++)
            {
                int b=int.Parse(Console.ReadLine());
                Console.Write(vid_Zakuska[i] +"/"+ pari[i]);
            }
        }
    }
}
