namespace Exercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee("Rino", "OwO", "Hang Buom Disctrict", 20, 3000);

            Console.WriteLine(emp.ToString());
            Console.WriteLine("Bonus: " + emp.Bonus(50));

            Console.WriteLine(emp.ToString());

        }

        class Employee
        {
            public string firstName;
            public string lastName;
            public string address;
            public long sin;
            public double salary;

            public Employee(string firstName, string lastName, string address, long sin, double salary)
            {
                this.firstName = firstName;
                this.lastName = lastName;
                this.address = address;
                this.sin = sin;
                this.salary = salary;
            }

            public override string? ToString()
            {
                return "Name: " + firstName + " " + lastName + 
                    "\nAddress: " + address + "\nSin: " + sin + "\nSalary: " + salary;
            }

            public double Bonus(double bonus)
            {
                return salary * bonus / 100;
            }
        }
    }
}