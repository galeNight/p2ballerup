using System;
using Google.Apis.Calendar.v3;
using Google.Apis.Services;

namespace Api.classes
{
    public class Api
    {
        const string ApiKey = "AIzaSyB3Lb5siSaXbEB8ZanqW25wSOPLPguO3O4"; // my APi KEY google
        const string CalenderId = "da.danish#holiday@group.v.calendar.google.com";// calendar id
        public Google.Apis.Calendar.v3.Data.Events response { get; set; }

        public Api()
        {
            var service = new CalendarService(new BaseClientService.Initializer()
            {
                ApiKey = ApiKey,
                ApplicationName = "api key example",
            });
            // sends a request to api and get responce with specfide item 
            var request = service.Events.List(CalenderId);
            request.Fields = "items(summary,start,end)";
            response = request.Execute();
        }

        public bool IsHoliday(DateTime date) 
        {
            foreach (var item in response.Items)
            {
                DateTime startDate = DateTime.Parse(item.Start.Date);
                // Check if the start date of a holiday event matches the given date
                if (startDate.Date == date.Date)
                {
                    return true;// Returns true if it's a holiday
                }
            }
            return false;// Returns false if it's not a holiday
        }


    }

}
