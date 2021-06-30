using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Account
    {
        //Attributs
        public string name;
        private string number;
        private double balance;
        public double uncovered;

        //Accesseurs / Modifieurs
        double Balance { get => balance; set => balance = value; }
        string Number { get => number; set => number = value; }

        //Constructeurs
        public Account(){
            name = "Compte indéfini";
            number = "000";
            balance = 0;
            uncovered = -100;
        }
        public Account(string _name, string _number, double _balance, double _uncovered){
            name = _name;
            number = _number;
            Balance = _balance;
            uncovered = _uncovered;
        }
        //méthodes
        public string getNumber
        {
            get
            {
                return number;
            }
        }
        public string  showInformations(){
            return "Nom: " + name + "\nNuméro de compte: " + number + "\nSolde: " + balance + "\nDecouvert Autorisé" + uncovered;
        }
        public void credit(int amount){
            this.balance += amount;
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
        public bool transfer(int amount, Account thisOne){
            bool enough;
            if (Balance - amount >= uncovered){
                this.debite(amount);
                thisOne.credit(amount);
                return true;
            }
            else{
                return false;
            }
        }
        public bool compare(Account thisOne) {
            if (this.Balance > thisOne.Balance){
                return true;
            }
            else {
                return false;
            }
        }
   
    }
}
