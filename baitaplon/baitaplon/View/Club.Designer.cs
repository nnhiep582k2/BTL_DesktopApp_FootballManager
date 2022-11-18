namespace baitaplon
{
    partial class Club
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
            this.dgvclub = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvclub)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvclub
            // 
            this.dgvclub.AllowUserToAddRows = false;
            this.dgvclub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvclub.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvclub.Location = new System.Drawing.Point(0, 0);
            this.dgvclub.Margin = new System.Windows.Forms.Padding(5);
            this.dgvclub.Name = "dgvclub";
            this.dgvclub.RowHeadersWidth = 51;
            this.dgvclub.RowTemplate.Height = 70;
            this.dgvclub.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvclub.Size = new System.Drawing.Size(1400, 813);
            this.dgvclub.TabIndex = 2;
            this.dgvclub.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclub_CellClick);
            this.dgvclub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvclub_CellContentClick);
            this.dgvclub.DoubleClick += new System.EventHandler(this.dgvclub_DoubleClick);
            this.dgvclub.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvclub_KeyDown);
            // 
            // Club
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1400, 813);
            this.Controls.Add(this.dgvclub);
            this.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Club";
            this.Text = "Câu lạc bộ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Club_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvclub)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvclub;
    }
}