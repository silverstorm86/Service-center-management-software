namespace Projector_service_app
{
    partial class ModifyRecordForm
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
            this.ErrorText = new System.Windows.Forms.TextBox();
            this.ErrorDesriptionLabel = new System.Windows.Forms.Label();
            this.SerialText = new System.Windows.Forms.TextBox();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.DeviceSelectButton = new System.Windows.Forms.Button();
            this.DeviceModel = new System.Windows.Forms.Label();
            this.DeviceModelLabel = new System.Windows.Forms.Label();
            this.DeviceType = new System.Windows.Forms.Label();
            this.DeviceTypeLabel = new System.Windows.Forms.Label();
            this.SelectCustomerButton = new System.Windows.Forms.Button();
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.MaintanceNumber = new System.Windows.Forms.Label();
            this.MaintanceIDLabel = new System.Windows.Forms.Label();
            this.MaterialCostText = new System.Windows.Forms.TextBox();
            this.MaterialCostLabel = new System.Windows.Forms.Label();
            this.RepairDescriptionText = new System.Windows.Forms.TextBox();
            this.RepairDescriptionLabel = new System.Windows.Forms.Label();
            this.OfferPrice = new System.Windows.Forms.TextBox();
            this.OfferLabel = new System.Windows.Forms.Label();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ErrorText
            // 
            this.ErrorText.Location = new System.Drawing.Point(175, 346);
            this.ErrorText.Multiline = true;
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(195, 103);
            this.ErrorText.TabIndex = 32;
            // 
            // ErrorDesriptionLabel
            // 
            this.ErrorDesriptionLabel.AutoSize = true;
            this.ErrorDesriptionLabel.Location = new System.Drawing.Point(43, 346);
            this.ErrorDesriptionLabel.Name = "ErrorDesriptionLabel";
            this.ErrorDesriptionLabel.Size = new System.Drawing.Size(83, 13);
            this.ErrorDesriptionLabel.TabIndex = 31;
            this.ErrorDesriptionLabel.Text = "Error description";
            // 
            // SerialText
            // 
            this.SerialText.Location = new System.Drawing.Point(175, 282);
            this.SerialText.Name = "SerialText";
            this.SerialText.Size = new System.Drawing.Size(195, 20);
            this.SerialText.TabIndex = 30;
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(43, 282);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(71, 13);
            this.SerialLabel.TabIndex = 29;
            this.SerialLabel.Text = "Serial number";
            // 
            // DeviceSelectButton
            // 
            this.DeviceSelectButton.Location = new System.Drawing.Point(43, 173);
            this.DeviceSelectButton.Name = "DeviceSelectButton";
            this.DeviceSelectButton.Size = new System.Drawing.Size(97, 26);
            this.DeviceSelectButton.TabIndex = 28;
            this.DeviceSelectButton.Text = "Select device";
            this.DeviceSelectButton.UseVisualStyleBackColor = true;
            this.DeviceSelectButton.Click += new System.EventHandler(this.DeviceSelectButton_Click);
            // 
            // DeviceModel
            // 
            this.DeviceModel.AutoSize = true;
            this.DeviceModel.Location = new System.Drawing.Point(268, 232);
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.Size = new System.Drawing.Size(102, 13);
            this.DeviceModel.TabIndex = 27;
            this.DeviceModel.Text = "Device not selected";
            // 
            // DeviceModelLabel
            // 
            this.DeviceModelLabel.AutoSize = true;
            this.DeviceModelLabel.Location = new System.Drawing.Point(172, 232);
            this.DeviceModelLabel.Name = "DeviceModelLabel";
            this.DeviceModelLabel.Size = new System.Drawing.Size(72, 13);
            this.DeviceModelLabel.TabIndex = 26;
            this.DeviceModelLabel.Text = "Device model";
            // 
            // DeviceType
            // 
            this.DeviceType.AutoSize = true;
            this.DeviceType.Location = new System.Drawing.Point(268, 181);
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Size = new System.Drawing.Size(102, 13);
            this.DeviceType.TabIndex = 25;
            this.DeviceType.Text = "Device not selected";
            // 
            // DeviceTypeLabel
            // 
            this.DeviceTypeLabel.AutoSize = true;
            this.DeviceTypeLabel.Location = new System.Drawing.Point(172, 181);
            this.DeviceTypeLabel.Name = "DeviceTypeLabel";
            this.DeviceTypeLabel.Size = new System.Drawing.Size(58, 13);
            this.DeviceTypeLabel.TabIndex = 24;
            this.DeviceTypeLabel.Text = "Devie type";
            // 
            // SelectCustomerButton
            // 
            this.SelectCustomerButton.Location = new System.Drawing.Point(43, 54);
            this.SelectCustomerButton.Name = "SelectCustomerButton";
            this.SelectCustomerButton.Size = new System.Drawing.Size(97, 26);
            this.SelectCustomerButton.TabIndex = 23;
            this.SelectCustomerButton.Text = "Select customer";
            this.SelectCustomerButton.UseVisualStyleBackColor = true;
            this.SelectCustomerButton.Click += new System.EventHandler(this.SelectCustomerButton_Click);
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(268, 113);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(112, 13);
            this.CustomerName.TabIndex = 22;
            this.CustomerName.Text = "Customer not selected";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(172, 113);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(80, 13);
            this.CustomerNameLabel.TabIndex = 21;
            this.CustomerNameLabel.Text = "Customer name";
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(268, 62);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(112, 13);
            this.CustomerID.TabIndex = 20;
            this.CustomerID.Text = "Customer not selected";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(172, 62);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(65, 13);
            this.CustomerIDLabel.TabIndex = 19;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // MaintanceNumber
            // 
            this.MaintanceNumber.AutoSize = true;
            this.MaintanceNumber.Location = new System.Drawing.Point(136, 11);
            this.MaintanceNumber.Name = "MaintanceNumber";
            this.MaintanceNumber.Size = new System.Drawing.Size(54, 13);
            this.MaintanceNumber.TabIndex = 18;
            this.MaintanceNumber.Text = "1MN2021";
            // 
            // MaintanceIDLabel
            // 
            this.MaintanceIDLabel.AutoSize = true;
            this.MaintanceIDLabel.Location = new System.Drawing.Point(40, 11);
            this.MaintanceIDLabel.Name = "MaintanceIDLabel";
            this.MaintanceIDLabel.Size = new System.Drawing.Size(71, 13);
            this.MaintanceIDLabel.TabIndex = 17;
            this.MaintanceIDLabel.Text = "Maintance ID";
            // 
            // MaterialCostText
            // 
            this.MaterialCostText.Location = new System.Drawing.Point(512, 212);
            this.MaterialCostText.Margin = new System.Windows.Forms.Padding(2);
            this.MaterialCostText.Name = "MaterialCostText";
            this.MaterialCostText.Size = new System.Drawing.Size(116, 20);
            this.MaterialCostText.TabIndex = 36;
            this.MaterialCostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MaterialCostLabel
            // 
            this.MaterialCostLabel.AutoSize = true;
            this.MaterialCostLabel.Location = new System.Drawing.Point(440, 215);
            this.MaterialCostLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.MaterialCostLabel.Name = "MaterialCostLabel";
            this.MaterialCostLabel.Size = new System.Drawing.Size(68, 13);
            this.MaterialCostLabel.TabIndex = 35;
            this.MaterialCostLabel.Text = "Material Cost";
            // 
            // RepairDescriptionText
            // 
            this.RepairDescriptionText.Location = new System.Drawing.Point(512, 60);
            this.RepairDescriptionText.Margin = new System.Windows.Forms.Padding(2);
            this.RepairDescriptionText.Multiline = true;
            this.RepairDescriptionText.Name = "RepairDescriptionText";
            this.RepairDescriptionText.Size = new System.Drawing.Size(199, 130);
            this.RepairDescriptionText.TabIndex = 34;
            // 
            // RepairDescriptionLabel
            // 
            this.RepairDescriptionLabel.AutoSize = true;
            this.RepairDescriptionLabel.Location = new System.Drawing.Point(414, 63);
            this.RepairDescriptionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.RepairDescriptionLabel.Name = "RepairDescriptionLabel";
            this.RepairDescriptionLabel.Size = new System.Drawing.Size(94, 13);
            this.RepairDescriptionLabel.TabIndex = 33;
            this.RepairDescriptionLabel.Text = "Repair Description";
            // 
            // OfferPrice
            // 
            this.OfferPrice.Location = new System.Drawing.Point(512, 253);
            this.OfferPrice.Name = "OfferPrice";
            this.OfferPrice.Size = new System.Drawing.Size(116, 20);
            this.OfferPrice.TabIndex = 38;
            this.OfferPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // OfferLabel
            // 
            this.OfferLabel.AutoSize = true;
            this.OfferLabel.Location = new System.Drawing.Point(476, 260);
            this.OfferLabel.Name = "OfferLabel";
            this.OfferLabel.Size = new System.Drawing.Size(30, 13);
            this.OfferLabel.TabIndex = 37;
            this.OfferLabel.Text = "Offer";
            // 
            // ChangeButton
            // 
            this.ChangeButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ChangeButton.Location = new System.Drawing.Point(512, 346);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(133, 46);
            this.ChangeButton.TabIndex = 39;
            this.ChangeButton.Text = "Change";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // ModifyRecordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 468);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.OfferPrice);
            this.Controls.Add(this.OfferLabel);
            this.Controls.Add(this.MaterialCostText);
            this.Controls.Add(this.MaterialCostLabel);
            this.Controls.Add(this.RepairDescriptionText);
            this.Controls.Add(this.RepairDescriptionLabel);
            this.Controls.Add(this.ErrorText);
            this.Controls.Add(this.ErrorDesriptionLabel);
            this.Controls.Add(this.SerialText);
            this.Controls.Add(this.SerialLabel);
            this.Controls.Add(this.DeviceSelectButton);
            this.Controls.Add(this.DeviceModel);
            this.Controls.Add(this.DeviceModelLabel);
            this.Controls.Add(this.DeviceType);
            this.Controls.Add(this.DeviceTypeLabel);
            this.Controls.Add(this.SelectCustomerButton);
            this.Controls.Add(this.CustomerName);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.CustomerID);
            this.Controls.Add(this.CustomerIDLabel);
            this.Controls.Add(this.MaintanceNumber);
            this.Controls.Add(this.MaintanceIDLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModifyRecordForm";
            this.Text = "ModifyRecordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ErrorText;
        private System.Windows.Forms.Label ErrorDesriptionLabel;
        private System.Windows.Forms.TextBox SerialText;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.Button DeviceSelectButton;
        private System.Windows.Forms.Label DeviceModel;
        private System.Windows.Forms.Label DeviceModelLabel;
        private System.Windows.Forms.Label DeviceType;
        private System.Windows.Forms.Label DeviceTypeLabel;
        private System.Windows.Forms.Button SelectCustomerButton;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label MaintanceNumber;
        private System.Windows.Forms.Label MaintanceIDLabel;
        private System.Windows.Forms.TextBox MaterialCostText;
        private System.Windows.Forms.Label MaterialCostLabel;
        private System.Windows.Forms.TextBox RepairDescriptionText;
        private System.Windows.Forms.Label RepairDescriptionLabel;
        private System.Windows.Forms.TextBox OfferPrice;
        private System.Windows.Forms.Label OfferLabel;
        private System.Windows.Forms.Button ChangeButton;
    }
}