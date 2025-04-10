
using Solid;
public class Program {
    public static void Main()
    {
       
        Customer customer = new Customer();
        customer.Amount = 2500;
        Console.WriteLine(customer.CalculateDiscount());


    }
}
