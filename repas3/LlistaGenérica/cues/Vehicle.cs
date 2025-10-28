using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cues
{
    public class Vehicle
    {
        public int id;
        public int preu;
        public string nom;
        public string color;
        public Vehicle(int id, int preu, string nom, string color)
        {
            this.id = id;
            this.preu = preu;
            this.nom = nom;
            this.color = color;

        }

        public override string ToString()
        {
            return "Id: " + id + ", Nom: " + nom + ", Color: " + color + ", Preu: " + preu;
        }
    }
}
