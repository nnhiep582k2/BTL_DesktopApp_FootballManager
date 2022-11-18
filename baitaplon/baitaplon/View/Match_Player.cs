using baitaplon.Model;
using baitaplon.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    
    public partial class Match_Player : Form
    {
        public string madoi, mact;
        public Match_Player()
        {
            InitializeComponent();
        }

        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        public void reset()
        {
            dgv_tdct.DataSource = conn.getTable("select * from TranDau_CauThu");

        }
        private void Formdgvtrandau_cauthu_Load(object sender, EventArgs e)
        {
            dgv_tdct.DataSource = conn.getTable("select * from TranDau_CauThu");
            //header
            dgv_tdct.Columns[0].HeaderText = "Mã Trận Dấu";
            dgv_tdct.Columns[1].HeaderText = "Mã Cầu Thủ";

            foreach (DataGridViewColumn header in dgv_tdct.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                header.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgv_tdct.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //content

            dgv_tdct.DefaultCellStyle.Font = new Font("Arial", 9F);
            dgv_tdct.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgv_tdct.EnableHeadersVisualStyles = false;
            dgv_tdct.BorderStyle = BorderStyle.None;
            dgv_tdct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_tdct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv_tdct.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgv_tdct.DefaultCellStyle.Font = new Font("Arial", 9F);

            dgv_tdct.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgv_tdct.ReadOnly = true;
            var col = dgv_tdct.Columns;
            for (int i = 0; i < col.Count; i++)
            {
                if (i == 0) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 1) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 2) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 3) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 4) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 5) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 6) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 7) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 8) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                if (i == 9) { col[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; }
                // Etc...
            }

            // dgvclub.Columns[0].Width = 100;
            dgv_tdct.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            
            getData("select MaTD from TranDau_CauThu", cbShowClub, "MaTD");
            getData("select TenDoi from TranDau_CauThu join TranDau on TranDau.MaTD = TranDau_CauThu.MaTD join DoiBong on DoiBong.MaDoi = TranDau.MaDoiKhach or DoiBong.MaDoi = TranDau.MaDoiNha",cbShowPlayer, "TenDoi");

        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void dgv_tdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Match_Player_SS.matd = dgv_tdct.CurrentRow.Cells[0].Value.ToString();
            Match_Player_SS.mact = dgv_tdct.CurrentRow.Cells[1].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
        }

        private void dgv_tdct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbShowClub_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgv_tdct.Columns[1].HeaderText = "Tên đội";
            dgv_tdct.DataSource = conn.getTable($"select TranDau_CauThu.MaTD, TenDoi from TranDau_CauThu join TranDau on TranDau.MaTD = TranDau_CauThu.MaTD join DoiBong on DoiBong.MaDoi = TranDau.MaDoiKhach or DoiBong.MaDoi = TranDau.MaDoiNha where TranDau_CauThu.MaTD = N'{cbShowClub.Text.Trim()}'");
        }

        private void getData(string query, ComboBox cbb, string lname)
        {
            DataTable dt = conn.getTable(query);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show($"Chưa có {lname}, Bạn cần thêm {lname} ở More!");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb.Items.Add(dt.Rows[i][lname].ToString());
            }
        }

        private void cbShowPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            dgv_tdct.Columns[0].HeaderText = "Tên đội";
            dgv_tdct.DataSource = conn.getTable($" select TenDoi, TenCT, MaVitri, NgaySinh, SoAo, CauThu.SoBanThang,CauThu.SoTheVang,CauThu.SoTheDo,MaQuocTich,SoLanRaSan,Anh from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi where TenDoi = '{cbShowPlayer.Text.Trim()}'");

        }

        private void dgv_tdct_DoubleClick(object sender, EventArgs e)
        {
       
           
        }
    }

  
    }

