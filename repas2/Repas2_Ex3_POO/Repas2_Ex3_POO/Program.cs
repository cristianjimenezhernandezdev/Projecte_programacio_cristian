using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repas2_Ex3_POO
{
    internal class Program
    {
        // Volem guardar informació per gestionar-la dins la nostra empresa.
        // Per una banda tenim Vehicles que poden ser cotxes o motos i, per una altra banda,
        // volem gestionar també les màquines que necessitem per produir. De tots aquests elements volem
        // portar la seva gestió de reserves i activar-les. D’aquesta manera el nostre programa ha de ser capaç
        // de reservar tant un vehicle com una màquina i en un moment donat, poder activar-los tots de cop.
        static void Main(string[] args)
        {
        }

        public class Vehicle
        {
            public int id;
            public string marca;
            public string matricula;
            public string estat;

            //fem el constructor
            public Vehicle(int idVehicle, string marcaVehicle, string matriculaVehicle)
            {
                id = idVehicle;
                marca = marcaVehicle;
                matricula = matriculaVehicle;
                estat = "lliure";
            }
            public class Cotxe : Vehicle
            {
                public int portes;
                public Cotxe(int idCotxe, string marcaCotxe, string matriculaCotxe, int numPortes) :
                    base(idCotxe, marcaCotxe, matriculaCotxe) 
                {
                    portes = numPortes;
                }
            }

            public class Moto : Vehicle
            {
                public int cilindrada;
                public int numReposapeus;
                public Moto(int idMoto, string marcaMoto, string matriculaMoto, int cilindradaMoto, int reposapeus)
                    : base(idMoto, marcaMoto, matriculaMoto) 
                {
                    cilindrada = cilindradaMoto;
                    numReposapeus = reposapeus;
                }
            }

            public class Maquinaria
            {
                public int id;
                public string nomM;
                public string estat;

                public Maquinaria(int idMaquina, string nomMaquina)
                {
                    id = idMaquina;
                    nomM = nomMaquina;
                    estat = "lliure";
                }
            }
    }
}
