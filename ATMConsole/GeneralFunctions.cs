using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    public class GeneralFunctions
    {
        public static void printOptions()
        {
           
            Console.WriteLine(new string('-', 50));
            Console.WriteLine("\tMain Menu:");
            Console.WriteLine("[Please choose one of the following options ->]\n");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
            Console.WriteLine(new string('-', 50));
        }

        public static void deposit( CardHolder currentUser)
        {
            Console.WriteLine("Enter your amount to deposite: ");
            string? input = Console.ReadLine();

            try
            {
                
                if (input != null) {
                    double deposit = Double.Parse(input);
                    currentUser.setBalance(deposit);
                    Console.WriteLine($"Your balance was updated, current balance is:{currentUser.getBalance() }");
                }
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                Console.WriteLine($"{ex.Message}");
            }

         
        }

        public static void withdraw(CardHolder currentUser) 
        {
            Console.WriteLine("Enter your amount to withdraw: ");
            string? input = Console.ReadLine();

            try
            {

                if (input != null)
                {
                    double withdraw = Double.Parse(input);

                    //check if there is enought money
                    if(currentUser.getBalance() > withdraw) { 

                    currentUser.setBalance((currentUser.getBalance() - withdraw));
                    Console.WriteLine($"Your balance was updated, current balance is:{currentUser.getBalance()}");
                    }
                    else
                    {
                        throw new DepositExeption("You don't have enough money to withdraw");
                    }
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input, please enter a valid number");
                Console.WriteLine($"{ex.Message}");
            }
        }

        public static void showBalance(CardHolder currentUser) 
        {
            Console.WriteLine($"Your current balance is: {currentUser.getBalance()}");
        }

        //a simple database
        public static List<CardHolder> initSimpleHolders()

        {
            List<CardHolder> cardHolders= new List<CardHolder>();

            cardHolders.Add(new CardHolder("4532772818527395", 1234, "John", "Snow", 9133.33));
            cardHolders.Add(new CardHolder("4532122818523211", 1234, "Mike", "Shell", 5363.33));
            cardHolders.Add(new CardHolder("4532672818521275", 1234, "Tom", "Lasly", 13433.33));
            cardHolders.Add(new CardHolder("4532982818525398", 1234, "Tim", "Nellic", 7313.33));
            cardHolders.Add(new CardHolder("4532552818526901", 1234, "Rany", "Krieger", 33133.33));


            return cardHolders;
        }


    }
}
