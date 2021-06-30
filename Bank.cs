using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp5
{
    public class Bank
    {
        //Attribut(s)
        public Account[] myAccounts;
        public int nbAccounts;
        public string name;
        public string city;

        //Constructeur(s)
        public Bank(string _name, string _city){
            this.city = _city;
            this.name = _name;
            myAccounts = new Account[20];
            this.nbAccounts = 0;
        }
        //Méthode(s)
        private void addOne(Account _a1){
            this.myAccounts[nbAccounts] = _a1;
            nbAccounts++;
        }
        public void inIt(){
            Account c1= new Account("Bertrand","123456", -3000, 4500.50);
            Account c2 = new Account("Hoflack","223456", -200, 1500);
            Account c3 = new Account("Dupont","32456", -500, 1500);
            this.addOne(c1);
            this.addOne(c2);
            this.addOne(c3);
        }
        public override string ToString()
        {
            string accounts = "Les différents comptes de la banque " + this.name + " basée à " + city + "sont: ";
            for(int i=0; i < this.nbAccounts; i++){
                accounts += this.myAccounts[i].ToString() + "\n";
            }
            return accounts;
        }
        public Account returnAccount(string _accNumber){
            for(int i=0; i < this.nbAccounts; i++){
                if (_accNumber == myAccounts[i].getNumber){
                    return myAccounts[i];
                }
            }
            return null;
        }
        public bool transfer(string accdeb, string accben, double amount){
            if (returnAccount(accdeb) != null&& returnAccount(accben) != null){
                if (returnAccount(accdeb)).debite(amount) == true){

                }
            }
        }
    }
}
