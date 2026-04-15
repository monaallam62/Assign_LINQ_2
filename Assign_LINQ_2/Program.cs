using static Assign_LINQ_2.DataSource.Source;
using Assign_LINQ_2.Models;
namespace Assign_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qustion 1
            var top3Expensive = ProductList
                .OrderByDescending(p => p.UnitPrice)
                .Take(3);
            foreach (var product in top3Expensive)
                Console.WriteLine($"{product.ProductName}: ${product.UnitPrice}");
            #endregion
        }
    }
}
