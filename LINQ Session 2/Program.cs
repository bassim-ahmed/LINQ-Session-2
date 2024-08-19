using System.Collections;
using static LINQ_Session_2.ListGenerator;

namespace LINQ_Session_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region part 1 filteration operators
            //fluent
            //var result =ProductsList.Where(P => P.UnitsInStock == 0);
            //query synatx
            //var result=from P in ProductsList
            //           where  P.UnitsInStock == 0
            //           select P;

            //var result = ProductsList.Where(P => { return P.Category == "Meat/Poultry" && P.UnitsInStock > 0; });
            //var result=from P in ProductsList
            //           where  P.UnitsInStock > 0 && P.Category == "Meat/Poultry" 
            //           select P;

            //var Result = ProductsList.Where((P, I) => P.UnitsInStock == 0 && I < 10);

            //foreach (var unit in Result)
            //{
            //    Console.WriteLine(unit);
            //}
            //oftype
            // ArrayList list= new ArrayList() { "ahmed",1,1.5};
            //var result= list.OfType<int>();
            // foreach (var unit in result)
            // {
            //     Console.WriteLine(unit);
            // }
            #endregion
            #region PART 2 Transformation operatoers
            //var result = ProductsList.Select(P => P);            
            //var result = ProductsList.Select(P => P.ProductID);
            //var result = ProductsList.Select(P => P.ProductName);
            //var result = ProductsList.Select(P => { return new { Id = P.ProductID, Name = P.ProductName }; });

            //QUERY SELECTOR
            //var result = from p in ProductsList
            //             select p.ProductName;
            //var result = from p in ProductsList
            //             select new
            //             {
            //                 name=p.ProductName,
            //                 Id=p.ProductID
            //             };

            //var result = CustomersList.SelectMany(p => p.Orders);
            //var result=from c in CustomersList
            //           from o in c.Orders
            //           select o;
            //var Result = ProductsList.Where(p => p.UnitsInStock > 0).Select(p =>
            //{
            //    return new
            //    {
            //        p.ProductID,
            //        p.ProductName,
            //        Newprice = p.UnitPrice - p.UnitPrice * 0.1m
            //    };
            //});
            //var Result = ProductsList.Select((P, I) =>  new {I,P.ProductName } );

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region ordering operators
            //var Result = ProductsList.OrderBy(p => p.UnitPrice);
            //var Result = ProductsList.OrderByDescending(p => p.UnitPrice);
            //Query Syntax
            //var Result=from P in ProductsList
            //           orderby P.UnitPrice descending
            //           select P;
            //var Result = ProductsList.Select(p => new { p.ProductName, p.UnitPrice, p.UnitsInStock }).OrderBy(p => p.UnitPrice).ThenBy(p => p.UnitsInStock);

            //query syntax
            //var Result = from P in ProductsList
            //             orderby P.UnitPrice, P.UnitsInStock
            //             select new
            //             {
            //                 P.ProductName,
            //                 P.UnitsInStock,
            //                 P.UnitPrice
            //             };


            //Reverse
            //var Result=ProductsList.Reverse<Product>();



            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Element Operator
            //ProductsList = new List<Product>();
            //var Result=ProductsList.First();
            //var Result = ProductsList.Last();
            //var Result = ProductsList.FirstOrDefault();
            //var Result=ProductsList.LastOrDefault();
            //var Result=ProductsList.First(p=>p.UnitsInStock==1000);
            //var Result = ProductsList.FirstOrDefault(new Product() { ProductName = "Defalt product" });
            //var Result = ProductsList.FirstOrDefault(p => p.UnitsInStock == 0, new Product() { ProductName = "Defalt" });
            //var Result = ProductsList.ElementAt(874784);
            //var Result = ProductsList.ElementAtOrDefault(858585);
            //ProductsList=new List<Product>() {new Product
            //{
            //    ProductName="one product"
            //} };

            ////var Result=ProductsList.Single();
            //var Result=ProductsList.SingleOrDefault();
            //var Result = ProductsList.Single(P => P.UnitsInStock == 1000);


            //Console.WriteLine(Result);
            #endregion
            #region Aggregate Operate
            //var Result = ProductsList.Count();
            //var Result=ProductsList.Count(P=>P.UnitsInStock==0);
            //var Result=ProductsList.Sum(P=>P.UnitPrice);
            //var Result = ProductsList.Average(P => P.UnitPrice);
            //var Result = ProductsList.Max(P=>P.UnitPrice);
            //var Result=ProductsList.MaxBy(P=>P.UnitPrice);
            //List<string> list = new List<string>() { "ahmed","ali","omar","bassim"};
            //var Result=list.Aggregate((str1,str2)=>$"{str1}::::::{str2}");

            //Console.WriteLine(Result);

            #endregion
            #region Generation Operaters
            //var Result = Enumerable.Range(1, 20);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            //var Result = Enumerable.Repeat(new Product() { ProductName = "Repeat product" }, count:10 );
            //var Result=Enumerable.Empty<int>();
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region set operatoers
            var Seq1 = Enumerable.Range(0, 100);
            var Seq2=Enumerable.Range(50, 100);
            //var Result = Seq1.Union(Seq2);
            //var Result = Seq1.Concat(Seq2);
            //var Result = Seq1.Intersect(Seq2);
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Quantifier operators
            //Any All  Sequence   Contain
            //ProductsList  =new List<Product>();
            //var Result = ProductsList.Any();
            //var Result = ProductsList.Any(P => P.UnitsInStock == 0);
            //var Result = ProductsList.All(P => P.UnitsInStock == 0);
            //SEQUENCE eQUAL
            //var seq2 = Enumerable.Range(50, 100);
            //var seq1 = Enumerable.Range(0, 100);
            ////var Result=seq1.SequenceEqual(Seq2);
            //var Result = seq1.Contains(233);
            //Console.WriteLine(Result);


            #endregion
            #region zipping operatores
            //List <string> list = new List<string>() { "ten","twenty","thrity","forthy"};
            //List<int> list2 = new List<int>() { 1,2,3,4,5,6,7 };
            //var Result = list2.Zip(list, (W, N) => $"{W},{N}");
            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Grouping Operators
            //var Result = ProductsList.GroupBy(P => P.Category);
            //var Result = from P in ProductsList
            //             group P by P.Category;
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count()>12
            //             select Category;
            //var Result = from P in ProductsList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //            into Category
            //             where Category.Count() > 12
            //             select new {categoryname=Category.Key, Count=Category.Count()};

            //foreach (var item in Result) {
            //    Console.WriteLine(item.Key);
            //    foreach (var item2 in item)
            //    {
            //        Console.WriteLine(item2);
            //    }

            //}
            //foreach (var P in Result) {

            //    Console.WriteLine(P);
            //}

            #endregion
            #region Partioning Operators
            //var Result = ProductsList.Take(5);
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0).Take(3);
            //var Result = ProductsList.Where(p => p.UnitsInStock == 0).TakeLast(3);
            //var Result = ProductsList.Skip(5);
            //var Result=ProductsList.Skip(5).Take(5);
            //int[] Numbers = {4,1,2,3,4,5};
            ////var Result=Numbers.TakeWhile((N)=>N%2==0);
            ////var Result = Numbers.SkipWhile((N) => N % 2 == 0);
            //var Num = Numbers.TakeWhile((N, I) => N > I);
            //foreach (var item in Result) {
            //    Console.WriteLine(item);
            //}

            #endregion
        }

    }
}
