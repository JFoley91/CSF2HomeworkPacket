using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesLibrary
{
   public class CreditCardAccount
    {
        //frugal / fields

        //people / properties
        public int AccountNumber { get; set; }
        public Customer CustomerInfo { get; set; }
        public decimal Balance { get; set; }
        public bool IsPastDue { get; set; }
        public decimal AnnualIntrestRate { get; set; }

        //collect / constructors (ctors)

        public CreditCardAccount(int accountNumber, Customer customerInfo, decimal balance, bool isPastDue, decimal annualIntrestRate)
        {
            AccountNumber = accountNumber;
            CustomerInfo = customerInfo;
            Balance = balance;
            IsPastDue = isPastDue;
            AnnualIntrestRate = annualIntrestRate;
        }//end FQ CTOR

        //money / methods
        public override string ToString()
        {
            return $"Account Number:\n{AccountNumber}\n" +
                $"\n{CustomerInfo}\n" +
                $"Current Balance of: {Balance:c} is currently Past due? {IsPastDue}\n" +
                $"Intrest Rate: {AnnualIntrestRate}";
        }
    }//end class
}//end namespace
