namespace baitaplon.View
{
    partial class Provices
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
            this.dgvTinh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTinh
            // 
            this.dgvTinh.AllowUserToAddRows = false;
            this.dgvTinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTinh.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTinh.Location = new System.Drawing.Point(0, 0);
            this.dgvTinh.Name = "dgvTinh";
            this.dgvTinh.RowHeadersWidth = 51;
            this.dgvTinh.RowTemplate.Height = 24;
            this.dgvTinh.Size = new System.Drawing.Size(832, 536);
            this.dgvTinh.TabIndex = 0;
            this.dgvTinh.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTinh_CellClick);
            this.dgvTinh.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Provices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 536);
            this.Controls.Add(this.dgvTinh);
            this.Name = "Provices";
            this.Text = "Provinces";
            this.Load += new System.EventHandler(this.Provices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTinh;
    }
}