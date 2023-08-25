namespace SingleChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "qwer";
            int index = 0;
            while (index < name.Length)
            {
                char character = name[index];
                Console.WriteLine(character);
                index++;
            }
        }
    }
}