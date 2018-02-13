using HotelsLibrary;
using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Xsl;   // XslCompiledTransform class
using System.Diagnostics;  // Process class
using System.Threading;

namespace Hotel_Reservations
{
    public partial class CreateFilesForm : Form
    {
        randomGeneration random = new randomGeneration();
        HotelListFactory hotelListFactory = new HotelListFactory();
        HotelFactory hotelFactory = new HotelFactory();
        ReservationFactory reservation = new ReservationFactory();
        ReservationFactory f = new ReservationFactory();
        RoomInventoryFactory RoomIventoryFactory;
        ListenerForm frm = null;
        List<ListenerForm> listenerList = new List<ListenerForm>();
        List<ReservationType> list = new List<ReservationType>();
        reservationForm a = null;
        private String id;

        //  ReservationFactory f = new ReservationFactory();
        public CreateFilesForm()
        {
           // list = ListOfResevations();
            RoomIventoryFactory = new RoomInventoryFactory();
            InitializeComponent();
        }

        private void mnuItemHotelsCreate_Click(object sender, EventArgs e)
        {
          
            hotelFactory.CreateHotel();
        }

        private void mnuItemHotelsDisplay_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
        }

        private void mnuItemRoomInventoryCreate_Click(object sender, EventArgs e)
        {
            RoomIventoryFactory.CreateRoomInventory();
        }

        private void mnuItemRoomInventoryDisplay_Click(object sender, EventArgs e)
        {
            BrowserForm frm = new BrowserForm();
            frm.URL = "roominventory.xml";
            frm.ShowDialog();
        }

        private void btnLoadHotelFile_Click(object sender, EventArgs e)
        {
            RunningReservations();

        }
  
        private void btnCreateHotelList_Click(object sender, EventArgs e)
        {

            reservation.GenerateReservation();
        }



        private void loadHotelFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotelListFactory.CreateHotelsList();
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotelslisting.xml";
            frm.ShowDialog();
        }

        private void displayBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string XSLT_FILENAME = @"..\..\XSLT_ASS2.xslt";
            string HOTELSLISTING_FILENAME = @"..\..\hotelslisting.xml";
            string NEW_HTML_FILENAME = "Assignment2.html";
            string path = @"..\..\img";

            try
            {
                XslCompiledTransform xslt = new XslCompiledTransform();

                xslt.Load(XSLT_FILENAME);
                xslt.Transform(HOTELSLISTING_FILENAME, NEW_HTML_FILENAME);
                lblStatus.Text = "Finished";
                Process.Start(NEW_HTML_FILENAME);
                lblStatus.Text = "Output stored in " + path + "\\" + NEW_HTML_FILENAME;
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void loadHotelAndInventoryFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            hotelListFactory.CreateHotelsList();
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
            RoomIventoryFactory.CreateRoomInventory();
            BrowserForm frm2 = new BrowserForm();
            frm2.URL = "roomInventory.xml";
            frm2.ShowDialog();
        }

        private void processAllTestReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
             a = new reservationForm();
            a.Show(); 
           
        }

        private bool CheckOpened(string id)
        {
            foreach (ListenerForm frm in listenerList)
            {
                if (frm.hotelID == id)
                    return true; 

            }
                return false;
        }

        public void RunningReservations()
        {
            progressBar1.Maximum = list.Count;    
            foreach (ReservationType reserve in list)
            {
                progressBar1.PerformStep();
                //This will take the last ID on the XML form and increase it by one, so if you run the simulator twice it wont generate 1 as the first id even 
                // if we had 30 reservations already
                reserve.customerId = random.getCustID(); 

                if (!f.ReserveRoom(reserve))
                {
                    //If the reservation wansnt completed added to the main method
                    listBox1.Items.Add("Customer " + reserve.customerId + " Tried to RESERVERD  " + reserve.roomType + " at Hotel " + reserve.hotelId + " Starting   " + reserve.startDate);
                }

                this.Refresh(); 
                Thread.Sleep(300);
            }
        }



        //Create a List of Reservation 
        public List<ReservationType> ListOfResevations()
        {
            // randomly choose a hotel ID, starting date, number of days, and  room type
            List<ReservationType>  list = new List<ReservationType>();
            ReservationType reserve;
 
            //String hotelID;
            String roomType;
            int NumDays; 
            int customerId = 1;
            String date;
            Random rnd = new Random(Environment.TickCount);
            string hotelID;
            for (int i = 0; i < 30; i++)
            {
                String custId = "000" + customerId;
               
                Thread.Sleep(50);

                hotelID = random.randomHotelId();

                roomType = random.randomRoomId();
                NumDays = random.randomNumOfDays();
                date = random.randomStarDate();
                reserve = new ReservationType(hotelID, date, NumDays, custId, roomType);
                list.Add(reserve);
 
                customerId++; 
            }

            return list; 

        }

        private void CreateFilesForm_Load(object sender, EventArgs e)
        {
            progressBar1.Step = 1;
            progressBar1.Value = 0;
            int x = 100;
            int y = 100;
            list = ListOfResevations();
            foreach (ReservationType res in list)
            {
                id = res.hotelId;
                if (!CheckOpened(res.hotelId))
                {
                    frm = new ListenerForm(id, HotelFactory.GetHotelName(id), f);
                    frm.Show();
                    frm.Location = new Point(x, y);
                    listenerList.Add(frm);
                    x += 1200;
                }
                if (x == 2500)
                {
                    y += 300;
                    x = 100; 
                }
              
            }
         
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FileInfo vfile = new FileInfo(@"..\..\reservations.xml");
            vfile.Delete();
            foreach (ListenerForm frm in listenerList)
                frm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lookReservation reservationL = new lookReservation();
            reservationL.Show(); 

        }

        private void button2_Click(object sender, EventArgs e)
        {
            a = new reservationForm();
            a.Show();
        }
    }
}
