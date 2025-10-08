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
            /*Creem una classe que és publica de la tercera part, lliga. Definim les parts de la classe, 
             * el nom, una llista de la classe Equips. Fem els constructors que és el nom de la lliga i emplenem
             * la llista d'esquips amb la funcio del sistema .Add dins ell metode per afegir equip
             i al final posem funcio per mostrar el contingut igual que amb el dels equips amb un 
            foreach per recorrer la llista
             */
            public class Lliga
            {
                public string Nom;
                public List<Equip> Equips = new List<Equip>();

                public Lliga(string nom)
                {
                    Nom = nom;
                }

                public void AfegirEquip(Equip e)
                {
                    Equips.Add(e);
                }

                public void MostrarEquips()
                {
                    Console.WriteLine("Lliga: " + Nom);
                    if (Equips.Count == 0)
                    {
                        Console.WriteLine("OJO!!! No hi ha equips .");
                    }
                    else
                    {
                        foreach (var e in Equips)
                        {
                            e.Jequip();
                            Console.WriteLine();
                        }
                    }
                }
            }

            /*A din el program creo cada part, empleno llistes i ho mostro
             */
            class Program
            {
                static void Main()
                {
                    // Crear lliga de futbol
                    Lliga lligaFutbol = new Lliga("Futbol");

                    Equip equip1 = new Equip("FC Motero Malote", Esport.Futbol);
                    equip1.AfegirJugador(new Jugador("Oscar", 1, 69));
                    equip1.AfegirJugador(new Jugador("Julia Malote", 5, 27));
                    equip1.AfegirJugador(new Jugador("Profe cazabichos", 9, 32));

                    Equip equip2 = new Equip("Atlètic Campalans", Esport.Futbol);
                    equip2.AfegirJugador(new Jugador("Eric Roca", 10, 25));
                    equip2.AfegirJugador(new Jugador("Joan Mir", 7, 23));


                    lligaFutbol.AfegirEquip(equip1);
                    lligaFutbol.AfegirEquip(equip2);
                    

                    // Crear lliga de bàsquet
                    Lliga lligaBasquet = new Lliga("Bàsquet");

                    Equip equip3 = new Equip("CB Looney tunes", Esport.Basquet);
                    equip3.AfegirJugador(new Jugador("Alex Madrid", 01, 28));
                    equip3.AfegirJugador(new Jugador("Bugs Bunny", 23, 500));

                    Equip equip4 = new Equip("CB Campalans Stars", Esport.Basquet);
                    equip4.AfegirJugador(new Jugador("Ruben Crack", 01, 28));
                    equip4.AfegirJugador(new Jugador("Amigo del Ratóon", 23, 40));

                    lligaBasquet.AfegirEquip(equip3);
                    lligaBasquet.AfegirEquip(equip4);

                    // Crear lliga de Tennis
                    Lliga lligaTennis = new Lliga("Tennis");

                    Equip equip5 = new Equip("CT Los del tenis", Esport.Tennis);
                    equip5.AfegirJugador(new Jugador("El Gafas", 04, 28));
                    equip5.AfegirJugador(new Jugador("Soldado de invierno", 23, 500));

                    Equip equip6 = new Equip("CT 3 són Multitud", Esport.Tennis);
                    equip6.AfegirJugador(new Jugador("Numero 1", 01, 1));
                    equip6.AfegirJugador(new Jugador("Numero 2", 02, 2));

                    lligaTennis.AfegirEquip(equip5);
                    lligaTennis.AfegirEquip(equip6);
                    

                    // Mostrar Aqui com que esta muntat un sistema de funcions anidades que una mostra l'anterior
                    // executant la primera automàticament apareixeran les altres que estan dins
                    //fins arribar al final
                    lligaFutbol.MostrarEquips();
                    Console.WriteLine();
                    lligaBasquet.MostrarEquips();
                    Console.WriteLine();
                    lligaTennis.MostrarEquips();

                    Console.WriteLine("Gràcies");                    
                }
            }
        }
    }
}

