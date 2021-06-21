using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    class Compte
    {
        //Attributs
        public string name;
        private int number;
        private double balance;
        public double uncovered;

        //Accesseurs / Modifieurs
        double Balance { get => balance; set => balance = value; }
        int Number { get => number; set => number = value; }

        //Constructeurs
        public Compte(){
            name = "Compte indéfini";
            number = 000;
            balance = 0;
            uncovered = -100;
        }
        public Compte(string _name, int _number, double _balance, double _uncovered){
            name = _name;
            number = _number;
            Balance = _balance;
            uncovered = _uncovered;
        }
        //méthodes
        public string showInformations(){
            return "Nom: " + name + "\nNuméro de compte: " + number + "\nSolde: " + balance + "\nDecouvert Autorisé" + uncovered;
        }
        public void credit(int amount){
            this.balance += amount;
            Console.WriteLine("Solde actuel: " + Balance + " euros.");
        }
        public bool debite(int amount){
            if (balance - amount >= uncovered){
                this.balance -= amount;
                return true;
            }
            else{
                Console.WriteLine("Crédit insuffisant.");
                return false;
            }
        }
        public bool transfer(int amount, Compte thisOne){
            bool enough;
            if (Balance - amount >= uncovered){
                this.debite(amount);
                thisOne.credit(amount);
                Console.WriteLine("Argent transféré");
                return true;
            }
            else{
                return false;
            }
        }
        public bool compare(Compte thisOne) {
            if (this.Balance > thisOne.Balance){
                Console.WriteLine("Le compte " + this.name + " est supérieur au compte :" + thisOne.name);
                return true;
            }
            else {
                Console.WriteLine("Le compte " + thisOne.name + " est supérieur au compte :" + thisOne.name);
                return false;
            }
        }
    }
}
