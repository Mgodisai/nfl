
namespace nfl
{
    partial class FormOrders
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
            this.panelItemList = new System.Windows.Forms.Panel();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSumOfOrders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panelItemList
            // 
            this.panelItemList.Location = new System.Drawing.Point(2, 16);
            this.panelItemList.Name = "panelItemList";
            this.panelItemList.Size = new System.Drawing.Size(945, 381);
            this.panelItemList.TabIndex = 0;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(404, 404);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(185, 40);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Rendelés";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Rendelés összege:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSumOfOrders
            // 
            this.labelSumOfOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelSumOfOrders.ForeColor = System.Drawing.Color.Green;
            this.labelSumOfOrders.Location = new System.Drawing.Point(143, 400);
            this.labelSumOfOrders.Name = "labelSumOfOrders";
            this.labelSumOfOrders.Size = new System.Drawing.Size(126, 48);
            this.labelSumOfOrders.TabIndex = 3;
            this.labelSumOfOrders.Text = "$0.00";
            this.labelSumOfOrders.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.labelSumOfOrders);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonOrder);
            this.Controls.Add(this.panelItemList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrders";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rendelés";
            this.Load += new System.EventHandler(this.FormOrders_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelItemList;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSumOfOrders;
    }
}