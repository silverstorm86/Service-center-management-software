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
            this.SelectVisibleOrNot = new System.Windows.Forms.GroupBox();
            this.SelectButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfDevices)).BeginInit();
            this.Add.SuspendLayout();
            this.SelectVisibleOrNot.SuspendLayout();
            this.Search.SuspendLayout();
            this.SuspendLayout();
            // 
            // ListOfDevices
            // 
            this.ListOfDevices.AllowUserToAddRows = false;
            this.ListOfDevices.AllowUserToDeleteRows = false;
            this.ListOfDevices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.ListOfDevices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfDevices.Location = new System.Drawing.Point(16, 15);
            this.ListOfDevices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ListOfDevices.Name = "ListOfDevices";
            this.ListOfDevices.ReadOnly = true;
            this.ListOfDevices.RowHeadersWidth = 51;
            this.ListOfDevices.Size = new System.Drawing.Size(368, 449);
            this.ListOfDevices.TabIndex = 0;
            // 
            // Add
            // 
            this.Add.Controls.Add(this.ModelText);
            this.Add.Controls.Add(this.ModelLabel);
            this.Add.Controls.Add(this.AddDevice);
            this.Add.Controls.Add(this.TypeText);
            this.Add.Controls.Add(this.TypeLabel);
            this.Add.Location = new System.Drawing.Point(409, 15);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Name = "Add";
            this.Add.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add.Size = new System.Drawing.Size(267, 214);
            this.Add.TabIndex = 1;
            this.Add.TabStop = false;
            this.Add.Text = "Adding new device";
            // 
            // ModelText
            // 
            this.ModelText.Location = new System.Drawing.Point(44, 112);
            this.ModelText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ModelText.Name = "ModelText";
            this.ModelText.Size = new System.Drawing.Size(180, 22);
            this.ModelText.TabIndex = 4;
            // 
            // ModelLabel
            // 
            this.ModelLabel.AutoSize = true;
            this.ModelLabel.Location = new System.Drawing.Point(40, 91);
            this.ModelLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ModelLabel.Name = "ModelLabel";
            this.ModelLabel.Size = new System.Drawing.Size(50, 17);
            this.ModelLabel.TabIndex = 3;
            this.ModelLabel.Text = "Model:";
            // 
            // AddDevice
            // 
            this.AddDevice.Location = new System.Drawing.Point(79, 152);
            this.AddDevice.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AddDevice.Name = "AddDevice";
            this.AddDevice.Size = new System.Drawing.Size(117, 38);
            this.AddDevice.TabIndex = 2;
            this.AddDevice.Text = "Add Device";
            this.AddDevice.UseVisualStyleBackColor = true;
            this.AddDevice.Click += new System.EventHandler(this.AddDevice_Click);
            // 
            // TypeText
            // 
            this.TypeText.Location = new System.Drawing.Point(44, 55);
            this.TypeText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TypeText.Name = "TypeText";
            this.TypeText.Size = new System.Drawing.Size(180, 22);
            this.TypeText.TabIndex = 1;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(40, 34);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(44, 17);
            this.TypeLabel.TabIndex = 0;
            this.TypeLabel.Text = "Type:";
            // 
            // SelectVisibleOrNot
            // 
            this.SelectVisibleOrNot.Controls.Add(this.SelectButton);
            this.SelectVisibleOrNot.Location = new System.Drawing.Point(409, 399);
            this.SelectVisibleOrNot.Name = "SelectVisibleOrNot";
            this.SelectVisibleOrNot.Size = new System.Drawing.Size(267, 65);
            this.SelectVisibleOrNot.TabIndex = 2;
            this.SelectVisibleOrNot.TabStop = false;
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(79, 15);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(4);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(117, 38);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            this.Search.Controls.Add(this.textBox1);
            this.Search.Controls.Add(this.label1);
            this.Search.Controls.Add(this.label2);
            this.Search.Controls.Add(this.textBox2);
            this.Search.Location = new System.Drawing.Point(409, 236);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(267, 157);
            this.Search.TabIndex = 3;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(43, 105);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "Model:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(43, 48);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(180, 22);
            this.textBox2.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Type:";
            // 
            // DeviceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 484);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.SelectVisibleOrNot);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ListOfDevices);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DeviceForm";
            this.Text = "DeviceForm";
            ((System.ComponentModel.ISupportInitialize)(this.ListOfDevices)).EndInit();
            this.Add.ResumeLayout(false);
            this.Add.PerformLayout();
            this.SelectVisibleOrNot.ResumeLayout(false);
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
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
        private System.Windows.Forms.GroupBox SelectVisibleOrNot;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}