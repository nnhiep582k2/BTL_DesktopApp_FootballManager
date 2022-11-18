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
    public partial class Add_Nationalities : Form
    {
        public Add_Nationalities()
        {
            InitializeComponent();
        }
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
            if (check())
            {
                if (MessageBox.Show("Bạn có muốn thêm Quốc tịch không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connectData.Excute($"Insert into QuocTich (MaQuocTich,TenQuocTich) values (N'{txtMaQT.Text}',N'{txtTenQT.Text}')");
                        MessageBox.Show("Thêm thành công!", "Thêm Quốc tịch", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Nationality_Load(sender, e);
                        resetForm();

                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Nationality_Load(object sender, EventArgs e)
        {
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
                        Nationality_Load(sender, e);
                       
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
            this.Hide();
          
        }

       
      
    }
}
