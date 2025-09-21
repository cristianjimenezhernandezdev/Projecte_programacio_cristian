using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex3
{
    internal class Program
    {
        /*3.	Fes un programa per multiplicar tots els números entre dos valors llegits pel teclat, 
         * per exemple si poseu 1 i 4 farà 1*2*3*4. Vigileu per què si poseu números molt grans us podeu passar del tamany dels 
         * integers ( proveu-lo fins a 12). Si comenceu des de 1 i aneu fins al valor llegit esteu calculant el 
         * factorial del número llegit.
         * Nota: La majoria de comentaris han estat posats amb chatgpt*/


        static void Main(string[] args)
        {
            int a = 0;
            int b = 0;
            int temp = 0;
            int i = 0;
            Console.Write("Introdueix un número a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix un número b: ");
            b = Convert.ToInt32(Console.ReadLine());

     
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Números imparells:");
            for (i = a; i <= b; i++)
            {
                if (i % 2 != 0)   
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
