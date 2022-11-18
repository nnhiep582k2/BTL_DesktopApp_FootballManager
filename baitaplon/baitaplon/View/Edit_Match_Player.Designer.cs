namespace baitaplon
{
    partial class Edit_Match_Player
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnpdate = new System.Windows.Forms.Button();
            this.cb_matd = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.lbmatd = new System.Windows.Forms.Label();
            this.cb_ct = new System.Windows.Forms.ComboBox();
            this.lbmact = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(969, 316);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.btnpdate);
            this.panel3.Controls.Add(this.cb_matd);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.lbmatd);
            this.panel3.Controls.Add(this.cb_ct);
            this.panel3.Controls.Add(this.lbmact);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 316);
            this.panel3.TabIndex = 5;
            // 
            // btnpdate
            // 
            this.btnpdate.BackColor = System.Drawing.Color.White;
            this.btnpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnpdate.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnpdate.Location = new System.Drawing.Point(413, 198);
            this.btnpdate.Name = "btnpdate";
            this.btnpdate.Size = new System.Drawing.Size(128, 50);
            this.btnpdate.TabIndex = 3;
            this.btnpdate.Text = "UPDATE";
            this.btnpdate.UseVisualStyleBackColor = false;
            this.btnpdate.Click += new System.EventHandler(this.btnpdate_Click);
            // 
            // cb_matd
            // 
            this.cb_matd.BackColor = System.Drawing.Color.White;
            this.cb_matd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_matd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_matd.FormattingEnabled = true;
            this.cb_matd.Location = new System.Drawing.Point(247, 40);
            this.cb_matd.Name = "cb_matd";
            this.cb_matd.Size = new System.Drawing.Size(169, 31);
            this.cb_matd.TabIndex = 1;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(606, 198);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 50);
            this.button3.TabIndex = 2;
            this.button3.Text = "BACK";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // lbmatd
            // 
            this.lbmatd.AutoSize = true;
            this.lbmatd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatd.Location = new System.Drawing.Point(103, 46);
            this.lbmatd.Name = "lbmatd";
            this.lbmatd.Size = new System.Drawing.Size(116, 23);
            this.lbmatd.TabIndex = 0;
            this.lbmatd.Text = "Mã trận đấu";
            // 
            // cb_ct
            // 
            this.cb_ct.BackColor = System.Drawing.Color.White;
            this.cb_ct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_ct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_ct.FormattingEnabled = true;
            this.cb_ct.Location = new System.Drawing.Point(644, 40);
            this.cb_ct.Name = "cb_ct";
            this.cb_ct.Size = new System.Drawing.Size(184, 31);
            this.cb_ct.TabIndex = 3;
            // 
            // lbmact
            // 
            this.lbmact.AutoSize = true;
            this.lbmact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmact.Location = new System.Drawing.Point(519, 46);
            this.lbmact.Name = "lbmact";
            this.lbmact.Size = new System.Drawing.Size(107, 23);
            this.lbmact.TabIndex = 2;
            this.lbmact.Text = "Mã cầu thủ";
            // 
            // Edit_Match_Player
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 316);
            this.Controls.Add(this.panel2);
            this.Name = "Edit_Match_Player";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TranDau_CauThu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox cb_ct;
        private System.Windows.Forms.Label lbmact;
        private System.Windows.Forms.ComboBox cb_matd;
        private System.Windows.Forms.Label lbmatd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnpdate;
    }
}

