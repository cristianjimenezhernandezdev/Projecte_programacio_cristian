using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llistes
{
    class Program
    {
        static void Main(string[] args)
        {
            Llista lg = new Llista();
            lg.Inserir(1, 10);
            lg.Inserir(2, 20);
            lg.Inserir(3, 30);
            lg.Inserir(2, 15);
            lg.Inserir(1, 115);
            lg.Imprimir();
            Console.WriteLine("Després de Borrar el primer");
            lg.Borrar(1);
            lg.Imprimir();
            Console.WriteLine("Després d'extreure el segon");
            lg.Extreure(2);
            lg.Imprimir();
            Console.WriteLine("Després d'Intercambiar el primer amb el tercer");
            lg.Intercanviar(1, 3);
            lg.Imprimir();
            if (lg.Existeix(10))
            {
                Console.WriteLine("Es troba el 10 dins lista");
            }
            else
            {
                Console.WriteLine("No es troba el 10 dins lista");
            }
            Console.WriteLine("La posició del més gran es:" + lg.PosMesGran());
            if (lg.Ordenada())
            {
                Console.WriteLine("La lista está ordenada de menor a major");
            }
            else
            {
                Console.WriteLine("La lista no está ordenada de menor a major");
            }
            Console.ReadKey();
        }
    }
}
