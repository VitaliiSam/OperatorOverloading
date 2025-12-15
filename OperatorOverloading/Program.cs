using ClassLibrary1;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //First part - Employee
            Employee e1 = new Employee(2000);
            Employee e2 = new Employee(3000);

            e1 = e1 + 2000;
            e2 = e2 - 1000;

            Console.WriteLine("First part - Employee");

            Console.WriteLine(e1.Salary);
            Console.WriteLine(e2.Salary);

            Console.WriteLine(e1 > e2);
            Console.WriteLine(e1 == e2);

            //Second part - City
            City c1 = new City(20000);
            City c2 = new City(30000);

            c1 = c1 + 2000;
            c2 = c2 - 1000;

            Console.WriteLine("Second part - City");

            Console.WriteLine(c1.Population);
            Console.WriteLine(c2.Population);

            Console.WriteLine(c1 > c2);
            Console.WriteLine(c1 == c2);

            //Third part - CreditCard
            CreditCard crcd1 = new CreditCard(10000, 123);
            CreditCard crcd2 = new CreditCard(15000, 456);

            crcd1 = crcd1 + 1500;
            crcd2 = crcd2 - 1200;

            Console.WriteLine("Third part - CreditCard");

            Console.WriteLine(crcd1.Balance);
            Console.WriteLine(crcd2.Balance);

            Console.WriteLine(crcd1 > crcd2);
            Console.WriteLine(crcd1 == crcd2);
        }
    }
}
