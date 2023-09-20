using Api.classes;
namespace Api.classes
{
    public class Date
    {
        public DateTime currentDate = DateTime.Now;// look at current dates
        Api APIobj = new Api();

        public void UpdateDate(int daysToAdd = 1) //add dayes and then update 
        {
            currentDate = currentDate.AddDays(daysToAdd);
            daysToAdd++;
        }
        public string CheckDate(string output) //check if date match a holidays via currentdate
        {
            if (APIobj.IsHoliday(currentDate))
            {
                output = APIobj.GetHolidayName(currentDate);
            }
            else
            {
                output = "";
            }
            return output;
        }
    }
}