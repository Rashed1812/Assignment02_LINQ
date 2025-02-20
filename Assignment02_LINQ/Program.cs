using Assignment02_LINQ;
using System.Collections;
using System.Collections.Concurrent;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment02_LINQ.ListGenerator;



namespace Assignment02_LINQ
{
    class InsensitiveCompare : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
            throw new NotImplementedException();
        }
    
    }
    internal class Program
    {
        static void Main(string[] args)
        {
             string[] dic = File.ReadAllLines("dictionary_english.txt");


            #region LINQ - Restriction Operators
            #region 1. Find all products that are out of stock.
            //var result = ProducstList.Where(p => p.UnitsInStock==0);
            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 2. Find all products that are in stock and cost more than 3.00 per unit.
            //var result = ProducstList.Where(p => p.UnitPrice > 3 && p.UnitsInStock != 0);
            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 3. Returns digits whose name is shorter than their value.
            //String[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = Arr.Select((x, i) => new { Value = i, digit = x }).Where(a => a.digit.Length<a.Value);
            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item.Value);
            //} 
            #endregion
            #endregion

            #region LINQ - Element Operators
            #region 1. Get first Product out of Stock 
            //var result = ProducstList.FirstOrDefault(a=>a.UnitsInStock==0);
            //Console.WriteLine(result); 
            #endregion

            #region 2. Return the first product whose Price > 1000, unless there is no match, in which case null is returned.
            //var result = ProducstList.FirstOrDefault(a => a.UnitPrice>1000);
            //Console.WriteLine(result); 
            #endregion

            #region 3. Retrieve the second number greater than 5 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(a=> a>5).ElementAt(1);
            //Console.WriteLine(result); 
            #endregion

            #endregion

            #region LINQ - Aggregate Operators

            #region 1. Uses Count to get the number of odd numbers in the array

            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Where(a=>a%2 != 0).Count();
            //Console.WriteLine(result);
            #endregion

            #region 2. Return a list of customers and how many orders each has
            //var result = CustomersList.Select(c=> new { c.CustomerName, CountOfOrders = c.Orders.Count() }).ToList();

            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}

            #endregion

            #region 3. Return a list of categories and how many products each has

            //var result = ProducstList.Select(p=> new {p.Category,ProductCount = p.ProductName.Count()});
            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 4. Get the total of the numbers in an array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Sum();
            //Console.WriteLine(result);
            #endregion

            #region 5. Get the total number of characters of all words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dic.Sum(x => x.Length);
            //Console.WriteLine(result);

            #endregion

            #region 6. Get the length of the shortest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).

            //var result = dic.Min(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            #region 7. Get the length of the longest word in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dic.Max(x => x.Length);
            //Console.WriteLine(result);
            #endregion

            #region 8. Get the average length of the words in dictionary_english.txt (Read dictionary_english.txt into Array of String First).
            //var result = dic.Average(x=> x.Length);
            //Console.WriteLine(result);
            #endregion

            #region 9. Get the total units in stock for each product category.
            //var result = ProducstList.GroupBy(p => p.Category).Select(x => new { Category = x.Key, ProductsInStock = x.Sum(x => x.UnitsInStock) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 10. Get the cheapest price among each category's products
            //var result = ProducstList.GroupBy(p => p.Category).Select(x => new { Category = x.Key, CheapstPrice = x.Min(x => x.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 11. Get the products with the cheapest price in each category (Use Let)
            //var result = from p in ProducstList
            //             group p by p.Category into x
            //             let Chsapest = x.Min(p => p.UnitPrice)
            //             select new { category = x.Key, Chsapest = Chsapest };
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 12. Get the most expensive price among each category's products.
            //var result = ProducstList.GroupBy(p => p.Category).Select(x => new { Category = x.Key, MostExpensivePrice = x.Max(x => x.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 13. Get the products with the most expensive price in each category.
            //var result = ProducstList.GroupBy(p => p.Category).Select(x =>
            //    x.OrderByDescending(o => o.UnitPrice).FirstOrDefault()
            //);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region 14. Get the average price of each category's products.
            //var result = ProducstList.GroupBy(p => p.Category).Select(x => new { category = x.Key, Average = x.Average(x => x.UnitPrice) });
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //} 

            #endregion

            #endregion

            #region LINQ - Ordering Operators

            #region 1. Sort a list of products by name

            //var result = ProducstList.OrderBy(x=>x.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Uses a custom comparer to do a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //Array.Sort(Arr,new CaseInsensitiveComparer());
            //foreach (string str in Arr) 
            //{
            //    Console.WriteLine(str);
            //}
            #endregion

            #region 3. Sort a list of products by units in stock from highest to lowest.
            //var result = ProducstList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Sort a list of digits, first by length of their name, and then alphabetically by the name itself.

            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.OrderBy(x => x.Length).ThenBy(x=>x);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 5. Sort first by-word length and then by a case-insensitive sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenBy(x=>x,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 6. Sort a list of products, first by category, and then by unit price, from highest to lowest.

            //var result = ProducstList.OrderBy(p=>p.Category).ThenByDescending(p=>p.UnitPrice);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 7. Sort first by-word length and then by a case-insensitive descending sort of the words in an array.

            //String[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var result = Arr.OrderBy(x => x.Length).ThenByDescending(x=>x,StringComparer.OrdinalIgnoreCase);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
            //var result = Arr.Where(a => a.Length > 1 && char.ToLower(a[1] ) == 'i').Reverse();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion



            #endregion

            #region LINQ – Transformation Operators

            #region 1. Return a sequence of just the names of a list of products.
            //var result = ProducstList.Select(x => x.ProductName);
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 2. Produce a sequence of the uppercase and lowercase versions of each word in the original array (Anonymous Types).
            //String[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var result = words.Select(w => new { UpperCase = w.ToUpper(),LowerCase = w.ToLower()});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region 3. Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.

            //var result = ProducstList.Select(p => new {ProductName = p.ProductName,PriceOfUnit=p.UnitPrice,Category=p.Category});
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region 4. Determine if the value of int in an array matches their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var result = Arr.Select((x, i) => new {value = x ,Ismatch = x == i });
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.value}: {item.Ismatch}");

            //}
            #endregion

            #region 5. Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var result = from a in numbersA
            //             from b in numbersB
            //             where a < b
            //             select new { A = a,B = b};
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.A} Is Less Than {item.B}");
            //}
            #endregion

            #region 6. Select all orders where the order total is less than 500.00.
            //var result = CustomersList.SelectMany(c => c.Orders).Where(c => c.Total<500.00m);

            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}
            #endregion

            #region 7. Select all orders where the order was made in 1998 or later.
            //var result = CustomersList.SelectMany(c => c.Orders).Where(c => c.OrderDate.Year >= 1998);

            //foreach (var Item in result)
            //{
            //    Console.WriteLine(Item);
            //}

            #endregion

            #endregion
        }
    }
}
