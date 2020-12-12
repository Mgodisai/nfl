namespace Kozepek
{
    partial class Form1
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
            this.tbxX = new System.Windows.Forms.TextBox();
            this.tbxY = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbxSzamtani = new System.Windows.Forms.TextBox();
            this.tbxMertani = new System.Windows.Forms.TextBox();
            this.tbxHarmonikus = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSzamol = new System.Windows.Forms.Button();
            this.btnTorol = new System.Windows.Forms.Button();
            this.btnBezar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxX
            // 
            this.tbxX.Location = new System.Drawing.Point(76, 58);
            this.tbxX.Name = "tbxX";
            this.tbxX.Size = new System.Drawing.Size(133, 22);
            this.tbxX.TabIndex = 0;
            this.tbxX.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.tbxX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // tbxY
            // 
            this.tbxY.Location = new System.Drawing.Point(233, 58);
            this.tbxY.Name = "tbxY";
            this.tbxY.Size = new System.Drawing.Size(133, 22);
            this.tbxY.TabIndex = 1;
            this.tbxY.TextChanged += new System.EventHandler(this.input_TextChanged);
            this.tbxY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.input_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(230, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y";
            // 
            // tbxSzamtani
            // 
            this.tbxSzamtani.Enabled = false;
            this.tbxSzamtani.Location = new System.Drawing.Point(208, 129);
            this.tbxSzamtani.Name = "tbxSzamtani";
            this.tbxSzamtani.Size = new System.Drawing.Size(100, 22);
            this.tbxSzamtani.TabIndex = 2;
            this.tbxSzamtani.TabStop = false;
            // 
            // tbxMertani
            // 
            this.tbxMertani.Enabled = false;
            this.tbxMertani.Location = new System.Drawing.Point(208, 157);
            this.tbxMertani.Name = "tbxMertani";
            this.tbxMertani.Size = new System.Drawing.Size(100, 22);
            this.tbxMertani.TabIndex = 2;
            this.tbxMertani.TabStop = false;
            // 
            // tbxHarmonikus
            // 
            this.tbxHarmonikus.Enabled = false;
            this.tbxHarmonikus.Location = new System.Drawing.Point(208, 185);
            this.tbxHarmonikus.Name = "tbxHarmonikus";
            this.tbxHarmonikus.Size = new System.Drawing.Size(100, 22);
            this.tbxHarmonikus.TabIndex = 2;
            this.tbxHarmonikus.TabStop = false;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(76, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Számtani";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(76, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mértani";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(76, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 23);
            this.label5.TabIndex = 3;
            this.label5.Text = "Harmonikus";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSzamol
            // 
            this.btnSzamol.Enabled = false;
            this.btnSzamol.Location = new System.Drawing.Point(79, 258);
            this.btnSzamol.Name = "btnSzamol";
            this.btnSzamol.Size = new System.Drawing.Size(75, 23);
            this.btnSzamol.TabIndex = 2;
            this.btnSzamol.Text = "Számol";
            this.btnSzamol.UseVisualStyleBackColor = true;
            this.btnSzamol.Click += new System.EventHandler(this.btnSzamol_Click);
            // 
            // btnTorol
            // 
            this.btnTorol.Location = new System.Drawing.Point(233, 258);
            this.btnTorol.Name = "btnTorol";
            this.btnTorol.Size = new System.Drawing.Size(75, 23);
            this.btnTorol.TabIndex = 3;
            this.btnTorol.Text = "Töröl";
            this.btnTorol.UseVisualStyleBackColor = true;
            this.btnTorol.Click += new System.EventHandler(this.btnTorol_Click);
            // 
            // btnBezar
            // 
            this.btnBezar.Location = new System.Drawing.Point(156, 305);
            this.btnBezar.Name = "btnBezar";
            this.btnBezar.Size = new System.Drawing.Size(75, 23);
            this.btnBezar.TabIndex = 4;
            this.btnBezar.Text = "Bezár";
            this.btnBezar.UseVisualStyleBackColor = true;
            this.btnBezar.Click += new System.EventHandler(this.btnBezar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 355);
            this.Controls.Add(this.btnBezar);
            this.Controls.Add(this.btnTorol);
            this.Controls.Add(this.btnSzamol);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbxHarmonikus);
            this.Controls.Add(this.tbxMertani);
            this.Controls.Add(this.tbxSzamtani);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbxY);
            this.Controls.Add(this.tbxX);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxX;
        private System.Windows.Forms.TextBox tbxY;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbxSzamtani;
        private System.Windows.Forms.TextBox tbxMertani;
        private System.Windows.Forms.TextBox tbxHarmonikus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSzamol;
        private System.Windows.Forms.Button btnTorol;
        private System.Windows.Forms.Button btnBezar;
    }
}

