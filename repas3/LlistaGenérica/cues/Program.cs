using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cues
{
    class Program
    {
        static void Main(string[] args)
        {
            Cua Cua1 = new Cua();
            Cua1.Inserir(5);
            Cua1.Inserir(10);
            Cua1.Inserir(50);
            Cua1.Imprimir();
            Console.WriteLine("Extraiem un de la Cua:" + Cua1.Extreure());
            Cua1.Imprimir();
            Console.ReadKey();
        }
    }
}
