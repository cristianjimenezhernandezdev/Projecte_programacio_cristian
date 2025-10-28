using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHerencia
{
    internal class Equip
    {// atributs
        private string _nom;
        private int _guanyats;
        private int _perduts;
        private int _empatats;
        // propietats
        public string nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public int guanyats
        {
            get { return _guanyats; }
            set { _guanyats = value; }
        }
        public int perduts
        {
            get { return _perduts; }
            set { _perduts = value; }
        }
        public int empatats
        {
            get { return _empatats; }
            set { _empatats = value; }
        }
        // constructors, en tindrem 3
        // el primer sense arguments
        // el segon amb 4 arguments
        // el tercer amb una cadena i un separador, de la que recuperarem els valors
        // aquest tercer constructor tindrà gestió d'excepcions
        public Equip()
        {
            this.nom = "";
            this.guanyats = 0;
            this.empatats = 0;
            this.perduts = 0;
        }
        public Equip(string xnom, int xg, int xe, int xp)
        {
            this.nom = xnom;
            this.guanyats = xg;
            this.empatats = xe;
            this.perduts = xp;
        }
        public Equip(string xcad, char[] xsep)
        {
            string[] vcad = null;
            try
            {
                vcad = xcad.Split(xsep);
                this.nom = vcad[0];
                this.guanyats = Int32.Parse(vcad[1]);
                this.empatats = Int32.Parse(vcad[2]);
                this.perduts = Int32.Parse(vcad[3]);
            }
            catch (Exception e)
            {
                string msg = "ERROR => " + xcad;
                throw (new ExcepcioEquip(msg, e));
            }
            finally
            {
                // no fem res
            }
        }
        public override string ToString()
        {
            string cad = "";
            cad = String.Format("{0,10} {1,3:d} {2,3:d} {3,3:d}", this.nom, this.guanyats, this.empatats, this.perduts);
            return cad;
        }

    }// final classe Equip

}
