using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repas2_Ex3_POO
{
    using System;
    using System.Timers;

    // Volem guardar informació per gestionar-la dins la nostra empresa.
    // Per una banda tenim Vehicles que poden ser cotxes o motos i, per una altra banda,
    // volem gestionar també les màquines que necessitem per produir. De tots aquests elements volem
    // portar la seva gestió de reserves i activar-les. D’aquesta manera el nostre programa ha de ser capaç
    // de reservar tant un vehicle com una màquina i en un moment donat, poder activar-los tots de cop.




    internal class Program
    {

        static void Main(string[] args)
        {
            {
              //Provem
                Vehicle.Cotxe c1 = new Vehicle.Cotxe(1, false, false, "Ford", "1234ABC", 5);
                Vehicle.Moto m1 = new Vehicle.Moto(2, false, false, "Yamaha", "5555AAA", 689, 2);
                Vehicle.Maquinaria maq1 = new Vehicle.Maquinaria(3, false, false, "Excavadora X");

                c1.ReservarCotxe();
                m1.ReservarMoto();
                maq1.ReservarMaquina();

                ActivarTots(c1 , m1, maq1);
            }

        }
        //Un metode per activar-los tots
        static void ActivarTots(Vehicle.Cotxe c, Vehicle.Moto m, Vehicle.Maquinaria maq)
        {
            c.Activar();
            m.Activar();
            maq.Activar();
        }


        //Classe que serveix per tots
        public class Item
        {
            public int id;
            public bool reservat;
            public bool actiu;
        

            public Item(int idItem, bool reservatInicial, bool actiuInicial)
            {
                id = idItem;
                reservat = reservatInicial;
                actiu = actiuInicial;
             
            }
            //Faig un mètode per la opcio d'activar que al estar dins del Item doncs servirà per tots els
            //objectes que heretin la classe
            public void Activar()
            {
                if (reservat && !actiu)
                {
                    actiu = true;
                    Console.WriteLine(id  + " activat.");
                }
                else
                {
                    Console.WriteLine(id  + " no es pot activar");
                }
            }
            public void Alliberar()
            {
                if (reservat || actiu)
                {
                    reservat = false;
                    actiu = false;
                    Console.WriteLine(id + " alliberat correctament.");
                }
                else
                {
                    Console.WriteLine(id + " ja estava lliure.");
                }
            }

            public void TreureReserva()
            {
                if (reservat)
                {
                    reservat = false;
                   
                    Console.WriteLine(id + " se li ha tret la reserva correctament.");
                }
                else
                {
                    Console.WriteLine(id + " ja estava lliure.");
                }
            }



        }

        //El vehicle el faig fill de Item i li afegeixo dos atributs propis, marca i matricula
        public class Vehicle : Item
        {
            public string marca;
            public string matricula;

            public Vehicle(int idVehicle, bool reservatInicial, bool actiuInicial, string marcaVehicle, string matriculaVehicle)
                : base(idVehicle, reservatInicial, actiuInicial)
            {
                marca = marcaVehicle;
                matricula = matriculaVehicle;
            }
            //la classe cotxe hereta atributs tant de vehicle com de Item i li afegeixo propietat única  portes
            public class Cotxe : Vehicle
            {
                public int portes;

                public Cotxe(int idCotxe, bool reservatInicial, bool actiuInicial, string marcaCotxe, string matriculaCotxe, int numPortes)
                    : base(idCotxe, reservatInicial, actiuInicial, marcaCotxe, matriculaCotxe)
                {
                    portes = numPortes;
                }
                //faig unmetode per reservar el cotxe i canviar el seu estat a reservat
                public void ReservarCotxe()
                {
                    if (!reservat)
                    {
                        reservat = true;
                        Console.WriteLine(id + " " + marca + " " + matricula + " reservat.");
                    }
                    else
                    {
                        Console.WriteLine(id + " " + marca + " " + matricula + " no es pot reservar.");
                    }
                }
            }

            //la classe cotxe hereta atributs tant de vehicle com de Item i li afegeixo dos propietats propies, cilindrada 
            //i numero de reposapeus
            public class Moto : Vehicle
            {
                public int cilindrada;
                public int numReposapeus;

                public Moto(int idMoto, bool reservatInicial, bool actiuInicial, string marcaMoto, string matriculaMoto, int cilindradaMoto, int reposapeus)
                    : base(idMoto, reservatInicial, actiuInicial, marcaMoto, matriculaMoto)
                {
                    cilindrada = cilindradaMoto;
                    numReposapeus = reposapeus;
                }
                //metode per reservar moto
                public void ReservarMoto()
                {
                    if (!reservat)
                    {
                        reservat = true;
                        Console.WriteLine(id + " " + marca + " " + matricula + " reservat.");
                    }
                    else
                    {
                        Console.WriteLine(id + " " + marca + " " + matricula + " no es pot reservar.");
                    }
                }
            }

            //la poso sota de la classe Item
            public class Maquinaria : Item
            {
                public string nom;
                public Maquinaria(int idMaquina, bool reservatInicial, bool actiuInicial, string nomMaquina)
                    : base(idMaquina, reservatInicial, actiuInicial)
                {
                    nom= nomMaquina;
                }
                //metode per reservar la maquina
                public void ReservarMaquina()
                {
                    if (!reservat)
                    {
                        reservat = true;
                        Console.WriteLine(id + " " + nom + " reservat.");
                    }
                    else
                    {
                        Console.WriteLine(id + " " + nom + " no es pot reservar.");
                    }
                }
            }
        }
    }
}


