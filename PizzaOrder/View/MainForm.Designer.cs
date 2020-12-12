
namespace PizzaOrder
{
    partial class FormStarter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStarter));
            this.ButtonImportData = new System.Windows.Forms.Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.TextBoxSum = new System.Windows.Forms.TextBox();
            this.LabelSum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ButtonImportData
            // 
            this.ButtonImportData.Location = new System.Drawing.Point(298, 406);
            this.ButtonImportData.Name = "ButtonImportData";
            this.ButtonImportData.Size = new System.Drawing.Size(205, 32);
            this.ButtonImportData.TabIndex = 0;
            this.ButtonImportData.Text = "Adatbevitel";
            this.ButtonImportData.UseVisualStyleBackColor = true;
            this.ButtonImportData.Click += new System.EventHandler(this.ButtonImportData_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.AutoScroll = true;
            this.PanelMain.BackColor = System.Drawing.Color.Moccasin;
            this.PanelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelMain.Location = new System.Drawing.Point(11, 96);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(778, 246);
            this.PanelMain.TabIndex = 1;
            // 
            // ButtonClear
            // 
            this.ButtonClear.Location = new System.Drawing.Point(11, 406);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(66, 32);
            this.ButtonClear.TabIndex = 2;
            this.ButtonClear.Text = "Töröl";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.Location = new System.Drawing.Point(714, 406);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(75, 32);
            this.ButtonExit.TabIndex = 3;
            this.ButtonExit.Text = "Kilépés";
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ExitProgram);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.Location = new System.Drawing.Point(11, 348);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(87, 33);
            this.ButtonCalculate.TabIndex = 4;
            this.ButtonCalculate.Text = "Számol";
            this.ButtonCalculate.UseVisualStyleBackColor = true;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // TextBoxSum
            // 
            this.TextBoxSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TextBoxSum.Location = new System.Drawing.Point(298, 351);
            this.TextBoxSum.Name = "TextBoxSum";
            this.TextBoxSum.Size = new System.Drawing.Size(205, 27);
            this.TextBoxSum.TabIndex = 5;
            this.TextBoxSum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // LabelSum
            // 
            this.LabelSum.AutoSize = true;
            this.LabelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LabelSum.ForeColor = System.Drawing.Color.DarkRed;
            this.LabelSum.Location = new System.Drawing.Point(187, 354);
            this.LabelSum.Name = "LabelSum";
            this.LabelSum.Size = new System.Drawing.Size(97, 20);
            this.LabelSum.TabIndex = 6;
            this.LabelSum.Text = "Fizetendő:";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(107, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(589, 35);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pizzák";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormStarter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(804, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LabelSum);
            this.Controls.Add(this.TextBoxSum);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.ButtonImportData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormStarter";
            this.Text = "Pizzéria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonImportData;
        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Button ButtonClear;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.TextBox TextBoxSum;
        private System.Windows.Forms.Label LabelSum;
        private System.Windows.Forms.Label label1;
    }
}

