using baitaplon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon.View
{
    public partial class Edit_Nationalities : Form
    {
        public Edit_Nationalities()
        {
            InitializeComponent();
        }
        public string maQT;
        public string tenQT;
        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private bool check()
        {
            Regex ma = new Regex(@"QT[0-9]");
            if (txtMaQT.Text.Trim() == "")
            {
                MessageBox.Show("Mã tỉnh không được để trống", "Thông báo");
                return false;
            }
            if (!ma.IsMatch(txtMaQT.Text))
            {
                MessageBox.Show("Mã trận đấu phải bắt đầu bằng QT và theo sau là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaQT.Focus();
                return false;
            }
            if (txtTenQT.Text.Trim() == "")
            {
                MessageBox.Show("Tên tỉnh không được để trống", "Thông báo");
                return false;
            }

            return true;
        }
        private void resetForm()
        {
            txtMaQT.Text = "";
            txtTenQT.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            
        }

        private void Nationality_Load(object sender, EventArgs e)
        {
            maQT = Nationalities_SS.maQT;
            tenQT = Nationalities_SS.tenQT;
            txtMaQT.Text = maQT;
            txtTenQT.Text = tenQT;
            txtMaQT.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string query = $"Update QuocTich set TenQuocTich = N'{txtTenQT.Text}' where MaQuocTich = N'{txtMaQT.Text.Trim()}'";
                if (MessageBox.Show("Bạn có muốn sửa thông tin Quốc tịch không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    try
                    {
                        connectData.Excute(query);
                        MessageBox.Show("Sửa thành công!", "Thông báo");
                        resetForm();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Thông báo");
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            /*
              string s = dgvQuoctich.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == System.Windows.Forms.DialogResult.Yes)
            {
                string query = "delete from QuocTich where MaQuocTich = '" + s + "'";
                connectData.Excute(query);
                Nationality_Load(sender, e);
            }
            */
        }

        private void Add_Nationalities_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
