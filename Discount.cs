using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{
    /// <summary>
    /// Discount Class will Handle Discount Calculations
    /// </summary>
    public class Discount
    {
        public decimal CalculateDiscount(Customer c)
        {
            decimal amt = c.Amount;
            decimal finalAmount = c.Amount;
            decimal percent = 5;

            if (c.Amount > 1000) 
            {
                var discountPercentage = percent / 100;
                decimal discountAmt = amt * discountPercentage;
                finalAmount=amt-discountAmt;

            }
            return finalAmount;
        }
    }
}
