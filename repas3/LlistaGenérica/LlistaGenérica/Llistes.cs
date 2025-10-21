using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Llistes
{
    class Llista
    {
        class Node
        {
            public int info;
            public Node seg;
        }

        private Node arrel;

        public Llista()
        {
            arrel = null;
        }

        public void Inserir(int pos, int x)
        {
            if (pos <= Quantitat() + 1)
            {
                Node nou = new Node();
                nou.info = x;
                if (pos == 1)
                {
                    nou.seg = arrel;
                    arrel = nou;
                }
                else
                    if (pos == Quantitat() + 1)
                {
                    Node reco = arrel;
                    while (reco.seg != null)
                    {
                        reco = reco.seg;
                    }
                    reco.seg = nou;
                    nou.seg = null;
                }
                else
                {
                    Node reco = arrel;
                    for (int f = 1; f <= pos - 2; f++)
                    {
                        reco = reco.seg;
                    }
                    Node seguent = reco.seg;
                    reco.seg = nou;
                    nou.seg = seguent;
                }
            }
        }

        public int Extreure(int pos)
        {
            if (pos <= Quantitat())
            {
                int informacio;
                if (pos == 1)
                {
                    informacio = arrel.info;
                    arrel = arrel.seg;
                }
                else
                {
                    Node reco;
                    reco = arrel;
                    for (int f = 1; f <= pos - 2; f++)
                    {
                        reco = reco.seg;
                    }
                    Node proper = reco.seg;
                    reco.seg = proper.seg;
                    informacio = proper.info;
                }
                return informacio;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public void Borrar(int pos)
        {
            if (pos <= Quantitat())
            {
                if (pos == 1)
                {
                    arrel = arrel.seg;
                }
                else
                {
                    Node reco;
                    reco = arrel;
                    for (int f = 1; f <= pos - 2; f++)
                        reco = reco.seg;
                    Node proper = reco.seg;
                    reco.seg = proper.seg;
                }
            }
        }

        public void Intercanviar(int pos1, int pos2)
        {
            if (pos1 <= Quantitat() && pos2 <= Quantitat())
            {
                Node reco1 = arrel;
                for (int f = 1; f < pos1; f++)
                {
                    reco1 = reco1.seg;
                }
                Node reco2 = arrel;
                for (int f = 1; f < pos2; f++)
                {
                    reco2 = reco2.seg;
                }
                int aux = reco1.info;
                reco1.info = reco2.info;
                reco2.info = aux;
            }
        }

        public int MesGran()
        {
            if (!Buida())
            {
                int may = arrel.info;
                Node reco = arrel.seg;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                    }
                    reco = reco.seg;
                }
                return may;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int PosMesGran()
        {
            if (!Buida())
            {
                int may = arrel.info;
                int x = 1;
                int pos = x;
                Node reco = arrel.seg;
                while (reco != null)
                {
                    if (reco.info > may)
                    {
                        may = reco.info;
                        pos = x;
                    }
                    reco = reco.seg;
                    x++;
                }
                return pos;
            }
            else
            {
                return int.MaxValue;
            }
        }

        public int Quantitat()
        {
            int cant = 0;
            Node reco = arrel;
            while (reco != null)
            {
                reco = reco.seg;
                cant++;
            }
            return cant;
        }

        public bool Ordenada()
        {
            if (Quantitat() > 1)
            {
                Node reco1 = arrel;
                Node reco2 = arrel.seg;
                while (reco2 != null)
                {
                    if (reco2.info < reco1.info)
                    {
                        return false;
                    }
                    reco2 = reco2.seg;
                    reco1 = reco1.seg;
                }
            }
            return true;
        }

        public bool Existeix(int x)
        {
            Node reco = arrel;
            while (reco != null)
            {
                if (reco.info == x)
                    return true;
                reco = reco.seg;
            }
            return false;
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

        public void Imprimir()
        {
            Node reco = arrel;
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.seg;
            }
            Console.WriteLine();
        }
    }
}
