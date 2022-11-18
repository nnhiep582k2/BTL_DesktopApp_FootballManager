using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data;
using System.IO;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Remoting.Channels;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace baitaplon.View
{
    public partial class add_clup : Form
    {
        
   
     
      
        public add_clup()
        {
            InitializeComponent();
        }
        ConnAdd conn = new ConnAdd();
        DoiBong db;
        private void label2_Click(object sender, EventArgs e)
        {
           
        }

        private void add_clup_Load(object sender, EventArgs e)
        {
            showDataCBTinh();
            showDataCBMaDoi();
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

            

            if (pictureBox1.Image==null)
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
            if (int.TryParse(txthlv.Text,out s))
            {
                MessageBox.Show("tên hlv không hợp lẹ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Chọn Ảnh";
            openFileDialog.Filter = "Image Files(*.gìf;*.jpg;*.jpeg;*.bmp;*.png)|*.gìf;*.jpg;*.jpeg;*.bmp;*.png";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;

            }

        }
      private void Getvalues()
        {
            string madb = txtmadb.Text;
            string tendb= txttendoi.Text;
            string hlv = txthlv.Text;
            byte[] anh = imageToByarray(pictureBox1);

            string masan = cbMaSan.Text;
            string matinh = cbMaTinh.Text;
            db = new DoiBong(madb, tendb, hlv, anh,masan,matinh);

        }
        private byte[] imageToByarray(PictureBox pictureBox)
        {
            MemoryStream memoryStream = new MemoryStream();
            pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
            return memoryStream.ToArray();
        }

        private void Add_clupbtn_Click(object sender, EventArgs e)
        {
           if(this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn thêm đội bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    string query = $"Insert into DoiBong(MaDoi,TenDoi,HLV,Logo,MaSan,MaTinh) values (@madoi,@tendoi,@hlv,@anh,@masan,@matinh)";
                    Getvalues();
                    conn.Excute(db, query);

                    MessageBox.Show("them thanh cong");
                    this.Hide();

                }
            }
           
          
        
        
        
        }

        private void back_button_Click(object sender, EventArgs e)
        {

            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

      
    }
}
