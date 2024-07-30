namespace BlackJack
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.Hitbutton1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lblnumber1 = new System.Windows.Forms.Label();
            this.Lblnumber2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Hitbutton2 = new System.Windows.Forms.Button();
            this.Standbutton1 = new System.Windows.Forms.Button();
            this.Standbutton2 = new System.Windows.Forms.Button();
            this.Lblresult2 = new System.Windows.Forms.Label();
            this.Lblresult1 = new System.Windows.Forms.Label();
            this.Lblstay1 = new System.Windows.Forms.Label();
            this.Lbltaken1 = new System.Windows.Forms.Label();
            this.lblfinal1 = new System.Windows.Forms.Label();
            this.Winnerbutton = new System.Windows.Forms.Button();
            this.Lbltaken2 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.lblfinal2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblr = new System.Windows.Forms.Label();
            this.lblr2 = new System.Windows.Forms.Label();
            this.Lblreceived1 = new System.Windows.Forms.TextBox();
            this.Lblreceived2 = new System.Windows.Forms.TextBox();
            this.Newbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Hitbutton1
            // 
            this.Hitbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hitbutton1.Location = new System.Drawing.Point(64, 302);
            this.Hitbutton1.Name = "Hitbutton1";
            this.Hitbutton1.Size = new System.Drawing.Size(126, 37);
            this.Hitbutton1.TabIndex = 0;
            this.Hitbutton1.Text = "Hit";
            this.Hitbutton1.UseVisualStyleBackColor = true;
            this.Hitbutton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(111, 266);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = " Player 1 ";
            // 
            // Lblnumber1
            // 
            this.Lblnumber1.AutoSize = true;
            this.Lblnumber1.BackColor = System.Drawing.Color.Ivory;
            this.Lblnumber1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblnumber1.ForeColor = System.Drawing.Color.Red;
            this.Lblnumber1.Location = new System.Drawing.Point(1, 2);
            this.Lblnumber1.Name = "Lblnumber1";
            this.Lblnumber1.Size = new System.Drawing.Size(36, 27);
            this.Lblnumber1.TabIndex = 2;
            this.Lblnumber1.Text = "    ";
            // 
            // Lblnumber2
            // 
            this.Lblnumber2.AutoSize = true;
            this.Lblnumber2.BackColor = System.Drawing.Color.Ivory;
            this.Lblnumber2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblnumber2.ForeColor = System.Drawing.Color.Red;
            this.Lblnumber2.Location = new System.Drawing.Point(3, 1);
            this.Lblnumber2.Name = "Lblnumber2";
            this.Lblnumber2.Size = new System.Drawing.Size(36, 27);
            this.Lblnumber2.TabIndex = 5;
            this.Lblnumber2.Text = "    ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(751, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 33);
            this.label3.TabIndex = 4;
            this.label3.Text = " Player 2 ";
            // 
            // Hitbutton2
            // 
            this.Hitbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Hitbutton2.Location = new System.Drawing.Point(655, 307);
            this.Hitbutton2.Name = "Hitbutton2";
            this.Hitbutton2.Size = new System.Drawing.Size(126, 37);
            this.Hitbutton2.TabIndex = 3;
            this.Hitbutton2.Text = "Hit";
            this.Hitbutton2.UseVisualStyleBackColor = true;
            this.Hitbutton2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Standbutton1
            // 
            this.Standbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Standbutton1.Location = new System.Drawing.Point(64, 350);
            this.Standbutton1.Name = "Standbutton1";
            this.Standbutton1.Size = new System.Drawing.Size(126, 36);
            this.Standbutton1.TabIndex = 6;
            this.Standbutton1.Text = "Stand";
            this.Standbutton1.UseVisualStyleBackColor = true;
            this.Standbutton1.Click += new System.EventHandler(this.buttonkal1_Click_1);
            // 
            // Standbutton2
            // 
            this.Standbutton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Standbutton2.Location = new System.Drawing.Point(656, 350);
            this.Standbutton2.Name = "Standbutton2";
            this.Standbutton2.Size = new System.Drawing.Size(126, 37);
            this.Standbutton2.TabIndex = 7;
            this.Standbutton2.Text = "Stand";
            this.Standbutton2.UseVisualStyleBackColor = true;
            this.Standbutton2.Click += new System.EventHandler(this.buttonkal2_Click_1);
            // 
            // Lblresult2
            // 
            this.Lblresult2.AutoSize = true;
            this.Lblresult2.BackColor = System.Drawing.Color.Ivory;
            this.Lblresult2.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblresult2.ForeColor = System.Drawing.Color.Red;
            this.Lblresult2.Location = new System.Drawing.Point(3, 0);
            this.Lblresult2.Name = "Lblresult2";
            this.Lblresult2.Size = new System.Drawing.Size(36, 27);
            this.Lblresult2.TabIndex = 9;
            this.Lblresult2.Text = "    ";
            // 
            // Lblresult1
            // 
            this.Lblresult1.AutoSize = true;
            this.Lblresult1.BackColor = System.Drawing.Color.Ivory;
            this.Lblresult1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblresult1.ForeColor = System.Drawing.Color.Red;
            this.Lblresult1.Location = new System.Drawing.Point(-2, 2);
            this.Lblresult1.Name = "Lblresult1";
            this.Lblresult1.Size = new System.Drawing.Size(36, 27);
            this.Lblresult1.TabIndex = 10;
            this.Lblresult1.Text = "    ";
            // 
            // Lblstay1
            // 
            this.Lblstay1.AutoSize = true;
            this.Lblstay1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblstay1.ForeColor = System.Drawing.Color.Black;
            this.Lblstay1.Location = new System.Drawing.Point(201, 349);
            this.Lblstay1.Name = "Lblstay1";
            this.Lblstay1.Size = new System.Drawing.Size(92, 33);
            this.Lblstay1.TabIndex = 11;
            this.Lblstay1.Text = "Total: ";
            // 
            // Lbltaken1
            // 
            this.Lbltaken1.AutoSize = true;
            this.Lbltaken1.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbltaken1.ForeColor = System.Drawing.Color.Black;
            this.Lbltaken1.Location = new System.Drawing.Point(198, 300);
            this.Lbltaken1.Name = "Lbltaken1";
            this.Lbltaken1.Size = new System.Drawing.Size(98, 33);
            this.Lbltaken1.TabIndex = 12;
            this.Lbltaken1.Text = "Taken:";
            // 
            // lblfinal1
            // 
            this.lblfinal1.AutoSize = true;
            this.lblfinal1.BackColor = System.Drawing.Color.Transparent;
            this.lblfinal1.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinal1.ForeColor = System.Drawing.Color.Red;
            this.lblfinal1.Location = new System.Drawing.Point(9, 11);
            this.lblfinal1.Name = "lblfinal1";
            this.lblfinal1.Size = new System.Drawing.Size(139, 159);
            this.lblfinal1.TabIndex = 8;
            this.lblfinal1.Text = "  ";
            this.lblfinal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Winnerbutton
            // 
            this.Winnerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Winnerbutton.Location = new System.Drawing.Point(403, 483);
            this.Winnerbutton.Name = "Winnerbutton";
            this.Winnerbutton.Size = new System.Drawing.Size(217, 49);
            this.Winnerbutton.TabIndex = 13;
            this.Winnerbutton.Text = "Winner...";
            this.Winnerbutton.UseVisualStyleBackColor = true;
            this.Winnerbutton.Click += new System.EventHandler(this.button3_Click);
            // 
            // Lbltaken2
            // 
            this.Lbltaken2.AutoSize = true;
            this.Lbltaken2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbltaken2.ForeColor = System.Drawing.Color.Black;
            this.Lbltaken2.Location = new System.Drawing.Point(806, 307);
            this.Lbltaken2.Name = "Lbltaken2";
            this.Lbltaken2.Size = new System.Drawing.Size(98, 33);
            this.Lbltaken2.TabIndex = 15;
            this.Lbltaken2.Text = "Taken:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label2.ForeColor = System.Drawing.Color.Black;
            this.Label2.Location = new System.Drawing.Point(806, 350);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(92, 33);
            this.Label2.TabIndex = 14;
            this.Label2.Text = "Total: ";
            // 
            // lblfinal2
            // 
            this.lblfinal2.AutoSize = true;
            this.lblfinal2.BackColor = System.Drawing.Color.White;
            this.lblfinal2.Font = new System.Drawing.Font("Microsoft YaHei UI", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblfinal2.ForeColor = System.Drawing.Color.Red;
            this.lblfinal2.Location = new System.Drawing.Point(0, -2);
            this.lblfinal2.Name = "lblfinal2";
            this.lblfinal2.Size = new System.Drawing.Size(247, 159);
            this.lblfinal2.TabIndex = 16;
            this.lblfinal2.Text = "     ";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Gabriola", 49.8F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(359, -16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(430, 130);
            this.label4.TabIndex = 17;
            this.label4.Text = "Blackjack";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::BlackJack.Properties.Resources.hqdefault;
            this.pictureBox2.Location = new System.Drawing.Point(655, 104);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(335, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BlackJack.Properties.Resources.pisti_360x200;
            this.pictureBox1.Location = new System.Drawing.Point(21, 104);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(340, 162);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // lblr
            // 
            this.lblr.AutoSize = true;
            this.lblr.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblr.ForeColor = System.Drawing.Color.Black;
            this.lblr.Location = new System.Drawing.Point(68, 402);
            this.lblr.Name = "lblr";
            this.lblr.Size = new System.Drawing.Size(135, 33);
            this.lblr.TabIndex = 20;
            this.lblr.Text = "Received:";
            // 
            // lblr2
            // 
            this.lblr2.AutoSize = true;
            this.lblr2.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblr2.ForeColor = System.Drawing.Color.Black;
            this.lblr2.Location = new System.Drawing.Point(654, 402);
            this.lblr2.Name = "lblr2";
            this.lblr2.Size = new System.Drawing.Size(135, 33);
            this.lblr2.TabIndex = 21;
            this.lblr2.Text = "Received:";
            // 
            // Lblreceived1
            // 
            this.Lblreceived1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblreceived1.ForeColor = System.Drawing.Color.Red;
            this.Lblreceived1.Location = new System.Drawing.Point(218, 405);
            this.Lblreceived1.Name = "Lblreceived1";
            this.Lblreceived1.Size = new System.Drawing.Size(178, 30);
            this.Lblreceived1.TabIndex = 28;
            // 
            // Lblreceived2
            // 
            this.Lblreceived2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lblreceived2.ForeColor = System.Drawing.Color.Red;
            this.Lblreceived2.Location = new System.Drawing.Point(812, 406);
            this.Lblreceived2.Name = "Lblreceived2";
            this.Lblreceived2.Size = new System.Drawing.Size(178, 30);
            this.Lblreceived2.TabIndex = 29;
            // 
            // Newbutton
            // 
            this.Newbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Newbutton.Location = new System.Drawing.Point(403, 104);
            this.Newbutton.Name = "Newbutton";
            this.Newbutton.Size = new System.Drawing.Size(217, 49);
            this.Newbutton.TabIndex = 30;
            this.Newbutton.Text = "New Game";
            this.Newbutton.UseVisualStyleBackColor = true;
            this.Newbutton.Click += new System.EventHandler(this.Newbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblfinal1);
            this.panel1.Location = new System.Drawing.Point(114, 481);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 179);
            this.panel1.TabIndex = 31;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblfinal2);
            this.panel2.Location = new System.Drawing.Point(669, 483);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(235, 161);
            this.panel2.TabIndex = 32;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.Lblnumber1);
            this.panel3.Location = new System.Drawing.Point(324, 300);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(37, 30);
            this.panel3.TabIndex = 33;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.Lblresult1);
            this.panel4.Location = new System.Drawing.Point(324, 357);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 30);
            this.panel4.TabIndex = 34;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.Lblnumber2);
            this.panel5.Location = new System.Drawing.Point(919, 311);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(39, 28);
            this.panel5.TabIndex = 35;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Controls.Add(this.Lblresult2);
            this.panel6.Location = new System.Drawing.Point(920, 355);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(38, 27);
            this.panel6.TabIndex = 36;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1025, 672);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Newbutton);
            this.Controls.Add(this.Lblreceived2);
            this.Controls.Add(this.Lblreceived1);
            this.Controls.Add(this.lblr2);
            this.Controls.Add(this.lblr);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Lbltaken2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Winnerbutton);
            this.Controls.Add(this.Lbltaken1);
            this.Controls.Add(this.Lblstay1);
            this.Controls.Add(this.Standbutton2);
            this.Controls.Add(this.Standbutton1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Hitbutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hitbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Hitbutton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lblnumber1;
        private System.Windows.Forms.Label Lblnumber2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Hitbutton2;
        private System.Windows.Forms.Button Standbutton1;
        private System.Windows.Forms.Button Standbutton2;
        private System.Windows.Forms.Label Lblresult2;
        private System.Windows.Forms.Label Lblresult1;
        private System.Windows.Forms.Label Lblstay1;
        private System.Windows.Forms.Label Lbltaken1;
        private System.Windows.Forms.Label lblfinal1;
        private System.Windows.Forms.Button Winnerbutton;
        private System.Windows.Forms.Label Lbltaken2;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.Label lblfinal2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblr;
        private System.Windows.Forms.Label lblr2;
        private System.Windows.Forms.TextBox Lblreceived1;
        private System.Windows.Forms.TextBox Lblreceived2;
        private System.Windows.Forms.Button Newbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
    }
}

