namespace Lab3
{
    class Car
    {
        public string make;
        public string model;
        public string color;
        public int yearBuilt;

        public void Start()
        {
            System.Console.WriteLine(model + " started");
        }
        public void Stop()
        {
            System.Console.WriteLine(model + " stopped");

        }
    }
        internal class Program
    {
        static void Main(string[] args)
        {

            Car myCar;
            System.Console.WriteLine("Creating a Car object and assigning " + "its memory location to myCar");
            myCar = new Car();

            myCar.make = "Toyota";
            myCar.model = "MR2";
            myCar.color = "black";
            myCar.yearBuilt = 1995;

            System.Console.WriteLine("My Car details:");
            System.Console.WriteLine("My Car make : " + myCar.make);
            System.Console.WriteLine("My Car model: " + myCar.model);
            System.Console.WriteLine("My Car color: " + myCar.color);
            System.Console.WriteLine("My Car year:" + myCar.yearBuilt);

            myCar.Start();
            myCar.Stop();

            System.Console.WriteLine("Creating another Car object and" + "assigning its memory location to Red Porsche");
            Car redPorsche = new Car();
            redPorsche.make = "Porsche";
            redPorsche.model = "Boxster";
            redPorsche.color = "red";
            redPorsche.yearBuilt = 2000;
            System.Console.WriteLine("Red Porsche is a " + redPorsche.model);
  
            System.Console.WriteLine("Assigning Red Porsche to  my car");
            myCar = redPorsche;
            System.Console.WriteLine("My Car details:");

            System.Console.WriteLine("My Car make: " + myCar.make);
            System.Console.WriteLine("My Car model: " + myCar.model);
            System.Console.WriteLine("My Car color: " + myCar.color);
            System.Console.WriteLine("My Car year: " + myCar.yearBuilt);

            myCar = null;
            Console.ReadLine();
        }
    }
}