using baitaplon.Model;
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
    public partial class Match_Goal : Form
    {
       

        private void dgv_tdbt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Match_Goal_SS.matd = dgv_tdbt.CurrentRow.Cells[0].Value.ToString();
            Match_Goal_SS.mact = dgv_tdbt.CurrentRow.Cells[1].Value.ToString();
            Match_Goal_SS.tg = int.Parse(dgv_tdbt.CurrentRow.Cells[2].Value.ToString());
            Match_Goal_SS.ghichu = dgv_tdbt.CurrentRow.Cells[3].Value.ToString();
            Match_Goal_SS.sl =int.Parse( dgv_tdbt.CurrentRow.Cells[4].Value.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
         
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void dgv_tdbt_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public Match_Goal()
        {
            InitializeComponent();
        }


        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private void dgvTrandau_banthang_Load(object sender, EventArgs e)
        {

            dgv_tdbt.DataSource = conn.getTable("select * from TranDau_BanThang");
            //header
            dgv_tdbt.Columns[0].HeaderText = "Mã Trận Dấu";
            dgv_tdbt.Columns[1].HeaderText = "Mã Cầu Thủ";
            dgv_tdbt.Columns[2].HeaderText = "Thời gian";
            dgv_tdbt.Columns[3].HeaderText = "Ghi chú";
            dgv_tdbt.Columns[4].HeaderText = "Số lượng";

            foreach (DataGridViewColumn header in dgv_tdbt.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                header.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgv_tdbt.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //content

            dgv_tdbt.DefaultCellStyle.Font = new Font("Arial", 9F);
            dgv_tdbt.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgv_tdbt.EnableHeadersVisualStyles = false;
            dgv_tdbt.BorderStyle = BorderStyle.None;
            dgv_tdbt.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_tdbt.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv_tdbt.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgv_tdbt.DefaultCellStyle.Font = new Font("Arial", 9F);

            dgv_tdbt.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgv_tdbt.ReadOnly = true;
            var col = dgv_tdbt.Columns;
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
            dgv_tdbt.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            getData("select distinct MaTD from TranDau_BanThang",cbShowPlayer, "MaTD");

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
            dgv_tdbt.DataSource = conn.getTable($" select TenCT, MaVitri, NgaySinh, SoAo, CauThu.SoBanThang,CauThu.SoTheVang,CauThu.SoTheDo,MaQuocTich,SoLanRaSan,Anh from CauThu join TranDau_BanThang on TranDau_BanThang.MaCT = CauThu.MaCT where TranDau_BanThang.MaTD = N'{cbShowPlayer.Text.Trim()}'");           
        }
    }
}
