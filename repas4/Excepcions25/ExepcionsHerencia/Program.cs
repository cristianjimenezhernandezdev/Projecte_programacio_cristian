using ExceptionHerencia;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExepcionsHerencia
{
    internal class Program
    {
        static void Main(string[] args)

        {// el programa principal llegeix les dades del fitxer  les fica
            // en un arrayList i les mostra

            string nomFitxer = @"..\..\equips.txt";
            ArrayList arlEquips = new ArrayList();
            // cridem la funcio
            LlegirDades(nomFitxer, arlEquips);
            // mostrem les dades
            MostrarDades(arlEquips);
            // tenquam el programa
            Console.WriteLine(" FINAL del programa, apreti intro per sortir...");
            Console.ReadLine();
        }// final main

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
                    Equip e = new Equip(cad, sep);
                    arl.Add(e);// afegim els equips al arraylist
                }
            }
            catch (FileNotFoundException fe)
            {// atrapem la excepcio de fitxer no trobat
                Console.WriteLine(" Fitxer :{0} no trobat ", fe.FileName);
                Console.WriteLine(" Excepcio : {0} ", fe.Message);
            }
            catch (ExcepcioEquip eeq)
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
            foreach (Equip e in arl)
            {
                Console.WriteLine("{0}", e.ToString());
            }
        }

    }
}
