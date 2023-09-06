using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace Api.classes
{
    public class api
    {
        const string ApiKey = "AIzaSyB3Lb5siSaXbEB8ZanqW25wSOPLPguO3O4";
        const string CalenderId = "da.danish#holiday@group.v.calendar.google.com";
        public Google.Apis.Calendar.v3.Data.Events response { get; set; }

        public api()        {

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "api key example",
            });

            var request = service.Events.List(CalenderId);
            request.Fields = "items(summary,start,end)";
            response = request.Execute();
        }

        public async Task tets()
        {
            Console.WriteLine("holidays fuck");

            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "api key example",
            });

            var request = service.Events.List(CalenderId);
            request.Fields = "items(summary,start,end)";
            response = await request.ExecuteAsync();

            foreach (var item in response.Items)
            {
                Console.WriteLine($"Holiday: {item.Summary} start: {item.Start} end: {item.End}");
            }
            Console.ReadLine();
        }
    }
}
