using baitaplon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace baitaplon.View
{
    public partial class Add_Stadium : Form
    {
        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        public Add_Stadium()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }

        private void Stadium_Load(object sender, EventArgs e)
        {
           
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                try
                {
                    db.Excute($"update sanbong set tensan = N'{txtTen.Text}', diachi = N'{txtDiaChi.Text}', soghe = {int.Parse(txtSoGhe.Text)} where masan = '{txtMa.Text}'");
                    MessageBox.Show("Sửa thành công!", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Reset();
                    //dataGridViewStadium.DataSource = db.getTable("select * from sanbong");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Sửa thất bại!", "Lỗi sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(this.Validate())
            {
                try
                {
                    db.Excute($"insert into sanbong values ('{txtMa.Text}',N'{txtTen.Text}',N'{txtDiaChi.Text}',{int.Parse(txtSoGhe.Text)})");
                    MessageBox.Show("Thêm thành công!", "Thêm thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Reset();
                    //dataGridViewStadium.DataSource = db.getTable("select * from sanbong");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Thêm mới thất bại!", "Lỗi thêm mới", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewStadium_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteStadium();
            }
        }

        private void DeleteStadium()
        {
           // string ma = dataGridViewStadium.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa sân bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                  //  db.Excute($"delete from sanbong where MaSan = '{ma}'");
                    MessageBox.Show("Xóa thành công!", "Xóa sân bóng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                  //  dataGridViewStadium.DataSource = db.getTable("select * from sanbong");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    MessageBox.Show("Phát sinh dữ liệu liên quan! Hãy xóa sân bóng trong bảng đội bóng trước khi xóa sân bóng.", "Lỗi xóa dữ liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            this.DeleteStadium();
        }

        private void dataGridViewStadium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void Reset()
        {
            txtMa.Text = "";
            txtDiaChi.Text = "";
            txtSoGhe.Text = "";
            txtTen.Text = "";
            txtMa.Focus();
        }

        private new bool Validate()
        {
            Regex cMa = new Regex(@"SB[0-9]");
            Regex cTen = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Không được để trống mã sân bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return false;
            }
            if (!cMa.IsMatch(txtMa.Text))
            {
                MessageBox.Show("Mã sân bóng phải bắt đầu bằng SB và theo sau là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Không được để trống tên sân bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (cTen.IsMatch(txtTen.Text))
            {
                MessageBox.Show("Tên sân bóng không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtDiaChi.Text))
            {
                MessageBox.Show("Không được để trống vị trí", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiaChi.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoGhe.Text))
            {
                MessageBox.Show("Không được để trống số ghế của sân bóng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGhe.Focus();
                return false;
            }
            int s;
            if (!int.TryParse(txtSoGhe.Text, out s))
            {
                MessageBox.Show("Số ghế phải là số nguyên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoGhe.Focus();
                return false;
            }
            return true;
        }

        private void dataGridViewStadium_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
