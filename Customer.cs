using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid
{

    /// <summary>
    /// Example Shows SRP : Single Responsilbity Principle 
    /// Divide the Customer Class and Discount 
    /// Customer Class will have attributes related to Customer
    /// </summary>
    public class Customer
    {
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public decimal CalculateDiscount() 
        { 
            Discount discount = new Discount(); 
            return discount.CalculateDiscount(this);
        }
    }

}
