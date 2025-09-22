using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4.	Feu un programa per escriure la cadena CADENA d’aquesta forma
            El programa demana 		Nom: cadena i mostra el triangle que es veu a continuació
            */
            //Versió 1
            string l1 = "c";
            string l2 = "a";
            string l3 = "d";
            string l4 = "e";
            string l5 = "n";
            string l6 = "a";

            Console.WriteLine(l1);
            Console.WriteLine(l1 + l2);
            Console.WriteLine(l1 + l2 + l3);
            Console.WriteLine(l1 + l2 + l3 + l4);
            Console.WriteLine(l1 + l2 + l3 + l4 + l5);
            Console.WriteLine(l1 + l2 + l3 + l4 + l5 + l6);

        }
    }
}
