using Assign_LINQ_2.DataSource;
using Assign_LINQ_2.Models;
using static Assign_LINQ_2.DataSource.Source;
namespace Assign_LINQ_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Qustion 1
            //var top3Expensive = ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3);
            //foreach (var product in top3Expensive)
            //    Console.WriteLine($"{product.ProductName}: ${product.UnitPrice}");
            #endregion
            #region Question 2
            //int pageSize = 5;
            //int pageNumber = 2;
            //var pagedProducts =ProductList
            //    .Skip((pageNumber - 1) * pageSize)
            //    .Take(pageSize);
            //foreach (var product in pagedProducts)
            //    Console.WriteLine($"{product.ProductID}: {product.ProductName} - ${product.UnitPrice}");
            #endregion
            #region Question 3
            //var cheapProducts = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25);
            //foreach (var product in cheapProducts)
            //    Console.WriteLine($"{product.ProductName}: ${product.UnitPrice}");
            #endregion
            #region Question 4
            //bool allSeafoodInStock = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);
            //Console.WriteLine($"All Seafood products in stock: {allSeafoodInStock}");
            #endregion
            #region Question 5
            //int[] ids = { 3, 9, 13, 18 };
            //bool listContain9 = ids.Contains(9);
            //Console.WriteLine(listContain9);
            #endregion
        }
    }
}
