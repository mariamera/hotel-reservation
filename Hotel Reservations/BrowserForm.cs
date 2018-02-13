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
    public partial class BrowserForm: Form
    {
        public String URL { get; set; }
        private string appPath;

        public BrowserForm()
        {
            InitializeComponent();
            String path = Application.ExecutablePath;
            int index = path.LastIndexOf("\\");
            appPath = path.Substring(0, index) + @"\..\..\";
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            String temp = "file://" + appPath + this.URL;
            this.Text = temp;           
            webBrowserControl.Navigate(temp);
        }
    }
}
