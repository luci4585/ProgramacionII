using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //TestEvenNumbers();
        //TestFilterObjects();
        //TestFilterToSqlData();
        //TestFileXml();
        //TestSelectNamesUsersAdults();
        //TestSelectManyMeses();
        TestBookOrderByTitles();
    }

    private static void TestBookOrderByTitles()
    {
        XDocument doc = XDocument.Load("../../../../PruebasLinq/Books.xml");
        var titles = from book in doc.Descendants("book")
                     select book.Element("title")!.Value;
        var titles = doc.Descendants("book")
                        .Select(book => book.Element("title")!.Value);

        Console.WriteLine("Titulos de Libros:");
        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }
    }

    private static void TestSelectManyMeses()
    {
        List<string[]> monthList = new List<string[]>
        {
            new string[] { "Enero", "Febrero" },
            new string[] { "Marzo", "Abril", "Mayo","Junio" },
            new string[] {"Julio"}
        };

        var allMonths = monthList.SelectMany(months => months);
        Console.WriteLine("Lista de meses:");
        foreach (var month in allMonths)
        {
            Console.WriteLine(month);//Output: Enero, Febrero, Marzo...
        }
        Console.WriteLine("Mostramos todos los meses juntos, separados por comas, usando select");
        string AllMonthsList = string.Join(", ", allMonths);
    }

    private static void TestSelectNamesUsersAdults()
    {
        using (var context = new MyDbContext())
        {
            var userNames = context.Users
                             .Where(u => u.Age >= 18)
                             .Select(u => u.Name)
                             .ToList();
            Console.WriteLine("Nombres de usuarios adultos:");
            foreach (var name in userNames)
            {
                Console.WriteLine(name);
            }
        }
    }

    private static void TestFileXml()
    {
        XDocument doc = XDocument.Load("../../../../PruebasLinq/Books.xml");
        //var titles = from book in doc.Descendants("book")
        //             select book.Element("title")!.Value;
        var titles = doc.Descendants("book")
                        .Select(book => book.Element("title")!.Value);

        Console.WriteLine("Titulos de Libros:");
        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }
    }

    private static void TestFilterToSqlData()
    {
        using (var context = new MyDbContext())
        {
            var allUsers = context.Users.ToList();
            var userAdults = context.Users.Where(u => u.Age >= 18).ToList();

            Console.WriteLine("Imprimo todos los usuarios");
            foreach (var user in allUsers)
            {
                Console.WriteLine($"{user.Name} edad:{user.Age}");
            }

            Console.WriteLine("Imprimo usuarios mayores de 18 años");
            foreach (var user in userAdults)
            {
                Console.WriteLine(user.Name);
            }
        }
    }

    private static void TestFilterObjects()
    {
        List<string> names = new List<string> { "John", "Jane", "Joe", "Pedro", "Oscar" };
        var namesWithO = from name in names
                    where name.Contains("o",StringComparison.OrdinalIgnoreCase) 
                    select name;
        var namesWith4Characters = from name in names
                                  where name.Length==4
                                  select name;
        Console.WriteLine("Nombres con O");
        foreach (var name in namesWithO)
        {
            Console.WriteLine(name); // Output: John, Jane, Joe
        }
        Console.WriteLine("Nombres con 4 caracteres");
        foreach (var name in namesWith4Characters)
        {
            Console.WriteLine(name); // Output: John, Jane, Joe
        }
    }

    /// <summary>
    /// Demonstrates how to filter even numbers from an array using both query syntax and method syntax in LINQ.
    /// </summary>
    /// <remarks>This method showcases two approaches to filtering even numbers from a predefined array of
    /// integers: query syntax and extension method syntax. The results are printed to the console.</remarks>

    private static void TestEvenNumbers()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        //numeros pares con sintáxis de expresiones de consulta
        var evenNumbers = from num in numbers
                          where num % 2 == 0
                          select num;

        //numeros pares con sintáxis de métodos de extensión
        var evenNumbers2 = numbers.Where(num => num % 2 == 0);

        foreach (var num in evenNumbers)
        {
            Console.WriteLine(num); // Output: 2, 4
        }

        foreach (var num in evenNumbers2)
        {
            Console.WriteLine(num); // Output: 2, 4
        }
    }
}