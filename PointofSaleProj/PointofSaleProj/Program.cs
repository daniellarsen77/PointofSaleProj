namespace PointofSaleProj
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Daniel was here");
            Console.WriteLine();
            Terminal terminal = new Terminal();
            terminal.PrintMenu();
        }
    }
}