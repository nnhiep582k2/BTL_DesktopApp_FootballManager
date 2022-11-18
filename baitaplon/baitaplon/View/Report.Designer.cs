namespace baitaplon.View
{
    partial class Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Report));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.playerListReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchResultInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.excelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.matchResultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topThreePlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.cbSelect = new System.Windows.Forms.ComboBox();
            this.lbCBSelect = new System.Windows.Forms.Label();
            this.picBoxBody = new System.Windows.Forms.PictureBox();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBody)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.PaleTurquoise;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerListReportToolStripMenuItem,
            this.matchResultInformationToolStripMenuItem,
            this.toolStripMenuItem1,
            this.excelToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Padding = new System.Windows.Forms.Padding(14, 3, 0, 3);
            this.menuStrip2.Size = new System.Drawing.Size(1266, 37);
            this.menuStrip2.TabIndex = 4;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // playerListReportToolStripMenuItem
            // 
            this.playerListReportToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.playerListReportToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerListReportToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.playerListReportToolStripMenuItem.Name = "playerListReportToolStripMenuItem";
            this.playerListReportToolStripMenuItem.Size = new System.Drawing.Size(135, 31);
            this.playerListReportToolStripMenuItem.Text = "Player list";
            this.playerListReportToolStripMenuItem.Click += new System.EventHandler(this.playerListReportToolStripMenuItem_Click);
            // 
            // matchResultInformationToolStripMenuItem
            // 
            this.matchResultInformationToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.matchResultInformationToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.matchResultInformationToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.matchResultInformationToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.matchResultInformationToolStripMenuItem.Name = "matchResultInformationToolStripMenuItem";
            this.matchResultInformationToolStripMenuItem.Size = new System.Drawing.Size(165, 31);
            this.matchResultInformationToolStripMenuItem.Text = "Match result";
            this.matchResultInformationToolStripMenuItem.Click += new System.EventHandler(this.matchResultInformationToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.IndianRed;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(217, 31);
            this.toolStripMenuItem1.Text = "Top three players";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // excelToolStripMenuItem
            // 
            this.excelToolStripMenuItem.BackColor = System.Drawing.Color.IndianRed;
            this.excelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playListToolStripMenuItem,
            this.matchResultToolStripMenuItem,
            this.topThreePlayerToolStripMenuItem});
            this.excelToolStripMenuItem.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold);
            this.excelToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.excelToolStripMenuItem.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.excelToolStripMenuItem.Name = "excelToolStripMenuItem";
            this.excelToolStripMenuItem.Size = new System.Drawing.Size(164, 31);
            this.excelToolStripMenuItem.Text = "Export Excel";
            this.excelToolStripMenuItem.Click += new System.EventHandler(this.excelToolStripMenuItem_Click);
            // 
            // playListToolStripMenuItem
            // 
            this.playListToolStripMenuItem.Name = "playListToolStripMenuItem";
            this.playListToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.playListToolStripMenuItem.Text = "PlayList";
            this.playListToolStripMenuItem.Click += new System.EventHandler(this.playListToolStripMenuItem_Click);
            // 
            // matchResultToolStripMenuItem
            // 
            this.matchResultToolStripMenuItem.Name = "matchResultToolStripMenuItem";
            this.matchResultToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.matchResultToolStripMenuItem.Text = "Match Result";
            this.matchResultToolStripMenuItem.Click += new System.EventHandler(this.matchResultToolStripMenuItem_Click);
            // 
            // topThreePlayerToolStripMenuItem
            // 
            this.topThreePlayerToolStripMenuItem.Name = "topThreePlayerToolStripMenuItem";
            this.topThreePlayerToolStripMenuItem.Size = new System.Drawing.Size(276, 32);
            this.topThreePlayerToolStripMenuItem.Text = "Top three player";
            this.topThreePlayerToolStripMenuItem.Click += new System.EventHandler(this.topThreePlayerToolStripMenuItem_Click);
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 37);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1266, 749);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // cbSelect
            // 
            this.cbSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbSelect.FormattingEnabled = true;
            this.cbSelect.Location = new System.Drawing.Point(919, 2);
            this.cbSelect.Name = "cbSelect";
            this.cbSelect.Size = new System.Drawing.Size(271, 35);
            this.cbSelect.TabIndex = 6;
            this.cbSelect.SelectedIndexChanged += new System.EventHandler(this.cbSelect_SelectedIndexChanged);
            // 
            // lbCBSelect
            // 
            this.lbCBSelect.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbCBSelect.AutoSize = true;
            this.lbCBSelect.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.lbCBSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(58)))), ((int)(((byte)(64)))));
            this.lbCBSelect.Location = new System.Drawing.Point(788, 9);
            this.lbCBSelect.Name = "lbCBSelect";
            this.lbCBSelect.Size = new System.Drawing.Size(125, 22);
            this.lbCBSelect.TabIndex = 7;
            this.lbCBSelect.Text = "Mã đội bóng";
            // 
            // picBoxBody
            // 
            this.picBoxBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxBody.Image = ((System.Drawing.Image)(resources.GetObject("picBoxBody.Image")));
            this.picBoxBody.Location = new System.Drawing.Point(0, 37);
            this.picBoxBody.Name = "picBoxBody";
            this.picBoxBody.Size = new System.Drawing.Size(1266, 749);
            this.picBoxBody.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxBody.TabIndex = 8;
            this.picBoxBody.TabStop = false;
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1266, 786);
            this.Controls.Add(this.picBoxBody);
            this.Controls.Add(this.lbCBSelect);
            this.Controls.Add(this.cbSelect);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Report";
            this.Text = "báo cáo";
            this.Load += new System.EventHandler(this.Report_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxBody)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem playerListReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchResultInformationToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.ComboBox cbSelect;
        private System.Windows.Forms.Label lbCBSelect;
        private System.Windows.Forms.PictureBox picBoxBody;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem excelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem matchResultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topThreePlayerToolStripMenuItem;
    }
}