using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasPOO
{
    /*1. Volem crear una aplicació que ens permeti gestionar lligues de diferents esports 
     * com futbol, hoquei, etc. Cada lliga tindrà equips a dins. Cada equip podrà ser de futbol, 
     * Bàsquet, tennis, etc, i tindrà un nom i un esport. A més els equips guardaran els jugadors 
     * que el componen. De cada jugador guardarem el seu nom, el dorsal i l'edat. 
     * El programa ens ha de mostrar quins equips hi ha a la lliga i de cada equip quina 
     * és la seva alineació.*/

    namespace GestioLligues
    {
        // Tipus d'esport
        public enum Esport { Futbol, Basquet, Hoquei, Tennis }

        // Classe Jugador
        public class Jugador
        {
            public string Nom;
            public int Dorsal;
            public int Edat;

            public Jugador(string nom, int dorsal, int edat)
            {
                Nom = nom;
                Dorsal = dorsal;
                Edat = edat;
            }

            public string VeureJugador()
            {
                return "Nom:" + Nom + "; Dorsal: " + Dorsal + "; Edat: " + Edat;
            }
        }

        // Equip declarem l'atribut Nom, cridem el enum del Esport, fem una Llista de Jugadors amb la classe
        // Jugador fem el constructor on li pasem el nom del equip que pot ser qualsevol i el de l'esport que és
        //el del enum. 
        //Fem servir la funcio de sistema .Add per afegir amb un metode un jugador a la llista. 
        //Quan creem un jugador, executem el metode i l'afegeix a la llista de Jugadors
        //Fem un metode per Mostrar l'equip
        public class Equip
        {
            public string Nom;
            public Esport Esport;
            public List<Jugador> Jugadors = new List<Jugador>();

            public Equip(string nom, Esport esport)
            {
                Nom = nom;
                Esport = esport;
            }

            public void AfegirJugador(Jugador j)
            {
                Jugadors.Add(j);
            }

            public void Jequip()
            {
                Console.WriteLine("Equip: " + Nom + " Esport: " + Esport);
                if (Jugadors.Count == 0)
                {
                    Console.WriteLine("  L'equip no te jugadors.");
                }
                else
                {
                    Console.WriteLine("  Jugadors de l'equip:");
                    foreach (var i in Jugadors)
                    {
                        Console.WriteLine("   - " + i.VeureJugador());
                    }
                }
            }
        }

    }
}

