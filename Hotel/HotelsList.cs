using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsLibrary
{
    public class HotelsList
    {
        public string id { get; set; }
        public string name { get; set; }
        public string rating { get; set; }
        public List<Room> RoomTypes { get; set; }
    
        public HotelsList(string id, string name, string rating)
        {
            this.id = id;
            this.name = name;
            this.rating = rating;
            RoomTypes = new List<Room>();
        }

        public HotelsList()
        {
        }

        public void AddRoomType(Room r)
        {
            RoomTypes.Add(r);
        }

        public override string ToString()
        {
            return String.Format("[*] HOTEL NAME: " + name + " [RATING: ]" + rating);
        }
    }
}
