namespace MemoryGame
{
    partial class Form3
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.newGameButton = new System.Windows.Forms.Button();
            this.Hint = new System.Windows.Forms.Button();
            this.time = new System.Windows.Forms.Label();
            this.remaining = new System.Windows.Forms.Label();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scorelabel = new System.Windows.Forms.Label();
            this.lbl_value = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            this.SuspendLayout();
            // 
            // newGameButton
            // 
            this.newGameButton.BackColor = System.Drawing.Color.White;
            this.newGameButton.BackgroundImage = global::MemoryGame.Properties.Resources.button;
            this.newGameButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.newGameButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newGameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newGameButton.Font = new System.Drawing.Font("Kids Magazine", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newGameButton.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.newGameButton.Location = new System.Drawing.Point(398, 605);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(123, 55);
            this.newGameButton.TabIndex = 24;
            this.newGameButton.Text = "NEW GAME";
            this.newGameButton.UseVisualStyleBackColor = false;
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // Hint
            // 
            this.Hint.BackColor = System.Drawing.Color.White;
            this.Hint.BackgroundImage = global::MemoryGame.Properties.Resources.button;
            this.Hint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Hint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Hint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Hint.Font = new System.Drawing.Font("Kids Magazine", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hint.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.Hint.Location = new System.Drawing.Point(423, 74);
            this.Hint.Name = "Hint";
            this.Hint.Size = new System.Drawing.Size(101, 41);
            this.Hint.TabIndex = 23;
            this.Hint.Text = "HINT";
            this.Hint.UseVisualStyleBackColor = false;
            this.Hint.Click += new System.EventHandler(this.Hint_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.BackColor = System.Drawing.Color.Transparent;
            this.time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.time.Font = new System.Drawing.Font("Kids Magazine", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.Color.White;
            this.time.Location = new System.Drawing.Point(49, 39);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(96, 46);
            this.time.TabIndex = 22;
            this.time.Text = "time:";
            this.time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // remaining
            // 
            this.remaining.AutoSize = true;
            this.remaining.BackColor = System.Drawing.Color.Transparent;
            this.remaining.Font = new System.Drawing.Font("Kids Magazine", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remaining.ForeColor = System.Drawing.Color.Transparent;
            this.remaining.Location = new System.Drawing.Point(345, 554);
            this.remaining.Name = "remaining";
            this.remaining.Size = new System.Drawing.Size(44, 30);
            this.remaining.TabIndex = 21;
            this.remaining.Text = "10";
            // 
            // pictureBox16
            // 
            this.pictureBox16.Location = new System.Drawing.Point(72, 443);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(75, 95);
            this.pictureBox16.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox16.TabIndex = 19;
            this.pictureBox16.TabStop = false;
            this.pictureBox16.Tag = "0";
            this.pictureBox16.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(152, 344);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(75, 95);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 18;
            this.pictureBox12.TabStop = false;
            this.pictureBox12.Tag = "0";
            this.pictureBox12.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(232, 245);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(75, 95);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 17;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Tag = "0";
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(312, 146);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(75, 95);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Tag = "0";
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox15
            // 
            this.pictureBox15.Location = new System.Drawing.Point(392, 344);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(75, 95);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 15;
            this.pictureBox15.TabStop = false;
            this.pictureBox15.Tag = "0";
            this.pictureBox15.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(72, 344);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(75, 95);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 5;
            this.pictureBox11.TabStop = false;
            this.pictureBox11.Tag = "0";
            this.pictureBox11.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(152, 245);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(75, 95);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Tag = "0";
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(232, 146);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(75, 95);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Tag = "0";
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Location = new System.Drawing.Point(312, 344);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(75, 95);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 11;
            this.pictureBox14.TabStop = false;
            this.pictureBox14.Tag = "0";
            this.pictureBox14.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(392, 246);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(75, 95);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 10;
            this.pictureBox10.TabStop = false;
            this.pictureBox10.Tag = "0";
            this.pictureBox10.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(72, 245);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(75, 95);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 9;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Tag = "0";
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(152, 146);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 95);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Tag = "0";
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox13
            // 
            this.pictureBox13.Location = new System.Drawing.Point(232, 344);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(75, 95);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 7;
            this.pictureBox13.TabStop = false;
            this.pictureBox13.Tag = "0";
            this.pictureBox13.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(312, 245);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(75, 95);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 6;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Tag = "0";
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(392, 146);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(75, 95);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 20;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Tag = "0";
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(72, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Tag = "0";
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox17
            // 
            this.pictureBox17.Location = new System.Drawing.Point(392, 443);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(75, 95);
            this.pictureBox17.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox17.TabIndex = 28;
            this.pictureBox17.TabStop = false;
            this.pictureBox17.Tag = "0";
            this.pictureBox17.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox18
            // 
            this.pictureBox18.Location = new System.Drawing.Point(312, 443);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(75, 95);
            this.pictureBox18.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox18.TabIndex = 27;
            this.pictureBox18.TabStop = false;
            this.pictureBox18.Tag = "0";
            this.pictureBox18.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox19
            // 
            this.pictureBox19.Location = new System.Drawing.Point(232, 443);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(75, 95);
            this.pictureBox19.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox19.TabIndex = 26;
            this.pictureBox19.TabStop = false;
            this.pictureBox19.Tag = "0";
            this.pictureBox19.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox20
            // 
            this.pictureBox20.Location = new System.Drawing.Point(152, 443);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(75, 95);
            this.pictureBox20.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox20.TabIndex = 25;
            this.pictureBox20.TabStop = false;
            this.pictureBox20.Tag = "0";
            this.pictureBox20.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // scorelabel
            // 
            this.scorelabel.AutoSize = true;
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Kids Magazine", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.scorelabel.Location = new System.Drawing.Point(245, 42);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(47, 25);
            this.scorelabel.TabIndex = 31;
            this.scorelabel.Text = "140";
            // 
            // lbl_value
            // 
            this.lbl_value.AutoSize = true;
            this.lbl_value.BackColor = System.Drawing.Color.Transparent;
            this.lbl_value.Font = new System.Drawing.Font("Kids Magazine", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_value.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbl_value.Location = new System.Drawing.Point(446, 42);
            this.lbl_value.Name = "lbl_value";
            this.lbl_value.Size = new System.Drawing.Size(27, 25);
            this.lbl_value.TabIndex = 33;
            this.lbl_value.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Kids Magazine", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(150, 597);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 32;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.hardlvl_bg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(535, 676);
            this.Controls.Add(this.lbl_value);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.scorelabel);
            this.Controls.Add(this.pictureBox17);
            this.Controls.Add(this.pictureBox18);
            this.Controls.Add(this.pictureBox19);
            this.Controls.Add(this.pictureBox20);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.Hint);
            this.Controls.Add(this.time);
            this.Controls.Add(this.remaining);
            this.Controls.Add(this.pictureBox16);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Difficult Level";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button newGameButton;
        private System.Windows.Forms.Button Hint;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label remaining;
        private System.Windows.Forms.PictureBox pictureBox16;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox15;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox13;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox17;
        private System.Windows.Forms.PictureBox pictureBox18;
        private System.Windows.Forms.PictureBox pictureBox19;
        private System.Windows.Forms.PictureBox pictureBox20;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label lbl_value;
        private System.Windows.Forms.Label label3;
    }
}