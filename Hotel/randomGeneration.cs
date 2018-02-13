using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HotelsLibrary
{


    public class randomGeneration
    {
        public List<string> HotelIdList = new List<String>();
        Random rnd = new Random(Environment.TickCount);
        public List<HotelsList> hotels;
        int number = 0;

        public bool listHasId(string id)
        {
            foreach(string CurrentId in HotelIdList)
            {
                if (HotelIdList.Equals(id))
                {
                    return true;
                }
            }
            return false;

        }

        public string randomHotelId()
        {
            number = rnd.Next(1, 11) / 2;
            if (number == 0)
               {
                   return "000111";
               }
               if (number >= 10)
               {
                   return "001000";
               }
               return "000" + number + number + number;

        }

        public string randomStarDate()
        {
            int days = rnd.Next(30) + 1;
            return DateTime.Now.AddDays(days).ToString("201609dd");
        }
        public string randomRoomId()
        {
            dezerialize a = new dezerialize();
            List<RoomTypes> roomList = a.dezerializeRoomTypes();
            Random rnd = new Random(Environment.TickCount);
            number = rnd.Next(1, 5);
            switch (number)
            {
                case 1:
                    return roomList[0].id;
                case 2:
                    return roomList[1].id;

                case 3:
                    return roomList[2].id;
                case 4:
                    return roomList[3].id;
            }
            return null;
        }

        public int randomNumOfDays()
        {
            Random rnd = new Random(Environment.TickCount);
            number = rnd.Next(1, 10);

            return number;
        }

        public String getCustID()
        {
            XDocument doc;
            String cusID;
            int cID; 
            if (File.Exists(@"../../reservations.xml") == false)
            {
              return "0001";
            }
            else
            {
                doc = XDocument.Load(@"../../reservations.xml");
                XElement root = doc.Root;
                XElement lastPost = (XElement)root.LastNode;
                cusID = lastPost.Element("customerId").Value;
                cID = Convert.ToInt32(cusID);
                cID++;
               return "000" + cID;
            }
        }
    }
}
