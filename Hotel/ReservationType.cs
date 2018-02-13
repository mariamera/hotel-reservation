using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Xml.XPath;

namespace HotelsLibrary
{

    public class ReservationType
    {


        public string hotelId { get; set; } // input field
        public string startDate { get; set; } // input field
        public int numDays { get; set; } // input field
        public string customerId { get; set; } // input field
        public string roomType { get; set; } // input field
        public string reservationId { get; set; } // output
        public double cost { get; set; } // output
        public ReservationResultType result { get; set; } // output


        public ReservationType(string hotelId, string startDate, int numDays, string customerId, string roomType)
        {
            this.hotelId = hotelId;
            this.startDate = startDate;
            this.numDays = numDays;
            this.customerId = customerId;
            this.roomType = roomType;

        }


        public ReservationType()
        {


        }

        public enum ReservationResultType
        {
            Success, RoomNotAvailable, UnknownHotelId, UnknownRoomType
        }


    }
}
