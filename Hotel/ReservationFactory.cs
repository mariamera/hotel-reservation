using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace HotelsLibrary
{
    public class ReservationFactory : ISubject
    {
        List<IObserver> observers;
        StreamReader sr;
        XmlSerializer Serial;
        ReservationType reservation = new ReservationType();
        List<ReservationType> list;
        public ReservationFactory()
        {
            observers = new List<IObserver>(); 
        }
        public void RegisterObserver(IObserver objObserver)
        {

            observers.Add(objObserver);
        }

        public void RemoveObserver(IObserver observ)
        {
            int i = observers.IndexOf(observ);
            if (i >= 0)
            {
                observers.Remove(observ);
            }   
        }

        public void NotifyObservers(ReservationType reservation)
        {
            String hotelId; 
            foreach (IObserver ob in observers)
            {
                hotelId = ob.GetHotelId(); 
                //Notify the right observer 
              if  ( hotelId == reservation.hotelId)
                {   
                ob.Update(reservation);
                    break; 
               }

            }
        }



        public List<InventoryType> dezerializeRoomI()
        {
            StreamReader sr;
            List<InventoryType> inventory;  //holds deserialized data from roomInventory.xml
            //Reads InventoryType.xml data
            inventory = new List<InventoryType>();
            sr = new StreamReader(@"..\..\roomInventory.xml");
            Serial = new XmlSerializer(inventory.GetType());
            inventory = (List<InventoryType>)Serial.Deserialize(sr);
            sr.Close();
            return inventory;

        }

        // If the reservation went through save it in reservations.xml
        public void addToSucced(string hotelId, string startDate, int numDays, string customerId, string roomType, double cost, String reservationId, ReservationType.ReservationResultType result)
        {

            if (File.Exists(@"../../reservations.xml") == false)
            {


                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create(@"../../reservations.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("ArrayOfReservationType");

                    xmlWriter.WriteStartElement("ReservationType");
                    xmlWriter.WriteElementString("hotelId", hotelId);
                    xmlWriter.WriteElementString("startDate", startDate);
                    xmlWriter.WriteElementString("numDays", numDays.ToString());
                    xmlWriter.WriteElementString("customerId", customerId);
                    xmlWriter.WriteElementString("roomType", roomType);
                    xmlWriter.WriteElementString("reservationId", reservationId);
                    xmlWriter.WriteElementString("cost", cost.ToString());
                    xmlWriter.WriteElementString("result", result.ToString());
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument doc = XDocument.Load(@"../../reservations.xml");
                XElement school = doc.Element("ArrayOfReservationType");
                school.Add(new XElement("ReservationType",
                           new XElement("hotelId", hotelId),
                           new XElement("startDate", startDate),
                           new XElement("numDays", numDays.ToString()),
                           new XElement("customerId", customerId),
                           new XElement("roomType", roomType),
                           new XElement("reservationId", reservationId),
                           new XElement("cost", cost),
                           new XElement("result", result)));
                doc.Save(@"../../reservations.xml");
            }

        }


        public double calculatePrice(int roomRate, int numberOfDays)
        {
            int cost = roomRate * numberOfDays;
            return cost;
        }

        public bool CheckAvailable(ReservationType curretReservation, String Quantity)
        {
       
           // List<ReservationType> currentList;
            List<string> Reservation;
            int roomsAvailable = (int.Parse(Quantity));
            List<String> listOfDays = CreateDateList(curretReservation.startDate, curretReservation.numDays);
            String CheckIn = listOfDays[0];
            String CheckOut = listOfDays[listOfDays.Count - 1];
            // if the files doesn't exist will return true since there is no other preview reservation
            if (File.Exists(@"../../reservations.xml") == false ) 
            { if (CheckOut.CompareTo("20160930") < 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
               
            } 

            list = new List<ReservationType>();
            sr = new StreamReader(@"..\..\reservations.xml");
            Serial = new XmlSerializer(list.GetType());
            list = (List<ReservationType>)Serial.Deserialize(sr);
            sr.Close();

            if (CheckOut.CompareTo("20160930") > 0) // if the room is outside the range of the hotel dates
            {
                return false;
            }

            else if (list.Count <= roomsAvailable - 1)
            {
                //Room Available because there are less reservations than rooms

                return true;

            }

            else {
                for (int i = 0; i < list.Count; i++)
                {
              
                        Reservation = CreateDateList(list[i].startDate, list[i].numDays);

                    //to confirm we are checking in the same hotel ans same roomtype
                        if (curretReservation.hotelId == list[i].hotelId && curretReservation.roomType == list[i].roomType && list[i].result == ReservationType.ReservationResultType.Success) 
                        {
 

                            // see if the current reservation  interfier with any preview reservation made
                            if ((Reservation[0].CompareTo(CheckOut) <= 0 && Reservation[Reservation.Count - 1].CompareTo(CheckIn) >= 0))
                           {

                                //decrease the room amount
                                roomsAvailable--;

                        }            
                    
                     }
                    if (roomsAvailable <= 0)
                    {
                        return false;

                    }
                }
                    
            }
            return true; 

        }

        public List<string> CreateDateList(String startDate, int numDays)
        {
            List<String> result = new List<String>();
            result.Add(startDate);
            int year = Convert.ToInt32(startDate.Substring(0, 4));
            int month = Convert.ToInt32(startDate.Substring(4, 2));
            int day = Convert.ToInt32(startDate.Substring(6, 2));
            DateTime current = new DateTime(year, month, day);

            for (int i = 1; i < numDays; i++)
            {
                current = current.AddDays(1);
                result.Add(current.ToString("yyyyMMdd"));
            }
            return result;
        }



        public bool ReserveRoom(ReservationType reservation)
        {
            List<InventoryType> inventory;  //holds deserialized data from roomInventory.xml
            List<HotelsList> hotels;
            List<RoomTypes> roomamount;
            StreamReader sr;
            XmlSerializer Serial;
            bool UnknownHotelId = false;
            bool UnknownRoomType = false;

            int x = 0;

            //Reads InventoryType.xml data
            inventory = dezerializeRoomI();

            //Reads hotels.xml data
            hotels = new List<HotelsList>();
            sr = new StreamReader(@"..\..\hotelslisting.xml");
            Serial = new XmlSerializer(hotels.GetType());
            hotels = (List<HotelsList>)Serial.Deserialize(sr);
            sr.Close();

            //Reads roomtypes.xml data
            roomamount = new List<RoomTypes>();
            sr = new StreamReader(@"..\..\roomtypes.xml");
            Serial = new XmlSerializer(roomamount.GetType());
            roomamount = (List<RoomTypes>)Serial.Deserialize(sr);
            sr.Close();

            //loop through inventory file by each Hotel
            for (int i = 0; i < inventory.Count; i++)
            {
                //loop if the hotelId exist
                if (reservation.hotelId == inventory[i].HotelId)
                {
                    //this is to divide i by the number of rooms so we can find out the hotel 
                    int numberOfRooms = roomamount.Count();
                    x = i / numberOfRooms;


                    for (int j = 0; j < hotels[x].RoomTypes.Count; j++) // loop through all the types that can happen in the hotels file
                    {
                        if (reservation.roomType == inventory[j].RoomType ) // check if the room type maches
                        {
                            //Create a reservation ID
                            Random rnd = new Random();
                            reservation.reservationId = rnd.Next().ToString();
                            //Calculate the cost of the reservation with method
                            reservation.cost = calculatePrice(int.Parse(hotels[x].RoomTypes[j].rate), reservation.numDays);
                           if( CheckAvailable(reservation, inventory[j].quantity))
                            {
                                reservation.result = ReservationType.ReservationResultType.Success;
                                addToSucced(reservation.hotelId, reservation.startDate, reservation.numDays, reservation.customerId, reservation.roomType, reservation.cost, reservation.reservationId, reservation.result);
                                NotifyObservers(reservation); 
                                return true;
                            }
                            else
                            {
                                reservation.result = ReservationType.ReservationResultType.RoomNotAvailable;
                                reservation.cost = 0;
                                reservation.reservationId = null;
                                addToSucced(reservation.hotelId, reservation.startDate, reservation.numDays, reservation.customerId, reservation.roomType, reservation.cost, reservation.reservationId, reservation.result);
                               // NotifyObservers(reservation);
                                return false; 
                            }


                        }
                        else
                        {
                            UnknownRoomType = true;
                        }

                    }
                }
                else
                {
                    UnknownHotelId = true;
                }

            }

            if (UnknownRoomType == true)
            {
                reservation.result = ReservationType.ReservationResultType.UnknownRoomType;
                reservation.cost = 0;
                reservation.reservationId = null;
                addToSucced(reservation.hotelId, reservation.startDate, reservation.numDays, reservation.customerId, reservation.roomType, reservation.cost, reservation.reservationId, reservation.result);
               
            }
            else if (UnknownHotelId == true)
            {
                reservation.result = ReservationType.ReservationResultType.UnknownHotelId;
                reservation.cost = 0;
                reservation.reservationId = null;
                addToSucced(reservation.hotelId, reservation.startDate, reservation.numDays, reservation.customerId, reservation.roomType, reservation.cost, reservation.reservationId, reservation.result);
             
            }

            return false;
        }
       
        public void GenerateReservation()
        {
            list = new List<ReservationType>();

            ReservationType reserve = new ReservationType("000111", "20160905", 1, "00001", "KB");
            ReserveRoom(reserve); 
            reserve = new ReservationType("000111", "20160905", 4, "00002", "KB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160905", 5, "00003", "KB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160907", 3, "00004", "KB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160909", 4, "00005", "KB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160906", 5, "00006", "KB"); // fails - room not available
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160905", 1, "00007", "QB");
            ReserveRoom(reserve);
           reserve = new ReservationType("000111", "20160905", 1, "00008", "KB"); // fails- room not available
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20160905", 4, "00009", "QB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000111", "20170905", 1, "00010", "KB"); // fails- room not available
            ReserveRoom(reserve);
            reserve = new ReservationType("000555", "20160915", 5, "00011", "QB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000555", "20160925", 10, "00012", "QB");  // fails- room not available.
            ReserveRoom(reserve);                                                   
            reserve = new ReservationType("000555", "20160907", 3, "00013", "QB"); 
            ReserveRoom(reserve);
            reserve = new ReservationType("000555", "20160909", 3, "00014", "KB");
            ReserveRoom(reserve);
            reserve = new ReservationType("000555", "20160905", 1, "00015", "AB"); // fails- unknown room type
            ReserveRoom(reserve);
            reserve = new ReservationType("000998", "20160905", 1, "00016", "DB"); // fails- unknown hotel ID. I changed the ID you gave us cause that was a hotel on our program 
            ReserveRoom(reserve);     

        }


     
    }
}
