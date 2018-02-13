using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Diagnostics;

namespace HotelsLibrary
{
    public class HotelListFactory
    {
        StreamWriter sw;
        StreamReader sr;
        XmlSerializer Serial;
        //XmlSerializer Serial1;
        List<HotelsList> newList;       //holds data to be entered into hotelslisting.xml
        List<RoomTypes> typeList;       //holds deserialized data from roomtypes.xml
        List<Hotels> oldList;           //holds deserialized data from hotels.xml

        string HOTELSLISTING_FILENAME = @"..\..\hotelslisting.xml";

        public void CreateHotelsList()
        { 
            //holds value
            string hlID;
            string hlName;
            string hlRating;
            string hlRoomType;
            string hlDailyRate;
            string hlCapacity;

            //Reads hotels.xml data
            oldList = new List<Hotels>();
            sr = new StreamReader(@"..\..\hotels.xml");
            Serial = new XmlSerializer(oldList.GetType());
            oldList = (List <Hotels>)Serial.Deserialize(sr);
            sr.Close();

            //Reads roomtypes.xml data
            typeList = new List<RoomTypes>();
            sr = new StreamReader(@"..\..\roomtypes.xml");
            Serial = new XmlSerializer(typeList.GetType());
            typeList = (List <RoomTypes>) Serial.Deserialize(sr);
            sr.Close();

            //initialize newList
            newList = new List<HotelsList>();
            
            //loop through oldList by each Hotel
            for (int i=0; i<oldList.Count; i++)
            {
                hlID = oldList[i].id;           //copy id to local var
                hlName = oldList[i].name;       //copy name to local var
                hlRating = oldList[i].rating;  //copy rating 
                //create H and enter values from local vars
                HotelsList H = new HotelsList(hlID, hlName, hlRating);
                //loop through oldList RoomList by each room
                for (int j=0; j<oldList[i].RoomList.Count; j++)
                {
                    //loop through typeList by each RoomType
                    for (int k=0; k<typeList.Count; k++)
                    {
                        //check to see if each id == id for roomtype
                        if (oldList[i].RoomList[j].id == typeList[k].id)
                        {
                            hlRoomType = typeList[k].name;                          //copy name to local var
                            hlDailyRate = oldList[i].RoomList[j].rate;              //copy rate to local var
                            hlCapacity = oldList[i].RoomList[j].capacity;           //copy capacity to local var
                            //create R and enter values from local vars
                            Room R = new Room(hlRoomType, hlDailyRate, hlCapacity); 
                            //add R to H Rooms
                            H.AddRoomType(R);
                        }    
                    }
                }
                //add H to newList
                newList.Add(H);               
            }
            //Writes hotelslisting.xml                       
            Serial = new XmlSerializer(newList.GetType());
            sw = new StreamWriter(HOTELSLISTING_FILENAME);
            Serial.Serialize(sw, newList);
            sw.Close();
        }
    }
}