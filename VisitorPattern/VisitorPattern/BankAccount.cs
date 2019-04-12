using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class BankAccount :IAsset
    {
        public decimal Amount { get; set; }
        public decimal   MonthlyInterest { get; set; }

        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
