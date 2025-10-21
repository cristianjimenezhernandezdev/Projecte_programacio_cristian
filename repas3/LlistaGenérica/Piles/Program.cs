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
            Pila pila1 = new Pila();
            pila1.Insertar(10);
            pila1.Insertar(40);
            pila1.Insertar(3);
            pila1.Imprimir();
            Console.WriteLine("Extraiem de la pila:" + pila1.Extreure());
            pila1.Imprimir();
            Console.ReadKey();
        }
    }
}
