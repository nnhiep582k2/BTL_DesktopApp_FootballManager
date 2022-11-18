namespace baitaplon
{
    partial class Match_Card
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
            this.dgv_tdcthe = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdcthe)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_tdcthe
            // 
            this.dgv_tdcthe.AllowUserToAddRows = false;
            this.dgv_tdcthe.BackgroundColor = System.Drawing.Color.White;
            this.dgv_tdcthe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_tdcthe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_tdcthe.Location = new System.Drawing.Point(0, 0);
            this.dgv_tdcthe.Name = "dgv_tdcthe";
            this.dgv_tdcthe.RowHeadersWidth = 51;
            this.dgv_tdcthe.RowTemplate.Height = 24;
            this.dgv_tdcthe.Size = new System.Drawing.Size(1150, 504);
            this.dgv_tdcthe.TabIndex = 2;
            this.dgv_tdcthe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdct_CellClick);
            this.dgv_tdcthe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_tdct_CellContentClick);
            // 
            // Match_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 504);
            this.Controls.Add(this.dgv_tdcthe);
            this.Name = "Match_Card";
            this.Text = "dgvtrandau_The";
            this.Load += new System.EventHandler(this.dgvtrandau_The_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tdcthe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_tdcthe;
    }
}