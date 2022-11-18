namespace baitaplon
{
    partial class Match_Player
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
            this.dgv_tdct = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.cbShowClub = new System.Windows.Forms.ComboBox();
            this.cbShowPlayer = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdct)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tdct
            // 
            this.dgv_tdct.AllowUserToAddRows = false;
            this.dgv_tdct.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tdct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tdct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tdct.GridColor = System.Drawing.Color.White;
            this.dgv_tdct.Location = new System.Drawing.Point(0, 0);
            this.dgv_tdct.Name = "dgv_tdct";
            this.dgv_tdct.RowHeadersWidth = 51;
            this.dgv_tdct.RowTemplate.Height = 24;
            this.dgv_tdct.Size = new System.Drawing.Size(1118, 622);
            this.dgv_tdct.TabIndex = 1;
            this.dgv_tdct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdct_CellClick);
            this.dgv_tdct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdct_CellContentClick);
            this.dgv_tdct.DoubleClick += new System.EventHandler(this.dgv_tdct_DoubleClick);
            // 
            // cbShowClub
            // 
            this.cbShowClub.FormattingEnabled = true;
            this.cbShowClub.Location = new System.Drawing.Point(49, 19);
            this.cbShowClub.Name = "cbShowClub";
            this.cbShowClub.Size = new System.Drawing.Size(224, 24);
            this.cbShowClub.TabIndex = 2;
            this.cbShowClub.Text = "Search club";
            this.cbShowClub.SelectedIndexChanged += new System.EventHandler(this.cbShowClub_SelectedIndexChanged);
            // 
            // cbShowPlayer
            // 
            this.cbShowPlayer.FormattingEnabled = true;
            this.cbShowPlayer.Location = new System.Drawing.Point(339, 19);
            this.cbShowPlayer.Name = "cbShowPlayer";
            this.cbShowPlayer.Size = new System.Drawing.Size(224, 24);
            this.cbShowPlayer.TabIndex = 3;
            this.cbShowPlayer.Text = "Search player";
            this.cbShowPlayer.SelectedIndexChanged += new System.EventHandler(this.cbShowPlayer_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbShowPlayer);
            this.panel1.Controls.Add(this.cbShowClub);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 548);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1118, 74);
            this.panel1.TabIndex = 4;
            // 
            // Match_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 622);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_tdct);
            this.Name = "Match_Player";
            this.Text = "Formdgvtrandau_cauthu";
            this.Load += new System.EventHandler(this.Formdgvtrandau_cauthu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tdct;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cbShowClub;
        private System.Windows.Forms.ComboBox cbShowPlayer;
        private System.Windows.Forms.Panel panel1;
    }
}