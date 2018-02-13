namespace HotelsLibrary
{
    public class RoomTypes
    {
        public string id { get; set; }
        public string name { get; set; }

        public RoomTypes(string id, string name)
        {
            this.id = id;
            this.name = name;
        }

        public RoomTypes() { }

        public override string ToString()
        {
            return string.Format("{0}, {1}", id, name);
        }
    }
}
