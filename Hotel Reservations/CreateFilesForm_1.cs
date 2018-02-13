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

namespace Hotel_Reservations
{
    public partial class CreateFilesForm : Form
    {
        XmlSerializer Serial;
        HotelListFactory hotelListFactory = new HotelListFactory();
        HotelFactory hotelFactory = new HotelFactory();
        ReservationFactory reservation = new ReservationFactory(); 
        RoomInventoryFactory RoomIventoryFactory = new RoomInventoryFactory(); 
        public CreateFilesForm()
        {
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
            hotelListFactory.CreateHotelsList();
            BrowserForm frm = new BrowserForm();
            frm.URL = "hotels.xml";
            frm.ShowDialog();
            BrowserForm frm2 = new BrowserForm();
            frm2.URL = "roomInventory.xml";
            frm2.ShowDialog();
        }

        private void btnCreateHotelList_Click(object sender, EventArgs e)
        {

            reservation.GenerateReservation();
        }

        private void dezerializeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
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
    }
}
