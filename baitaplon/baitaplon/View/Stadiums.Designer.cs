namespace baitaplon.View
{
    partial class Stadiums
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewStadium = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadium)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(403, 156);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(228, 155);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewStadium
            // 
            this.dataGridViewStadium.AllowUserToAddRows = false;
            this.dataGridViewStadium.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStadium.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewStadium.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStadium.Name = "dataGridViewStadium";
            this.dataGridViewStadium.RowHeadersWidth = 51;
            this.dataGridViewStadium.RowTemplate.Height = 24;
            this.dataGridViewStadium.Size = new System.Drawing.Size(896, 552);
            this.dataGridViewStadium.TabIndex = 1;
            this.dataGridViewStadium.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStadium_CellClick);
            this.dataGridViewStadium.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStadium_CellContentClick);
            // 
            // Stadiums
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 552);
            this.Controls.Add(this.dataGridViewStadium);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Stadiums";
            this.Text = "Stadiums";
            this.Load += new System.EventHandler(this.Stadiums_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStadium)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridViewStadium;
    }
}