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
    public partial class Match_Card : Form
    {
        
        public Match_Card()
        {
            InitializeComponent();
        }

        private void dgv_tdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Match_Card_SS.matd = dgv_tdcthe.CurrentRow.Cells[0].Value.ToString();
            Match_Card_SS.mact = dgv_tdcthe.CurrentRow.Cells[1].Value.ToString();
            Match_Card_SS.tg = int.Parse(dgv_tdcthe.CurrentRow.Cells[2].Value.ToString());
            Match_Card_SS.loaithe = dgv_tdcthe.CurrentRow.Cells[3].Value.ToString();
            Match_Card_SS.ghichu = dgv_tdcthe.CurrentRow.Cells[4].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
         
        }

        private void dgv_tdct_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
       
        }

        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private void dgvtrandau_The_Load(object sender, EventArgs e)
        {

            dgv_tdcthe.DataSource = conn.getTable("select * from TranDau_The");
            //header
            dgv_tdcthe.Columns[0].HeaderText = "Mã Trận Dấu";
            dgv_tdcthe.Columns[1].HeaderText = "Mã Cầu Thủ";
            dgv_tdcthe.Columns[2].HeaderText = "Thời gian";
            dgv_tdcthe.Columns[3].HeaderText = "Loại thẻ";
            dgv_tdcthe.Columns[4].HeaderText = "Ghi chú";
           
            foreach (DataGridViewColumn header in dgv_tdcthe.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                header.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            dgv_tdcthe.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //content

            dgv_tdcthe.DefaultCellStyle.Font = new Font("Arial", 9F);
            dgv_tdcthe.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgv_tdcthe.EnableHeadersVisualStyles = false;
            dgv_tdcthe.BorderStyle = BorderStyle.None;
            dgv_tdcthe.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv_tdcthe.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgv_tdcthe.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgv_tdcthe.DefaultCellStyle.Font = new Font("Arial", 9F);

            dgv_tdcthe.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgv_tdcthe.ReadOnly = true;
            var col = dgv_tdcthe.Columns;
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
            dgv_tdcthe.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;



        }

        private void button1_Click(object sender, EventArgs e)
        {
           Add_Match_Card tdt = new Add_Match_Card();
            tdt.Show();
        }
    }
}
