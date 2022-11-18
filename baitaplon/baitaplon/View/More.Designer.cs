namespace baitaplon.View
{
    partial class More
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(More));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItemNational = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemProvices = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemLocation = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStadium = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemNational,
            this.menuItemProvices,
            this.menuItemLocation,
            this.menuItemStadium});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1069, 35);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItemNational
            // 
            this.menuItemNational.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuItemNational.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuItemNational.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.menuItemNational.Name = "menuItemNational";
            this.menuItemNational.Size = new System.Drawing.Size(168, 31);
            this.menuItemNational.Text = "Nationalities";
            this.menuItemNational.Click += new System.EventHandler(this.nationalitiesToolStripMenuItem_Click);
            // 
            // menuItemProvices
            // 
            this.menuItemProvices.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuItemProvices.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuItemProvices.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.menuItemProvices.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuItemProvices.Name = "menuItemProvices";
            this.menuItemProvices.Size = new System.Drawing.Size(138, 31);
            this.menuItemProvices.Text = "Provinces";
            this.menuItemProvices.Click += new System.EventHandler(this.menuItemProvices_Click);
            // 
            // menuItemLocation
            // 
            this.menuItemLocation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuItemLocation.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuItemLocation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.menuItemLocation.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuItemLocation.Name = "menuItemLocation";
            this.menuItemLocation.Size = new System.Drawing.Size(124, 31);
            this.menuItemLocation.Text = "Location";
            this.menuItemLocation.Click += new System.EventHandler(this.menuItemLocation_Click);
            // 
            // menuItemStadium
            // 
            this.menuItemStadium.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.menuItemStadium.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.menuItemStadium.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.menuItemStadium.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuItemStadium.Name = "menuItemStadium";
            this.menuItemStadium.Size = new System.Drawing.Size(117, 31);
            this.menuItemStadium.Text = "Stadium";
            this.menuItemStadium.Click += new System.EventHandler(this.menuItemStadium_Click);
            // 
            // panel_body
            // 
            this.panel_body.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_body.Controls.Add(this.pictureBox1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.panel_body.Location = new System.Drawing.Point(0, 35);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(1069, 672);
            this.panel_body.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1069, 672);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // More
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 707);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "More";
            this.Text = "More";
            this.Load += new System.EventHandler(this.More_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItemProvices;
        private System.Windows.Forms.ToolStripMenuItem menuItemLocation;
        private System.Windows.Forms.ToolStripMenuItem menuItemStadium;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ToolStripMenuItem menuItemNational;
    }
}