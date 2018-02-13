using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelsLibrary
{
    public class Hotels
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string rating { get; set; }
        public Features features { get; set; }
        public Distance distance { get; set; }
        public List<Room> RoomList { get; set; }

        public Hotels(string id, string name, string address, string rating, Features features, Distance distance)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.rating = rating;
            this.features = features;
            this.distance = distance;
            RoomList = new List<Room>(); 
           
        }

        public Hotels() 
        {
            features = new Features();
            distance = new Distance(); 
        }

        public void AddRoom(Room r)
        {
            RoomList.Add(r); 
        }
        public override string ToString()
        {
            return String.Format("[*] HOTEL NAME: " + name + " ADDRESS: " + address + " [RATING: ]" + rating);
        }
    }
    
}
