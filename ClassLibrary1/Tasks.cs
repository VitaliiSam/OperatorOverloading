namespace ClassLibrary1
{
    //First part - Employee
    public class Employee
    {
        private decimal salary;

        public decimal Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Salary can't be negative");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public Employee(decimal salary)
        {
            Salary = salary;
        }
        public static Employee operator +(Employee e, decimal amount)
        {
            return new Employee(e.Salary + amount);
        }
        public static Employee operator -(Employee e, decimal amount)
        {
            return new Employee(e.Salary - amount);
        }
        public static bool operator ==(Employee e1, Employee e2)
        {
            return e1.Salary == e2.Salary;
        }
        public static bool operator !=(Employee e1, Employee e2)
        {
            return !(e1 == e2);
        }
        public static bool operator <(Employee e1, Employee e2)
        {
            return e1.Salary < e2.Salary;
        }
        public static bool operator >(Employee e1, Employee e2)
        {
            return e1.Salary > e2.Salary;
        }
        //Is it needed (rows 55-65)? Generated because of C# suggestion
        public override bool Equals(object? obj)
        {
            return obj is Employee employee &&
                   salary == employee.salary &&
                   Salary == employee.Salary;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(salary, Salary);
        }
    }
    //Second part - City
    public class City
    {
        private int population;

        public int Population
        {
            get
            {
                return population;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Population can't be negative");
                }
                else
                {
                    population = value;
                }
            }
        }
        public City(int population)
        {
            Population = population;
        }
        public static City operator +(City c, int amount)
        {
            return new City(c.Population + amount);
        }
        public static City operator -(City c, int amount)
        {
            return new City(c.Population - amount);
        }
        public static bool operator ==(City c1, City c2)
        {
            return c1.Population == c2.Population;
        }
        public static bool operator !=(City c1, City c2)
        {
            return !(c1 == c2);
        }
        public static bool operator <(City c1, City c2)
        {
            return c1.Population < c2.Population;
        }
        public static bool operator >(City c1, City c2)
        {
            return c1.Population > c2.Population;
        }
    }
}
