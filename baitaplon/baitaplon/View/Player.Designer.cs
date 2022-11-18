namespace baitaplon
{
    partial class Player
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Player));
            this.dataGridViewPlayer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPlayer
            // 
            this.dataGridViewPlayer.AllowUserToAddRows = false;
            this.dataGridViewPlayer.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPlayer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPlayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPlayer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPlayer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPlayer.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPlayer.Name = "dataGridViewPlayer";
            this.dataGridViewPlayer.ReadOnly = true;
            this.dataGridViewPlayer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPlayer.Size = new System.Drawing.Size(749, 489);
            this.dataGridViewPlayer.TabIndex = 0;
            this.dataGridViewPlayer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayer_CellClick);
            this.dataGridViewPlayer.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPlayer_CellContentClick);
            this.dataGridViewPlayer.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewPlayer_DataError);
            this.dataGridViewPlayer.DoubleClick += new System.EventHandler(this.dataGridViewPlayer_DoubleClick);
            this.dataGridViewPlayer.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridViewPlayer_KeyDown);
            // 
            // Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(749, 489);
            this.Controls.Add(this.dataGridViewPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Player";
            this.Text = "Cầu thủ";
            this.Load += new System.EventHandler(this.Player_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Player_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPlayer;
    }
}