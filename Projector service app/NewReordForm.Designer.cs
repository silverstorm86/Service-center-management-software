namespace Projector_service_app
{
    partial class NewReordForm
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
            this.MaintanceIDLabel = new System.Windows.Forms.Label();
            this.MaintanceNumber = new System.Windows.Forms.Label();
            this.CustomerID = new System.Windows.Forms.Label();
            this.CustomerIDLabel = new System.Windows.Forms.Label();
            this.CustomerName = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.SelectCustomerButton = new System.Windows.Forms.Button();
            this.DeviceSelectButton = new System.Windows.Forms.Button();
            this.DeviceModel = new System.Windows.Forms.Label();
            this.DeviceModelLabel = new System.Windows.Forms.Label();
            this.DeviceType = new System.Windows.Forms.Label();
            this.DeviceTypeLabel = new System.Windows.Forms.Label();
            this.SerialLabel = new System.Windows.Forms.Label();
            this.SerialText = new System.Windows.Forms.TextBox();
            this.ErrorText = new System.Windows.Forms.TextBox();
            this.ErrorDesriptionLabel = new System.Windows.Forms.Label();
            this.AddRecordButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // MaintanceIDLabel
            // 
            this.MaintanceIDLabel.AutoSize = true;
            this.MaintanceIDLabel.Location = new System.Drawing.Point(16, 11);
            this.MaintanceIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaintanceIDLabel.Name = "MaintanceIDLabel";
            this.MaintanceIDLabel.Size = new System.Drawing.Size(90, 17);
            this.MaintanceIDLabel.TabIndex = 0;
            this.MaintanceIDLabel.Text = "Maintance ID";
            // 
            // MaintanceNumber
            // 
            this.MaintanceNumber.AutoSize = true;
            this.MaintanceNumber.Location = new System.Drawing.Point(144, 11);
            this.MaintanceNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MaintanceNumber.Name = "MaintanceNumber";
            this.MaintanceNumber.Size = new System.Drawing.Size(69, 17);
            this.MaintanceNumber.TabIndex = 1;
            this.MaintanceNumber.Text = "1MN2021";
            // 
            // CustomerID
            // 
            this.CustomerID.AutoSize = true;
            this.CustomerID.Location = new System.Drawing.Point(320, 74);
            this.CustomerID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(149, 17);
            this.CustomerID.TabIndex = 3;
            this.CustomerID.Text = "Customer not selected";
            // 
            // CustomerIDLabel
            // 
            this.CustomerIDLabel.AutoSize = true;
            this.CustomerIDLabel.Location = new System.Drawing.Point(192, 74);
            this.CustomerIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerIDLabel.Name = "CustomerIDLabel";
            this.CustomerIDLabel.Size = new System.Drawing.Size(85, 17);
            this.CustomerIDLabel.TabIndex = 2;
            this.CustomerIDLabel.Text = "Customer ID";
            // 
            // CustomerName
            // 
            this.CustomerName.AutoSize = true;
            this.CustomerName.Location = new System.Drawing.Point(320, 137);
            this.CustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Size = new System.Drawing.Size(149, 17);
            this.CustomerName.TabIndex = 5;
            this.CustomerName.Text = "Customer not selected";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Location = new System.Drawing.Point(192, 137);
            this.CustomerNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(107, 17);
            this.CustomerNameLabel.TabIndex = 4;
            this.CustomerNameLabel.Text = "Customer name";
            // 
            // SelectCustomerButton
            // 
            this.SelectCustomerButton.Location = new System.Drawing.Point(20, 64);
            this.SelectCustomerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SelectCustomerButton.Name = "SelectCustomerButton";
            this.SelectCustomerButton.Size = new System.Drawing.Size(129, 32);
            this.SelectCustomerButton.TabIndex = 6;
            this.SelectCustomerButton.Text = "Select customer";
            this.SelectCustomerButton.UseVisualStyleBackColor = true;
            this.SelectCustomerButton.Click += new System.EventHandler(this.SelectCustomerButton_Click);
            // 
            // DeviceSelectButton
            // 
            this.DeviceSelectButton.Location = new System.Drawing.Point(20, 210);
            this.DeviceSelectButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DeviceSelectButton.Name = "DeviceSelectButton";
            this.DeviceSelectButton.Size = new System.Drawing.Size(129, 32);
            this.DeviceSelectButton.TabIndex = 11;
            this.DeviceSelectButton.Text = "Select device";
            this.DeviceSelectButton.UseVisualStyleBackColor = true;
            this.DeviceSelectButton.Click += new System.EventHandler(this.DeviceSelectButton_Click);
            // 
            // DeviceModel
            // 
            this.DeviceModel.AutoSize = true;
            this.DeviceModel.Location = new System.Drawing.Point(320, 283);
            this.DeviceModel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeviceModel.Name = "DeviceModel";
            this.DeviceModel.Size = new System.Drawing.Size(132, 17);
            this.DeviceModel.TabIndex = 10;
            this.DeviceModel.Text = "Device not selected";
            // 
            // DeviceModelLabel
            // 
            this.DeviceModelLabel.AutoSize = true;
            this.DeviceModelLabel.Location = new System.Drawing.Point(192, 283);
            this.DeviceModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeviceModelLabel.Name = "DeviceModelLabel";
            this.DeviceModelLabel.Size = new System.Drawing.Size(93, 17);
            this.DeviceModelLabel.TabIndex = 9;
            this.DeviceModelLabel.Text = "Device model";
            // 
            // DeviceType
            // 
            this.DeviceType.AutoSize = true;
            this.DeviceType.Location = new System.Drawing.Point(320, 220);
            this.DeviceType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeviceType.Name = "DeviceType";
            this.DeviceType.Size = new System.Drawing.Size(132, 17);
            this.DeviceType.TabIndex = 8;
            this.DeviceType.Text = "Device not selected";
            // 
            // DeviceTypeLabel
            // 
            this.DeviceTypeLabel.AutoSize = true;
            this.DeviceTypeLabel.Location = new System.Drawing.Point(192, 220);
            this.DeviceTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DeviceTypeLabel.Name = "DeviceTypeLabel";
            this.DeviceTypeLabel.Size = new System.Drawing.Size(75, 17);
            this.DeviceTypeLabel.TabIndex = 7;
            this.DeviceTypeLabel.Text = "Devie type";
            // 
            // SerialLabel
            // 
            this.SerialLabel.AutoSize = true;
            this.SerialLabel.Location = new System.Drawing.Point(20, 345);
            this.SerialLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SerialLabel.Name = "SerialLabel";
            this.SerialLabel.Size = new System.Drawing.Size(96, 17);
            this.SerialLabel.TabIndex = 12;
            this.SerialLabel.Text = "Serial number";
            // 
            // SerialText
            // 
            this.SerialText.Location = new System.Drawing.Point(196, 345);
            this.SerialText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SerialText.Name = "SerialText";
            this.SerialText.Size = new System.Drawing.Size(259, 22);
            this.SerialText.TabIndex = 13;
            // 
            // ErrorText
            // 
            this.ErrorText.Location = new System.Drawing.Point(196, 423);
            this.ErrorText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ErrorText.Multiline = true;
            this.ErrorText.Name = "ErrorText";
            this.ErrorText.Size = new System.Drawing.Size(259, 126);
            this.ErrorText.TabIndex = 15;
            // 
            // ErrorDesriptionLabel
            // 
            this.ErrorDesriptionLabel.AutoSize = true;
            this.ErrorDesriptionLabel.Location = new System.Drawing.Point(20, 423);
            this.ErrorDesriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ErrorDesriptionLabel.Name = "ErrorDesriptionLabel";
            this.ErrorDesriptionLabel.Size = new System.Drawing.Size(113, 17);
            this.ErrorDesriptionLabel.TabIndex = 14;
            this.ErrorDesriptionLabel.Text = "Error description";
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddRecordButton.Location = new System.Drawing.Point(167, 578);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Size = new System.Drawing.Size(151, 50);
            this.AddRecordButton.TabIndex = 16;
            this.AddRecordButton.Text = "Add record";
            this.AddRecordButton.UseVisualStyleBackColor = true;
            this.AddRecordButton.Click += new System.EventHandler(this.AddRecordButton_Click);
            // 
            // NewReordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 644);
            this.Controls.Add(this.AddRecordButton);
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
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewReordForm";
            this.Text = "NewReordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MaintanceIDLabel;
        private System.Windows.Forms.Label MaintanceNumber;
        private System.Windows.Forms.Label CustomerID;
        private System.Windows.Forms.Label CustomerIDLabel;
        private System.Windows.Forms.Label CustomerName;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button SelectCustomerButton;
        private System.Windows.Forms.Button DeviceSelectButton;
        private System.Windows.Forms.Label DeviceModel;
        private System.Windows.Forms.Label DeviceModelLabel;
        private System.Windows.Forms.Label DeviceType;
        private System.Windows.Forms.Label DeviceTypeLabel;
        private System.Windows.Forms.Label SerialLabel;
        private System.Windows.Forms.TextBox SerialText;
        private System.Windows.Forms.TextBox ErrorText;
        private System.Windows.Forms.Label ErrorDesriptionLabel;
        private System.Windows.Forms.Button AddRecordButton;
    }
}