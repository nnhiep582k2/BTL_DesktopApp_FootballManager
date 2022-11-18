namespace baitaplon
{
    partial class Match_Goal
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
            this.dgv_tdbt = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbShowPlayer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdbt)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_tdbt
            // 
            this.dgv_tdbt.AllowUserToAddRows = false;
            this.dgv_tdbt.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tdbt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tdbt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tdbt.Location = new System.Drawing.Point(0, 0);
            this.dgv_tdbt.Name = "dgv_tdbt";
            this.dgv_tdbt.RowHeadersWidth = 51;
            this.dgv_tdbt.RowTemplate.Height = 24;
            this.dgv_tdbt.Size = new System.Drawing.Size(1059, 531);
            this.dgv_tdbt.TabIndex = 3;
            this.dgv_tdbt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdbt_CellClick);
            this.dgv_tdbt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdbt_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbShowPlayer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 448);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1059, 83);
            this.panel1.TabIndex = 4;
            // 
            // cbShowPlayer
            // 
            this.cbShowPlayer.FormattingEnabled = true;
            this.cbShowPlayer.Location = new System.Drawing.Point(51, 27);
            this.cbShowPlayer.Name = "cbShowPlayer";
            this.cbShowPlayer.Size = new System.Drawing.Size(284, 24);
            this.cbShowPlayer.TabIndex = 0;
            this.cbShowPlayer.Text = "Search player";
            this.cbShowPlayer.SelectedIndexChanged += new System.EventHandler(this.cbShowPlayer_SelectedIndexChanged);
            // 
            // Match_Goal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 531);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgv_tdbt);
            this.Name = "Match_Goal";
            this.Load += new System.EventHandler(this.dgvTrandau_banthang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdbt)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tdbt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbShowPlayer;
    }
}