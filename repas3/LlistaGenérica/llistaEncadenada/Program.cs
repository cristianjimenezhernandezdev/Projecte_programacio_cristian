using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llistaEncadenada
{
    class Program
    {
        static void Main(string[] args)
        {
            Llista l = new Llista();
            Random r = new Random();

            for (int i = 0; i < 10; i++)
            {
                l.inserirOrdenat(r.Next(0, 50));
            }
            l.Mostrar();
            l.Ultim();
            Console.WriteLine(l.ActualValor());

            l.Primer();
            Console.WriteLine(l.ActualValor());

            Console.ReadKey();
        }
    }
}
