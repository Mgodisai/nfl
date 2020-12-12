namespace gyak_6_2
{
    partial class formGreetings
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
            this.lastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.firstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneNumber = new System.Windows.Forms.MaskedTextBox();
            this.infoBox = new System.Windows.Forms.TextBox();
            this.btnGreeting = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lastName
            // 
            this.lastName.Location = new System.Drawing.Point(155, 50);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(180, 22);
            this.lastName.TabIndex = 0;
            this.lastName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lastName_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vezetéknév:";
            // 
            // firstName
            // 
            this.firstName.Location = new System.Drawing.Point(155, 92);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(180, 22);
            this.firstName.TabIndex = 1;
            this.firstName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.firstName_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Keresztnév:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefonszám:";
            // 
            // phoneNumber
            // 
            this.phoneNumber.Location = new System.Drawing.Point(153, 141);
            this.phoneNumber.Mask = "(0#) 000-000#";
            this.phoneNumber.Name = "phoneNumber";
            this.phoneNumber.Size = new System.Drawing.Size(182, 22);
            this.phoneNumber.TabIndex = 2;
            this.phoneNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.phoneNumber_KeyDown);
            // 
            // infoBox
            // 
            this.infoBox.BackColor = System.Drawing.SystemColors.Info;
            this.infoBox.Location = new System.Drawing.Point(153, 183);
            this.infoBox.Multiline = true;
            this.infoBox.Name = "infoBox";
            this.infoBox.ReadOnly = true;
            this.infoBox.Size = new System.Drawing.Size(182, 94);
            this.infoBox.TabIndex = 3;
            this.infoBox.TabStop = false;
            // 
            // btnGreeting
            // 
            this.btnGreeting.Location = new System.Drawing.Point(153, 312);
            this.btnGreeting.Name = "btnGreeting";
            this.btnGreeting.Size = new System.Drawing.Size(75, 23);
            this.btnGreeting.TabIndex = 4;
            this.btnGreeting.Text = "Ü&dvözöl";
            this.btnGreeting.UseVisualStyleBackColor = true;
            this.btnGreeting.Click += new System.EventHandler(this.btnGreeting_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(259, 312);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "B&ezár";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // formGreetings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 362);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnGreeting);
            this.Controls.Add(this.infoBox);
            this.Controls.Add(this.phoneNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.lastName);
            this.Name = "formGreetings";
            this.Text = "Üdvözlet";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.formGreetings_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox phoneNumber;
        private System.Windows.Forms.TextBox infoBox;
        private System.Windows.Forms.Button btnGreeting;
        private System.Windows.Forms.Button btnClose;
    }
}

