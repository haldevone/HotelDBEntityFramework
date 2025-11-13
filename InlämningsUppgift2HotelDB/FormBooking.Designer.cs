namespace InlämningsUppgift2HotelDB
{
    partial class FormBooking
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
            panel1 = new Panel();
            label9 = new Label();
            listBoxBookingResult = new ListBox();
            comboBoxCustomers = new ComboBox();
            buttonBookRoom = new Button();
            buttonBookedRoom = new Button();
            listBoxAvailableRoooms = new ListBox();
            buttonShowAvailableRoooms = new Button();
            comboBoxRoomType = new ComboBox();
            comboBoxNrOfGuests = new ComboBox();
            dateTimePickerCheckOut = new DateTimePicker();
            dateTimePickerCheckIn = new DateTimePicker();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label7 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(listBoxBookingResult);
            panel1.Controls.Add(comboBoxCustomers);
            panel1.Controls.Add(buttonBookRoom);
            panel1.Controls.Add(buttonBookedRoom);
            panel1.Controls.Add(listBoxAvailableRoooms);
            panel1.Controls.Add(buttonShowAvailableRoooms);
            panel1.Controls.Add(comboBoxRoomType);
            panel1.Controls.Add(comboBoxNrOfGuests);
            panel1.Controls.Add(dateTimePickerCheckOut);
            panel1.Controls.Add(dateTimePickerCheckIn);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(49, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(882, 691);
            panel1.TabIndex = 0;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(720, 91);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 14;
            label9.Text = "Lista bokningar:";
            // 
            // listBoxBookingResult
            // 
            listBoxBookingResult.FormattingEnabled = true;
            listBoxBookingResult.Location = new Point(405, 131);
            listBoxBookingResult.Name = "listBoxBookingResult";
            listBoxBookingResult.Size = new Size(428, 464);
            listBoxBookingResult.TabIndex = 13;
            listBoxBookingResult.SelectedIndexChanged += listBoxBookingResult_SelectedIndexChanged;
            listBoxBookingResult.DoubleClick += listBoxBooking_MoreInfo;
            // 
            // comboBoxCustomers
            // 
            comboBoxCustomers.FormattingEnabled = true;
            comboBoxCustomers.Location = new Point(65, 607);
            comboBoxCustomers.Name = "comboBoxCustomers";
            comboBoxCustomers.Size = new Size(151, 28);
            comboBoxCustomers.TabIndex = 11;
            // 
            // buttonBookRoom
            // 
            buttonBookRoom.BackColor = Color.Purple;
            buttonBookRoom.ForeColor = SystemColors.ControlLightLight;
            buttonBookRoom.Location = new Point(222, 607);
            buttonBookRoom.Name = "buttonBookRoom";
            buttonBookRoom.Size = new Size(94, 28);
            buttonBookRoom.TabIndex = 10;
            buttonBookRoom.Text = "Boka";
            buttonBookRoom.UseVisualStyleBackColor = false;
            buttonBookRoom.Click += buttonBookRoom_Click;
            // 
            // buttonBookedRoom
            // 
            buttonBookedRoom.BackColor = Color.Purple;
            buttonBookedRoom.ForeColor = SystemColors.ControlLightLight;
            buttonBookedRoom.Location = new Point(710, 601);
            buttonBookedRoom.Name = "buttonBookedRoom";
            buttonBookedRoom.Size = new Size(123, 29);
            buttonBookedRoom.TabIndex = 7;
            buttonBookedRoom.Text = "Visa bokningar";
            buttonBookedRoom.UseVisualStyleBackColor = false;
            buttonBookedRoom.Click += button1_BookedRooms;
            // 
            // listBoxAvailableRoooms
            // 
            listBoxAvailableRoooms.FormattingEnabled = true;
            listBoxAvailableRoooms.Location = new Point(13, 330);
            listBoxAvailableRoooms.Name = "listBoxAvailableRoooms";
            listBoxAvailableRoooms.Size = new Size(303, 264);
            listBoxAvailableRoooms.TabIndex = 8;
            // 
            // buttonShowAvailableRoooms
            // 
            buttonShowAvailableRoooms.BackColor = Color.Purple;
            buttonShowAvailableRoooms.ForeColor = SystemColors.ControlLightLight;
            buttonShowAvailableRoooms.Location = new Point(13, 280);
            buttonShowAvailableRoooms.Name = "buttonShowAvailableRoooms";
            buttonShowAvailableRoooms.Size = new Size(129, 29);
            buttonShowAvailableRoooms.TabIndex = 7;
            buttonShowAvailableRoooms.Text = "Visa lediga rum";
            buttonShowAvailableRoooms.UseVisualStyleBackColor = false;
            buttonShowAvailableRoooms.Click += button1_AvailableRooms;
            // 
            // comboBoxRoomType
            // 
            comboBoxRoomType.FormattingEnabled = true;
            comboBoxRoomType.Location = new Point(112, 235);
            comboBoxRoomType.Name = "comboBoxRoomType";
            comboBoxRoomType.Size = new Size(151, 28);
            comboBoxRoomType.TabIndex = 6;
            comboBoxRoomType.SelectedIndexChanged += comboBoxRoomType_SelectedIndexChanged;
            // 
            // comboBoxNrOfGuests
            // 
            comboBoxNrOfGuests.FormattingEnabled = true;
            comboBoxNrOfGuests.Location = new Point(112, 198);
            comboBoxNrOfGuests.Name = "comboBoxNrOfGuests";
            comboBoxNrOfGuests.Size = new Size(151, 28);
            comboBoxNrOfGuests.TabIndex = 5;
            // 
            // dateTimePickerCheckOut
            // 
            dateTimePickerCheckOut.Location = new Point(112, 159);
            dateTimePickerCheckOut.Name = "dateTimePickerCheckOut";
            dateTimePickerCheckOut.Size = new Size(204, 27);
            dateTimePickerCheckOut.TabIndex = 4;
            // 
            // dateTimePickerCheckIn
            // 
            dateTimePickerCheckIn.Location = new Point(112, 121);
            dateTimePickerCheckIn.Name = "dateTimePickerCheckIn";
            dateTimePickerCheckIn.Size = new Size(204, 27);
            dateTimePickerCheckIn.TabIndex = 3;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(13, 610);
            label8.Name = "label8";
            label8.Size = new Size(46, 20);
            label8.TabIndex = 2;
            label8.Text = "Kund:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 235);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 2;
            label6.Text = "Rumstyp:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 198);
            label5.Name = "label5";
            label5.Size = new Size(93, 20);
            label5.TabIndex = 1;
            label5.Text = "Antal Gäster:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 159);
            label4.Name = "label4";
            label4.Size = new Size(93, 20);
            label4.TabIndex = 1;
            label4.Text = "Utcheckning:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 121);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 1;
            label3.Text = "Incheckning:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(198, 307);
            label7.Name = "label7";
            label7.Size = new Size(118, 20);
            label7.TabIndex = 0;
            label7.Text = "Lista lediga rum:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 81);
            label2.Name = "label2";
            label2.Size = new Size(85, 20);
            label2.TabIndex = 0;
            label2.Text = "Ny Bokning";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 17);
            label1.Name = "label1";
            label1.Size = new Size(263, 35);
            label1.TabIndex = 0;
            label1.Text = "Hantera Bokningar";
            // 
            // FormBooking
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(973, 735);
            Controls.Add(panel1);
            Name = "FormBooking";
            Text = "FormBooking";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox comboBoxRoomType;
        private ComboBox comboBoxNrOfGuests;
        private DateTimePicker dateTimePickerCheckOut;
        private DateTimePicker dateTimePickerCheckIn;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button buttonBookRoom;
        private ListBox listBoxAvailableRoooms;
        private Button buttonShowAvailableRoooms;
        private Label label7;
        private ComboBox comboBoxCustomers;
        private Label label8;
        private Label label9;
        private ListBox listBoxBookingResult;
        private Button buttonBookedRoom;
    }
}