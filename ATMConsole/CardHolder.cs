using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMConsole
{
    public class CardHolder
    {
        public String cardNum;
        public int pin;
        String FirstName;
        String LastName;

        double balance;

        //we create new variables, pass them into the constructor and initiate a new object
        public CardHolder(string cardNum, int pin, string firstName, string lastName, double balance)
        {
            this.cardNum = cardNum;
            this.pin = pin;
            FirstName = firstName;
            LastName = lastName;
            this.balance = balance;
        }


        public String getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public String getFirstName()
        {
            return FirstName;
        }
        public String getLastName()
        {
            return LastName;
        }

        public double getBalance()
        {
            return balance;
        }


        public void setPin(int new_pin)
        {

            pin = new_pin;
        }

        public void setFirstName(String new_firstName)
        {
            FirstName = new_firstName;
        }
        public void setLastName(String new_lastName)
        { LastName = new_lastName;}

        public void setBalance(double new_balance)
        { balance = new_balance; }

    }
}
