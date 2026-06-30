namespace formsdeneme
{
    partial class Form2
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.buttongeri = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.buttonderece = new System.Windows.Forms.Button();
            this.buttonturev = new System.Windows.Forms.Button();
            this.buttondif = new System.Windows.Forms.Button();
            this.buttonsayi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(153, 147);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(167, 24);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(70, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "sayı1 =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(70, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "sayı2 =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(70, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "işlem";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(153, 94);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 5;
            // 
            // buttongeri
            // 
            this.buttongeri.Location = new System.Drawing.Point(468, 197);
            this.buttongeri.Name = "buttongeri";
            this.buttongeri.Size = new System.Drawing.Size(98, 51);
            this.buttongeri.TabIndex = 8;
            this.buttongeri.Text = "Geri Dön";
            this.buttongeri.UseVisualStyleBackColor = true;
            this.buttongeri.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(468, 94);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(109, 22);
            this.textBox4.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(259, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "*Sayı gir kardeş";
            this.label4.Visible = false;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(384, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "sonuç =";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(214, 285);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(106, 51);
            this.button3.TabIndex = 12;
            this.button3.Text = "Diğer İşlemler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonderece
            // 
            this.buttonderece.Location = new System.Drawing.Point(107, 346);
            this.buttonderece.Name = "buttonderece";
            this.buttonderece.Size = new System.Drawing.Size(104, 50);
            this.buttonderece.TabIndex = 13;
            this.buttonderece.Text = "Dereceli Denklemler";
            this.buttonderece.UseVisualStyleBackColor = true;
            this.buttonderece.Visible = false;
            this.buttonderece.Click += new System.EventHandler(this.buttonderece_Click);
            // 
            // buttonturev
            // 
            this.buttonturev.Location = new System.Drawing.Point(230, 346);
            this.buttonturev.Name = "buttonturev";
            this.buttonturev.Size = new System.Drawing.Size(90, 50);
            this.buttonturev.TabIndex = 14;
            this.buttonturev.Text = "İntegral Türev";
            this.buttonturev.UseVisualStyleBackColor = true;
            this.buttonturev.Visible = false;
            // 
            // buttondif
            // 
            this.buttondif.Location = new System.Drawing.Point(335, 346);
            this.buttondif.Name = "buttondif";
            this.buttondif.Size = new System.Drawing.Size(103, 50);
            this.buttondif.TabIndex = 15;
            this.buttondif.Text = "Diferansiyel Denklemler";
            this.buttondif.UseVisualStyleBackColor = true;
            this.buttondif.Visible = false;
            // 
            // buttonsayi
            // 
            this.buttonsayi.Location = new System.Drawing.Point(456, 347);
            this.buttonsayi.Name = "buttonsayi";
            this.buttonsayi.Size = new System.Drawing.Size(98, 49);
            this.buttonsayi.TabIndex = 16;
            this.buttonsayi.Text = "Sayısal Yöntemler";
            this.buttonsayi.UseVisualStyleBackColor = true;
            this.buttonsayi.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 482);
            this.ControlBox = false;
            this.Controls.Add(this.buttonsayi);
            this.Controls.Add(this.buttondif);
            this.Controls.Add(this.buttonturev);
            this.Controls.Add(this.buttonderece);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.buttongeri);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.MinimumSize = new System.Drawing.Size(750, 500);
            this.Name = "Form2";
            this.Text = "Hesap Makinesi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button buttongeri;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buttonderece;
        private System.Windows.Forms.Button buttonturev;
        private System.Windows.Forms.Button buttondif;
        private System.Windows.Forms.Button buttonsayi;
    }
}