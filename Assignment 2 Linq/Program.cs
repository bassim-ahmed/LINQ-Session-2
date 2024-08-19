using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;
using static Assignment_2_Linq.ListGenerators;
namespace Assignment_2_Linq
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region LINQ - Restriction Operators
            //var soldOutProducts = from p in ProductList
            //                      where p.UnitsInStock == 0
            //                      select p;

            //foreach (var product in soldOutProducts)
            //{
            //    Console.WriteLine(product);
            //}

            //var Result = from p in ProductList
            //                               where p.UnitsInStock > 0 && p.UnitPrice > 3.00M
            //                               select p;
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var shortDigits = digits.Where((digit, index) => digit.Length < index);
            //foreach (var d in shortDigits)
            //{
            //    Console.WriteLine(d);
            //}
            #endregion
            #region LINQ - Element Operators

            //var Result = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine(Result);
            //var Result = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine(Result);
            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = arr.Where(num => num > 5).Skip(1).FirstOrDefault();
            ////foreach (int num in Result)
            ////{
            ////    Console.WriteLine(num);
            ////}
            //Console.WriteLine(Result);
            #endregion
            #region LINQ - Aggregate Operators

            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int Result = arr.Count(num => num % 2 != 0);
            //Console.WriteLine($"The number of odd numbers in the array: {Result}");

            //var Result = CustomerList.Select(g => new{ ContactID = g.CustomerName, OrderCount = g.CustomerName.Count()});
            //       foreach (var item in Result)
            //       {
            //           Console.WriteLine($"Customer {item.ContactID} has {item.OrderCount} orders.");
            //       }

            //var Result = ProductList.Select(g => new { Category = g.Category, Count = g.ProductName.Count() });
            //foreach (var categoryCount in Result)
            //{
            //    Console.WriteLine($"{categoryCount.Category}: {categoryCount.Count} products");
            //}


            //int[] arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int total = arr.Sum();
            //Console.WriteLine(total);

            string[] wordArray = 
{
    "wwwwwwwww", "d", "aa", "aaa", "aah", "aahed", "aahing", "aahs",
    "aal", "aalii", "aaliis", "aals", "aam", "aani", "aardvark", "aardvarks",
    "aardwolf", "aardwolves", "aargh", "aaron", "aaronic", "aaronical",
    "aaronite", "aaronitic", "aarrgh", "aarrghh", "aaru", "aas", "aasvogel",
    "aasvogels", "ab", "aba", "ababdeh", "ababua", "abac", "abaca", "abacay",
    "abacas", "abacate", "abacaxi", "abaci", "abacinate", "abacination",
    "abacisci", "abaciscus", "abacist", "aback", "abacli", "abacot",
    "abacterial", "abactinal", "abactinally", "abaction", "abactor",
    "abaculi", "abaculus", "abacus", "abacuses", "abada", "abaddon",
    "abadejo", "abadengo", "abadia", "abadite", "abaff", "abaft", "abay",
    "abayah", "abaisance", "abaised", "abaiser", "abaisse", "abaissed",
    "abaka", "abakas", "abalation", "abalienate", "abalienated",
    "abalienating", "abalienation", "abalone", "abalones", "abama",
    "abamp", "abampere", "abamperes", "abamps", "aband", "abandon",
    "abandonable", "abandoned", "abandonedly", "abandonee", "abandoner",
    "abandoners", "abandoning", "abandonment", "abandonments", "abandons",
    "abandum", "abanet", "abanga", "abanic", "abannition", "abantes"
};

            //int totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine($"Total characters in the dictionary: {totalCharacters}");

            //string shortestWord = wordArray.OrderBy(word => word.Length).FirstOrDefault();

            //Console.WriteLine($"The shortest word in the dictionary: {shortestWord} (Length: {shortestWord.Length})");

            //string Result = wordArray.OrderByDescending(word => word.Length).FirstOrDefault();
            //Console.WriteLine($"The longest word in the dictionary: '{Result}' (Length: {Result.Length})");


            //double Result = wordArray.Average(word => word.Length);
            //Console.WriteLine(Result);


            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, TotalUnits = g.Sum(p => p.UnitsInStock) });
            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"{Item.Category}: {Item.TotalUnits} units");
            //}

            //var Result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, CheapestPrice = g.Min(p => p.UnitPrice) });
            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"{item.Category}: {item.CheapestPrice}");
            //}


            //var Result = from p in ProductList
            //                      group p by p.Category into g
            //                      let cheapestPrice = g.Min(p => p.UnitPrice)
            //                      from product in g
            //                      where product.UnitPrice == cheapestPrice
            //                      select product;

            //foreach (var Item in Result)
            //{
            //    Console.WriteLine($"Category: {Item.Category} | Product: {Item.ProductName} | Price: {Item.UnitPrice}");
            //}



            //var Result = from p in ProductList
            //             group p by p.Category into g
            //             let mostExpensivePrice = g.Max(p => p.UnitPrice)
            //             from product in g
            //             where product.UnitPrice == mostExpensivePrice
            //             select product;

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category} | Product: {item.ProductName} | Price: {item.UnitPrice}");
            //}




            //var Result = from p in ProductList
            //                    group p by p.Category into g
            //                    let averagePrice = g.Average(p => p.UnitPrice)
            //                    select new { Category = g.Key, AveragePrice = averagePrice };

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Category: {item.Category} | Average Price: {item.AveragePrice}");
            //}
            #endregion
            #region LINQ - Ordering Operators

            //var Result = ProductList.OrderBy(p => p.ProductName);

            //foreach (var product in Result)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} | Category: {product.Category}");
            //}



            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = Arr.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            //var sortedProducts = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} | Units in Stock: {product.UnitsInStock}");
            //}


            //string[] digitNames = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var sortedDigits = digitNames.OrderBy(d => d.Length).ThenBy(d => d);

            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}


            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            //var sortedWords = words.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}


            //var sortedProducts = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);

            //foreach (var product in sortedProducts)
            //{
            //    Console.WriteLine($"Product: {product.ProductName} | Category: {product.Category} | Price: {product.UnitPrice}");
            //}


            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


            //var sortedWords = words.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);

            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}


            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var Result = Arr.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            //foreach (var digit in Result)
            //{
            //    Console.WriteLine(digit);
            //}
            #endregion
            #region LINQ – Transformation Operators

            //var Result = ProductList.Select(p => p.ProductName);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}


            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry"};
            //var Result = words.Select(w => new
            //{
            //    Uppercase = w.ToUpper(),
            //    Lowercase = w.ToLower()
            //});
            //foreach (var word in Result)
            //{
            //    Console.WriteLine($"Uppercase: {word.Uppercase} | Lowercase: {word.Lowercase}");
            //}

            //var Result = ProductList.Select(p => new
            //{
            //    Name = p.ProductName,
            //    Category = p.Category,
            //    Price = p.UnitPrice 
            //});

            //foreach (var product in Result)
            //{
            //    Console.WriteLine($"Product: {product.Name} | Category: {product.Category} | Price: {product.Price}");
            //}


            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //for (int i = 0; i < Arr.Length; i++)
            //{
            //    bool matchesPosition = Arr[i] == i;
            //    Console.WriteLine($"{Arr[i]}:{matchesPosition}");
            //}



            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA
            //            from b in numbersB
            //            where a < b
            //            select new { NumberA = a, NumberB = b };

            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"({pair.NumberA} less than {pair.NumberB})");
            //}

            #endregion
            #region LINQ - Set Operators

            //var Result = ProductList.Select(p => p.Category).Distinct();
            //foreach (var category in Result)
            //{
            //    Console.WriteLine($"Category: {category}");
            //}

            //var Result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0])).Distinct();

            //var Result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));

            //var Result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));

            //var Result = ProductList.Select(p => p.ProductName[^3..]).Concat(CustomerList.Select(c => c.CustomerName[^3..]));
            #endregion
            #region LINQ - Partitioning Operators

            //var Result = CustomerList.Where(order => order.Region == "Washington").Take(3);



            //var Result = CustomerList.Where(order => order.Region == "Washington").Skip(2);
            //foreach (var order in Result)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderId}, Customer: {order.CustomerName}");
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.TakeWhile((n, i) => n >= i);

            //foreach (var num in result)
            //{
            //    Console.Write(num + " ");
            //}

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //int[] result = numbers.SkipWhile(num => num != 3).ToArray();
            //  foreach (int num in result)
            //{
            //    Console.WriteLine(num);
            //}


            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var Result = numbers.SkipWhile(n => n % 3 != 0);
            //foreach( var i in Result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region LINQ - Quantifiers

            //var words = File.ReadAllLines("dictionary_english.txt");

            //var Result = words.Any(w => w.Contains("ei"));


            //var Result = ProductList.GroupBy(p => p.Category).Where(c => c.Any(p => p.UnitsInStock == 0)).Select(p => p);

            //foreach (var categoryGroup in Result)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"  - {product.ProductName}");
            //    }
            //}


            //var Result = ProductList.GroupBy(p => p.Category).Where(c => c.All(p => p.UnitsInStock > 0)).Select(p => p);
            //foreach (var categoryGroup in Result)
            //{
            //    Console.WriteLine($"Category: {categoryGroup.Key}");
            //    foreach (var product in categoryGroup)
            //    {
            //        Console.WriteLine($"  - {product.ProductName}");
            //    }
            //}
            #endregion
            #region LINQ – Grouping Operators

            //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            //var Result = numbers.GroupBy(n => n % 5);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine($"Numbers with Remainder of {item.Key} when devided by 5:");
            //    foreach (var item1 in item)
            //    {
            //        Console.WriteLine(item1);
            //    }
            //}


            //List<string> words = new List<string>{ "apple", "banana", "cat", "dog", "elephant", "frog", "grape"};

            //var Result = from word in words
            //                   group word by word[0] into wordGroup
            //                   select wordGroup;
            //foreach (var group in Result)
            //{
            //    Console.WriteLine($"Words starting with '{group.Key}':");
            //    foreach (var word in group)
            //    {
            //        Console.WriteLine($"  {word}");
            //    }
            //}
            #endregion
        }
    }
}
