using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_Ex2
{
    internal class Program
    {
        /*
        2. Fes un programa amb un bucle for, que mostri el següent

        0|x 1|xx 2|xxx 3|xxxx 4|xxxxx 5|xxxxxx 6|xxxxxxx 7|xxxxxxxx 8|xxxxxxxxx 9|xxxx
        xxxxx 10|

        Nota: La majoria de comentaris han estat posats amb chatgpt
        */
        static void Main(string[] args)
        {
            // Número màxim per al qual volem mostrar les línies (inclòs)
            int a = 10;

            // Cadena que conté la 'x' inicial; anirem afegint una 'x' per cada iteració
            string b = "x";

            // Variable temporal (no és necessària en aquest exemple, es deixa per compatibilitat)
            int temp = 0;

            // Bucle que recorre des de 0 fins a 'a' i mostra el nombre i la cadena corresponent
            for (int i = 0; i <= a; i++)
            {
                // Mostrem el número i la cadena 'b' separats per una barra vertical
                Console.Write($"{i}|{b} ");

                // Afegim una 'x' a la cadena per a la següent iteració
                b += "x";
            }


        }
    }
}
