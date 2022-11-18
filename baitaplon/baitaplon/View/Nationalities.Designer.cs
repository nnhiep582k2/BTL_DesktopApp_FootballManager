namespace baitaplon.View
{
    partial class Nationalities
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
            this.dgvQuoctich = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuoctich)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvQuoctich
            // 
            this.dgvQuoctich.AllowUserToAddRows = false;
            this.dgvQuoctich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuoctich.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvQuoctich.Location = new System.Drawing.Point(0, 0);
            this.dgvQuoctich.Name = "dgvQuoctich";
            this.dgvQuoctich.RowHeadersWidth = 51;
            this.dgvQuoctich.RowTemplate.Height = 24;
            this.dgvQuoctich.Size = new System.Drawing.Size(985, 592);
            this.dgvQuoctich.TabIndex = 0;
            this.dgvQuoctich.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuoctich_CellClick_1);
            this.dgvQuoctich.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nationalities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 592);
            this.Controls.Add(this.dgvQuoctich);
            this.Name = "Nationalities";
            this.Text = "Nationalities";
            this.Load += new System.EventHandler(this.Nationalities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuoctich)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvQuoctich;
    }
}