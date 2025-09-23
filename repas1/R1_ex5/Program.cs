using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R1_ex5
{
    /*5.	Fes un programa que llegeixi un país i et digui la seva capital. 
     * El programa ha de tenir dos vectors un de països i un de capitals. Quan l’usuari escriu un país, 
     * el programa ha de comparar-lo amb cada un dels països que té el programa fins a trobar el índex corresponent. 
     * Després el programa mostrarà la seva capital.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] paisos = { "Espanya", "França", "Peru", "China", "Japo" };
            string[] capitals = { "Madrid", "París", "Lima", "Beijing", "Tokio" };

            Console.Write("Introdueix un país (o escriu 0 per sortir): ");
            string paisentrat = Console.ReadLine();

            while (paisentrat != "0")
            {
                bool trobat = false;
                int i = 0;

                while (i < paisos.Length && !trobat)
                {
                    if (paisentrat == paisos[i])  
                    {
                        Console.WriteLine($"La capital de {paisos[i]} és {capitals[i]}.");
                        trobat = true;
                    }
                    i++;
                }

                if (!trobat)
                {
                    Console.WriteLine("Aquest país no està a la llista.");
                }

                Console.Write("Introdueix un altre país (o 0 per sortir): ");
                paisentrat = Console.ReadLine();
            }
        }
    }

}

    


