using HotelsLibrary;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelsLibrary
{
    public class RoomInventoryFactory
    {
        StreamWriter sw;
        XmlSerializer Serial;
        List<InventoryType> RoomInventoryList;
        const string HOTEL_FILENAME = @"..\..\roomInventory.xml";

        public void CreateRoomInventory()
        {
            RoomInventoryList = new List<InventoryType>();
            //Hotels H =  Deserialize();
            InventoryType R = new InventoryType("20160905", "000111", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160901","000111","QB","3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160915", "000111", "DB", "4");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160902", "000111", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160911", "000222", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160921", "000222", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160906", "000222", "DB", "4");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160910", "000222", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160911", "000333", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160929", "000333", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160923", "000333", "DB", "2");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160907", "000333", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160905", "000444", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160912", "000444", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160916", "000444", "DB", "2");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160920", "000444", "BS", "3");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160905", "000555", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000555", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000555", "DB", "1");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000555", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160920", "000666", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160923", "000666", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("201609025", "000666", "DB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("201609023", "000666", "BS", "5");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160904", "000777", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000777", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("201609008", "000777", "DB", "1");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160912", "000777", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160914", "000888", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160924", "000888", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160906", "000888", "DB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160920", "000888", "BS", "2");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160905", "000999", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000999", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000999", "DB", "5");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160905", "000999", "BS", "1");
            RoomInventoryList.Add(R);

            R = new InventoryType("20160906", "001000", "KB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160908", "001000", "QB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160912", "001000", "DB", "3");
            RoomInventoryList.Add(R);
            R = new InventoryType("20160924", "001000", "BS", "4");
            RoomInventoryList.Add(R);

          //  XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
           // namespaces.Add(string.Empty, string.Empty);
            Serial = new XmlSerializer(RoomInventoryList.GetType());
            sw = new StreamWriter(HOTEL_FILENAME);
            Serial.Serialize(sw, RoomInventoryList);
            sw.Close();
        }
        public Hotels Deserialize()
        {
            using (TextReader reader = new StreamReader(@"..\..\hotels.xml"))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Hotels));
                return (Hotels)serializer.Deserialize(reader);
            }
        }

        //change two letter code to string room name
        //loop through RoomInventoryList
        //look at roomtype variable
        
    }

}



