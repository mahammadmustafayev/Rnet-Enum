using EnumDisplay.Models;

namespace EnumDisplay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new();
            customer.GetDisplayName();
        }
    }
}