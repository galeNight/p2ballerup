using taxatets.data;
using System.Text.Json;
using System.IO;

namespace taxatets.service
{
    public class Parameterservice
    {
        private string filepath = Path.Combine(Environment.CurrentDirectory, "Pages\\data.json");
        public string JsonString { get; }
        private readonly Parameters _parameters;
        private readonly JsonSerializerOptions _option;

        public Parameterservice(Parameters parameters)
        {
            // Test Parameret skal hentes fra DB
            _parameters = parameters;
            _option = new JsonSerializerOptions { WriteIndented = true };

            JsonString = JsonSerializer.Serialize(_parameters, _option);
        }

        public void DoThis()
        {
            File.WriteAllText(filepath, JsonString);
        }
    }
}
