namespace Rektangel1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int HøjdeRekt;

            Console.WriteLine("Hej, skriv din højde på din rektangel");
            HøjdeRekt = Int32.Parse(Console.ReadLine());

            Console.WriteLine(HøjdeRekt);
            Console.ReadLine();
        }
    }
}
