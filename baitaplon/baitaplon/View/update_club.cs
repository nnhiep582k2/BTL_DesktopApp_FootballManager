using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon.View
{
    public partial class update_club : Form
    {
        public string madoi, tendoi, hlv, masan, matinh;
        public PictureBox pBox;
        public update_club()
        {
            InitializeComponent();
        }
        ConnAdd conn = new ConnAdd();
        DoiBong db;
        private void update_clup_Load(object sender, EventArgs e)
        {
           // showDataCBTinh();
            //showDataCBMaDoi();
            txtmadb.Text = madoi;
            txttendoi.Text= tendoi;
            txthlv.Text = hlv;
            this.getData($"select MaSan from SanBong", cbMaSan, "Masan");
            this.getData($"select MaTinh from Tinh", cbMaTinh, "MaTinh");
            cbMaSan.Text = masan;   
            cbMaTinh.Text = matinh;

            if(pBox.Image != null)
            {
                pictureBox1.Image = pBox.Image;
            }
            txtmadb.Enabled = false;
        }
        private void getData(string query, ComboBox cbb, string lname)
        {
            DataTable dt = conn.table(query);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb.Items.Add(dt.Rows[i][lname].ToString());
            }
        }
        private void showDataCBTinh()
        {
            DataTable dt = conn.table($"select MaTinh from Tinh");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaTinh.Items.Add(dt.Rows[i]["MaTinh"].ToString());
            }
        }

        private void showDataCBMaDoi()
        {
            DataTable dt = conn.table($"select MaSan from SanBong");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaSan.Items.Add(dt.Rows[i]["MaSan"].ToString());
            }
        }
        private void Getvalues()
        {
            string madb = txtmadb.Text;
            string tendb = txttendoi.Text;
            string hlv = txthlv.Text;
            byte[] anh = imageToByarray(pictureBox1);
 
            string masan = cbMaSan.Text;
            string matinh = cbMaTinh.Text;
            db = new DoiBong(madb, tendb, hlv, anh, masan, matinh);

        }
        private byte[] imageToByarray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }
        private new bool Validate()
        {

            if (string.IsNullOrEmpty(txtmadb.Text))
            {
                MessageBox.Show("Không được để trống mã đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtmadb.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txttendoi.Text))
            {
                MessageBox.Show("Không được để trống tên đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendoi.Focus();
                return false;
            }



            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Không được để trống logo đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txttendoi.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(txthlv.Text))
            {
                MessageBox.Show("Không được để trống tên hlv đội bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthlv.Focus();
                return false;
            }
         
            int s;
            if (int.TryParse(txthlv.Text, out s))
            {
                MessageBox.Show("tên hlv ko không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txthlv.Focus();
                return false;
            }

            if (string.IsNullOrEmpty(cbMaSan.Text))
            {
                MessageBox.Show("Không được để trống mã sân bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaSan.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(cbMaTinh.Text))
            {
                MessageBox.Show("Không được để trống mã sân bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbMaTinh.Focus();
                return false;
            }

            return true;
        }

        private void Update_clupbtn_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn update đội bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    string query = $"update DoiBong set TenDoi=@tendoi,HLV=@hlv,Logo=@anh,MaSan=@masan,MaTinh=@matinh Where  MaDoi = @madoi";
                    Getvalues();
                    conn.Excute(db, query);
                    MessageBox.Show("update thanh cong");
                    this.Hide();
                }

            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gìf;*.jpg;*.jpeg;*.bmp;*.png)|*.gìf;*.jpg;*.jpeg;*.bmp;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }
        }
    }
}
