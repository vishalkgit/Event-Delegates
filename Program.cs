using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Delegates
{
    public delegate void GreaterAmount();
    public delegate void LowBalance();
    public delegate void ZeroBalance();

    public delegate void DisplayMessage();
    public class Program
    {

        static void GreaterAmount()
        {
            Console.WriteLine("Amount is greater than balance, cant deduct money");
        }

        static void LowBalance()
        {
            Console.WriteLine("Balance is less than 3000, cant deduct money");
        }

        static void ZeroBalance()
        {
            Console.WriteLine("Your account balance is zero");
        }
        static void Main(string[] args)
        {
            Bank bk=new Bank(5000);
            bk.GreaterAmount += new DisplayMessage(GreaterAmount);
            bk.LowBalance += new DisplayMessage(LowBalance);
            bk.ZeroBalance += new DisplayMessage(ZeroBalance);

            bk.Debit(6000);
            //bk.Credit(15000);



        }
    }
}
