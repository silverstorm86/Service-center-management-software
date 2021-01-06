namespace Projector_service_app
{
    partial class DeviceForm
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
            this.ListOfDevices = new System.Windows.Forms.DataGridView();
            this.Add = new System.Windows.Forms.GroupBox();
            this.ModelText = new System.Windows.Forms.TextBox();
            this.ModelLabel = new System.Windows.Forms.Label();
            this.AddDevice = new System.Windows.Forms.Button();
            this.TypeText = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfDevices)).BeginInit();
            this.Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfDevices
            // 
            this.ListOfDevices.AllowUserToAddRows = false;
            this.ListOfDevices.AllowUserToDeleteRows = false;
            this.ListOfDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListOfDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfDevices.Location = new System.Drawing.Point(12, 12);
            this.ListOfDevices.Name = "ListOfDevices";
            this.ListOfDevices.ReadOnly = true;
            this.ListOfDevices.Size = new System.Drawing.Size(276, 365);
            this.ListOfDevices.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.ModelText);
            this.Add.Controls.Add(this.ModelLabel);
            this.Add.Controls.Add(this.AddDevice);
            this.Add.Controls.Add(this.TypeText);
            this.Add.Controls.Add(this.TypeLabel);
            this.Add.Location = new System.Drawing.Point(307, 12);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(200, 219);
            this.Add.TabIndex = 1;
            this.Add.TabStop = false;
            this.Add.Text = "Adding new device";
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(33, 115);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(136, 20);
            this.ModelText.TabIndex = 4;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(30, 98);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(39, 13);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model:";
            // 
            // AddDevice
            // 
            this.AddDevice.Location = new System.Drawing.Point(59, 162);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(88, 31);
            this.AddDevice.TabIndex = 2;
            this.AddDevice.Text = "Add Device";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // TypeText
            // 
            this.TypeText.Location = new System.Drawing.Point(33, 55);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(136, 20);
            this.TypeText.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(30, 38);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(34, 13);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 393);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListOfDevices);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfDevices)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView ListOfDevices;
        private System.Windows.Forms.GroupBox Add;
        private System.Windows.Forms.TextBox ModelText;
        private System.Windows.Forms.Label ModelLabel;
        private System.Windows.Forms.Button AddDevice;
        private System.Windows.Forms.TextBox TypeText;
        private System.Windows.Forms.Label TypeLabel;
    }
}