using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasa_directory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unos putanja mape
            Console.WriteLine("unesi putanju mape:");
           string putanja =  Console.ReadLine();

            // provjera da li mapa postoji
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Mapa postoji!");
                // ako postoji ispisuje sve datoteke u mapi
                Console.WriteLine("ispis datoteka:");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine(datoteka);
                }
                
               
                //putanja podmape
                string putanjaPodmape = putanja + "\\bla";

                //provjera da li podmapa postoji, ako ne postoji, kreiramo je
                if (!Directory.Exists(putanjaPodmape))
                {
                    Directory.CreateDirectory(putanjaPodmape);
                    Console.WriteLine("Mapa" + putanjaPodmape + "je napravljena.");
                }
                // ispis podmapa
                Console.WriteLine("ispis podmapa:");
                foreach (string podmapa in Directory.GetDirectories(putanja))
                {
                    Console.WriteLine(podmapa);
                }
                //brisanje podmape
                Directory.Delete(putanjaPodmape);
                Console.WriteLine("ispis podmapa nakon brisanja:");
                foreach(string podmapa in Directory.GetDirectories (putanja))
                {
                    Console.WriteLine(podmapa);

                }
            }



            // ako ne postoji, kreiramo mapu
            else
            {
                Directory.CreateDirectory(putanja);
                Console.WriteLine("Mapa" + putanja + "je napravljena!");
            }
            Console.ReadKey();

        }
    }
}
