using System;

namespace VisitorPattern
{
    //https://www.codeproject.com/Articles/12508/Dude-are-you-still-programming-using-if-then-else
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Assets.Add(new BankAccount { Amount = 1000, MonthlyInterest = 0.01M });
            person.Assets.Add(new BankAccount { Amount = 2000, MonthlyInterest = 0.02M });
            person.Assets.Add(new Loan { MonthlyPayment = 40, Owed = 40000 });
            person.Assets.Add(new RealEstate { EstimatedValue = 79000, MonthlyRent = 500 });



            //Un refactored Code

            //decimal netWorth = 0;

            //foreach (var acct  in person.bankAccounts)
            //{
            //    netWorth += acct.Amount;
            //}

            //foreach (var loan in person.loans)
            //{
            //    netWorth -= loan.Owed;
            //}

            //foreach (var RE in person.realEstate)
            //{
            //    netWorth += RE.EstimatedValue;
            //}


            //Console.WriteLine(netWorth);



            NetWorth netWorth = new NetWorth();//visitor or fuctionality need to be added  or any new functionality
            person.Accept(netWorth);
            Console.WriteLine(netWorth.Total);
        }
    }
}
