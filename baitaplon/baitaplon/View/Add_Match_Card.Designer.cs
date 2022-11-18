namespace baitaplon
{
    partial class Add_Match_Card
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_delete = new System.Windows.Forms.Button();
            this.txttg = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.txtghichu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_the = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_matd = new System.Windows.Forms.ComboBox();
            this.lbmatd = new System.Windows.Forms.Label();
            this.cb_ct = new System.Windows.Forms.ComboBox();
            this.lbmact = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(182)))), ((int)(((byte)(150)))));
            this.panel3.Controls.Add(this.btn_delete);
            this.panel3.Controls.Add(this.txttg);
            this.panel3.Controls.Add(this.btn_add);
            this.panel3.Controls.Add(this.txtghichu);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.cb_the);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.cb_matd);
            this.panel3.Controls.Add(this.lbmatd);
            this.panel3.Controls.Add(this.cb_ct);
            this.panel3.Controls.Add(this.lbmact);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1192, 368);
            this.panel3.TabIndex = 6;
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.White;
            this.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_delete.Location = new System.Drawing.Point(828, 231);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(128, 50);
            this.btn_delete.TabIndex = 2;
            this.btn_delete.Text = "BACK";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.button3_Click);
            // 
            // txttg
            // 
            this.txttg.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttg.Location = new System.Drawing.Point(937, 45);
            this.txttg.Name = "txttg";
            this.txttg.Size = new System.Drawing.Size(184, 30);
            this.txttg.TabIndex = 11;
            this.txttg.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttg_KeyPress);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_add.Location = new System.Drawing.Point(546, 231);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(128, 50);
            this.btn_add.TabIndex = 0;
            this.btn_add.Text = "ADD";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // txtghichu
            // 
            this.txtghichu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtghichu.Location = new System.Drawing.Point(546, 94);
            this.txtghichu.Name = "txtghichu";
            this.txtghichu.Size = new System.Drawing.Size(184, 30);
            this.txtghichu.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(420, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 23);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ghi chú";
            // 
            // cb_the
            // 
            this.cb_the.BackColor = System.Drawing.Color.White;
            this.cb_the.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_the.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_the.ForeColor = System.Drawing.Color.Black;
            this.cb_the.FormattingEnabled = true;
            this.cb_the.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.cb_the.Location = new System.Drawing.Point(142, 94);
            this.cb_the.Name = "cb_the";
            this.cb_the.Size = new System.Drawing.Size(184, 31);
            this.cb_the.TabIndex = 7;
            this.cb_the.SelectedIndexChanged += new System.EventHandler(this.cb_the_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Loại thẻ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(810, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thời gian";
            // 
            // cb_matd
            // 
            this.cb_matd.BackColor = System.Drawing.Color.White;
            this.cb_matd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_matd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_matd.FormattingEnabled = true;
            this.cb_matd.Location = new System.Drawing.Point(142, 37);
            this.cb_matd.Name = "cb_matd";
            this.cb_matd.Size = new System.Drawing.Size(184, 31);
            this.cb_matd.TabIndex = 1;
            // 
            // lbmatd
            // 
            this.lbmatd.AutoSize = true;
            this.lbmatd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmatd.Location = new System.Drawing.Point(12, 40);
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
            this.cb_ct.Location = new System.Drawing.Point(546, 41);
            this.cb_ct.Name = "cb_ct";
            this.cb_ct.Size = new System.Drawing.Size(184, 31);
            this.cb_ct.TabIndex = 3;
            // 
            // lbmact
            // 
            this.lbmact.AutoSize = true;
            this.lbmact.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbmact.Location = new System.Drawing.Point(418, 42);
            this.lbmact.Name = "lbmact";
            this.lbmact.Size = new System.Drawing.Size(107, 23);
            this.lbmact.TabIndex = 2;
            this.lbmact.Text = "Mã cầu thủ";
            // 
            // Edit_Match_Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 368);
            this.Controls.Add(this.panel3);
            this.Name = "Edit_Match_Card";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "trandau_thecs";
            this.Load += new System.EventHandler(this.Formtrandau_thecs_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cb_matd;
        private System.Windows.Forms.Label lbmatd;
        private System.Windows.Forms.ComboBox cb_ct;
        private System.Windows.Forms.Label lbmact;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.TextBox txttg;
        private System.Windows.Forms.TextBox txtghichu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_the;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}