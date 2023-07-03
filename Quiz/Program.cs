using System.Security.AccessControl;
using Quiz;
namespace Quiz
{
    internal class Program
    {
        // start the program
        static void Main(string[] args)
        {
            // calls the gui class and run it
            new GUI();
        }
    }
    public class metodes
    {
        public void writeanswer()
        {
            Console.Write("Write you answer:");
        }
        public void option(string option)
        {
            Console.WriteLine(option);
        }
        public void correct()
        {
            Console.WriteLine("Rigtig!\n");
        }
        public void wrong()
        {
            Console.WriteLine("Forkert!\n");//print wrong choice
        }
        public void keycontinue()
        {
            Console.WriteLine("Press any key to continue...\n");//print continue
            Console.ReadKey();
        }
        public void complete()
        {
            Console.WriteLine("quiz complete");//print complete
            Console.ReadKey();
        }
    }
}