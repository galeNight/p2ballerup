namespace SingleChar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.charName();
            obj.arrayone();
            obj.arraytwo();
            obj.arrayname();
        }
        void charName()
        {
            string Name = "Jannick Mørup"; // navn variable
            foreach (char output in Name) //læser navn og liger hvert ord i output
            {
                Console.WriteLine(output);//udskriver hvert ord i navn
            }
            Console.WriteLine();// laver mellemrum
        }
        void arrayone()
        {
            double nedbørmåned1 = 4;
            double nedbørmåned2 = 12;
            double nedbørmåned3 = 2;
            double nedbørmåned4 = 8;
            double sum = nedbørmåned1 + nedbørmåned2 + nedbørmåned3 + nedbørmåned4;
            Console.WriteLine($"sum{sum:N2}");
            double gns = sum / 4;
            Console.WriteLine($"Gennemsnit{gns:N2}");
            Console.WriteLine();
        }
        void arraytwo()
        {
            double[] nedbør = { 4, 12, 2, 8 };
            double sum = 0;
            for(int i=0;i<nedbør.Length;i++)
            {
                sum += nedbør[i];
                Console.WriteLine($"sum{sum:N3}");
                double gns = sum / nedbør.Length;
                Console.WriteLine($"Gennemsnit{gns:N2}");
                Console.WriteLine();
            }
        }
        void arrayname()
        {
            string name = Console.ReadLine();//string name =console.readline læser hvad man har  skrevet 
            Console.WriteLine();
            for(int i = name.Length - 1; i >= 0; i--)
            //for() gøre det i et loop. int i = name.length -1 læser navnet i tal. i<=0 kontrolere hvilken bugstav refererer. i-- tæller ned
            {
                Console.WriteLine(name[i]); //console.writeline(name[i]); udskriver navnet baglæns
            }
        }
    }
}