namespace Projector_service_app
{
    partial class PricingForm
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
            this.OfferLabel = new System.Windows.Forms.Label();
            this.OfferPrice = new System.Windows.Forms.TextBox();
            this.OfferAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OfferLabel
            // 
            this.OfferLabel.AutoSize = true;
            this.OfferLabel.Location = new System.Drawing.Point(13, 13);
            this.OfferLabel.Name = "OfferLabel";
            this.OfferLabel.Size = new System.Drawing.Size(76, 13);
            this.OfferLabel.TabIndex = 0;
            this.OfferLabel.Text = "Make the offer";
            // 
            // OfferPrice
            // 
            this.OfferPrice.Location = new System.Drawing.Point(52, 46);
            this.OfferPrice.Name = "OfferPrice";
            this.OfferPrice.Size = new System.Drawing.Size(116, 20);
            this.OfferPrice.TabIndex = 1;
            this.OfferPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.OfferPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OfferPrice_KeyPress);
            // 
            // OfferAdd
            // 
            this.OfferAdd.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OfferAdd.Location = new System.Drawing.Point(66, 80);
            this.OfferAdd.Name = "OfferAdd";
            this.OfferAdd.Size = new System.Drawing.Size(91, 30);
            this.OfferAdd.TabIndex = 2;
            this.OfferAdd.Text = "Add";
            this.OfferAdd.UseVisualStyleBackColor = true;
            this.OfferAdd.Click += new System.EventHandler(this.OfferAdd_Click);
            // 
            // PricingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(213, 128);
            this.Controls.Add(this.OfferAdd);
            this.Controls.Add(this.OfferPrice);
            this.Controls.Add(this.OfferLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PricingForm";
            this.Text = "PricingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label OfferLabel;
        private System.Windows.Forms.TextBox OfferPrice;
        private System.Windows.Forms.Button OfferAdd;
    }
}