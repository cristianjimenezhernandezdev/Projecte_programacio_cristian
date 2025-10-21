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

        public void Inserir(int info)
        {
            Node nou;
            nou = new Node();
            nou.info = info;
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

        public int Extreure()
        {
            if (!Buida())
            {
                int informacio = arrel.info;
                if (arrel == fons)
                {
                    arrel = null;
                    fons = null;
                }
                else
                {
                    arrel = arrel.seg;
                }
                return informacio;
            }
            else
            {
                return int.MaxValue;
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
