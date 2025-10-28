using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cues
{
    class Cua
    {
        private Node arrel, fons;

        public Cua()
        {
            arrel = null;
            fons = null;
        }

        public bool Buida()
        {
            return arrel == null;
        }

        public void Inserir(Vehicle v1)
        {
            Node nou = new Node();
            nou.info = v1; // guardar referència, no cal clonar
            nou.seg = null;
            if (Buida())
            {
                arrel = nou;
                fons = nou;
            }
            else
            {
                fons.seg = nou;
                fons = nou;
            }
        }

        public Vehicle Extreure()
        {
            if (!Buida())
            {
                Vehicle vehicle = arrel.info;
                if (arrel == fons)
                {
                    arrel = null;
                    fons = null;
                }
                else
                {
                    arrel = arrel.seg;
                }
                return vehicle;
            }
            else
            {
                Console.WriteLine("La cua esta buida");
                return null;
            }
        }

        public void Imprimir()
        {
            Node reco = arrel;
            Console.WriteLine("Llistat de tots els elements de la Cua:");
            while (reco != null)
            {
                Console.WriteLine(reco.info); // usa Vehicle.ToString()
                reco = reco.seg;
            }
            Console.WriteLine();
        }
    }
}
