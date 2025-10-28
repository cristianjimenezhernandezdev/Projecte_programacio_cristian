using cues;
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

            Vehicle ve1 = new Vehicle(1,20000, "Cotxe", "Vermell");
            Vehicle ve2 = new Vehicle(2,15000, "Moto", "Blau");
            Vehicle ve3 = new Vehicle(3,30000, "Camio", "Verd");
            

            //Cua1.Inserir(ve1);
            //Cua1.Inserir(ve2);
            //Cua1.Inserir(ve3);
            

            //Cua1.Imprimir();
                       
            Console.WriteLine("Extraiem un de la Cua: " + Cua1.Extreure());
            Cua1.Imprimir();
            Console.ReadKey();
        }
    }
}
