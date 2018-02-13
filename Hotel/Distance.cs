namespace HotelsLibrary
{
    public class Distance
    {
        public string Beach { get; set; }
        public string Shopping { get; set; }
        public string Airport { get; set; }

        public Distance(string Beach, string Shopping, string Airport)
        {
            this.Beach = Beach;
            this.Shopping = Shopping;
            this.Airport = Airport;
        }

        public Distance() { }
    }
}