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
        }
    }
}
