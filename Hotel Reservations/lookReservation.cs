using HotelsLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Reservations
{
    public partial class lookReservation : Form
    {
        List<ReservationType> reservations = new List<ReservationType>(); 
        public lookReservation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool foundR = false; 
            String reservationid = reservationBox.Text.Trim();
            dezerialize d = new dezerialize();
            reservations = d.dezerializeReservation(); 
            if (reservations == null)
            {
                found.Text = "Reservation \n not Found";
                Hotellbl.Text = "";
                costlbl.Text = "";
                numNightslbl.Text = "";
                startDatelbl.Text = ""; ;
            }
            else
            {

               
                foreach (ReservationType reserv in reservations)
                {
                    if (reserv.reservationId.Equals(reservationid))
                    {

                        String year = reserv.startDate.Substring(0, 4);
                        String month = reserv.startDate.Substring(4, 2);
                        String day = reserv.startDate.Substring(6, 2);

                        Hotellbl.Text = HotelFactory.GetHotelName(reserv.hotelId);
                        costlbl.Text = "$" + reserv.cost.ToString() +".00";
                        numNightslbl.Text = reserv.numDays.ToString();
                        startDatelbl.Text = month + "/" + day + "/" + year;
                        found.Text = "Reservation Found";
                        foundR = true;
                        break;
                    }
                }
            }
            if (!foundR)
            {
                found.Text = "Reservation \n not Found";
                Hotellbl.Text = "";
                costlbl.Text = "";
                numNightslbl.Text = "";
                startDatelbl.Text = ""; 
            }
        }
    }
}
