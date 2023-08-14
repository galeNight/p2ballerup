
namespace taxatets.data
{
    public class Calculation
    {
        public Parameters Parameters { get; set; }
        public decimal Antalkm { get; set; }
        public decimal Antalmin { get; set; }
        public Calculation(Parameters parameters, decimal antalkm, decimal antalmin)
        {
            //start + kilometert * kilometer + min * min + extra

            Parameters = parameters;
            Antalkm = antalkm;
            Antalmin = antalmin;
        }
        public decimal Getprice()
        {
            return Parameters.startingprices + Parameters.priceprkm * Antalkm + Parameters.priceprmin * Antalmin;
        }
        
    }
}
