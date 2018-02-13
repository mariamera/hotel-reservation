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
    public partial class ListenerForm : Form, IObserver
    {
        public String hotelID;
        private String hotelName;
        private ISubject subject;
        private Label lblStatus;
        private ListBox listBox1;
        private ReservationType reservation;

        public ListenerForm()
        {
            InitializeComponent(); 
        }

        public ListenerForm(String id, String HotelName, ReservationFactory subject)
        {
            InitializeComponent();
            this.hotelID = id;
            this.hotelName = HotelName;
            this.subject = subject;
            subject.RegisterObserver(this);
            lblStatus.Text = hotelName + " (" + hotelID + ")";
        }
        public string GetHotelId()
        {
            dezerialize des = new dezerialize();
            List<HotelsList> hotels = des.dezerializeHotels();
            foreach (HotelsList H in hotels)
            {
                if (H.id == this.hotelID)
                {
                    return H.id;
                }
            }
            return null;
        }
        public string GetHotelName()
        {
            dezerialize des = new dezerialize();
            List<HotelsList> hotels = des.dezerializeHotels();
            foreach (HotelsList H in hotels)
            {
                if (H.id == this.hotelID)
                {
                    return H.name;
                }
            }
            return null;
        }

        public void Update(ReservationType reservation)
        {
            this.reservation = reservation; 
            listBox1.Items.Add("Customer " + reservation.customerId + "  RESERVERD  " + reservation.roomType + " ROOM  for  " + reservation.numDays + " days Starting   " + reservation.startDate + " - $" + reservation.cost);
            this.Refresh();
        }

        private void InitializeComponent()
        {
            this.lblStatus = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BackColor = System.Drawing.SystemColors.Control;
            this.lblStatus.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(23, 33);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(328, 33);
            this.lblStatus.TabIndex = 12;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(29, 98);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(532, 121);
            this.listBox1.TabIndex = 13;
            // 
            // ListenerForm
            // 
            this.ClientSize = new System.Drawing.Size(595, 262);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblStatus);
            this.Name = "ListenerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.ResumeLayout(false);
            this.PerformLayout();

        }


    }
}