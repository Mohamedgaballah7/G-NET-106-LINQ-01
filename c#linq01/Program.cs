using LINQ.DataSources;

namespace c_linq01
{
    internal class Program
    {
        static void Main(string[] args)
        {



            #region Q1 

            //var q1 = Source.ProductList
            //    .Where(p => p.Category == "Seafood");

            //foreach (var item in q1)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}

            #endregion

            #region Q2 

            //var q2 = Source.ProductList
            //    .Select(p => p.ProductName);

            //foreach (var name in q2)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Q3 

            //var q3 = Source.ProductList
            //    .OrderBy(p => p.UnitPrice);

            //foreach (var item in q3)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}

            #endregion

            #region Q4 

            //var q4 = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30);

            //foreach (var item in q4)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitPrice}");
            //}

            #endregion

            #region Q5

            //var q5 = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

            //foreach (var item in q5)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}

            #endregion

            #region Q6

            //var q6 = Source.ProductList
            //    .Select(p => new
            //    {
            //        Name = p.ProductName,
            //        Price = p.UnitPrice,
            //        StockStatus = p.UnitsInStock > 0 ? "Available" : "Out of Stock"
            //    });

            //foreach (var item in q6)
            //{
            //    Console.WriteLine($"{item.Name} - {item.Price} - {item.StockStatus}");
            //}

            #endregion

            #region Q7 

            //var q7 = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Position = index + 1,
            //        Name = p.ProductName
            //    });

            //foreach (var item in q7)
            //{
            //    Console.WriteLine($"{item.Position}. {item.Name}");
            //}

            #endregion

            #region Q8 

            //var q8 = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice);

            //foreach (var item in q8)
            //{
            //    Console.WriteLine($"{item.Category} - {item.ProductName} - {item.UnitPrice}");
            //}

            #endregion

            #region Q9

            //var q9 = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock);

            //foreach (var item in q9)
            //{
            //    Console.WriteLine($"{item.ProductName} - {item.UnitsInStock}");
            //}

            #endregion

            #region Q10 

            //var q10 =
            //    from c in Source.CustomerList
            //    from o in c.Orders
            //    where o.OrderDate.Year >= 1997
            //    select new
            //    {
            //        c.CustomerID,
            //        o.OrderDate
            //    };

            //foreach (var item in q10)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
            //}

            #endregion

            #region Q11 

            //var q11 = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Position = index + 1,
            //        ProductName = p.ProductName
            //    });

            //foreach (var item in q11)
            //{
            //    Console.WriteLine($"{item.Position}. {item.ProductName}");
            //}

            #endregion

            #region Q12

            //        string[] Arr =
            //        {
            //    "aPPLE", "AbAcUs", "bRaNcH",
            //    "BlUeBeRrY", "ClOvEr", "cHeRry"
            //};

            //        var q12 = Arr
            //            .OrderBy(s => s.Length)
            //            .ThenBy(s => s, StringComparer.OrdinalIgnoreCase);

            //        foreach (var item in q12)
            //        {
            //            Console.WriteLine(item);
            //        }

            #endregion

            #region Q13

            //        string[] Arr2 =
            //        {
            //    "aPPLE", "AbAcUs", "bRaNcH",
            //    "BlUeBeRrY", "ClOvEr", "cHeRry"
            //};

            //        var q13 = Arr2
            //            .Where(s => s.Length > 1 && char.ToLower(s[1]) == 'i')
            //            .Reverse()
            //            .ToList();

            //        foreach (var item in q13)
            //        {
            //            Console.WriteLine(item);
            //        }

            #endregion
        }
    }
}
