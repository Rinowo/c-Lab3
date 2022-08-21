namespace Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Atom atom = new Atom();

            Console.WriteLine("Atomic information");
            Console.WriteLine("==========================");

            Console.WriteLine("Enter Atomic Full name");
            atom.AtomFn = Console.ReadLine();

            Console.WriteLine("Enter Atomic Symbol");
            atom.AtomSb = Console.ReadLine();

            Console.WriteLine("Enter Atomic Number");
            atom.AtomN = Console.Read();

            Console.WriteLine("Enter Atomic Weight");
            atom.AtomW = Console.Read();

            atom.display();
            Console.ReadLine();
        }
    }
}