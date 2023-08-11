namespace talformat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //formareringer af tal 
            int a = 25123;
            double b = 232354.3426;
            double c = 0.25;

            Console.WriteLine(a.ToString("N2"));
            Console.WriteLine(a.ToString("N3"));
            Console.WriteLine(a.ToString("F1"));
            Console.WriteLine(a.ToString("C2\n"));
            Console.WriteLine(b.ToString("N2"));
            Console.WriteLine(b.ToString("N3"));
            Console.WriteLine(b.ToString("F5\n"));
            Console.WriteLine(a.ToString("P0"));
            Console.WriteLine(a.ToString("P2"));
        }
    }
}