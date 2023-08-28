namespace SingleChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.charName();
        }
        void charName()
        {
            string Name = "Jannick Mørup";
            foreach (char output in Name)
            {
                Console.WriteLine(output);
            }
            Console.WriteLine();
        }
    }
}