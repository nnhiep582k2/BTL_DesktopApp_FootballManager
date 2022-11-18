using baitaplon.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitaplon.Model;
using System.IO;
using System.Reflection;

namespace baitaplon
{
    public partial class Player : Form
    {
        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        public string mode = "Add";

        public string maCT, tenCT, maViTri, ngaySinh, maQuocTich, maDoi;
        public int soAo, soBanThang, soTheVang, soTheDo, soLanRaSan;
        public PictureBox pBox;
        public static string v_madoi, v_tendoi, v_banthang, v_tenCT;
       
        private void Player_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void dataGridViewPlayer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeletePlayer();
            }
        }

        private void dataGridViewPlayer_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridViewPlayer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void Player_Load(object sender, EventArgs e)
        {
            pBox = new PictureBox();
            if (!string.IsNullOrEmpty(v_tendoi))
            {
                dataGridViewPlayer.DataSource = db.getTable($"select MaCT, TenCT, MaVitri, NgaySinh, SoAo, doibong.SoBanThang, SoTheVang, SoTheDo, MaQuocTich, SoLanRaSan, Anh, doibong.MaDoi from cauthu join doibong on cauthu.madoi = doibong.madoi where tendoi = N'{v_tendoi}'");
                v_madoi = "";
                v_banthang = "";
            }
            else if (!string.IsNullOrEmpty(v_tenCT))
            {
                dataGridViewPlayer.DataSource = db.getTable($"select * from cauthu where tenCT Like N'%{v_tenCT}%'");
                v_tendoi = "";
                v_banthang = "";
            }
            else if (!string.IsNullOrEmpty(v_banthang))
            {
                dataGridViewPlayer.DataSource = db.getTable($"select * from cauthu where SoBanThang = {int.Parse(v_banthang)}");
                v_tendoi = "";
                v_madoi = "";
            }
            else
            {
                dataGridViewPlayer.DataSource = db.getTable("select * from cauthu");
            }
            DataGridViewImageColumn pic = new DataGridViewImageColumn();
            pic = (DataGridViewImageColumn)dataGridViewPlayer.Columns["Anh"];
            pic.ImageLayout = DataGridViewImageCellLayout.Zoom;
            SetupDataGridView();
        }

        private void dataGridViewPlayer_DoubleClick(object sender, EventArgs e)
        {
            this.mode = "Edit";
            FormAddPlayer formAdd = new FormAddPlayer();
            formAdd.maCT = maCT;
            formAdd.tenCT = tenCT;
            formAdd.maViTri = maViTri;
            formAdd.ngaySinh = ngaySinh;
            formAdd.maQuocTich = maQuocTich;
            formAdd.maDoi = maDoi;
            formAdd.soAo = soAo;
            formAdd.soBanThang = soBanThang;
            formAdd.soTheVang = soTheVang;
            formAdd.soTheDo = soTheDo;
            formAdd.soLanRaSan = soLanRaSan;
            formAdd.status = mode;
            formAdd.pBox = pBox;
            formAdd.ShowDialog();
        }

        private void SetupDataGridView()
        {
            // Header
            dataGridViewPlayer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewPlayer.ColumnHeadersHeight = 60;
            dataGridViewPlayer.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridViewPlayer.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPlayer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewPlayer.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewPlayer.EnableHeadersVisualStyles = false;
            dataGridViewPlayer.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dataGridViewPlayer.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Content
            dataGridViewPlayer.ReadOnly = true;
            dataGridViewPlayer.BorderStyle = BorderStyle.None;
            dataGridViewPlayer.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dataGridViewPlayer.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewPlayer.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewPlayer.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dataGridViewPlayer.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridViewPlayer.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewPlayer.BackgroundColor = Color.FromArgb(235, 237, 240);
            dataGridViewPlayer.RowTemplate.Height = 60;
            dataGridViewPlayer.Columns["MaCT"].Width = 80;
            dataGridViewPlayer.Columns["TenCT"].Width = 220;
            dataGridViewPlayer.Columns["MaViTri"].Width = 70;
            dataGridViewPlayer.Columns["NgaySinh"].Width = 120;
            dataGridViewPlayer.Columns["SoAo"].Width = 70;
            dataGridViewPlayer.Columns["Anh"].Width = 80;
            dataGridViewPlayer.Columns["SoBanThang"].Width = 80;
            dataGridViewPlayer.Columns["SoTheVang"].Width = 70;
            dataGridViewPlayer.Columns["SoTheDo"].Width = 70;
            dataGridViewPlayer.Columns["SoLanRaSan"].Width = 70;
            dataGridViewPlayer.Columns["MaQuocTich"].Width = 110;
            dataGridViewPlayer.Columns["MaDoi"].Width = 80;
            dataGridViewPlayer.Columns["MaCT"].HeaderText = "MÃ TRẬN ĐẤU";
            dataGridViewPlayer.Columns["TenCT"].HeaderText = "TÊN CẦU THỦ";
            dataGridViewPlayer.Columns["MaViTri"].HeaderText = "VỊ TRÍ";
            dataGridViewPlayer.Columns["NgaySinh"].HeaderText = "NGÀY SINH";
            dataGridViewPlayer.Columns["SoAo"].HeaderText = "SỐ ÁO";
            dataGridViewPlayer.Columns["SoBanThang"].HeaderText = "BÀN THẮNG";
            dataGridViewPlayer.Columns["SoTheVang"].HeaderText = "THẺ VÀNG";
            dataGridViewPlayer.Columns["SoTheDo"].HeaderText = "THẺ ĐỎ";
            dataGridViewPlayer.Columns["MaQuocTich"].HeaderText = "MÃ QUỐC TỊCH";
            dataGridViewPlayer.Columns["SoLanRaSan"].HeaderText = "LẦN RA SÂN";
            dataGridViewPlayer.Columns["Anh"].HeaderText = "ẢNH";
            dataGridViewPlayer.Columns["MaDoi"].HeaderText = "MÃ ĐỘI";
        }

        public Player()
        {
            InitializeComponent();
        }

        public void DeletePlayer()
        {
            string ma = dataGridViewPlayer.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa cầu thủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    db.Excute($"delete from CauThu where MaCT = '{ma}'");
                    MessageBox.Show("Xóa thành công!", "Xóa cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dataGridViewPlayer.DataSource = db.getTable("select * from CauThu");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi! Bạn cần xóa mã cầu thủ trong bảng đang tham chiếu đến đội bóng trước.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Click thêm
        private void button1_Click(object sender, EventArgs e)
        {
            this.mode = "Add";
            FormAddPlayer formAdd = new FormAddPlayer();
            formAdd.status = mode;
            formAdd.ShowDialog();
        }

        private void dataGridViewPlayer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            maCT = dataGridViewPlayer.CurrentRow.Cells[0].Value.ToString();
            tenCT = dataGridViewPlayer.CurrentRow.Cells[1].Value.ToString();
            maViTri = dataGridViewPlayer.CurrentRow.Cells[2].Value.ToString();
            ngaySinh = dataGridViewPlayer.CurrentRow.Cells[3].Value.ToString();
            soAo = int.Parse(dataGridViewPlayer.CurrentRow.Cells[4].Value.ToString());
            soBanThang = int.Parse(dataGridViewPlayer.CurrentRow.Cells[5].Value.ToString());
            soTheVang = int.Parse(dataGridViewPlayer.CurrentRow.Cells[6].Value.ToString());
            soTheDo = int.Parse(dataGridViewPlayer.CurrentRow.Cells[7].Value.ToString());
            maQuocTich = dataGridViewPlayer.CurrentRow.Cells[8].Value.ToString();
            soLanRaSan = int.Parse(dataGridViewPlayer.CurrentRow.Cells[9].Value.ToString());
            maDoi = dataGridViewPlayer.CurrentRow.Cells[11].Value.ToString();
            if (dataGridViewPlayer.SelectedRows[0].Cells[10].Value.ToString() != "")
            {
                MemoryStream ms = new MemoryStream((byte[])dataGridViewPlayer.SelectedRows[0].Cells[10].Value);
                pBox.Image = Image.FromStream(ms);
            }
            else
            {
                pBox.Image = null;
            }

            Players.maCT = maCT;
            Players.tenCT = tenCT;
            Players.maViTri = maViTri;
            Players.ngaySinh = ngaySinh;
            Players.soAo = soAo;
            Players.soBanThang = soBanThang;
            Players.soTheVang = soTheVang;
            Players.soTheDo = soTheDo;
            Players.maQuocTich = maQuocTich;
            Players.soLanRaSan = soLanRaSan;
            Players.maDoi = maDoi;
            Players.anh = pBox;
        }



    }
}
