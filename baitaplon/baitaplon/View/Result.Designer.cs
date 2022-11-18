namespace baitaplon.View
{
    partial class Result
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matchGoalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchCardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_body = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.panel_body.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGreen;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matchGoalToolStripMenuItem,
            this.matchCardToolStripMenuItem,
            this.matchPlayerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(950, 37);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // matchGoalToolStripMenuItem
            // 
            this.matchGoalToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.matchGoalToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.matchGoalToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.matchGoalToolStripMenuItem.Name = "matchGoalToolStripMenuItem";
            this.matchGoalToolStripMenuItem.Size = new System.Drawing.Size(166, 31);
            this.matchGoalToolStripMenuItem.Text = "Match - Goal";
            this.matchGoalToolStripMenuItem.Click += new System.EventHandler(this.matchGoalToolStripMenuItem_Click);
            // 
            // matchCardToolStripMenuItem
            // 
            this.matchCardToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.matchCardToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.matchCardToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.matchCardToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.matchCardToolStripMenuItem.Name = "matchCardToolStripMenuItem";
            this.matchCardToolStripMenuItem.Size = new System.Drawing.Size(167, 31);
            this.matchCardToolStripMenuItem.Text = "Match - Card";
            this.matchCardToolStripMenuItem.Click += new System.EventHandler(this.matchCardToolStripMenuItem_Click);
            // 
            // matchPlayerToolStripMenuItem
            // 
            this.matchPlayerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.matchPlayerToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.matchPlayerToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.matchPlayerToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.matchPlayerToolStripMenuItem.Name = "matchPlayerToolStripMenuItem";
            this.matchPlayerToolStripMenuItem.Size = new System.Drawing.Size(182, 31);
            this.matchPlayerToolStripMenuItem.Text = "Match - Player";
            this.matchPlayerToolStripMenuItem.Click += new System.EventHandler(this.matchPlayerToolStripMenuItem_Click);
            // 
            // panel_body
            // 
            this.panel_body.Controls.Add(this.pictureBox1);
            this.panel_body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_body.Location = new System.Drawing.Point(0, 37);
            this.panel_body.Name = "panel_body";
            this.panel_body.Size = new System.Drawing.Size(950, 527);
            this.panel_body.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(950, 527);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(950, 564);
            this.Controls.Add(this.panel_body);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Result";
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel_body.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matchGoalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchCardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchPlayerToolStripMenuItem;
        private System.Windows.Forms.Panel panel_body;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}