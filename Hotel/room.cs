namespace HotelsLibrary
{
    public class Room
    {
        public string id { get; set; }
        public string rate { get; set; }
        public string capacity { get; set; }

        public Room(string id, string rate, string capacity)
        {
            this.id = id;
            this.rate = rate;
            this.capacity = capacity;
        }

        public Room() { }
    }
}