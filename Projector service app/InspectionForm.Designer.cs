namespace Projector_service_app
{
    partial class InspectionForm
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
            this.RepairDescriptionLabel = new System.Windows.Forms.Label();
            this.RepairDescriptionText = new System.Windows.Forms.TextBox();
            this.MaterialCostLabel = new System.Windows.Forms.Label();
            this.MaterialCostText = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // RepairDescriptionLabel
            // 
            this.RepairDescriptionLabel.AutoSize = true;
            this.RepairDescriptionLabel.Location = new System.Drawing.Point(12, 23);
            this.RepairDescriptionLabel.Name = "RepairDescriptionLabel";
            this.RepairDescriptionLabel.Size = new System.Drawing.Size(125, 17);
            this.RepairDescriptionLabel.TabIndex = 0;
            this.RepairDescriptionLabel.Text = "Repair Description";
            // 
            // RepairDescriptionText
            // 
            this.RepairDescriptionText.Location = new System.Drawing.Point(37, 66);
            this.RepairDescriptionText.Multiline = true;
            this.RepairDescriptionText.Name = "RepairDescriptionText";
            this.RepairDescriptionText.Size = new System.Drawing.Size(264, 159);
            this.RepairDescriptionText.TabIndex = 1;
            this.RepairDescriptionText.Validating += new System.ComponentModel.CancelEventHandler(this.RepairDescriptionText_Validating);
            // 
            // MaterialCostLabel
            // 
            this.MaterialCostLabel.AutoSize = true;
            this.MaterialCostLabel.Location = new System.Drawing.Point(12, 248);
            this.MaterialCostLabel.Name = "MaterialCostLabel";
            this.MaterialCostLabel.Size = new System.Drawing.Size(90, 17);
            this.MaterialCostLabel.TabIndex = 2;
            this.MaterialCostLabel.Text = "Material Cost";
            // 
            // MaterialCostText
            // 
            this.MaterialCostText.Location = new System.Drawing.Point(158, 248);
            this.MaterialCostText.Name = "MaterialCostText";
            this.MaterialCostText.Size = new System.Drawing.Size(143, 22);
            this.MaterialCostText.TabIndex = 3;
            this.MaterialCostText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MaterialCostText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MaterialCostText_KeyPress);
            this.MaterialCostText.Validating += new System.ComponentModel.CancelEventHandler(this.MaterialCostText_Validating);
            // 
            // AddButton
            // 
            this.AddButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.AddButton.Enabled = false;
            this.AddButton.Location = new System.Drawing.Point(102, 299);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(129, 37);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            // 
            // InspectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 348);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MaterialCostText);
            this.Controls.Add(this.MaterialCostLabel);
            this.Controls.Add(this.RepairDescriptionText);
            this.Controls.Add(this.RepairDescriptionLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "InspectionForm";
            this.Text = "InspectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RepairDescriptionLabel;
        private System.Windows.Forms.TextBox RepairDescriptionText;
        private System.Windows.Forms.Label MaterialCostLabel;
        private System.Windows.Forms.TextBox MaterialCostText;
        private System.Windows.Forms.Button AddButton;
    }
}