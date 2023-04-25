using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_App
{
    public class GUI
    {
        public void printOptions()
        {
            Console.WriteLine("Please choose one from the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Exit");
        }

        public void Deposit(Cardholder currentUser)
        {
            double deposit;
            while (true)
            {
                try
                {
                    Console.WriteLine("How much money would you like to deposit: ");
                    deposit = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter an amount of money.");
                }
            }
            currentUser.setBalance(deposit + currentUser.getBalance());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Thank you for your money. Your new Balance is: " + currentUser.getBalance());
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Withdraw(Cardholder currentUser)
        {
            double withdraw;
            while (true)
            {
                try
                {
                    Console.WriteLine("How much money would you like to withdraw: ");
                    withdraw = double.Parse(Console.ReadLine());
                    break;
                }
                catch
                {
                    Console.WriteLine("Please enter an amount of money.");
                }
            }

            if (withdraw > currentUser.getBalance())
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Your balance is to low, sorry :(");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdraw);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Thank you, here is your money. Your new Balance is: " + currentUser.getBalance());
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        public void Balance(Cardholder currentUser)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Current balance: " + currentUser.getBalance());
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}