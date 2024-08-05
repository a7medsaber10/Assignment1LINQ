using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Runtime.ConstrainedExecution;
using System.Xml.Linq;
using static Assignment1LINQ.ListGenerator;

namespace Assignment1LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part1 [Restriction Operators]

            //1.Find all products that are out of stock.
            #region Q1
            //Console.WriteLine("List Of Products Out Of Stock: \n");
            //var productsOutOfStock = ProductsList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in productsOutOfStock)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
            #endregion

            //2.Find all products that are in stock and cost more than 3.00 per unit.
            #region Q2
            //Console.WriteLine("List Of products that are in stock and cost more than 3.00 per unit: \n");
            //var products = ProductsList.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);
            //foreach (var item in products)
            //{
            //    Console.WriteLine($"{item}\n");
            //}
            #endregion

            //3.Returns digits whose name is shorter than their value.
            #region Q3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            ////Query syntax
            ////var result = from index in Enumerable.Range(0, Arr.Length)
            ////             where Arr[index].Length < index
            ////             select index;

            //// Fluent syntax
            //var result = Enumerable.Range(0, Arr.Length).Where(index => Arr[index].Length < index);

            //Console.Write("Digit Whose Name is Shorter than their value: ");
            //foreach (var item in result)
            //{
            //    Console.Write($"{item} ");
            //}
            //Console.WriteLine();
            #endregion

            #endregion

            #region Part2 [Ordering Operators]
            //1.Sort a list of products by name
            #region Q1
            //var products = ProductsList.OrderBy(p => p.ProductName);
            //Console.WriteLine("Products ordered by Product Name: \n");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product}\n");
            //}
            #endregion

            //2.Uses a custom comparer to do a case -insensitive sort of the words in an array.
            #region Q2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var ordered = Arr.OrderBy(word => word.ToLower());
            //Console.WriteLine("Ordered Words : ");
            //foreach (var item in ordered)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            //3.Sort a list of products by units in stock from highest to lowest.
            #region Q3
            //var products = ProductsList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine("Products ordered by units in stock from highest to lowest: \n");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product}\n");
            //}
            #endregion

            //4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            #region Q4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var orderedArr = Arr.OrderByDescending(a => a.Length).ThenBy(a => a);
            //Console.WriteLine("sorted list first by length of their name, and then alphabetically by the name itself: \n");
            //foreach (var a in orderedArr)
            //{
            //    Console.WriteLine($"{a}\n");
            //}
            #endregion

            //5.Sort first by word length and then by a case-insensitive sort of the words in an array.
            #region Q5
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var orderedArr = words.OrderBy(w => w.Length).ThenBy(w => w.ToLower());
            //Console.WriteLine("sorted list first by word length and then by a case-insensitive: \n");
            //foreach (var a in orderedArr)
            //{
            //    Console.WriteLine($"{a}\n");
            //}
            #endregion

            //6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            #region Q6
            //var oreredProducts = ProductsList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //Console.WriteLine("list of products, first by category, and then by unit price, from highest to lowest: \n");
            //foreach (var a in oreredProducts)
            //{
            //    Console.WriteLine($"{a}\n");
            //}
            #endregion

            //7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.
            #region Q7
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var orderedArr = words.OrderBy(w => w.Length).ThenByDescending(w => w.ToLower());
            //Console.WriteLine("sorted list first by word length and then by a case-insensitive descending: \n");
            //foreach (var a in orderedArr)
            //{
            //    Console.WriteLine($"{a}\n");
            //}
            #endregion

            //8.Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            #region Q8
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var revArrWithSecondCharI = Arr.Where(w => w[1] == 'i').Reverse();
            //Console.WriteLine("list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array: \n");
            //foreach (var a in revArrWithSecondCharI)
            //{
            //    Console.WriteLine($"{a}\n");
            //}
            #endregion

            #endregion
        }
    }
}
