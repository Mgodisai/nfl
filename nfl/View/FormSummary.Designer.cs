
namespace nfl
{
    partial class FormSummary
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
            this.labelNumberOfOrders = new System.Windows.Forms.Label();
            this.labelPurchasingPrice = new System.Windows.Forms.Label();
            this.labelSellingPrice = new System.Windows.Forms.Label();
            this.labelMargin = new System.Windows.Forms.Label();
            this.labelValueNumberOfOrders = new System.Windows.Forms.Label();
            this.labelValuePurchasingPrice = new System.Windows.Forms.Label();
            this.labelValueSellingPrice = new System.Windows.Forms.Label();
            this.labelValueMargin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelNumberOfOrders
            // 
            this.labelNumberOfOrders.AutoSize = true;
            this.labelNumberOfOrders.Location = new System.Drawing.Point(22, 31);
            this.labelNumberOfOrders.Name = "labelNumberOfOrders";
            this.labelNumberOfOrders.Size = new System.Drawing.Size(165, 21);
            this.labelNumberOfOrders.TabIndex = 0;
            this.labelNumberOfOrders.Text = "Rendelések száma:";
            // 
            // labelPurchasingPrice
            // 
            this.labelPurchasingPrice.AutoSize = true;
            this.labelPurchasingPrice.Location = new System.Drawing.Point(22, 71);
            this.labelPurchasingPrice.Name = "labelPurchasingPrice";
            this.labelPurchasingPrice.Size = new System.Drawing.Size(146, 21);
            this.labelPurchasingPrice.TabIndex = 0;
            this.labelPurchasingPrice.Text = "Beszerzési érték:";
            // 
            // labelSellingPrice
            // 
            this.labelSellingPrice.AutoSize = true;
            this.labelSellingPrice.Location = new System.Drawing.Point(22, 113);
            this.labelSellingPrice.Name = "labelSellingPrice";
            this.labelSellingPrice.Size = new System.Drawing.Size(75, 17);
            this.labelSellingPrice.TabIndex = 0;
            this.labelSellingPrice.Text = "Eladási ár:";
            // 
            // labelMargin
            // 
            this.labelMargin.AutoSize = true;
            this.labelMargin.Location = new System.Drawing.Point(22, 151);
            this.labelMargin.Name = "labelMargin";
            this.labelMargin.Size = new System.Drawing.Size(91, 21);
            this.labelMargin.TabIndex = 0;
            this.labelMargin.Text = "Nyereség:";
            // 
            // labelValueNumberOfOrders
            // 
            this.labelValueNumberOfOrders.AutoSize = true;
            this.labelValueNumberOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueNumberOfOrders.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.labelValueNumberOfOrders.Location = new System.Drawing.Point(193, 24);
            this.labelValueNumberOfOrders.Name = "labelValueNumberOfOrders";
            this.labelValueNumberOfOrders.Size = new System.Drawing.Size(70, 25);
            this.labelValueNumberOfOrders.TabIndex = 1;
            this.labelValueNumberOfOrders.Text = "label1";
            // 
            // labelValuePurchasingPrice
            // 
            this.labelValuePurchasingPrice.AutoSize = true;
            this.labelValuePurchasingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValuePurchasingPrice.ForeColor = System.Drawing.Color.Teal;
            this.labelValuePurchasingPrice.Location = new System.Drawing.Point(193, 64);
            this.labelValuePurchasingPrice.Name = "labelValuePurchasingPrice";
            this.labelValuePurchasingPrice.Size = new System.Drawing.Size(70, 25);
            this.labelValuePurchasingPrice.TabIndex = 1;
            this.labelValuePurchasingPrice.Text = "label1";
            // 
            // labelValueSellingPrice
            // 
            this.labelValueSellingPrice.AutoSize = true;
            this.labelValueSellingPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueSellingPrice.ForeColor = System.Drawing.Color.Maroon;
            this.labelValueSellingPrice.Location = new System.Drawing.Point(193, 105);
            this.labelValueSellingPrice.Name = "labelValueSellingPrice";
            this.labelValueSellingPrice.Size = new System.Drawing.Size(70, 25);
            this.labelValueSellingPrice.TabIndex = 1;
            this.labelValueSellingPrice.Text = "label1";
            // 
            // labelValueMargin
            // 
            this.labelValueMargin.AutoSize = true;
            this.labelValueMargin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelValueMargin.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.labelValueMargin.Location = new System.Drawing.Point(193, 144);
            this.labelValueMargin.Name = "labelValueMargin";
            this.labelValueMargin.Size = new System.Drawing.Size(70, 25);
            this.labelValueMargin.TabIndex = 1;
            this.labelValueMargin.Text = "label1";
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 203);
            this.Controls.Add(this.labelValueMargin);
            this.Controls.Add(this.labelValueSellingPrice);
            this.Controls.Add(this.labelValuePurchasingPrice);
            this.Controls.Add(this.labelValueNumberOfOrders);
            this.Controls.Add(this.labelMargin);
            this.Controls.Add(this.labelSellingPrice);
            this.Controls.Add(this.labelPurchasingPrice);
            this.Controls.Add(this.labelNumberOfOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSummary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Könyvelés";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNumberOfOrders;
        private System.Windows.Forms.Label labelPurchasingPrice;
        private System.Windows.Forms.Label labelSellingPrice;
        private System.Windows.Forms.Label labelMargin;
        private System.Windows.Forms.Label labelValueNumberOfOrders;
        private System.Windows.Forms.Label labelValuePurchasingPrice;
        private System.Windows.Forms.Label labelValueSellingPrice;
        private System.Windows.Forms.Label labelValueMargin;
    }
}