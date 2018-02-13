using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HotelsLibrary;
using System.Xml.Linq;
using System.IO;
using System.Net.Mail;
using System.Net;

namespace Hotel_Reservations
{
    public partial class reservationForm : Form
    {
        public double NumberDays { get; private set; }
        public int customerId = 1;
        ReservationFactory r = new ReservationFactory();
        dezerialize a = new dezerialize();
        public bool clicked = false;
        public  List<string> roomid;
        List<HotelsList> hotels = new List<HotelsList>(); 

        public reservationForm()
        {
            InitializeComponent();
            ListBox();
          //  ListBox2();
        }

        private void ListBox()
        {
            hotels = a.dezerializeHotels();
            foreach(HotelsList h in hotels)
            listBox1.Items.Add(h.name);
            
            listBox1.Click += new EventHandler(listBox1_Click);
            

        }

  /*      public void sortlistdecreasing()
        {
            int x = 0;

            hotels = a.dezerializeHotels();
            String i = hotels[0].rating;
            String j = hotels[hotels.Count / 2].rating;
            int y = 1;
            int z = 1;
            String[] Ratings = new String[10];
            while (x < hotels.Count)
            {
                Console.WriteLine(x); 
                 if  (j == hotels[9].rating)
                {
                    Ratings[x] = i;
                    i = hotels[z].rating;
                }
                else
                if (j.CompareTo(i) < 0)
                {
                    Ratings[x] = j;
                    j = hotels[hotels.Count / 2 + y++].rating;
                }
                else
                {
                    Ratings[x] = i;
                  //  i = hotels[z].rating;
                }
                x++;
            }

            foreach(String s in Ratings)
            {
                Console.WriteLine(s + "\n" );
            }
        }
        */

        private string hotelID()
        {
            string hotelName = listBox1.GetItemText(listBox1.SelectedItem);
            List<HotelsList> hotels = a.dezerializeHotels();
            foreach (HotelsList h in hotels)
                if (h.name == hotelName)
                    return h.id;

            return null; 
        }

        private void listBox1_Click(object sender, EventArgs e)
        {

            listBox2.Items.Clear();
            String hotelId = hotelID(); 
            dezerialize a = new dezerialize();
            List<HotelsList> hotels = a.dezerializeHotels();
            foreach (HotelsList r in hotels)
                if (r.id == hotelId)
                {
                    for( int i= 0; i < r.RoomTypes.Count; i++)
                    {
                        listBox2.Items.Add(r.RoomTypes[i].id + " | Price per night: " + r.RoomTypes[i].rate);
                
                    }
                   
                }
        }

        private string hotelRoom ()
        {
            dezerialize a = new dezerialize();
            List<RoomTypes> rooms = a.dezerializeRoomTypes();
            string roomType = listBox2.GetItemText(listBox2.SelectedItem);
            roomType = roomType.Substring(0, 12); 

            Console.Write(roomType);
            foreach (RoomTypes r in rooms)
            {
                String mean = r.name.Substring(0, 12);
                if (mean == roomType)
                    return r.id;
            }

            return null;
        }
        int getDateDifference()
       {
            NumberDays = (int) (monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays;
            int v = Convert.ToInt32(NumberDays); 
            return v;
            //   NumberDays = (int) (monthCalendar1.SelectionEnd - monthCalendar1.SelectionStart).TotalDays;
          //  MessageBox.Show(NumberDays.ToString());
        }

        public ReservationType generation()
        {
            String sd = monthCalendar1.SelectionStart.ToString("yyyyMMdd");
            String cusID;
            randomGeneration ran = new randomGeneration();
            cusID = ran.getCustID(); 

            ReservationType reservation = new ReservationType(hotelID(), sd, getDateDifference(), cusID, hotelRoom());
            if (r.ReserveRoom(reservation))
            {
                String year = reservation.startDate.Substring(0, 4);
                String month = reservation.startDate.Substring(4, 2);
                String day = reservation.startDate.Substring(6, 2);

                MessageBox.Show("The reservation was: " + reservation.result + ".Customer " + reservation.customerId + "  RESERVERD  " + reservation.roomType + " ROOM  for  " + reservation.numDays + " days Starting   " + month + "/" + day + "/" + year + " - $" + reservation.cost);
                String email = EmailBox.Text;
                Console.WriteLine(email); 
                MailMessage message = new MailMessage();
                SmtpClient client = new SmtpClient();
                client.Host = "smtp.gmail.com";
                client.Port = 587;
                client.EnableSsl = true;
                client.Credentials = new NetworkCredential("project.cop4814.email@gmail.com", "danielandmaria");

                 String boo = "Hello " + nameBox.Text + "!!!\n You just reserved a room in " + HotelFactory.GetHotelName(reservation.hotelId) + "\n " + "Your reservation starts: " + month + "/" + day + "/" + year + " for " + reservation.numDays + " nights " + ". The total cost of your reservation is $" + reservation.cost + ".\nTo keep track of your reservation: " + reservation.reservationId +"\n We hope you have an amazing time and thanks for choosing us!!.";
  try
                {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress("mariaadelaidamera@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Information from your reservation!!";
                mail.Body = boo;
              
                    client.Send(mail);
                    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Cannot email the reservation");
                    //MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Cannot reserve because: " + reservation.result);
            }

            return reservation;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            generation();
        }
    }
}
