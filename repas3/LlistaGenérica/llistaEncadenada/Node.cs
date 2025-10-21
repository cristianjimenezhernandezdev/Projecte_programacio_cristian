using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace llistaEncadenada
{
    public class Node
    {
        public int info;
        public Node seg;
        public Node(int valor)
        {
            info = valor;
            seg = null;
        }
    }
}
