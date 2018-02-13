namespace Hotel_Reservations
{
    partial class reservationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hotellbl = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.Datelbl = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TypeRoomlbl = new System.Windows.Forms.Label();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.lblStatus = new System.Windows.Forms.Label();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.Namelbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Hotellbl
            // 
            this.Hotellbl.AutoSize = true;
            this.Hotellbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hotellbl.Location = new System.Drawing.Point(44, 25);
            this.Hotellbl.Name = "Hotellbl";
            this.Hotellbl.Size = new System.Drawing.Size(134, 25);
            this.Hotellbl.TabIndex = 0;
            this.Hotellbl.Text = "Select Hotel:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 53);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(209, 121);
            this.listBox1.TabIndex = 1;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(250, 59);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 2;
            // 
            // Datelbl
            // 
            this.Datelbl.AutoSize = true;
            this.Datelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelbl.Location = new System.Drawing.Point(268, 25);
            this.Datelbl.Name = "Datelbl";
            this.Datelbl.Size = new System.Drawing.Size(133, 25);
            this.Datelbl.TabIndex = 3;
            this.Datelbl.Text = "Select Days:";
            // 
            // button1
            // 
            this.button1.AccessibleName = "button_1";
            this.button1.Location = new System.Drawing.Point(337, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "Process";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TypeRoomlbl
            // 
            this.TypeRoomlbl.AutoSize = true;
            this.TypeRoomlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeRoomlbl.Location = new System.Drawing.Point(12, 243);
            this.TypeRoomlbl.Name = "TypeRoomlbl";
            this.TypeRoomlbl.Size = new System.Drawing.Size(182, 25);
            this.TypeRoomlbl.TabIndex = 5;
            this.TypeRoomlbl.Text = "Select RoomType";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(12, 286);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(209, 108);
            this.listBox2.TabIndex = 6;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(247, 307);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(73, 15);
            this.lblStatus.TabIndex = 7;
            this.lblStatus.Text = "Your Email: ";
            // 
            // EmailBox
            // 
            this.EmailBox.Location = new System.Drawing.Point(337, 307);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(140, 20);
            this.EmailBox.TabIndex = 8;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(337, 270);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(140, 20);
            this.nameBox.TabIndex = 10;
            // 
            // Namelbl
            // 
            this.Namelbl.AutoSize = true;
            this.Namelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelbl.Location = new System.Drawing.Point(248, 271);
            this.Namelbl.Name = "Namelbl";
            this.Namelbl.Size = new System.Drawing.Size(72, 15);
            this.Namelbl.TabIndex = 9;
            this.Namelbl.Text = "Your Name:";
            // 
            // reservationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 416);
            this.Controls.Add(this.nameBox);
            this.Controls.Add(this.Namelbl);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.TypeRoomlbl);
            this.Controls.Add(this.Datelbl);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Hotellbl);
            this.Name = "reservationForm";
            this.Text = "reservationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Hotellbl;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label Datelbl;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TypeRoomlbl;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Label Namelbl;
    }
}