using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepcions25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 3, b = 0, c = 0;
            try
            {
                c = CalcularDivisio(a, b);
            }
            catch (Exception x)
            {
                Console.WriteLine(x.Message);
            }
            finally
            {
                Console.WriteLine(a + "/" + b + "=" + c);
            }
            Console.ReadKey();
        }
        static int CalcularDivisio(int numerador, int denominador)
        {
            if (denominador == 0)
                throw new Exception("El denominador NO debe ser cero");
            else
                return (numerador / denominador);
        }
    }
}
