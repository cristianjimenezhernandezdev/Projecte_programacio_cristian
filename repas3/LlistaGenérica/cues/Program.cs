using cues;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cues
{
    class Program
    {
        static void Main(string[] args)
        {
            Cua Cua1 = new Cua();

            Vehicle ve1 = new Vehicle(1,20000, "Cotxe", "Vermell");
            Vehicle ve2 = new Vehicle(2,15000, "Moto", "Blau");
            Vehicle ve3 = new Vehicle(3,30000, "Camio", "Verd");


            //Cua1.Inserir(ve1);
            //Cua1.Inserir(ve2);
            //Cua1.Inserir(ve3);
            
            // try { Cua1.Inserir(null); } catch (ExcepcioCua ex) { Console.WriteLine("Error de cua: " + ex.Message); }

            try
            {
                Console.WriteLine("Extraiem un de la Cua: " + Cua1.Extreure());
            }
            catch (ExcepcioCua ex)
            {
                Console.WriteLine("Error de cua: " + ex.Message);
            }
            Cua1.Imprimir();
            Console.ReadKey();
        }
        static void LlegirDades(string nomFitxer, ArrayList arl)
        {
            FileStream fs = null;
            StreamReader sr = null;
            try/* protegim la lectura*/
            {
                fs = new FileStream(nomFitxer, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string cad = "";
                char[] sep = { ',' };
                while ((cad = sr.ReadLine()) != null)
                {// fem servir el constructor amb 2 arguments una cadena i un separador
                    Cua e = new Cua(cad, sep);
                    arl.Add(e);// afegim els equips al arraylist
                }
            }
            catch (FileNotFoundException fe)
            {// atrapem la excepcio de fitxer no trobat
                Console.WriteLine(" Fitxer :{0} no trobat ", fe.FileName);
                Console.WriteLine(" Excepcio : {0} ", fe.Message);
            }
            catch (ExcepcioCua eeq)
            {// atrapem la nostra excepcio deguda a un mal format del fitxer
                // recuperem el missatge de la excepcio per saber quin equip
                // ens dona el problema. El primer equip que esta malament
                // fa que la lectura es pari i mostri el missatge
                Console.WriteLine(" tenim un problema amb l'equip {0}", eeq.Message);
            }
            catch (Exception eg)
            {// atrapem qualsevol altre excepcio 
                Console.WriteLine(" Error inesperat :{0}", eg.Message);
            }
            finally
            { // alliberem recursos si s'han fet servir
                if (sr != null)
                {
                    sr.Close();
                }
                if (fs != null)
                {
                    fs.Close();
                    fs.Dispose();
                }
            }

        }// final llegirDades
        static void MostrarDades(ArrayList arl)
        {
            foreach (Cua e in arl)
            {
                Console.WriteLine("{0}", e.ToString());
            }
        }
    }
}
