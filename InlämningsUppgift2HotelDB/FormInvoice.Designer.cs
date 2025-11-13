namespace InlämningsUppgift2HotelDB
{
    partial class FormInvoice
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
            buttonRemoveBooking = new Button();
            buttonRegPayment = new Button();
            listBoxInvoiceResult = new ListBox();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(buttonRemoveBooking);
            panel1.Controls.Add(buttonRegPayment);
            panel1.Controls.Add(listBoxInvoiceResult);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(47, 22);
            panel1.Name = "panel1";
            panel1.Size = new Size(711, 546);
            panel1.TabIndex = 0;
            // 
            // buttonRemoveBooking
            // 
            buttonRemoveBooking.BackColor = Color.Purple;
            buttonRemoveBooking.ForeColor = SystemColors.ControlLightLight;
            buttonRemoveBooking.Location = new Point(212, 493);
            buttonRemoveBooking.Name = "buttonRemoveBooking";
            buttonRemoveBooking.Size = new Size(140, 36);
            buttonRemoveBooking.TabIndex = 5;
            buttonRemoveBooking.Text = "Ta bort bokning";
            buttonRemoveBooking.UseVisualStyleBackColor = false;
            buttonRemoveBooking.Click += buttonRemoveBooking_Click;
            // 
            // buttonRegPayment
            // 
            buttonRegPayment.BackColor = Color.Purple;
            buttonRegPayment.ForeColor = SystemColors.ControlLightLight;
            buttonRegPayment.Location = new Point(36, 493);
            buttonRegPayment.Name = "buttonRegPayment";
            buttonRegPayment.Size = new Size(160, 36);
            buttonRegPayment.TabIndex = 4;
            buttonRegPayment.Text = "Registrera betalning";
            buttonRegPayment.UseVisualStyleBackColor = false;
            buttonRegPayment.Click += buttonRegPayment_Click;
            // 
            // listBoxInvoiceResult
            // 
            listBoxInvoiceResult.FormattingEnabled = true;
            listBoxInvoiceResult.Location = new Point(36, 114);
            listBoxInvoiceResult.Name = "listBoxInvoiceResult";
            listBoxInvoiceResult.Size = new Size(643, 364);
            listBoxInvoiceResult.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 82);
            label2.Name = "label2";
            label2.Size = new Size(65, 20);
            label2.TabIndex = 1;
            label2.Text = "Fakturor:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 13);
            label1.Name = "label1";
            label1.Size = new Size(253, 35);
            label1.TabIndex = 0;
            label1.Text = "Faktura Hantering";
            // 
            // FormInvoice
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(804, 599);
            Controls.Add(panel1);
            Name = "FormInvoice";
            Text = "FormInvoice";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button buttonRemoveBooking;
        private Button buttonRegPayment;
        private ListBox listBoxInvoiceResult;
        private Label label2;
    }
}