using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_Ex2
{
    internal class Program
    {
        /*2.	Fes un programa amb un bucle for, que mostri el següent

0|x 1|xx 2|xxx 3|xxxx 4|xxxxx 5|xxxxxx 6|xxxxxxx 7|xxxxxxxx 8|xxxxxxxxx 9|xxxxx
xxxxx 10|

        Nota: La majoria de comentaris han estat posats amb chatgpt*/
        static void Main(string[] args)
        {
            int a = 10;
            string b = "x";
            int temp = 0;

            for (int i = 0; i <= a; i++)
            {
                Console.Write($"{i}|{b} ");
                b += "x";
            }

           

        }
    }
}
