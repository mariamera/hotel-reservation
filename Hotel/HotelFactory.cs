using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelsLibrary
{
    public class HotelFactory
    {
        StreamWriter sw;
        XmlSerializer Serial;
        List<Hotels> HotelList;
        const string HOTEL_FILENAME = @"..\..\hotels.xml";
        

        public void CreateHotel()
        {  
            Room a = new Room("KB", "600", "2/0");
        
            HotelList = new List<Hotels>();
            Features f = new Features(true, true, true, true);
            Distance d = new Distance("1.0", "2.0", "1.5"); 
            Hotels H = new Hotels("000111", "Courtyard Suites", "2012 Lion's Hwy, Narnia", "4.5", f, d);
            H.AddRoom(a);
            H.AddRoom(new Room("QB", "530", "2/0"));
            H.AddRoom(new Room("DB", "515", "2/0"));
            H.AddRoom(new Room("BS", "625", "2/2"));
            HotelList.Add(H);

            f = new Features(true, true, false, true);
            d = new Distance("1.0", "7.0", "5.2");
            H = new Hotels("000222", "Dolce Vita Hotel", "2020 Rainbow Hwy, Narnia", "3.0",f, d);
            H.AddRoom(new Room("KB", "560", "2/1"));
            H.AddRoom(new Room("QB", "110", "2/1"));
            H.AddRoom(new Room("DB", "115", "2/1"));
            H.AddRoom(new Room("BS", "220", "4/2"));
            HotelList.Add(H);

            f = new Features(true, true, true, true);
            d = new Distance("1.0", "4.0", "3.2");
            H = new Hotels("000333", "Fireflies Suites", "Anvard street , Narnia", "5.0", f, d);
            H.AddRoom(new Room("KB", "610", "2/1"));
            H.AddRoom(new Room("QB", "520", "2/0"));
            H.AddRoom(new Room("DB", "545", "2/0"));
            H.AddRoom(new Room("BS", "650", "2/1"));
            HotelList.Add(H);

            f = new Features(false, true, false, false);
            d = new Distance("2.0", "2.0", "2.0");
            H = new Hotels("000444", "Aquamarine Camp Hotel", "1010 Small forest rd , Narnia", "2.5",f, d);
             H.AddRoom(new Room("KB", "530", "2/2"));
            H.AddRoom(new Room("QB", "120", "4/2"));
            H.AddRoom(new Room("DB", "100", "2/0"));
            H.AddRoom(new Room("BS", "90", "3/2"));
            HotelList.Add(H);

            f = new Features(true, true, false, true);
            d = new Distance("1.0", "4.0", "5.5");
            H = new Hotels("000555", "Kaoba Hotel", "8921 The Voyage Hwy , Narnia", "3.5", f, d);
            H.AddRoom(new Room("KB", "555", "2/2"));
            H.AddRoom(new Room("QB", "160", "1/0"));
            H.AddRoom(new Room("DB", "130", "1/0"));
            H.AddRoom(new Room("BS", "110", "2/2"));
            HotelList.Add(H);

            f = new Features(true, true, true, true);
            d = new Distance("1.0", "1.0", "1.2");
            H = new Hotels("000666", "Glee Suites", "Aslan's Howe street , Narnia", "3.0",f,d);
            H.AddRoom(new Room("KB", "545", "2/1"));
            H.AddRoom(new Room("QB", "120", "3/0"));
            H.AddRoom(new Room("DB", "110", "3/0"));
            H.AddRoom(new Room("BS", "120", "5/2"));
            HotelList.Add(H);

            f = new Features(true, true, false, false);
            d = new Distance("1.5", "6.0", "2.0");
            H = new Hotels("000777", "Daydream Hotel", "Anvard street , Narnia", "1.5", f, d);
            H.AddRoom(new Room("KB", "520", "3/2"));
            H.AddRoom(new Room("QB", "50", "1/0"));
            H.AddRoom(new Room("DB", "90", "1/0"));
            H.AddRoom(new Room("BS", "80", "2/2"));
            HotelList.Add(H);

            f = new Features(true, true, true, false);
            d = new Distance("1.0", "1.0", "1.2");
            H = new Hotels("000888", "Golden Coast Resort", "Calormen street , Narnia", "2.0", f, d);
            H.AddRoom(new Room("KB", "540", "4/2"));
            H.AddRoom(new Room("QB", "410", "3/1"));
            H.AddRoom(new Room("DB", "395", "3/0"));
            H.AddRoom(new Room("BS", "545", "2/2"));
            HotelList.Add(H);

            f = new Features(false, true, true, false);
            d = new Distance("5.0", "5.0", "5.2");
            H = new Hotels("000999", "Holiday Suites", "1231 Great River Rd , Narnia", "4.0", f, d);
            H.AddRoom(new Room("KB", "585", "2/2"));
            H.AddRoom(new Room("QB", "499", "2/0"));
            H.AddRoom(new Room("DB", "445", "5/3"));
            H.AddRoom(new Room("BS", "375", "1/1"));
            HotelList.Add(H);

            f = new Features(true, true, false, false);
            d = new Distance("1.0", "7.0", "5.2");
            H = new Hotels("001000", "Redhaven Suites", "Seven Isles street , Narnia", "4.5", f, d);
            H.AddRoom(new Room("KB", "545", "2/2"));
            H.AddRoom(new Room("QB", "500", "2/0"));
            H.AddRoom(new Room("DB", "515", "3/1"));
            H.AddRoom(new Room("BS", "610", "4/2"));    
            HotelList.Add(H);

            Serial = new XmlSerializer(HotelList.GetType());
            sw = new StreamWriter(HOTEL_FILENAME);
            Serial.Serialize(sw, HotelList);
            sw.Close();
        }

        public static string GetHotelName(string id)
        {
            dezerialize des = new dezerialize();
            List<HotelsList> hotels = des.dezerializeHotels();
            foreach (HotelsList H in hotels)
            {
                if (H.id == id)
                {
                    return H.name;
                }
            }
            return null;
        }
    }
}