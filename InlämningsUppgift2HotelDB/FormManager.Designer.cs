namespace InlämningsUppgift2HotelDB
{
    partial class FormManager
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            buttonInvoices = new Button();
            buttonBookings = new Button();
            buttonCustomerManagement = new Button();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(buttonInvoices);
            panel1.Controls.Add(buttonBookings);
            panel1.Controls.Add(buttonCustomerManagement);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(72, 47);
            panel1.Name = "panel1";
            panel1.Size = new Size(514, 320);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(307, 293);
            label5.Name = "label5";
            label5.Size = new Size(193, 17);
            label5.TabIndex = 4;
            label5.Text = "© HalDev Booking System 2025";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(49, 217);
            label4.Name = "label4";
            label4.Size = new Size(134, 20);
            label4.TabIndex = 4;
            label4.Text = "3. Hantera Fakturor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(49, 182);
            label3.Name = "label3";
            label3.Size = new Size(148, 20);
            label3.TabIndex = 4;
            label3.Text = "2. Hantera Bokningar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 150);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 4;
            label2.Text = "1. Hantera Kunder";
            // 
            // buttonInvoices
            // 
            buttonInvoices.BackColor = Color.Purple;
            buttonInvoices.ForeColor = SystemColors.ControlLightLight;
            buttonInvoices.Location = new Point(281, 85);
            buttonInvoices.Name = "buttonInvoices";
            buttonInvoices.Size = new Size(108, 35);
            buttonInvoices.TabIndex = 3;
            buttonInvoices.Text = "Fakturor";
            buttonInvoices.UseVisualStyleBackColor = false;
            buttonInvoices.Click += buttonInvoices_Click;
            // 
            // buttonBookings
            // 
            buttonBookings.BackColor = Color.Purple;
            buttonBookings.ForeColor = SystemColors.ControlLightLight;
            buttonBookings.Location = new Point(161, 85);
            buttonBookings.Name = "buttonBookings";
            buttonBookings.Size = new Size(101, 35);
            buttonBookings.TabIndex = 2;
            buttonBookings.Text = "Bokningar";
            buttonBookings.UseVisualStyleBackColor = false;
            buttonBookings.Click += buttonBookings_Click;
            // 
            // buttonCustomerManagement
            // 
            buttonCustomerManagement.BackColor = Color.Purple;
            buttonCustomerManagement.ForeColor = SystemColors.ControlLightLight;
            buttonCustomerManagement.Location = new Point(49, 85);
            buttonCustomerManagement.Name = "buttonCustomerManagement";
            buttonCustomerManagement.Size = new Size(92, 35);
            buttonCustomerManagement.TabIndex = 1;
            buttonCustomerManagement.Text = "Kunder";
            buttonCustomerManagement.UseVisualStyleBackColor = false;
            buttonCustomerManagement.Click += buttonCustomerManagement_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(307, 35);
            label1.TabIndex = 0;
            label1.Text = "Hotel Booking System";
            // 
            // FormManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(666, 379);
            Controls.Add(panel1);
            Name = "FormManager";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonInvoices;
        private Button buttonBookings;
        private Button buttonCustomerManagement;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
    }
}
