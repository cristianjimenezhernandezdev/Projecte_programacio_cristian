using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// Classe que representa una Llista encadenada ordenada de Nodes
/// 
/// </summary>
namespace llistaEncadenada
{
    class Llista
    {
        Node primer;
        Node actual;

        public Llista()
        {
            primer = null;
            actual = null;
        }
        /// <summary>
        /// Mètode per inserir ordenadament en ordre ascendent
        /// </summary>
        /// <param name="valor"></param>
        public void inserirOrdenat(int valor)
        {
            ///Necessitem gaurdar el node anterior per poder afegir entre mig de dos nodes
            Node anterior;
            Node nou = new Node(valor);

            ///Si és buida o només hi ha un element i el valors que em passen és més petit que l'element 
            if(EsBuida() || primer.info > valor)
            {
                nou.seg = primer;
                primer = nou;
            }
            ///Si hi ha mes elements hem de recòrrer l'estructura per trobar el lloc 
            else
            {
                ///Guardem anterior per poder afegir entre dos nodes
                anterior = primer;
                ///Mentres no sigui l'últim elemente i l'element actual(anterior.seg.info) sigui mes petit que valor
                while(anterior.seg != null && anterior.seg.info <= valor)
                {
                    ///Ens desplacem al seguent element
                    anterior = anterior.seg;
                }
                ///El nou element apunta a on apuntaba l'element anterio
                nou.seg = anterior.seg;
                ///L'element anterior apunta al nou element
                anterior.seg = nou;
            }
        }
        /// <summary>
        /// Métode per mostrar tota la informació de l'estructura
        /// </summary>
        public void Mostrar()
        {
            Node aux = primer;
            while(aux!=null)
            {
                Console.Write("{0}->",aux.info);
                aux = aux.seg;
            }
            Console.Write("null");
            Console.WriteLine();
        }
        
        /// <summary>
        /// Métode que ens retorna l'últim element de l'extructura, en aquest cas el màxim
        /// </summary>
        public void Ultim()
        {
            ///Node per recorrer(actual) apunta al primer element
            actual = primer;
            ///Si hi ha elements
            if(!EsBuida())
            {
                ///Mentre no sigui l'últim element(actual.seg != null)
                while (actual.seg != null)
                {
                    Seguent();
                }
            }
        }
        /// <summary>
        /// Retorna el primer element que equival al mínim o més petit en aquest cas
        /// </summary>
        public void Primer()
        {
            if (!EsBuida())
            {
                actual = primer;
            }
        }

        ///
        public bool Actual()
        {
            if (actual != null)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Retorna la informació de l'element actual
        /// </summary>
        /// <returns></returns>
        public int ActualValor()
        {
            if (Actual())
            {
                return actual.info;
            }
            else
            {
                return int.MaxValue;
            }
        }

        /// <summary>
        /// Desplacem l'element actual a la seguent posició
        /// </summary>
        public void Seguent()
        {
            if (Actual())
            {
                actual = actual.seg;
            }
        }

        /// <summary>
        /// Retorna true si l'estructura és buida
        /// </summary>
        /// <returns></returns>
        public bool EsBuida()
        {
            bool retorn = false;
            if (primer == null)
            {
                retorn = true;
            }
            return retorn;
        }

    }
}
