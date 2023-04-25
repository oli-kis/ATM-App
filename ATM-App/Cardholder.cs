using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class Cardholder
    {
        public string cardnumber;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public Cardholder(string cardnumber, int pin, string firstName, string lastName, double balance)
        {
            this.cardnumber = cardnumber;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNumber()
        {
            return cardnumber;
        }
        public int getPin()
        {
            return pin;
        }
        public double getBalance()
        {
            return balance;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public void setNum(string newCardnumber)
        {
            cardnumber = newCardnumber;
        }
        public void setPin(int newPin)
        {
            pin = newPin;
        }
        public void setBalance(double newBalance)
        {
            balance = newBalance;
        }
    }
}