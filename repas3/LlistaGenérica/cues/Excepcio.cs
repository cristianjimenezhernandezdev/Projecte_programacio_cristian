using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cues
{
    internal class ExcepcioCua : ApplicationException
    {
        public ExcepcioCua()// constructor sense arguments
            : base() // crida el constructor de la classe mare
        {
        }
        // constructor amb una cadena, ens permet enviar una excepcio
        // amb un missatge donat per xmsg
        public ExcepcioCua(string xmsg)
            : base(xmsg)
        {
        }
        // constructor amb un missatge i una InnerException xe
        // la xe fa referencia a la excepcio que va originar aquesta
        public ExcepcioCua(string xmsg, Exception xe)
            : base(xmsg, xe)
        {

        }

    }
}