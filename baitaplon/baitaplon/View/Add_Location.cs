using baitaplon.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace baitaplon.View
{
    public partial class Add_Location : Form
    {
        public Add_Location()
        {
            InitializeComponent();
        }
        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private bool check()
        {
            if (txtMaVT.Text.Trim() == "")
            {
                MessageBox.Show("Bạn chưa nhập mã vị trí.Xin vui lòng nhập lại!  ", "Thông báo");
                return false;
            }
            if (txtTenVT.Text.Trim() == "")
            {
                MessageBox.Show("Tên vị trí không được để trống", "Thông báo");
                return false;
            }

            return true;
        }
        private void resetForm()
        {
            txtMaVT.Text = "";
            txtTenVT.Text = "";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (check())
            {
                if (MessageBox.Show("Bạn có muốn thêm vị trí không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        connectData.Excute($"Insert into Vitri (MaViTri,TenViTri) values (N'{txtMaVT.Text}',N'{txtTenVT.Text}')");
                        MessageBox.Show("Thêm thành công!", "Thêm vị trí", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Location_Load(sender, e);
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

        private void Location_Load(object sender, EventArgs e)
        {
   
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void dgvVitri_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

       
        private void cbbVT_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            
        }
        private void SetupDataGridView()
        {
         
            
        }

        private void dgvVitri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
