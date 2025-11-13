namespace InlämningsUppgift2HotelDB
{
    partial class FormCustomers
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
            label6 = new Label();
            label5 = new Label();
            panel2 = new Panel();
            buttonSearchCustomers = new Button();
            textBoxCondition = new TextBox();
            listBoxCustomerResult = new ListBox();
            buttonDelete = new Button();
            buttonAdd = new Button();
            buttonUpdate = new Button();
            textBoxCustPhone = new TextBox();
            textBoxCustEmail = new TextBox();
            textBoxCustName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FloralWhite;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonDelete);
            panel1.Controls.Add(buttonAdd);
            panel1.Controls.Add(buttonUpdate);
            panel1.Controls.Add(textBoxCustPhone);
            panel1.Controls.Add(textBoxCustEmail);
            panel1.Controls.Add(textBoxCustName);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(53, 30);
            panel1.Name = "panel1";
            panel1.Size = new Size(741, 522);
            panel1.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 74);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 13;
            label6.Text = "Kund Information";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(408, 74);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 12;
            label5.Text = "Sök Kunder:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.SeaShell;
            panel2.Controls.Add(buttonSearchCustomers);
            panel2.Controls.Add(textBoxCondition);
            panel2.Controls.Add(listBoxCustomerResult);
            panel2.Location = new Point(408, 106);
            panel2.Name = "panel2";
            panel2.Size = new Size(301, 387);
            panel2.TabIndex = 11;
            // 
            // buttonSearchCustomers
            // 
            buttonSearchCustomers.BackColor = Color.Purple;
            buttonSearchCustomers.ForeColor = SystemColors.ControlLightLight;
            buttonSearchCustomers.Location = new Point(200, 3);
            buttonSearchCustomers.Name = "buttonSearchCustomers";
            buttonSearchCustomers.Size = new Size(94, 29);
            buttonSearchCustomers.TabIndex = 9;
            buttonSearchCustomers.Text = "Sök";
            buttonSearchCustomers.UseVisualStyleBackColor = false;
            buttonSearchCustomers.Click += buttonSearchCustomers_Click;
            // 
            // textBoxCondition
            // 
            textBoxCondition.Location = new Point(3, 3);
            textBoxCondition.Name = "textBoxCondition";
            textBoxCondition.PlaceholderText = "Kund Namn";
            textBoxCondition.Size = new Size(191, 27);
            textBoxCondition.TabIndex = 8;
            // 
            // listBoxCustomerResult
            // 
            listBoxCustomerResult.FormattingEnabled = true;
            listBoxCustomerResult.Location = new Point(5, 36);
            listBoxCustomerResult.Name = "listBoxCustomerResult";
            listBoxCustomerResult.Size = new Size(289, 344);
            listBoxCustomerResult.TabIndex = 7;
            listBoxCustomerResult.SelectedIndexChanged += listBoxCustomerResult_SelectedIndexChanged;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.Purple;
            buttonDelete.ForeColor = SystemColors.ControlLightLight;
            buttonDelete.Location = new Point(268, 240);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(96, 34);
            buttonDelete.TabIndex = 10;
            buttonDelete.Text = "Ta bort";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.Purple;
            buttonAdd.ForeColor = SystemColors.ControlLightLight;
            buttonAdd.Location = new Point(26, 240);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(110, 34);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Lägg Till Ny";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpdate
            // 
            buttonUpdate.BackColor = Color.Purple;
            buttonUpdate.ForeColor = SystemColors.ControlLightLight;
            buttonUpdate.Location = new Point(151, 240);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(102, 34);
            buttonUpdate.TabIndex = 9;
            buttonUpdate.Text = "Uppdatera";
            buttonUpdate.UseVisualStyleBackColor = false;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // textBoxCustPhone
            // 
            textBoxCustPhone.Location = new Point(125, 193);
            textBoxCustPhone.Name = "textBoxCustPhone";
            textBoxCustPhone.Size = new Size(239, 27);
            textBoxCustPhone.TabIndex = 6;
            // 
            // textBoxCustEmail
            // 
            textBoxCustEmail.Location = new Point(125, 151);
            textBoxCustEmail.Name = "textBoxCustEmail";
            textBoxCustEmail.Size = new Size(239, 27);
            textBoxCustEmail.TabIndex = 5;
            // 
            // textBoxCustName
            // 
            textBoxCustName.Location = new Point(125, 109);
            textBoxCustName.Name = "textBoxCustName";
            textBoxCustName.Size = new Size(239, 27);
            textBoxCustName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 193);
            label4.Name = "label4";
            label4.Size = new Size(61, 20);
            label4.TabIndex = 3;
            label4.Text = "Telefon:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 151);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 2;
            label3.Text = "E-post:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 109);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "Namn:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(20, 13);
            label1.Name = "label1";
            label1.Size = new Size(224, 35);
            label1.TabIndex = 0;
            label1.Text = "Kund Hantering";
            // 
            // FormCustomers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AntiqueWhite;
            ClientSize = new Size(841, 564);
            Controls.Add(panel1);
            Name = "FormCustomers";
            Text = "FormCustomers";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBoxCustPhone;
        private TextBox textBoxCustEmail;
        private TextBox textBoxCustName;
        private Button buttonDelete;
        private Button buttonUpdate;
        private Button buttonAdd;
        private ListBox listBoxCustomerResult;
        private Panel panel2;
        private Button buttonSearchCustomers;
        private TextBox textBoxCondition;
        private Label label6;
        private Label label5;
    }
}