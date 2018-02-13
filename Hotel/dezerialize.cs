using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelsLibrary
{
     public  class dezerialize
    {
        StreamReader sr;
        XmlSerializer Serial;

        public List<InventoryType> dezerializeRoomI()
        {
          
            List<InventoryType> inventory;  
            inventory = new List<InventoryType>();
            sr = new StreamReader(@"..\..\roomInventory.xml");
            Serial = new XmlSerializer(inventory.GetType());
            inventory = (List<InventoryType>)Serial.Deserialize(sr);
            sr.Close();
            return inventory;

        }
        public List<RoomTypes> dezerializeRoomTypes()
        {

            List<RoomTypes> inventory;
            inventory = new List<RoomTypes>();
            sr = new StreamReader(@"..\..\roomtypes.xml");
            Serial = new XmlSerializer(inventory.GetType());
            inventory = (List <RoomTypes>)Serial.Deserialize(sr);
            sr.Close();
            return inventory;

        }
        public List<HotelsList> dezerializeHotels()
        {
            List<HotelsList> hotels;
            hotels = new List<HotelsList>();
            sr = new StreamReader(@"..\..\hotelslisting.xml");
            Serial = new XmlSerializer(hotels.GetType());
            hotels = (List<HotelsList>)Serial.Deserialize(sr);
            sr.Close();
            return hotels; 

        }



         public  List<ReservationType> dezerializeReservation()
        {
            if (File.Exists(@"../../reservations.xml") == true)
            {
                List<ReservationType> reservations;
                reservations = new List<ReservationType>();
                sr = new StreamReader(@"..\..\reservations.xml");
                Serial = new XmlSerializer(reservations.GetType());
                reservations = (List<ReservationType>)Serial.Deserialize(sr);
                sr.Close();
                return reservations;
            } else
            {
                return null; 
            }
        }


    }
}
