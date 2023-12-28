namespace MemoryGame
{
    partial class StartingScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartingScreen));
            this.startbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startbutton
            // 
            this.startbutton.BackgroundImage = global::MemoryGame.Properties.Resources.start;
            this.startbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startbutton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.startbutton.ForeColor = System.Drawing.Color.Plum;
            this.startbutton.Location = new System.Drawing.Point(166, 383);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(139, 53);
            this.startbutton.TabIndex = 0;
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.easybutton_Click);
            this.startbutton.MouseLeave += new System.EventHandler(this.easybutton_MouseLeave);
            this.startbutton.MouseHover += new System.EventHandler(this.easybutton_MouseHover);
            // 
            // StartingScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MemoryGame.Properties.Resources.start_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(459, 657);
            this.Controls.Add(this.startbutton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "StartingScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pair Madness";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startbutton;
    }
}