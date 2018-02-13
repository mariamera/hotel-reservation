namespace HotelsLibrary
{
    public class InventoryType
    {
        public string Date { get; set; } // format: YYYMMDD
        public string HotelId { get; set; }
        public string RoomType { get; set; }
        public string quantity { get; set; }

        public InventoryType(string date, string HotelID , string RoomType, string quantity )
        {
            this.Date = date;
            this.HotelId = HotelID;
            this.RoomType = RoomType;
            this.quantity = quantity; 
        }

        public InventoryType() { }
    
    }
}