using HelloWorld.Model;
using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Value Type
            int numeroIntero;
            float numeroConLaVirgola32;
            double numeroConLaVirgola64;
            bool valoreLogico;
            char carattere;
            decimal valroeDecimale; //Valore preciso a 128 bit utilizzato nei calcoli monetari

            //Reference type
            string insiemeDiCaratteri;
            object oggetto;


            Person luca = new Person("Luca", "Lippi");
            luca.eta = 18;

            Console.WriteLine(luca.Anagrafica());

            Person giovanni = luca;
            giovanni.nome = "Giovanni";

            Console.WriteLine(luca.Anagrafica());
            Console.WriteLine(giovanni.Anagrafica());

        }
    }
}
