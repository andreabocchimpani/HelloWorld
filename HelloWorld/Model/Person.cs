using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld.Model
{
    class Person
    {
        public string name;
        public string surname;
        public int age;
        public string sex;
        public int height;
        public double weight;
        
        public Person(string nome, string cognome)
        {
            this.name = nome;
            this.surname = cognome;
            this.sex = "sconosciuto";
        }

        public Person(string nome)
        {

        }

        public Person(string nome, string cognome, int altezza, double peso)
        {
            this.name = nome;
            this.surname = cognome;
            this.height = altezza;
            this.weight = peso;
        }

        public string Anagrafica()
        {
            if (CalculateBMI() != -1)
            {
                string anagrafica = "Nome: " + this.name + " " + " Cognome: " + this.surname + " BMI: " + CalculateBMI() + "\n";
                return anagrafica;
            }
            else
            {
                string anagrafica = "Nome: " + this.name + " " + " Cognome: " + this.surname + " BMI:BMI non disponibile \n";
                return anagrafica;
            }

        }

        public double CalculateBMI()
        {
            if (this.height == 0 || this.weight == 0)
            {
                return -1;
            }
            else
            {
                double altm = (double)this.height / 100;
                double bmi = this.weight / (altm * altm);
                return bmi;
            }
                
        }

    }
}
