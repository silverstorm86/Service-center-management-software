namespace Projector_service_app
{
    partial class MoreInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.CompName = new System.Windows.Forms.Label();
            this.PostalCode = new System.Windows.Forms.Label();
            this.Town = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.Label();
            this.VatNum = new System.Windows.Forms.Label();
            this.ContactName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.PhoneNum = new System.Windows.Forms.Label();
            this.Customer = new System.Windows.Forms.GroupBox();
            this.Customer.SuspendLayout();
            this.SuspendLayout();
            // 
            // CompName
            // 
            this.CompName.AutoSize = true;
            this.CompName.Location = new System.Drawing.Point(18, 35);
            this.CompName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CompName.Name = "CompName";
            this.CompName.Size = new System.Drawing.Size(53, 14);
            this.CompName.TabIndex = 1;
            this.CompName.Text = "CompName";
            // 
            // PostalCode
            // 
            this.PostalCode.AutoSize = true;
            this.PostalCode.Location = new System.Drawing.Point(18, 63);
            this.PostalCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PostalCode.Name = "PostalCode";
            this.PostalCode.Size = new System.Drawing.Size(53, 14);
            this.PostalCode.TabIndex = 2;
            this.PostalCode.Text = "PostalCode";
            // 
            // Town
            // 
            this.Town.AutoSize = true;
            this.Town.Location = new System.Drawing.Point(85, 63);
            this.Town.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Town.Name = "Town";
            this.Town.Size = new System.Drawing.Size(28, 14);
            this.Town.TabIndex = 3;
            this.Town.Text = "Town";
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(18, 91);
            this.Address.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(42, 14);
            this.Address.TabIndex = 4;
            this.Address.Text = "Address";
            // 
            // VatNum
            // 
            this.VatNum.AutoSize = true;
            this.VatNum.Location = new System.Drawing.Point(18, 124);
            this.VatNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.VatNum.Name = "VatNum";
            this.VatNum.Size = new System.Drawing.Size(38, 14);
            this.VatNum.TabIndex = 5;
            this.VatNum.Text = "VatNum";
            // 
            // ContactName
            // 
            this.ContactName.AutoSize = true;
            this.ContactName.Location = new System.Drawing.Point(18, 158);
            this.ContactName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactName.Name = "ContactName";
            this.ContactName.Size = new System.Drawing.Size(62, 14);
            this.ContactName.TabIndex = 6;
            this.ContactName.Text = "ContactName";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(18, 194);
            this.Email.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(28, 14);
            this.Email.TabIndex = 7;
            this.Email.Text = "Email";
            // 
            // PhoneNum
            // 
            this.PhoneNum.AutoSize = true;
            this.PhoneNum.Location = new System.Drawing.Point(18, 234);
            this.PhoneNum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhoneNum.Name = "PhoneNum";
            this.PhoneNum.Size = new System.Drawing.Size(50, 14);
            this.PhoneNum.TabIndex = 8;
            this.PhoneNum.Text = "PhoneNum";
            // 
            // Customer
            // 
            this.Customer.Controls.Add(this.ContactName);
            this.Customer.Controls.Add(this.PhoneNum);
            this.Customer.Controls.Add(this.CompName);
            this.Customer.Controls.Add(this.Email);
            this.Customer.Controls.Add(this.PostalCode);
            this.Customer.Controls.Add(this.Town);
            this.Customer.Controls.Add(this.VatNum);
            this.Customer.Controls.Add(this.Address);
            this.Customer.Location = new System.Drawing.Point(3, 3);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(274, 275);
            this.Customer.TabIndex = 9;
            this.Customer.TabStop = false;
            this.Customer.Text = "Customer details";
            // 
            // MoreInformation
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Customer);
            this.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "MoreInformation";
            this.Size = new System.Drawing.Size(595, 842);
            this.Customer.ResumeLayout(false);
            this.Customer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label CompName;
        private System.Windows.Forms.Label PostalCode;
        private System.Windows.Forms.Label Town;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label VatNum;
        private System.Windows.Forms.Label ContactName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label PhoneNum;
        private System.Windows.Forms.GroupBox Customer;
    }
}
