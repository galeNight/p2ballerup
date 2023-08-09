namespace fileprogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input=Console.ReadLine();//strign input
            Name name = new Name(input);//initialize the Name class object
            Console.WriteLine(name.Lcount());//using the metod from name object and print the cout af characters
        }
    }
}