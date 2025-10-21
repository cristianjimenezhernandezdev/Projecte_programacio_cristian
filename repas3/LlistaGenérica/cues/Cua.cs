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
            if (arrel == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Inserir(Vehicle v1)
        {
            Node nou =new Node();
            Vehicle v=new Vehicle(v1.id, v1.preu,v1.nom, v1.color);
            nou.info = v;
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
            Console.WriteLine("Listado de todos los elementos de la Cua.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.seg;
            }
            Console.WriteLine();
        }
    }
}
