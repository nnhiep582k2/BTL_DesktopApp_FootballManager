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

namespace baitaplon.View
{
    public partial class Edit_Provinces : Form
    {
        public Edit_Provinces()
        {
            InitializeComponent();
        }
        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private bool check()
        {
            if (txtMaTinh.Text.Trim() == "")
            {
                MessageBox.Show("Mã tỉnh không được để trống", "Thông báo");
                return false;
            }
            if (txtTenTinh.Text.Trim() == "")
            {
                MessageBox.Show("Tên tỉnh không được để trống", "Thông báo");
                return false;
            }

            return true;
        }
        private void resetForm()
        {
            txtMaTinh.Text = "";
            txtTenTinh.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (MessageBox.Show("Bạn có muốn thêm tỉnh không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connectData.Excute($"Insert into Tinh (MaTinh,TenTinh) values (N'{txtMaTinh.Text}',N'{txtTenTinh.Text}')");
                        MessageBox.Show("Thêm thành công!", "Thêm tỉnh", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Province_Load(sender, e);
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

        private void Province_Load(object sender, EventArgs e)
        {
            txtMaTinh.Text = Province_SS.maTinh;
            txtTenTinh.Text = Province_SS.tenTinh;
            txtMaTinh.Enabled = false;

        }

        private void dgvTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check())
            {
                string query = $"Update Tinh set TenTinh = N'{txtTenTinh.Text}' where MaTinh = N'{txtMaTinh.Text.Trim()}'";
                if (MessageBox.Show("Bạn có muốn sửa thông tin tỉnh không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
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
      
        private void dgvTinh_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
