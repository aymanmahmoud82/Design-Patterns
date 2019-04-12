using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    public class Loan :IAsset
    {
        public decimal Owed { get; set; }
        public decimal MonthlyPayment { get; set; }

        public void Accept(IVisitor visitor)
        {
           visitor.Visit(this);
        }
    }
}
