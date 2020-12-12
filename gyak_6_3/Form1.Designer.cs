namespace gyak_6_3
{
    partial class frmStrings
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
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.tbxLength = new System.Windows.Forms.TextBox();
            this.lblLength = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblGreeting = new System.Windows.Forms.Label();
            this.btnGreeting = new System.Windows.Forms.Button();
            this.btnDoctor = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxInput
            // 
            this.tbxInput.Location = new System.Drawing.Point(28, 42);
            this.tbxInput.Name = "tbxInput";
            this.tbxInput.Size = new System.Drawing.Size(274, 22);
            this.tbxInput.TabIndex = 0;
            this.tbxInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbxInput_KeyDown);
            this.tbxInput.Leave += new System.EventHandler(this.txbInput_Leave);
            // 
            // tbxLastName
            // 
            this.tbxLastName.Enabled = false;
            this.tbxLastName.Location = new System.Drawing.Point(161, 101);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(141, 22);
            this.tbxLastName.TabIndex = 1;
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Enabled = false;
            this.tbxFirstName.Location = new System.Drawing.Point(161, 129);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(141, 22);
            this.tbxFirstName.TabIndex = 1;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(28, 19);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(46, 17);
            this.lblInput.TabIndex = 2;
            this.lblInput.Text = "label1";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(63, 101);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(46, 17);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "label2";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(63, 133);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(46, 17);
            this.lblFirstName.TabIndex = 4;
            this.lblFirstName.Text = "label3";
            // 
            // tbxLength
            // 
            this.tbxLength.Enabled = false;
            this.tbxLength.Location = new System.Drawing.Point(161, 170);
            this.tbxLength.Name = "tbxLength";
            this.tbxLength.Size = new System.Drawing.Size(55, 22);
            this.tbxLength.TabIndex = 1;
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(63, 173);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(46, 17);
            this.lblLength.TabIndex = 5;
            this.lblLength.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(238, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "karakter";
            // 
            // lblGreeting
            // 
            this.lblGreeting.AutoSize = true;
            this.lblGreeting.Font = new System.Drawing.Font("Segoe Script", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblGreeting.Location = new System.Drawing.Point(66, 227);
            this.lblGreeting.Name = "lblGreeting";
            this.lblGreeting.Size = new System.Drawing.Size(0, 33);
            this.lblGreeting.TabIndex = 7;
            // 
            // btnGreeting
            // 
            this.btnGreeting.Location = new System.Drawing.Point(72, 278);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(75, 30);
            this.btnGreeting.TabIndex = 8;
            this.btnGreeting.Text = "Üdvözlés";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDoctor
            // 
            this.btnDoctor.Location = new System.Drawing.Point(175, 278);
            this.btnDoctor.Name = "btnDoctor";
            this.btnDoctor.Size = new System.Drawing.Size(75, 30);
            this.btnDoctor.TabIndex = 9;
            this.btnDoctor.Text = "Doktor";
            this.btnDoctor.UseVisualStyleBackColor = true;
            this.btnDoctor.Click += new System.EventHandler(this.btnDoctor_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(72, 307);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Törlés";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(175, 307);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "Vége";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.button4_Click);
            // 
            // frmStrings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 384);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDoctor);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnGreeting);
            this.Controls.Add(this.lblGreeting);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.tbxLength);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxInput);
            this.Name = "frmStrings";
            this.Text = "Stringek használata";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxInput;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox tbxLength;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblGreeting;
        private System.Windows.Forms.Button btnGreeting;
        private System.Windows.Forms.Button btnDoctor;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
    }
}

