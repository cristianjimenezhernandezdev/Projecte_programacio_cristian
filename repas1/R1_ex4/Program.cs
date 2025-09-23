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

            //Versio 2
            //Es declara un string, es defineix la mida del que es mostra amb el for
            //Llavors fem servir la funcio substring inicia en 0 i que imprimeixi fins a la posicio i. 
            //d'aquesta manera acada volta va imprimint des de la primera lletra 0 fins a la lletra i, siguent el màxim la longitud de la paraula
            string text = "cadena";

            for (int i = 1; i <= text.Length; i++)
            {
                Console.WriteLine(text.Substring(0, i));
            }
            /*Versio 2
             És semblant a la 1 pero en cada volta imprimeix una a una les lletres amb j*/
            string text2 = "cadena";

            for (int i = 0; i < text2.Length; i++)
            {
                // imprimim de la posició 0 fins a la i
                for (int j = 0; j <= i; j++)
                {
                    Console.Write(text2[j]);
                }
                Console.WriteLine(); 
            }


        }
    }
}
