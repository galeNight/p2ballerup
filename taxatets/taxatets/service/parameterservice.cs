using taxatets.data;
using System.Text.Json;
using System.IO;

namespace taxatets.service
{
    public class Parameterservice
    {
        static string filepath = Path.Combine(Environment.CurrentDirectory, "Pages\\data.json");
        static Parameters parameters = new Parameters() 
        {
            startingprices = 37m,
            priceprkm = 12.75m,
            priceprmin = 5.75m
        };
        static JsonSerializerOptions option = new JsonSerializerOptions()
        {
            WriteIndented = true,
        };
        string jsonString = JsonSerializer.Serialize(parameters, option);

        public void DoThis()
        {
            File.WriteAllText(filepath, jsonString);
        }
    }
}
