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
            #region Question 6 
            //var groupedCategory = Source.ProductList.GroupBy(x => x.Category);

            //foreach (var group in groupedCategory) { 

            //    Console.WriteLine($"Category: {group.Key}");
            //    Console.WriteLine($"Count: {group.Count()}");                
            //}
            #endregion
            #region Question 7
            //var groupedCategory = Source.ProductList.GroupBy(x => x.Category);

            //foreach (var group in groupedCategory) { 
            //    Console.WriteLine($"Category: {group.Key}");

            //    foreach (var product in group)
            //    {
            //        Console.WriteLine(product.ProductName);
            //    }          
            //}
            #endregion
            #region Question 8
            //var moreThan3Produects = Source.ProductList.GroupBy(n => n.Category).
            //                                            Where(g => g.Count() > 3).
            //                                            Select(g => g.Key);

            //foreach(var category in moreThan3Produects)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region Quetion 9
            //var customers = from c in Source.CustomerList
            //                group c by c.Country into cGroup
            //                select new
            //                {
            //                    Country = cGroup.Key,
            //                    Count = cGroup.Count(),
            //                    TotalOrderValue = cGroup.Sum(o => o.Orders.Sum(o => o.Total))
            //                };
            //foreach (var customer in customers) { 
            //    Console.WriteLine($"Country: {customer.Country} - Count: {customer.Count} - Total: {customer.TotalOrderValue}");
            //}
            #endregion
            #region Question 10
            //int unitsInStock = Source.ProductList.Where(p => p.UnitsInStock > 0).Count();
            //Console.WriteLine(unitsInStock);
            #endregion
            #region Question11
            //decimal cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //decimal mostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);

            //Console.WriteLine($"The Cheapest: {cheapestPrice}");
            //Console.WriteLine($"The Most Expensive: {mostExpensivePrice}");

            #endregion
            #region Question12
            //var distinctCategory = Source.ProductList.Select(p => p.Category).Distinct();

            //Console.WriteLine("Distinct List: ");
            //foreach (var category in distinctCategory)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region Question13
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB);

            //foreach (int i in result) {
            //    Console.WriteLine(i);
            //}
            #endregion
            #region Question 14
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase);

            //foreach (var item in result) {
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Question15
            //var productDictionary = Source.ProductList.ToDictionary(u => u.ProductID);

            //var productSearch = productDictionary[18];
            //Console.WriteLine(productSearch);

            #endregion
            #region Question16
            //var firstGreaterThan50 = Source.ProductList.First(n => n.UnitPrice > 50);
            //Console.WriteLine(firstGreaterThan50);
            #endregion
            #region Question 17
            //var firstGreaterThan500 = Source.ProductList.FirstOrDefault(n => n.UnitPrice > 500);
            //Console.WriteLine(firstGreaterThan500);
            #endregion








        }
    }
}
