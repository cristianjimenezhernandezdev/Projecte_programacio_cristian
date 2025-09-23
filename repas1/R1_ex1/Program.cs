using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex1
{
    internal class Program
    {
        //1.	Fes un programa per mostrar els imparells entre dos números llegits pel teclat abdos inclosos. 
     
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

            // Ens assegurem de començar pel més petit
            if (a > b)
            {
                temp = a;
                a = b;
                b = temp;
            }

            Console.WriteLine("Números imparells:");
            for (i = a; i <= b; i++)
            {
                if (i % 2 != 0)   // comprovem si és imparell
                {
                    Console.WriteLine(i);
                }
            }

        }
    }
}
