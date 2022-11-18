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
    public partial class Add_Match_Goal : Form
    {
        public string matd, mact, ghichu;
        public int tg, sl;
        public Add_Match_Goal()
        {
            InitializeComponent();
            showDataCBMaTD();
            showDataCBCT();
        }

        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void btn_add_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn thêm thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    string query = $"Insert into TranDau_BanThang(MaTD,MaCT,Thoigian,Ghichu,SoLuong) values  (N'{cb_matd.Text}',N'{cb_ct.Text}','{txttg.Text}',N'{txtghichu.Text}',N'{txt_sl.Text}')";

                    conn.Excute(query);

                    MessageBox.Show("thêm thành công!");

                    this.Hide();

                    //dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");


                }

            }

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {

                if (MessageBox.Show("Bạn có muốn update thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    conn.Excute($"update TranDau_BanThang set  MaCT = '{cb_ct.Text}' Where MaTD = N'{cb_matd.Text}' and MaCT = '{cb_ct.Text}'  ");
                    this.Hide();

                    //dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                }
            }

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
          
            this.Hide();
           
        }

        private void showDataCBMaTD()
        {
            DataTable dt = conn.getTable($"select MaTD from TranDau");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_matd.Items.Add(dt.Rows[i]["MaTD"].ToString());
            }
        }

        private void txttg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_sl_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void showDataCBCT()
        {
            DataTable dt = conn.getTable($"select MaCT from CauThu");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_ct.Items.Add(dt.Rows[i]["MaCT"].ToString());
            }
        }
        private new bool Validate()
        {


            if (string.IsNullOrEmpty(cb_ct.Text))
            {
                MessageBox.Show("Không được để trống mã cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (string.IsNullOrEmpty(txttg.Text))
            {
                MessageBox.Show("Không được để trống thời gian", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            if (string.IsNullOrEmpty(txt_sl.Text))
            {
                MessageBox.Show("Không được để trống số lượng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrEmpty(cb_matd.Text))
            {
                MessageBox.Show("Không được để trống mã trận đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
            return true;
        }

        private void FormTrandau_banthang_Load(object sender, EventArgs e)
        {
            cb_ct.Text = mact;
            cb_matd.Text = matd;
            txt_sl.Text = sl.ToString();
            txttg.Text = tg.ToString();
            txtghichu.Text = ghichu;
        }
    }
}
