using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*6.	Fes un programa amb aquesta cadena “abcdefghijklmnopqrstuvxyz” que mostri el següent. 
             * Vigileu amb els límits de la cadena, recordeu que van entre 0 i cad.length-1 però adapteu-los a aquest problema. 
             * Podeu pensar igual que varem fer per fer el triangle de números amb files i columnes
             */
            //Versio 1 , pulida
            string alfabet = "abcdefghijklmnopqrstuvwxyz";   
            int max = alfabet.Length;                        // guardem la llargada màxima

            for (int fila = 0; 2 * fila + 1 <= max; fila++)
            {
                int longitud = 2 * fila + 1;                  /* 1,3,5,7,..
                                                               El valor longitud determina quina longitud te l'escrit en funcio de la fila
                on es troba, per exemple la fila 3 tindrà 8 de longitud maxima*/
                             

                int espais = (max - longitud) / 2;            // centrar la línia posant espais fent servir la longitud maxima de lafila
                // i la longitud total del string. 
                //Amb les variables que hem definit ja podem fer la part important que és escriure amb el writeline amb el format que volem.
                Console.WriteLine(new string(' ', espais) + alfabet.Substring(0, longitud));
            }

            //Versio 2, rudimentaria
            /* 
            * A cada fila calculem quantes lletres s’han d’escriure (1,3,5,…)
            * i també els espais que s’han de posar davant per centrar-ho.
            * Primer fem un bucle per posar els espais i després un altre per les lletres.
            * Al final fem un writeline per saltar de línia i continuar amb la següent. */

            string alfabet2 = "abcdefghijklmnopqrstuvwxyz"; 
            int max2 = alfabet2.Length;                        // guardem la llargada màxima


            for (int fila = 0; 2 * fila + 1 <= max2; fila++)
            {
                int longitud2 = 2 * fila + 1; 
                int espais2 = (max2 - longitud2) / 2;    
                // centrar la línia posant espais fent servir la longitud maxima de lafila
                // i la longitud total del string. 
                //Amb les variables que hem definit ja podem fer la part important que és escriure amb el writeline amb el format que volem.
                for (int i = 0; i < espais2; i++)               // fem un bucle per posar els espais
                {
                    Console.Write(" ");
                }
                // fem un bucle per escriure les lletres aplicant la logica del codi de
                // l'exercici anterior

                for (int j = 0; j < longitud2; j++)            
                {
                    Console.Write(alfabet2[j]);
                }
                Console.WriteLine();
            }
        }
    }
}
