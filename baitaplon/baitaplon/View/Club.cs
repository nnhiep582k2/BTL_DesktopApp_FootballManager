using baitaplon.Model;
using baitaplon.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon
{
    public partial class Club : Form
    {
        public string madoi, tendoi, hlv, masan, matinh;
        public byte[]anh;
        public PictureBox pBox;
        public Club()
        {
            InitializeComponent();
            pBox = new PictureBox();
            //dgvclub.DefaultCellStyle.Font = new Font("Arial", 8);
           

        }
        

        private void dgvclub_DoubleClick(object sender, EventArgs e)
        {
            update_club update_Clup = new update_club();
            update_Clup.madoi= madoi;
            update_Clup.tendoi= tendoi;
            update_Clup.hlv= hlv;
            update_Clup.pBox = pBox;
            update_Clup.masan= masan;
            update_Clup.matinh= matinh;
            update_Clup.Show();
          
        }

        public void DeleteClub()
        {
            ConnAdd conn = new ConnAdd();

            try
            {
                string ma = dgvclub.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Bạn có muốn xóa đội bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    /*
                        DataTable dt = new DataTable();
                        dt = conn.table($"select * from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                        DataTable dt_CauThu = new DataTable();
                        dt_CauThu = conn.table($"select * from CauThu where MaDoi = N'{ma}'");
                    if (dt.Rows.Count > 0)
                        {
                            DataTable dt_trandau = new DataTable();
                            dt_trandau = conn.table($"select MaTD from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                            string maTD = dt_trandau.Rows[0][0].ToString();
                            DataTable dt_the = new DataTable();
                            dt_the = conn.table($"select * from TranDau_The where MaTD = N'{maTD}'");
                            DataTable dt_BanThang = new DataTable();
                            dt_BanThang = conn.table($"select * from TranDau_BanThang where MaTD = N'{maTD}'");
                            DataTable dt_cauthu = new DataTable();
                            dt_cauthu = conn.table($"select * from TranDau_CauThu where MaTD = N'{maTD}'");

                            if(dt_the.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_The where MaTD = N'{maTD}'");
                            }

                            if (dt_BanThang.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_BanThang where MaTD = N'{maTD}'");

                            }
                            if (dt_cauthu.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_CauThu where MaTD = N'{maTD}'");

                            }

                    }
                    if(dt_CauThu.Rows.Count > 0)
                    {

                        DataTable dt_trandau = new DataTable();
                        dt_trandau = conn.table($"select MaCT from CauThu where MaDoi = N'{ma}'");
                        string maCT1= dt_trandau.Rows[0][0].ToString();

                        DataTable dt_the1 = new DataTable();
                        dt_the1 = conn.table($"select * from TranDau_The where MaCT = N'{maCT1}'");

                        DataTable dt_BanThang1 = new DataTable();
                        dt_BanThang1 = conn.table($"select * from TranDau_BanThang where MaCT = N'{maCT1}'");

                        DataTable dt_cauthu1 = new DataTable();
                        dt_cauthu1 = conn.table($"select * from TranDau_CauThu where MaCT = N'{maCT1}'");



                        if (dt_the1.Rows.Count > 0)
                        {
                            conn.Excute_new($"delete from TranDau_The where MaCT = N'{maCT1}'");
                        }

                        if (dt_BanThang1.Rows.Count > 0)
                        {
                            conn.Excute_new($"delete from TranDau_BanThang where MaCT = N'{maCT1}'");

                        }
                        if (dt_cauthu1.Rows.Count > 0)
                        {
                            conn.Excute_new($"delete from TranDau_CauThu where MaCT = N'{maCT1}'");

                        }
                    }
                        conn.Excute_new($"delete from CauThu where MaDoi = N'{ma}'");
                        conn.Excute_new($"delete from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                    */
                    conn.Excute_new($"delete from DoiBong where MaDoi = N'{ma}'");


                    MessageBox.Show("Xóa thành công!", "Xóa đội bóng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvclub.DataSource = conn.table("select * from DoiBong");



                }
            

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi! Bạn cần xóa mã đội trong bảng đang tham chiếu đến đội bóng trước.  ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvclub_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                this.DeleteClub();
            }
          
        }

        private void dgvclub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        SqlConnection connect;
        private void Club_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";
            connect.Open();
            SqlDataAdapter dataAdap = new SqlDataAdapter("select * from DoiBong", connect);
            DataTable dt = new DataTable();
            dataAdap.Fill(dt);
            dgvclub.DataSource = dt;
            dgvclub.Columns[0].HeaderText = "MÃ ĐỘI";
            dgvclub.Columns[1].HeaderText = "TÊN ĐỘI";
            dgvclub.Columns[2].HeaderText = "HLV ĐỘI";
            dgvclub.Columns[3].HeaderText = "LOGO";
            dgvclub.Columns[4].HeaderText = "ĐIỂM";
            dgvclub.Columns[5].HeaderText = "SỐ BÀN THẮNG";
            dgvclub.Columns[6].HeaderText = "Số BÀN THUA";
            dgvclub.Columns[7].HeaderText = "Số LƯỢNG CẦU THỦ";
            dgvclub.Columns[8].HeaderText = "MÃ SÂN";
            dgvclub.Columns[9].HeaderText = "MÃ TỈNH";

            dgvclub.DefaultCellStyle.Font = new Font("Arial", 11F);
            dgvclub.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgvclub.EnableHeadersVisualStyles = false;
            dgvclub.BorderStyle = BorderStyle.None;
            dgvclub.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvclub.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvclub.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgvclub.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            var col = dgvclub.Columns;
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
            foreach (DataGridViewColumn header in dgvclub.Columns)
            {
                header.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                header.HeaderCell.Style.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Pixel);
            }
            // dgvclub.Columns[0].Width = 100;
            dgvclub.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvclub.Columns[0].Width = 50;
            dgvclub.Columns[1].Width = 120;
            dgvclub.Columns[2].Width = 160;
            dgvclub.Columns[3].Width = 120;
            dgvclub.Columns[4].Width = 50;
            dgvclub.Columns[5].Width = 120;
            dgvclub.Columns[6].Width = 120;
            dgvclub.Columns[7].Width = 120;
            dgvclub.Columns[8].Width = 120;
            dgvclub.Columns[9].Width = 90;

            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dgvclub.Columns[3];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            connect.Close();

            dgvclub.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgvclub.ReadOnly = true;
        }


        private byte[] imageToByarray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void dgvclub_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            madoi = dgvclub.CurrentRow.Cells[0].Value.ToString();
            tendoi = dgvclub.CurrentRow.Cells[1].Value.ToString();
            hlv = dgvclub.CurrentRow.Cells[2].Value.ToString();

            if (dgvclub.SelectedRows[0].Cells[3].Value.ToString() != "")
            {
                MemoryStream ms = new MemoryStream((byte[])dgvclub.SelectedRows[0].Cells[3].Value);
                pBox.Image = Image.FromStream(ms);
            }
            else
            {
                pBox.Image = null;
            }
            masan = dgvclub.CurrentRow.Cells[8].Value.ToString();
            matinh = dgvclub.CurrentRow.Cells[9].Value.ToString();
            DoiBongs.madb = madoi;
            DoiBongs.tendb = tendoi;
            DoiBongs.hvldb = hlv;
            DoiBongs.anh = pBox;
            DoiBongs.masan = masan;
            DoiBongs.matinh = matinh;

        }
      
    }
}
