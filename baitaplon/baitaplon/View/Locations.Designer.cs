namespace baitaplon.View
{
    partial class Locations
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
            this.dgvVitri = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitri)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVitri
            // 
            this.dgvVitri.AllowUserToAddRows = false;
            this.dgvVitri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVitri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVitri.Location = new System.Drawing.Point(0, 0);
            this.dgvVitri.Name = "dgvVitri";
            this.dgvVitri.RowHeadersWidth = 51;
            this.dgvVitri.RowTemplate.Height = 24;
            this.dgvVitri.Size = new System.Drawing.Size(985, 592);
            this.dgvVitri.TabIndex = 0;
            this.dgvVitri.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuoctich_CellClick_1);
            this.dgvVitri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Locations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 592);
            this.Controls.Add(this.dgvVitri);
            this.Name = "Locations";
            this.Text = "Nationalities";
            this.Load += new System.EventHandler(this.Nationalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVitri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVitri;
    }
}