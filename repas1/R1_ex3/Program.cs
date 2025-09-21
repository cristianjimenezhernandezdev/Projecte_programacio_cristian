using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex3
{
    internal class Program
    {
        /*3.	Fes un programa per multiplicar tots els números entre dos valors llegits pel teclat, 
         * per exemple si poseu 1 i 4 farà 1*2*3*4. Vigileu per què si poseu números molt grans us podeu passar del tamany dels 
         * integers ( proveu-lo fins a 12). Si comenceu des de 1 i aneu fins al valor llegit esteu calculant el 
         * factorial del número llegit.
         * Nota: La majoria de comentaris han estat posats amb chatgpt*/

        static void Main(string[] args)
        {
            // Declaració de variables
            int a = 0;
            int b = 0;
         
            // Llegir valors des del teclat
            Console.Write("Introdueix un número a: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introdueix un número b: ");
            b = Convert.ToInt32(Console.ReadLine());

            // Càlcul del producte entre els dos nombres
            ProducteEntre(in a, in b, out int mult);
            Console.WriteLine($"El factorial de {b} menys {a} és {mult}");

            // Validació del rang
            if (!Validar(a, b))
            {
                Console.WriteLine("Error: no es poden multiplicar més de 11 nombres seguits.");
            }

            // Mostrar resultat
            Console.WriteLine($"La multiplicació del rang de numeros és: {ProducteEntre(in a, in b, out mult)}");
        }

        // Funció que calcula el producte entre dos nombres
        static int ProducteEntre(in int a, in int b, out int mult)
        {
            mult = 1;
            for (int i = a; i <= b; i++)
                mult *= i;
            return mult;
        }

        // Funció de validació simple del rang
        static bool Validar(int a, int b)
        {
            if ((b - a + 1) > 11)
            {
                return false;
            }
            return true;
        }        



}
}
