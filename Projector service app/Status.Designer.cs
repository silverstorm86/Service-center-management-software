namespace Projector_service_app
{
    partial class Status
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
            this.Search = new System.Windows.Forms.GroupBox();
            this.ListOfMaintenane = new System.Windows.Forms.DataGridView();
            this.IDLabel = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.InService = new System.Windows.Forms.CheckBox();
            this.OutService = new System.Windows.Forms.CheckBox();
            this.Repaired = new System.Windows.Forms.CheckBox();
            this.NewRecord = new System.Windows.Forms.Button();
            this.MoreInfo = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfMaintenane)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Controls.Add(this.Repaired);
            this.Search.Controls.Add(this.OutService);
            this.Search.Controls.Add(this.InService);
            this.Search.Controls.Add(this.CompanyText);
            this.Search.Controls.Add(this.CompanyLabel);
            this.Search.Controls.Add(this.IDText);
            this.Search.Controls.Add(this.IDLabel);
            this.Search.Location = new System.Drawing.Point(13, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(1278, 72);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // ListOfMaintenane
            // 
            this.ListOfMaintenane.AllowUserToAddRows = false;
            this.ListOfMaintenane.AllowUserToDeleteRows = false;
            this.ListOfMaintenane.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfMaintenane.Location = new System.Drawing.Point(13, 92);
            this.ListOfMaintenane.Name = "ListOfMaintenane";
            this.ListOfMaintenane.ReadOnly = true;
            this.ListOfMaintenane.RowHeadersWidth = 51;
            this.ListOfMaintenane.RowTemplate.Height = 24;
            this.ListOfMaintenane.Size = new System.Drawing.Size(1278, 604);
            this.ListOfMaintenane.TabIndex = 1;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(35, 32);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(67, 17);
            this.IDLabel.TabIndex = 0;
            this.IDLabel.Text = "Repair ID";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(108, 30);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 1;
            // 
            // CompanyText
            // 
            this.CompanyText.Location = new System.Drawing.Point(322, 30);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(220, 22);
            this.CompanyText.TabIndex = 3;
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(252, 32);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(67, 17);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Company";
            // 
            // InService
            // 
            this.InService.AutoSize = true;
            this.InService.Location = new System.Drawing.Point(859, 30);
            this.InService.Name = "InService";
            this.InService.Size = new System.Drawing.Size(114, 21);
            this.InService.TabIndex = 4;
            this.InService.Text = "In the service";
            this.InService.UseVisualStyleBackColor = true;
            // 
            // OutService
            // 
            this.OutService.AutoSize = true;
            this.OutService.Location = new System.Drawing.Point(1118, 30);
            this.OutService.Name = "OutService";
            this.OutService.Size = new System.Drawing.Size(134, 21);
            this.OutService.TabIndex = 5;
            this.OutService.Text = "Out from service";
            this.OutService.UseVisualStyleBackColor = true;
            // 
            // Repaired
            // 
            this.Repaired.AutoSize = true;
            this.Repaired.Location = new System.Drawing.Point(1003, 30);
            this.Repaired.Name = "Repaired";
            this.Repaired.Size = new System.Drawing.Size(88, 21);
            this.Repaired.TabIndex = 6;
            this.Repaired.Text = "Repaired";
            this.Repaired.UseVisualStyleBackColor = true;
            // 
            // NewRecord
            // 
            this.NewRecord.Location = new System.Drawing.Point(51, 719);
            this.NewRecord.Name = "NewRecord";
            this.NewRecord.Size = new System.Drawing.Size(143, 56);
            this.NewRecord.TabIndex = 2;
            this.NewRecord.Text = "Add new record";
            this.NewRecord.UseVisualStyleBackColor = true;
            // 
            // MoreInfo
            // 
            this.MoreInfo.Location = new System.Drawing.Point(452, 719);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.Size = new System.Drawing.Size(143, 56);
            this.MoreInfo.TabIndex = 3;
            this.MoreInfo.Text = "More information";
            this.MoreInfo.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(255, 719);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(143, 56);
            this.Modify.TabIndex = 4;
            this.Modify.Text = "Modify record";
            this.Modify.UseVisualStyleBackColor = true;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 797);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.NewRecord);
            this.Controls.Add(this.ListOfMaintenane);
            this.Controls.Add(this.Search);
            this.Name = "Status";
            this.Text = "Status";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfMaintenane)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.DataGridView ListOfMaintenane;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.CheckBox OutService;
        private System.Windows.Forms.CheckBox InService;
        private System.Windows.Forms.CheckBox Repaired;
        private System.Windows.Forms.Button NewRecord;
        private System.Windows.Forms.Button MoreInfo;
        private System.Windows.Forms.Button Modify;
    }
}