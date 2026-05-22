
using System.Xml.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        //TestEvenNumbers();
        //TestFilterObjects();
        //TestFilterToSqlData();
        TestFileXml();
    }

    private static void TestFileXml()
    {
        XDocument doc = XDocument.Load("../../../../PruebasLinq/Books.xml");
        var titles = from Book in doc.Descendants("title").Value;

        foreach (var title in titles)
        {
            Console.WriteLine(title);
        }
    }

    private static void TestFilterToSqlData()
    {
        using (var context = new MyDbContext())
        {
            var query = from user in context.Users
                        where user.Age > 18
                        select user;

            foreach (var user in query)
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