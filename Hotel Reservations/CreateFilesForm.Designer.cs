namespace Hotel_Reservations
{
    partial class CreateFilesForm
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
            this.lblStatus = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHotelsXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHotelsCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemHotelsDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRoomInventoryXML = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRoomInventoryCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuItemRoomInventoryDisplay = new System.Windows.Forms.ToolStripMenuItem();
            this.assigment2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHotelFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayBrowserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.assigment3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadHotelAndInventoryFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.processAllTestReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoadHotelFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(9, 237);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(137, 15);
            this.lblStatus.TabIndex = 4;
            this.lblStatus.Text = "(status of last operation)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.assigment2ToolStripMenuItem,
            this.assigment3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(588, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHotelsXML,
            this.mnuItemRoomInventoryXML});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(102, 24);
            this.toolStripMenuItem1.Text = "Assigment 1";
            // 
            // mnuItemHotelsXML
            // 
            this.mnuItemHotelsXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHotelsCreate,
            this.mnuItemHotelsDisplay});
            this.mnuItemHotelsXML.Name = "mnuItemHotelsXML";
            this.mnuItemHotelsXML.Size = new System.Drawing.Size(202, 24);
            this.mnuItemHotelsXML.Text = "hotels.xml";
            // 
            // mnuItemHotelsCreate
            // 
            this.mnuItemHotelsCreate.Name = "mnuItemHotelsCreate";
            this.mnuItemHotelsCreate.Size = new System.Drawing.Size(152, 24);
            this.mnuItemHotelsCreate.Text = "Create file";
            this.mnuItemHotelsCreate.Click += new System.EventHandler(this.mnuItemHotelsCreate_Click);
            // 
            // mnuItemHotelsDisplay
            // 
            this.mnuItemHotelsDisplay.Name = "mnuItemHotelsDisplay";
            this.mnuItemHotelsDisplay.Size = new System.Drawing.Size(152, 24);
            this.mnuItemHotelsDisplay.Text = "Display file";
            this.mnuItemHotelsDisplay.Click += new System.EventHandler(this.mnuItemHotelsDisplay_Click);
            // 
            // mnuItemRoomInventoryXML
            // 
            this.mnuItemRoomInventoryXML.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemRoomInventoryCreate,
            this.mnuItemRoomInventoryDisplay});
            this.mnuItemRoomInventoryXML.Name = "mnuItemRoomInventoryXML";
            this.mnuItemRoomInventoryXML.Size = new System.Drawing.Size(202, 24);
            this.mnuItemRoomInventoryXML.Text = "roominventory.xml";
            // 
            // mnuItemRoomInventoryCreate
            // 
            this.mnuItemRoomInventoryCreate.Name = "mnuItemRoomInventoryCreate";
            this.mnuItemRoomInventoryCreate.Size = new System.Drawing.Size(152, 24);
            this.mnuItemRoomInventoryCreate.Text = "Create file";
            this.mnuItemRoomInventoryCreate.Click += new System.EventHandler(this.mnuItemRoomInventoryCreate_Click);
            // 
            // mnuItemRoomInventoryDisplay
            // 
            this.mnuItemRoomInventoryDisplay.Name = "mnuItemRoomInventoryDisplay";
            this.mnuItemRoomInventoryDisplay.Size = new System.Drawing.Size(152, 24);
            this.mnuItemRoomInventoryDisplay.Text = "Display file";
            this.mnuItemRoomInventoryDisplay.Click += new System.EventHandler(this.mnuItemRoomInventoryDisplay_Click);
            // 
            // assigment2ToolStripMenuItem
            // 
            this.assigment2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHotelFileToolStripMenuItem,
            this.displayBrowserToolStripMenuItem});
            this.assigment2ToolStripMenuItem.Name = "assigment2ToolStripMenuItem";
            this.assigment2ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.assigment2ToolStripMenuItem.Text = "Assigment 2";
            // 
            // loadHotelFileToolStripMenuItem
            // 
            this.loadHotelFileToolStripMenuItem.Name = "loadHotelFileToolStripMenuItem";
            this.loadHotelFileToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.loadHotelFileToolStripMenuItem.Text = "Load Hotel File";
            this.loadHotelFileToolStripMenuItem.Click += new System.EventHandler(this.loadHotelFileToolStripMenuItem_Click);
            // 
            // displayBrowserToolStripMenuItem
            // 
            this.displayBrowserToolStripMenuItem.Name = "displayBrowserToolStripMenuItem";
            this.displayBrowserToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.displayBrowserToolStripMenuItem.Text = "Display browser";
            this.displayBrowserToolStripMenuItem.Click += new System.EventHandler(this.displayBrowserToolStripMenuItem_Click);
            // 
            // assigment3ToolStripMenuItem
            // 
            this.assigment3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadHotelAndInventoryFileToolStripMenuItem,
            this.processAllTestReservationsToolStripMenuItem});
            this.assigment3ToolStripMenuItem.Name = "assigment3ToolStripMenuItem";
            this.assigment3ToolStripMenuItem.Size = new System.Drawing.Size(102, 24);
            this.assigment3ToolStripMenuItem.Text = "Assigment 3";
            // 
            // loadHotelAndInventoryFileToolStripMenuItem
            // 
            this.loadHotelAndInventoryFileToolStripMenuItem.Name = "loadHotelAndInventoryFileToolStripMenuItem";
            this.loadHotelAndInventoryFileToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.loadHotelAndInventoryFileToolStripMenuItem.Text = "Load Hotel and Inventory File";
            this.loadHotelAndInventoryFileToolStripMenuItem.Click += new System.EventHandler(this.loadHotelAndInventoryFileToolStripMenuItem_Click);
            // 
            // processAllTestReservationsToolStripMenuItem
            // 
            this.processAllTestReservationsToolStripMenuItem.Name = "processAllTestReservationsToolStripMenuItem";
            this.processAllTestReservationsToolStripMenuItem.Size = new System.Drawing.Size(273, 24);
            this.processAllTestReservationsToolStripMenuItem.Text = "Process all Test Reservations";
            this.processAllTestReservationsToolStripMenuItem.Click += new System.EventHandler(this.processAllTestReservationsToolStripMenuItem_Click);
            // 
            // btnLoadHotelFile
            // 
            this.btnLoadHotelFile.Location = new System.Drawing.Point(12, 43);
            this.btnLoadHotelFile.Name = "btnLoadHotelFile";
            this.btnLoadHotelFile.Size = new System.Drawing.Size(215, 28);
            this.btnLoadHotelFile.TabIndex = 7;
            this.btnLoadHotelFile.Text = "Run Reservation Simulation";
            this.btnLoadHotelFile.UseVisualStyleBackColor = true;
            this.btnLoadHotelFile.Click += new System.EventHandler(this.btnLoadHotelFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(233, 43);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(323, 28);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 8;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(544, 121);
            this.listBox1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(162, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 25);
            this.button1.TabIndex = 10;
            this.button1.Text = "Look For a reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(372, 224);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 25);
            this.button2.TabIndex = 11;
            this.button2.Text = "Generate One Reservation";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreateFilesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(588, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnLoadHotelFile);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CreateFilesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hotel Reservations v5.0";
            this.Load += new System.EventHandler(this.CreateFilesForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHotelsXML;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHotelsCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHotelsDisplay;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRoomInventoryXML;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRoomInventoryCreate;
        private System.Windows.Forms.ToolStripMenuItem mnuItemRoomInventoryDisplay;
        private System.Windows.Forms.Button btnLoadHotelFile;
        private System.Windows.Forms.ToolStripMenuItem assigment2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHotelFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayBrowserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem assigment3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadHotelAndInventoryFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem processAllTestReservationsToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

