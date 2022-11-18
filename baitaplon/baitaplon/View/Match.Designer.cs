namespace baitaplon
{
    partial class Match
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvMatch = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(381, 197);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Match";
            // 
            // dgvMatch
            // 
            this.dgvMatch.AllowUserToAddRows = false;
            this.dgvMatch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMatch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMatch.Location = new System.Drawing.Point(0, 0);
            this.dgvMatch.Margin = new System.Windows.Forms.Padding(4);
            this.dgvMatch.Name = "dgvMatch";
            this.dgvMatch.RowHeadersWidth = 51;
            this.dgvMatch.RowTemplate.Height = 24;
            this.dgvMatch.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMatch.Size = new System.Drawing.Size(1357, 704);
            this.dgvMatch.TabIndex = 1;
            this.dgvMatch.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellClick);
            this.dgvMatch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMatch_CellContentClick);
            this.dgvMatch.DoubleClick += new System.EventHandler(this.dgvMatch_DoubleClick);
            this.dgvMatch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMatch_KeyDown);
            // 
            // Match
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1357, 704);
            this.Controls.Add(this.dgvMatch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Match";
            this.Text = "Trận đấu";
            this.Load += new System.EventHandler(this.Match_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMatch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvMatch;
    }
}