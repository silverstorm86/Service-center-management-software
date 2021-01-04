namespace Projector_service_app
{
    partial class Main
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
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CustomerLabel = new System.Windows.Forms.Label();
            this.DevicesLabel = new System.Windows.Forms.Label();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.PictureBox();
            this.Customers = new System.Windows.Forms.PictureBox();
            this.Devices = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Status)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusLabel.Location = new System.Drawing.Point(10, 66);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(55, 22);
            this.StatusLabel.TabIndex = 0;
            this.StatusLabel.Text = "Status";
            // 
            // CustomerLabel
            // 
            this.CustomerLabel.AutoSize = true;
            this.CustomerLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerLabel.Location = new System.Drawing.Point(80, 66);
            this.CustomerLabel.Name = "CustomerLabel";
            this.CustomerLabel.Size = new System.Drawing.Size(89, 22);
            this.CustomerLabel.TabIndex = 1;
            this.CustomerLabel.Text = "Customers";
            this.CustomerLabel.Click += new System.EventHandler(this.CustomerLabel_Click);
            // 
            // DevicesLabel
            // 
            this.DevicesLabel.AutoSize = true;
            this.DevicesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DevicesLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DevicesLabel.Location = new System.Drawing.Point(181, 65);
            this.DevicesLabel.Name = "DevicesLabel";
            this.DevicesLabel.Size = new System.Drawing.Size(68, 22);
            this.DevicesLabel.TabIndex = 2;
            this.DevicesLabel.Text = "Devices";
            this.DevicesLabel.Click += new System.EventHandler(this.DevicesLabel_Click);
            // 
            // ExitLabel
            // 
            this.ExitLabel.AutoSize = true;
            this.ExitLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitLabel.Location = new System.Drawing.Point(276, 65);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(38, 22);
            this.ExitLabel.TabIndex = 3;
            this.ExitLabel.Text = "Exit";
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            // 
            // Status
            // 
            this.Status.Image = global::Projector_service_app.Properties.Resources.volume;
            this.Status.Location = new System.Drawing.Point(12, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(50, 50);
            this.Status.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Status.TabIndex = 7;
            this.Status.TabStop = false;
            // 
            // Customers
            // 
            this.Customers.Image = global::Projector_service_app.Properties.Resources.profle;
            this.Customers.Location = new System.Drawing.Point(102, 12);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(50, 50);
            this.Customers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Customers.TabIndex = 6;
            this.Customers.TabStop = false;
            this.Customers.Click += new System.EventHandler(this.Customers_Click);
            // 
            // Devices
            // 
            this.Devices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Devices.Image = global::Projector_service_app.Properties.Resources.videocameracompact;
            this.Devices.Location = new System.Drawing.Point(191, 12);
            this.Devices.Name = "Devices";
            this.Devices.Size = new System.Drawing.Size(50, 50);
            this.Devices.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Devices.TabIndex = 5;
            this.Devices.TabStop = false;
            this.Devices.Click += new System.EventHandler(this.Devices_Click);
            // 
            // Exit
            // 
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = global::Projector_service_app.Properties.Resources.power;
            this.Exit.Location = new System.Drawing.Point(270, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(50, 50);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 4;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(333, 94);
            this.ControlBox = false;
            this.Controls.Add(this.Status);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.Devices);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.ExitLabel);
            this.Controls.Add(this.DevicesLabel);
            this.Controls.Add(this.CustomerLabel);
            this.Controls.Add(this.StatusLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu";
            ((System.ComponentModel.ISupportInitialize)(this.Status)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Customers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Devices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.Label CustomerLabel;
        private System.Windows.Forms.Label DevicesLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.PictureBox Devices;
        private System.Windows.Forms.PictureBox Customers;
        private System.Windows.Forms.PictureBox Status;
    }
}

