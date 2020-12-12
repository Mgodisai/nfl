namespace gyak_6_6b
{
    partial class frmSplitText
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
            this.tbxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxOutput = new System.Windows.Forms.TextBox();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(68, 63);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(627, 22);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kérem a szöveget";
            // 
            // tbxOutput
            // 
            this.tbxOutput.Location = new System.Drawing.Point(500, 121);
            this.tbxOutput.Multiline = true;
            this.tbxOutput.Name = "tbxOutput";
            this.tbxOutput.Size = new System.Drawing.Size(195, 285);
            this.tbxOutput.TabIndex = 2;
            // 
            // rtbOutput
            // 
            this.rtbOutput.Location = new System.Drawing.Point(247, 121);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(192, 285);
            this.rtbOutput.TabIndex = 3;
            this.rtbOutput.Text = "";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(68, 121);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(151, 43);
            this.btnSplit.TabIndex = 4;
            this.btnSplit.Text = "Tördelés";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(68, 194);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(151, 30);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Vége";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmSplitText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.tbxOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxInput);
            this.Name = "frmSplitText";
            this.Text = "Szöveg tördelése";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxOutput;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnExit;
    }
}

