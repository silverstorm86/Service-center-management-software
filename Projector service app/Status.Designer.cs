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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.Search = new System.Windows.Forms.GroupBox();
            this.Repaired = new System.Windows.Forms.CheckBox();
            this.OutService = new System.Windows.Forms.CheckBox();
            this.InService = new System.Windows.Forms.CheckBox();
            this.CompanyText = new System.Windows.Forms.TextBox();
            this.CompanyLabel = new System.Windows.Forms.Label();
            this.IDText = new System.Windows.Forms.TextBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.ListOfMaintenance = new System.Windows.Forms.DataGridView();
            this.NewRecordButton = new System.Windows.Forms.Button();
            this.MoreInfo = new System.Windows.Forms.Button();
            this.Modify = new System.Windows.Forms.Button();
            this.InspectionButton = new System.Windows.Forms.Button();
            this.PricingButton = new System.Windows.Forms.Button();
            this.PriceAcceptanceButton = new System.Windows.Forms.Button();
            this.RepairCompleteButton = new System.Windows.Forms.Button();
            this.TakeoverButton = new System.Windows.Forms.Button();
            this.PrintDocumentMI = new System.Drawing.Printing.PrintDocument();
            this.PrintPreviewDialogMoreInfo = new System.Windows.Forms.PrintPreviewDialog();
            this.Search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfMaintenance)).BeginInit();
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
            this.Search.Location = new System.Drawing.Point(13, 14);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Size = new System.Drawing.Size(1329, 71);
            this.Search.TabIndex = 0;
            this.Search.TabStop = false;
            this.Search.Text = "Search";
            // 
            // Repaired
            // 
            this.Repaired.AutoSize = true;
            this.Repaired.Location = new System.Drawing.Point(1056, 30);
            this.Repaired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Repaired.Name = "Repaired";
            this.Repaired.Size = new System.Drawing.Size(88, 21);
            this.Repaired.TabIndex = 6;
            this.Repaired.Text = "Repaired";
            this.Repaired.UseVisualStyleBackColor = true;
            this.Repaired.Click += new System.EventHandler(this.Repaired_Click);
            // 
            // OutService
            // 
            this.OutService.AutoSize = true;
            this.OutService.Location = new System.Drawing.Point(1171, 30);
            this.OutService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OutService.Name = "OutService";
            this.OutService.Size = new System.Drawing.Size(134, 21);
            this.OutService.TabIndex = 5;
            this.OutService.Text = "Out from service";
            this.OutService.UseVisualStyleBackColor = true;
            this.OutService.Click += new System.EventHandler(this.OutService_Click);
            // 
            // InService
            // 
            this.InService.AutoSize = true;
            this.InService.Location = new System.Drawing.Point(912, 30);
            this.InService.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InService.Name = "InService";
            this.InService.Size = new System.Drawing.Size(114, 21);
            this.InService.TabIndex = 4;
            this.InService.Text = "In the service";
            this.InService.UseVisualStyleBackColor = true;
            this.InService.Click += new System.EventHandler(this.InService_Click);
            // 
            // CompanyText
            // 
            this.CompanyText.Location = new System.Drawing.Point(365, 30);
            this.CompanyText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CompanyText.Name = "CompanyText";
            this.CompanyText.Size = new System.Drawing.Size(220, 22);
            this.CompanyText.TabIndex = 3;
            this.CompanyText.TextChanged += new System.EventHandler(this.CompanyText_TextChanged);
            // 
            // CompanyLabel
            // 
            this.CompanyLabel.AutoSize = true;
            this.CompanyLabel.Location = new System.Drawing.Point(252, 32);
            this.CompanyLabel.Name = "CompanyLabel";
            this.CompanyLabel.Size = new System.Drawing.Size(106, 17);
            this.CompanyLabel.TabIndex = 2;
            this.CompanyLabel.Text = "Company name";
            // 
            // IDText
            // 
            this.IDText.Location = new System.Drawing.Point(108, 30);
            this.IDText.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.IDText.Name = "IDText";
            this.IDText.Size = new System.Drawing.Size(100, 22);
            this.IDText.TabIndex = 1;
            this.IDText.TextChanged += new System.EventHandler(this.IDText_TextChanged);
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
            // ListOfMaintenance
            // 
            this.ListOfMaintenance.AllowUserToAddRows = false;
            this.ListOfMaintenance.AllowUserToDeleteRows = false;
            this.ListOfMaintenance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ListOfMaintenance.Location = new System.Drawing.Point(13, 92);
            this.ListOfMaintenance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListOfMaintenance.Name = "ListOfMaintenance";
            this.ListOfMaintenance.ReadOnly = true;
            this.ListOfMaintenance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.ListOfMaintenance.RowTemplate.Height = 24;
            this.ListOfMaintenance.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ListOfMaintenance.Size = new System.Drawing.Size(1329, 604);
            this.ListOfMaintenance.TabIndex = 1;
            this.ListOfMaintenance.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ListOfMaintenance_CellClick);
            this.ListOfMaintenance.VisibleChanged += new System.EventHandler(this.ListOfMaintenance_VisibleChanged);
            // 
            // NewRecordButton
            // 
            this.NewRecordButton.Location = new System.Drawing.Point(15, 727);
            this.NewRecordButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NewRecordButton.Name = "NewRecordButton";
            this.NewRecordButton.Size = new System.Drawing.Size(143, 57);
            this.NewRecordButton.TabIndex = 2;
            this.NewRecordButton.Text = "Add new record";
            this.NewRecordButton.UseVisualStyleBackColor = true;
            this.NewRecordButton.Click += new System.EventHandler(this.NewRecordButton_Click);
            // 
            // MoreInfo
            // 
            this.MoreInfo.Location = new System.Drawing.Point(1200, 727);
            this.MoreInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoreInfo.Name = "MoreInfo";
            this.MoreInfo.Size = new System.Drawing.Size(143, 57);
            this.MoreInfo.TabIndex = 3;
            this.MoreInfo.Text = "More information";
            this.MoreInfo.UseVisualStyleBackColor = true;
            this.MoreInfo.Click += new System.EventHandler(this.MoreInfo_Click);
            // 
            // Modify
            // 
            this.Modify.Location = new System.Drawing.Point(1031, 727);
            this.Modify.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Modify.Name = "Modify";
            this.Modify.Size = new System.Drawing.Size(143, 57);
            this.Modify.TabIndex = 4;
            this.Modify.Text = "Modify record";
            this.Modify.UseVisualStyleBackColor = true;
            this.Modify.Click += new System.EventHandler(this.Modify_Click);
            // 
            // InspectionButton
            // 
            this.InspectionButton.Location = new System.Drawing.Point(184, 727);
            this.InspectionButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.InspectionButton.Name = "InspectionButton";
            this.InspectionButton.Size = new System.Drawing.Size(143, 57);
            this.InspectionButton.TabIndex = 5;
            this.InspectionButton.Text = "Inspection";
            this.InspectionButton.UseVisualStyleBackColor = true;
            this.InspectionButton.Click += new System.EventHandler(this.InspectionButton_Click);
            // 
            // PricingButton
            // 
            this.PricingButton.Location = new System.Drawing.Point(353, 727);
            this.PricingButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PricingButton.Name = "PricingButton";
            this.PricingButton.Size = new System.Drawing.Size(143, 57);
            this.PricingButton.TabIndex = 6;
            this.PricingButton.Text = "Pricing";
            this.PricingButton.UseVisualStyleBackColor = true;
            this.PricingButton.Click += new System.EventHandler(this.PricingButton_Click);
            // 
            // PriceAcceptanceButton
            // 
            this.PriceAcceptanceButton.Location = new System.Drawing.Point(523, 727);
            this.PriceAcceptanceButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PriceAcceptanceButton.Name = "PriceAcceptanceButton";
            this.PriceAcceptanceButton.Size = new System.Drawing.Size(143, 57);
            this.PriceAcceptanceButton.TabIndex = 7;
            this.PriceAcceptanceButton.Text = "Price acceptance";
            this.PriceAcceptanceButton.UseVisualStyleBackColor = true;
            this.PriceAcceptanceButton.Click += new System.EventHandler(this.PriceAcceptanceButton_Click);
            // 
            // RepairCompleteButton
            // 
            this.RepairCompleteButton.Location = new System.Drawing.Point(692, 727);
            this.RepairCompleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RepairCompleteButton.Name = "RepairCompleteButton";
            this.RepairCompleteButton.Size = new System.Drawing.Size(143, 57);
            this.RepairCompleteButton.TabIndex = 8;
            this.RepairCompleteButton.Text = "Repair complete";
            this.RepairCompleteButton.UseVisualStyleBackColor = true;
            this.RepairCompleteButton.Click += new System.EventHandler(this.RepairCompleteButton_Click);
            // 
            // TakeoverButton
            // 
            this.TakeoverButton.Location = new System.Drawing.Point(861, 727);
            this.TakeoverButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TakeoverButton.Name = "TakeoverButton";
            this.TakeoverButton.Size = new System.Drawing.Size(143, 57);
            this.TakeoverButton.TabIndex = 9;
            this.TakeoverButton.Text = "Device takeover";
            this.TakeoverButton.UseVisualStyleBackColor = true;
            this.TakeoverButton.Click += new System.EventHandler(this.TakeoverButton_Click);
            // 
            // PrintDocumentMI
            // 
            this.PrintDocumentMI.DocumentName = "More Information";
            this.PrintDocumentMI.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.PrintDocumentMI_PrintPage);
            // 
            // PrintPreviewDialogMoreInfo
            // 
            this.PrintPreviewDialogMoreInfo.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogMoreInfo.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.PrintPreviewDialogMoreInfo.ClientSize = new System.Drawing.Size(400, 300);
            this.PrintPreviewDialogMoreInfo.Document = this.PrintDocumentMI;
            this.PrintPreviewDialogMoreInfo.Enabled = true;
            this.PrintPreviewDialogMoreInfo.Icon = ((System.Drawing.Icon)(resources.GetObject("PrintPreviewDialogMoreInfo.Icon")));
            this.PrintPreviewDialogMoreInfo.Name = "PrintPreviewDialogMoreInfo";
            this.PrintPreviewDialogMoreInfo.UseAntiAlias = true;
            this.PrintPreviewDialogMoreInfo.Visible = false;
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 798);
            this.Controls.Add(this.TakeoverButton);
            this.Controls.Add(this.RepairCompleteButton);
            this.Controls.Add(this.PriceAcceptanceButton);
            this.Controls.Add(this.PricingButton);
            this.Controls.Add(this.InspectionButton);
            this.Controls.Add(this.Modify);
            this.Controls.Add(this.MoreInfo);
            this.Controls.Add(this.NewRecordButton);
            this.Controls.Add(this.ListOfMaintenance);
            this.Controls.Add(this.Search);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Status";
            this.Text = "Status";
            this.Search.ResumeLayout(false);
            this.Search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListOfMaintenance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Search;
        private System.Windows.Forms.DataGridView ListOfMaintenance;
        private System.Windows.Forms.TextBox IDText;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox CompanyText;
        private System.Windows.Forms.Label CompanyLabel;
        private System.Windows.Forms.CheckBox OutService;
        private System.Windows.Forms.CheckBox InService;
        private System.Windows.Forms.CheckBox Repaired;
        private System.Windows.Forms.Button NewRecordButton;
        private System.Windows.Forms.Button MoreInfo;
        private System.Windows.Forms.Button Modify;
        private System.Windows.Forms.Button InspectionButton;
        private System.Windows.Forms.Button PricingButton;
        private System.Windows.Forms.Button PriceAcceptanceButton;
        private System.Windows.Forms.Button RepairCompleteButton;
        private System.Windows.Forms.Button TakeoverButton;
        private System.Drawing.Printing.PrintDocument PrintDocumentMI;
        private System.Windows.Forms.PrintPreviewDialog PrintPreviewDialogMoreInfo;
    }
}