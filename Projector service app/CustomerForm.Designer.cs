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
            this.VATText = new System.Windows.Forms.MaskedTextBox();
            this.AddCustomer = new System.Windows.Forms.Button();
            this.PhoneText = new System.Windows.Forms.TextBox();
            this.PhoneNumLabel = new System.Windows.Forms.Label();
            this.EmailText = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.ContactText = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.VatNumberLabel = new System.Windows.Forms.Label();
            this.AddressText = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.TownText = new System.Windows.Forms.TextBox();
            this.TownLabel = new System.Windows.Forms.Label();
            this.PostalCodeText = new System.Windows.Forms.TextBox();
            this.PostalCodeLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SelectVisibleOrNot = new System.Windows.Forms.GroupBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.GroupBox();
            this.CompanySearchText = new System.Windows.Forms.TextBox();
            this.CompanySearhLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).BeginInit();
            this.Add.SuspendLayout();
            this.SelectVisibleOrNot.SuspendLayout();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfCustomers
            // 
            this.ListOfCustomers.AllowUserToAddRows = false;
            this.ListOfCustomers.AllowUserToDeleteRows = false;
            this.ListOfCustomers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListOfCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfCustomers.Location = new System.Drawing.Point(16, 15);
            this.ListOfCustomers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListOfCustomers.Name = "ListOfCustomers";
            this.ListOfCustomers.ReadOnly = true;
            this.ListOfCustomers.RowHeadersWidth = 51;
            this.ListOfCustomers.Size = new System.Drawing.Size(884, 524);
            this.ListOfCustomers.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.VATText);
            this.Add.Controls.Add(this.AddCustomer);
            this.Add.Controls.Add(this.PhoneText);
            this.Add.Controls.Add(this.PhoneNumLabel);
            this.Add.Controls.Add(this.EmailText);
            this.Add.Controls.Add(this.EmailLabel);
            this.Add.Controls.Add(this.ContactText);
            this.Add.Controls.Add(this.ContactLabel);
            this.Add.Controls.Add(this.VatNumberLabel);
            this.Add.Controls.Add(this.AddressText);
            this.Add.Controls.Add(this.AddressLabel);
            this.Add.Controls.Add(this.TownText);
            this.Add.Controls.Add(this.TownLabel);
            this.Add.Controls.Add(this.PostalCodeText);
            this.Add.Controls.Add(this.PostalCodeLabel);
            this.Add.Controls.Add(this.NameText);
            this.Add.Controls.Add(this.NameLabel);
            this.Add.Location = new System.Drawing.Point(909, 15);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Size = new System.Drawing.Size(432, 397);
            this.Add.TabIndex = 1;
            this.Add.TabStop = false;
            this.Add.Text = "Adding new customer";
            // 
            // VATText
            // 
            this.VATText.Location = new System.Drawing.Point(132, 170);
            this.VATText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.VATText.Mask = "00000000-0-00";
            this.VATText.Name = "VATText";
            this.VATText.Size = new System.Drawing.Size(132, 22);
            this.VATText.TabIndex = 17;
            // 
            // AddCustomer
            // 
            this.AddCustomer.Location = new System.Drawing.Point(149, 345);
            this.AddCustomer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddCustomer.Name = "AddCustomer";
            this.AddCustomer.Size = new System.Drawing.Size(135, 38);
            this.AddCustomer.TabIndex = 16;
            this.AddCustomer.Text = "Add Customer";
            this.AddCustomer.UseVisualStyleBackColor = true;
            this.AddCustomer.Click += new System.EventHandler(this.AddCustomer_Click);
            // 
            // PhoneText
            // 
            this.PhoneText.Location = new System.Drawing.Point(132, 306);
            this.PhoneText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PhoneText.Name = "PhoneText";
            this.PhoneText.Size = new System.Drawing.Size(265, 22);
            this.PhoneText.TabIndex = 15;
            this.PhoneText.Validating += new System.ComponentModel.CancelEventHandler(this.PhoneText_Validating);
            // 
            // PhoneNumLabel
            // 
            this.PhoneNumLabel.AutoSize = true;
            this.PhoneNumLabel.Location = new System.Drawing.Point(23, 310);
            this.PhoneNumLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNumLabel.Name = "PhoneNumLabel";
            this.PhoneNumLabel.Size = new System.Drawing.Size(105, 17);
            this.PhoneNumLabel.TabIndex = 14;
            this.PhoneNumLabel.Text = "Phone number:";
            // 
            // EmailText
            // 
            this.EmailText.Location = new System.Drawing.Point(132, 267);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(265, 22);
            this.EmailText.TabIndex = 13;
            this.EmailText.Validating += new System.ComponentModel.CancelEventHandler(this.EmailText_Validating);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(23, 271);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(46, 17);
            this.EmailLabel.TabIndex = 12;
            this.EmailLabel.Text = "Email:";
            // 
            // ContactText
            // 
            this.ContactText.Location = new System.Drawing.Point(132, 219);
            this.ContactText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ContactText.Name = "ContactText";
            this.ContactText.Size = new System.Drawing.Size(265, 22);
            this.ContactText.TabIndex = 11;
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.Location = new System.Drawing.Point(23, 223);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(99, 17);
            this.ContactLabel.TabIndex = 10;
            this.ContactLabel.Text = "Contact name:";
            // 
            // VatNumberLabel
            // 
            this.VatNumberLabel.AutoSize = true;
            this.VatNumberLabel.Location = new System.Drawing.Point(23, 173);
            this.VatNumberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatNumberLabel.Name = "VatNumberLabel";
            this.VatNumberLabel.Size = new System.Drawing.Size(91, 17);
            this.VatNumberLabel.TabIndex = 8;
            this.VatNumberLabel.Text = "VAT number:";
            // 
            // AddressText
            // 
            this.AddressText.Location = new System.Drawing.Point(133, 123);
            this.AddressText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddressText.Name = "AddressText";
            this.AddressText.Size = new System.Drawing.Size(264, 22);
            this.AddressText.TabIndex = 7;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(23, 123);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(64, 17);
            this.AddressLabel.TabIndex = 6;
            this.AddressLabel.Text = "Address:";
            // 
            // TownText
            // 
            this.TownText.Location = new System.Drawing.Point(247, 70);
            this.TownText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TownText.Name = "TownText";
            this.TownText.Size = new System.Drawing.Size(151, 22);
            this.TownText.TabIndex = 5;
            // 
            // TownLabel
            // 
            this.TownLabel.AutoSize = true;
            this.TownLabel.Location = new System.Drawing.Point(189, 74);
            this.TownLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TownLabel.Name = "TownLabel";
            this.TownLabel.Size = new System.Drawing.Size(46, 17);
            this.TownLabel.TabIndex = 4;
            this.TownLabel.Text = "Town:";
            // 
            // PostalCodeText
            // 
            this.PostalCodeText.Location = new System.Drawing.Point(132, 70);
            this.PostalCodeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PostalCodeText.MaxLength = 4;
            this.PostalCodeText.Name = "PostalCodeText";
            this.PostalCodeText.Size = new System.Drawing.Size(47, 22);
            this.PostalCodeText.TabIndex = 3;
            this.PostalCodeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PostalCodeText_KeyPress);
            // 
            // PostalCodeLabel
            // 
            this.PostalCodeLabel.AutoSize = true;
            this.PostalCodeLabel.Location = new System.Drawing.Point(23, 74);
            this.PostalCodeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostalCodeLabel.Name = "PostalCodeLabel";
            this.PostalCodeLabel.Size = new System.Drawing.Size(86, 17);
            this.PostalCodeLabel.TabIndex = 2;
            this.PostalCodeLabel.Text = "Postal code:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(133, 26);
            this.NameText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(264, 22);
            this.NameText.TabIndex = 1;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(23, 28);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(110, 17);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Company name:";
            // 
            // SelectVisibleOrNot
            // 
            this.SelectVisibleOrNot.Controls.Add(this.SelectButton);
            this.SelectVisibleOrNot.Location = new System.Drawing.Point(909, 492);
            this.SelectVisibleOrNot.Name = "SelectVisibleOrNot";
            this.SelectVisibleOrNot.Size = new System.Drawing.Size(432, 50);
            this.SelectVisibleOrNot.TabIndex = 2;
            this.SelectVisibleOrNot.TabStop = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(149, 10);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(135, 36);
            this.SelectButton.TabIndex = 0;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.CompanySearchText);
            this.Search.Controls.Add(this.CompanySearhLabel);
            this.Search.Location = new System.Drawing.Point(909, 420);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(432, 66);
            this.Search.TabIndex = 3;
            this.Search.TabStop = false;
            this.Search.Text = "Search ";
            // 
            // CompanySearchText
            // 
            this.CompanySearchText.Location = new System.Drawing.Point(132, 24);
            this.CompanySearchText.Margin = new System.Windows.Forms.Padding(4);
            this.CompanySearchText.Name = "CompanySearchText";
            this.CompanySearchText.Size = new System.Drawing.Size(264, 22);
            this.CompanySearchText.TabIndex = 19;
            this.CompanySearchText.TextChanged += new System.EventHandler(this.CompanySearchText_TextChanged);
            // 
            // CompanySearhLabel
            // 
            this.CompanySearhLabel.AutoSize = true;
            this.CompanySearhLabel.Location = new System.Drawing.Point(22, 26);
            this.CompanySearhLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompanySearhLabel.Name = "CompanySearhLabel";
            this.CompanySearhLabel.Size = new System.Drawing.Size(110, 17);
            this.CompanySearhLabel.TabIndex = 18;
            this.CompanySearhLabel.Text = "Company name:";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1357, 554);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SelectVisibleOrNot);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListOfCustomers);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfCustomers)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.SelectVisibleOrNot.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
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
        private System.Windows.Forms.Label VatNumberLabel;
        private System.Windows.Forms.TextBox PhoneText;
        private System.Windows.Forms.Label PhoneNumLabel;
        private System.Windows.Forms.TextBox EmailText;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox ContactText;
        private System.Windows.Forms.Label ContactLabel;
        private System.Windows.Forms.Button AddCustomer;
        private System.Windows.Forms.MaskedTextBox VATText;
        private System.Windows.Forms.GroupBox SelectVisibleOrNot;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox CompanySearchText;
        private System.Windows.Forms.Label CompanySearhLabel;
    }
}