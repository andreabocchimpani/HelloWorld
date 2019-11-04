using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string nome;
        public string cognome;
        public int eta;
        public string sesso;
        public int altezza;
        public double peso;
        
        public Person(string nome, string cognome)
        {
            this.nome = nome;
            this.cognome = cognome;
            this.sesso = "sconosciuto";
        }

        public Person(string nome)
        {

        }

        public string Anagrafica()
        {
            string anagrafica = this.nome + " " + this.cognome; 
            return anagrafica;
        }



    }
}
