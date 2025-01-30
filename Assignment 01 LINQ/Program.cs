using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.IO;

using static Assignment_01_LINQ.ListGenerators;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock. 

            //var OutOfStock = ProductList.Where(p => p.UnitsInStock == 0);

            //foreach (var unit in OutOfStock)
            //{
            //    Console.WriteLine(unit);
            //}
            #endregion
            #region 2. Find all products that are in stock and cost more than 3.00 per unit. 

            //var products = ProductList.Where(p => p.UnitPrice > 3 && p.UnitsInStock > 0);

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product);
            //}
            #endregion
            #region 3. Returns digits whose name is shorter than their value. 
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight","nine" };

            //var digits = Arr.Where(a => a.Length < Array.IndexOf(Arr, a));
            //foreach (var i in digits)
            //    Console.WriteLine(i);
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock
            //Product product = ProductList.FirstOrDefault(a => a.UnitsInStock == 0);
            //Console.WriteLine(product);
            #endregion
            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var product = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(product);
            #endregion
            #region 3. Retrieve the second number greater than 5
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int n = Arr.Where(a => a > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine(n);
            #endregion
            #endregion

            #region LINQ - Aggregate Operators 
            #region 1. Uses Count to get the number of odd numbers in the array
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int n = Arr.Count(a => a % 2 != 0);
            //Console.WriteLine(n);
            #endregion
            #region 2. Return a list of customers and how many orders each has. 
            //var customers = CustomerList.Select(a => new {CustomerInfo =  a, NumberOfOrders = a.Orders.Count() });
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine(customer);
            //}
            #endregion
            #region 3. Return a list of categories and how many products each has.
            //var categories =  ProductList.GroupBy(p => p.Category).Select(c => new { Category = c.Key, ProductCount = c.Count() });
            //foreach (var category in categories)
            //{
            //    Console.WriteLine(category);
            //}
            #endregion
            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = Arr.Count();
            //Console.WriteLine(total);
            #endregion
            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            // WHERE IS  dictionary_english.txt !!!!!! I create my own dictionary_english.txt

            //Read the File 
            // CHANGE THE PATH OF THE FILE 
            //var Path = "C:\\Users\\Ahmed Ramzy\\source\\repos\\Assignment 01 LINQ\\Assignment 01 LINQ\\dictionary_english.txt";

            //if (File.Exists(Path))
            //{
            //    string[] StrArray = File.ReadAllLines(Path);
            //    int CharCounter = 0;
            //    foreach (var item in StrArray)
            //    {
            //        CharCounter += item.Count();
            //    }
            //    Console.WriteLine(CharCounter);
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}




            #endregion
            #region 6. Get the total units in stock for each product category. 
            //var products = ProductList
            //                .GroupBy(p => p.Category)
            //                .Select(g => new { Category = g.Key, TotalUnitsInStock = g.Sum(p => p.UnitsInStock) });
            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Total Units In Stock: {category.TotalUnitsInStock}");
            //}
            #endregion
            #region 7. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 
            //var path = "C:\\Users\\Ahmed Ramzy\\source\\repos\\Assignment 01 LINQ\\Assignment 01 LINQ\\dictionary_english.txt";
            //if (File.Exists(path))
            //{
            //    string[] words = File.ReadAllLines(path);
            //    int shortestWordLength = words.Min(w => w.Length);
            //    Console.WriteLine($"Shortest word length: {shortestWordLength}");
            //}
            //else
            //{
            //    Console.WriteLine("dictionary_english.txt not found");
            //}
            #endregion
            #region 8. Get the cheapest price among each category's products
            //var products = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });

            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Cheapest Price: {category.CheapestPrice}");
            //}
            #endregion
            #region 9. Get the products with the cheapest price in each category (Use Let) 
            //var products = from p in ProductList
            //                                 group p by p.Category into g
            //                                 let minPrice = g.Min(p => p.UnitPrice)
            //                                 select new { Category = g.Key, Products = g.Where(p => p.UnitPrice == minPrice) };

            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}
            #endregion
            #region 10. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First). 
            //var path = "C:\\Users\\Ahmed Ramzy\\source\\repos\\Assignment 01 LINQ\\Assignment 01 LINQ\\dictionary_english.txt";
            //if (File.Exists(path))
            //{
            //    string[] words = File.ReadAllLines(path);
            //    int longestWordLength = words.Max(w => w.Length);
            //    Console.WriteLine($"Longest word length: {longestWordLength}");
            //}
            //else
            //{
            //    Console.WriteLine("dictionary_english.txt not found");
            //}
            #endregion
            #region 11. Get the most expensive price among each category's products.
            //var mostExpensivePriceByCategory = ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new { Category = g.Key, MostExpensivePrice = g.Max(p => p.UnitPrice) });

            //foreach (var category in mostExpensivePriceByCategory)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Most Expensive Price: {category.MostExpensivePrice}");
            //}
            #endregion
            #region 12. Get the products with the most expensive price in each category. 
            //var products = from p in ProductList
            //                group p by p.Category into g
            //                let maxPrice = g.Max(p => p.UnitPrice)
            //                select new { Category = g.Key, Products = g.Where(p => p.UnitPrice == maxPrice) };

            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category: {category.Category}");
            //    foreach (var product in category.Products)
            //    {
            //        Console.WriteLine(product);
            //    }
            //}
            #endregion
            #region 13. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var path = "C:\\Users\\Ahmed Ramzy\\source\\repos\\Assignment 01 LINQ\\Assignment 01 LINQ\\dictionary_english.txt";
            //if (File.Exists(path))
            //{
            //    string[] words = File.ReadAllLines(path);
            //    double averageWordLength = words.Average(w => w.Length);
            //    Console.WriteLine($"Average word length: {averageWordLength}");
            //}
            //else
            //{
            //    Console.WriteLine("dictionary_english.txt not found");
            //}
            #endregion
            #region 14. Get the average price of each category's products.
            //var products = ProductList
            //                .GroupBy(p => p.Category)
            //                .Select(g => new { Category = g.Key, AveragePrice = g.Average(p => p.UnitPrice) });

            //foreach (var category in products)
            //{
            //    Console.WriteLine($"Category: {category.Category}, Average Price: {category.AveragePrice}");
            //}
            #endregion
            #endregion

            #region LINQ - Ordering Operators
            #region 1. Sort a list of products by name 
            //var products = ProductList.OrderBy(p => p.ProductName);

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            #endregion
            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedArr = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedArr)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 3. Sort a list of products by units in stock from highest to lowest
            //var products =  ProductList.OrderByDescending(p => p.UnitsInStock).ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.UnitsInStock);
            //}
            #endregion
            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var digits = Arr.OrderBy(a => a.Length).ThenBy(a => a);

            //foreach (var i in digits)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion
            #region 5. Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var StrArray = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in StrArray)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest. 
            //var products =  ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice).ToList();

            //foreach (var product in products)
            //{
            //    Console.WriteLine($"Category : {product.Category}, UnitPrice : {product.UnitPrice}");
            //}
            #endregion
            #region 7. Sort first by word length and then by a case-insensitive descending sort of the words in an array.

            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var array =  Arr.OrderBy(a => a.Length).ThenByDescending(a => a, StringComparer.OrdinalIgnoreCase);

            //foreach (string str in array)
            //{
            //    Console.WriteLine(str);
            //}

            #endregion
            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var nums = Arr.Where(x => x[1] == 'i').Reverse();

            //foreach (var x in nums)
            //{
            //    Console.WriteLine(x);
            //}

            #endregion
            #endregion

            #region LINQ – Transformation Operators
            #region 1. Return a sequence of just the names of a list of products. 
            //var productNames = ProductList.Select(p => p.ProductName);

            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types). 
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var Words = words.Select(x => new { Upper = x.ToUpper(), Lower = x.ToLower() });

            //foreach (var word in Words)
            //{
            //    Console.WriteLine($"Upper : {word.Upper},  Lower : {word.Lower}");
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var productDetails = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });

            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"ProductName: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            //}

            #endregion

            #region 4. Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var IfValueMatch = Arr.Select((value, index) => new { value, index, InPlace = value == index });

            //foreach (var item in IfValueMatch)
            //{
            //    Console.WriteLine($"Number: {item.value}: In-place? {item.InPlace}");
            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };

            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { a, b };

            //Console.WriteLine("Pairs where a < b:");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.a} is less than {pair.b}");
            //}

            #endregion

            #region 6. Select all orders where the order total is less than 500.00. 
            //var orders = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"OrderID: {order.Id}, Total: {order.Total}");
            //}
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later. 
            //var orders = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"OrderID: {order.Id}, OrderDate: {order.OrderDate}");
            //}
            #endregion
            #endregion

            #region LINQ - Partitioning Operators 
            #region 1. Get the first 3 orders from customers in Washington 
            //var orders = CustomerList.Where(c => c.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Take(3);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"OrderID: {order.Id}, OrderDate: {order.OrderDate}, Total: {order.Total}");
            //}
            #endregion

            #region 2. Get all but the first 2 orders from customers in Washington. 
            //var orders = CustomerList.Where(c => c.City == "Washington")
            //    .SelectMany(c => c.Orders)
            //    .Skip(2);
            //foreach (var order in orders)
            //{
            //    Console.WriteLine($"OrderID: {order.Id}, OrderDate: {order.OrderDate}, Total: {order.Total}");
            //}
            #endregion

            #region 3. Return elements starting from the beginning of the array until a number that is less than its position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var nums =  numbers.TakeWhile((n, index) => n >= index);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4.Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var nums =  numbers.SkipWhile(n => n % 3 != 0);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var nums = numbers.SkipWhile((n, index) => n >= index);

            //foreach (var item in nums)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #endregion

            #region LINQ - Quantifiers 
            #region 1. Determine if any of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First) contain the substring 'ei'.
            //Read the File
            //CHANGE THE PATH OF THE FILE
            //var Path = "C:\\Users\\Ahmed Ramzy\\source\\repos\\Assignment 01 LINQ\\Assignment 01 LINQ\\dictionary_english.txt";
            //if (File.Exists(Path))
            //{
            //    string[] StrArray = File.ReadAllLines(Path);
            //    bool IsContain = StrArray.Any(a => a.Contains("ei"));
            //    Console.WriteLine(IsContain);
            //}
            //else
            //{
            //    Console.WriteLine("not found");
            //}

            #endregion

            #region 2. Return a grouped a list of products only for categories that have at least one product that is out of stock. 
            //var products = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.Any(p => p.UnitsInStock == 0));

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.Key);
            //    foreach (var p in product)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}

            #endregion

            #region 3. Return a grouped a list of products only for categories that have all of their products in stock.
            //var products = ProductList.GroupBy(p => p.Category)
            //    .Where(g => g.All(p => p.UnitsInStock > 0));

            //foreach (var product in products)
            //{
            //    Console.WriteLine(product.Key);
            //    foreach (var p in product)
            //    {
            //        Console.WriteLine(p);
            //    }
            //}
            #endregion
            #endregion
        }
    }
}
