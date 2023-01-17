// See https://aka.ms/new-console-template for more information


using ATMConsole;

public class Main_Runner
{

    public static void Main(string[] args)
    {
        

       

        String? debitCard = "";
        CardHolder? currentUser;

        while(true)
        {
            Console.WriteLine("Welcome to simple ATM:");
            Console.WriteLine("Please enter your debit card:");
            try
            {
                debitCard = Console.ReadLine();
                currentUser = GeneralFunctions.initSimpleHolders().FirstOrDefault(m => m.cardNum == debitCard);
                if (currentUser != null) 
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Card not recognized, try again");
                }
            }
            catch (DepositExeption e)
            {
                Console.WriteLine("Card not recognized, try again");
                Console.WriteLine(e.Message);
            }
        }

        Console.WriteLine("Please enter your PIN");

        int? userPIN = int.Parse(Console.ReadLine());

        while (true)
        {

            try
            {
                //userPIN = int.Parse(Console.ReadLine());
                //currentUser = GeneralFunctions.initSimpleHolders().FirstOrDefault(m => m.pin == userPIN);
                if (currentUser.getPin() == userPIN)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("PIN not recognized, try again");
                }
            }
            catch (DepositExeption e)
            {
                Console.WriteLine("PIN not recognized, try again");
                Console.WriteLine(e.Message);
            }
        }
        string fullName = currentUser.getFirstName() +" "+currentUser.getLastName();

        Console.WriteLine($"Welcome {fullName}!");

        int option = 0;
        do
        {
            GeneralFunctions.printOptions();
            try
            {
                option = int.Parse(Console.ReadLine());
                if(option == 1)
                {
                    GeneralFunctions.deposit(currentUser);
                }
                else if(option == 2)
                {
                    GeneralFunctions.withdraw(currentUser);
                }
                else if(option == 3)
                {
                    GeneralFunctions.showBalance(currentUser);
                }
                else if(option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }
                
            }
            catch { Console.WriteLine("Invalid input, try again"); }
        }
        while (option != 4);
        Console.WriteLine("Thank you, have a nice day!");

    }

}