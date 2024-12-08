using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//code for Bank with Debit and Credit using Event And Delegates
namespace Event_Delegates
{

    

   
    public class Bank
    {
        public event DisplayMessage GreaterAmount;
        public event DisplayMessage LowBalance;
        public event DisplayMessage ZeroBalance;

        private float balance;
        private float amount;

        public Bank(float balance)
        {
            this.balance = balance;
        }

        public Bank()
        {
        }

        public void Debit(float amount)
        {
            if(balance==0)
            {
                ZeroBalance();
            }
            else if(balance<=3000)
            {
                LowBalance();
            }
            else if(amount>balance)
            {
                GreaterAmount();
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine($"Balance after debiting amount{amount} is {balance}");
            }
            
        }

        public void Credit(float amount)
        {
            balance=balance+amount;
            Console.WriteLine($"Balance after crediting {amount} is {balance}");
        }



    }
}
