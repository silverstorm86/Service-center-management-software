namespace Projector_service_app
{
    partial class CustomerForm
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
            this.ListOfCustomers = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.GroupBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.PostalCodeText = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.TownText = new System.Windows.Forms.TextBox();
            this.TownLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.VATText = new System.Windows.Forms.TextBox();
            this.VatNumberLabel = new System.Windows.Forms.Label();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.AddCustomer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).BeginInit();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfCustomers
            // 
            this.ListOfCustomers.AllowUserToAddRows = false;
            this.ListOfCustomers.AllowUserToDeleteRows = false;
            this.ListOfCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfCustomers.Location = new System.Drawing.Point(12, 12);
            this.ListOfCustomers.Name = "ListOfCustomers";
            this.ListOfCustomers.ReadOnly = true;
            this.ListOfCustomers.Size = new System.Drawing.Size(663, 426);
            this.ListOfCustomers.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.AddCustomer);
            this.Add.Controls.Add(this.PhoneText);
            this.Add.Controls.Add(this.PhoneNumLabel);
            this.Add.Controls.Add(this.EmailText);
            this.Add.Controls.Add(this.EmailLabel);
            this.Add.Controls.Add(this.ContactText);
            this.Add.Controls.Add(this.ContactLabel);
            this.Add.Controls.Add(this.VATText);
            this.Add.Controls.Add(this.VatNumberLabel);
            this.Add.Controls.Add(this.AddressText);
            this.Add.Controls.Add(this.AddressLabel);
            this.Add.Controls.Add(this.TownText);
            this.Add.Controls.Add(this.TownLabel);
            this.Add.Controls.Add(this.PostalCodeText);
            this.Add.Controls.Add(this.PostalCodeLabel);
            this.Add.Controls.Add(this.NameText);
            this.Add.Controls.Add(this.NameLabel);
            this.Add.Location = new System.Drawing.Point(682, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(324, 358);
            this.Add.TabIndex = 1;
            this.Add.TabStop = false;
            this.Add.Text = "Adding new customer";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(17, 35);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(83, 13);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Company name:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(100, 32);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(199, 20);
            this.NameText.TabIndex = 1;
            // 
            // PostalCodeText
            // 
            this.PostalCodeText.Location = new System.Drawing.Point(99, 69);
            this.PostalCodeText.Name = "PostalCodeText";
            this.PostalCodeText.Size = new System.Drawing.Size(36, 20);
            this.PostalCodeText.TabIndex = 3;
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(17, 72);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(66, 13);
            this.PostalCodeLabel.TabIndex = 2;
            this.PostalCodeLabel.Text = "Postal code:";
            // 
            // TownText
            // 
            this.TownText.Location = new System.Drawing.Point(185, 69);
            this.TownText.Name = "TownText";
            this.TownText.Size = new System.Drawing.Size(114, 20);
            this.TownText.TabIndex = 5;
            // 
            // TownLabel
            // 
            this.TownLabel.AutoSize = true;
            this.TownLabel.Location = new System.Drawing.Point(142, 72);
            this.TownLabel.Name = "TownLabel";
            this.TownLabel.Size = new System.Drawing.Size(37, 13);
            this.TownLabel.TabIndex = 4;
            this.TownLabel.Text = "Town:";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(100, 112);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(199, 20);
            this.AddressText.TabIndex = 7;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(17, 112);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(48, 13);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Address:";
            // 
            // VATText
            // 
            this.VATText.Location = new System.Drawing.Point(99, 150);
            this.VATText.Name = "VATText";
            this.VATText.Size = new System.Drawing.Size(87, 20);
            this.VATText.TabIndex = 9;
            // 
            // VatNumberLabel
            // 
            this.VatNumberLabel.AutoSize = true;
            this.VatNumberLabel.Location = new System.Drawing.Point(17, 153);
            this.VatNumberLabel.Name = "VatNumberLabel";
            this.VatNumberLabel.Size = new System.Drawing.Size(69, 13);
            this.VatNumberLabel.TabIndex = 8;
            this.VatNumberLabel.Text = "VAT number:";
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(99, 190);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(200, 20);
            this.ContactText.TabIndex = 11;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(17, 193);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(76, 13);
            this.ContactLabel.TabIndex = 10;
            this.ContactLabel.Text = "Contact name:";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(99, 229);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(200, 20);
            this.EmailText.TabIndex = 13;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(17, 232);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(35, 13);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email:";
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(99, 261);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(200, 20);
            this.PhoneText.TabIndex = 15;
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(17, 264);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(79, 13);
            this.PhoneNumLabel.TabIndex = 14;
            this.PhoneNumLabel.Text = "Phone number:";
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(120, 306);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(101, 31);
            this.AddCustomer.TabIndex = 16;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 450);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListOfCustomers);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfCustomers;
        private System.Windows.Forms.GroupBox Add;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox PostalCodeText;
        private System.Windows.Forms.Label PostalCodeLabel;
        private System.Windows.Forms.TextBox TownText;
        private System.Windows.Forms.Label TownLabel;
        private System.Windows.Forms.TextBox AddressText;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox VATText;
        private System.Windows.Forms.Label VatNumberLabel;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Button AddCustomer;
    }
}