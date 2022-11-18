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
    public partial class Edit_Match_Card : Form
    {
        public string matd, mact, loaithe, ghichu;
        public int tg;

        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        public Edit_Match_Card()
        {
            InitializeComponent();
            showDataCBCT();
            showDatathe();
            showDataCBMaTD();
        }
        
        private void showDataCBMaTD()
        {
            DataTable dt = conn.getTable($"select MaTD from TranDau");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cb_matd.Items.Add(dt.Rows[i]["MaTD"].ToString());
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

        public void reset()
        {
            cb_ct.Text  = "";
            cb_matd.Text  = "";
            cb_the.Text  = "";
            txttg.Text  = "";
            txtghichu.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
           
            
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
            if (string.IsNullOrEmpty(cb_the.Text))
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
        private void Formtrandau_thecs_Load(object sender, EventArgs e)
        {
            cb_ct.Text = Match_Card_SS.mact;
            cb_matd.Text = Match_Card_SS.matd;
            cb_the.Text = Match_Card_SS.loaithe;
            txttg.Text = Match_Card_SS.tg.ToString();
            txtghichu.Text = Match_Card_SS.ghichu;
            cb_ct.Enabled = false;
            cb_matd.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)

        {
            if (this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn update thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    conn.Excute($"update TranDau_The set  ThoiGian = N'{txttg.Text.Trim()}', LoaiThe = N'{cb_the.Text.Trim()}' , GhiChu = N'{txtghichu.Text.Trim()}'   Where MaTD = N'{cb_matd.Text}' and MaCT = '{cb_ct.Text}'  ");

                    MessageBox.Show("update thành công!", "update Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    //dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                }

            }

           

        }

        private void cb_the_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       

        private void txttg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        List<string> listItem;
        private void showDatathe()
        {
            listItem = new List<string>() { "Thẻ Đỏ","Thẻ Vàng"};
            cb_the.DataSource= listItem;


           

        }
        private void trandau_thecs_Load(object sender, EventArgs e)
        {
            cb_ct.Text = mact;
            cb_matd.Text = matd;
            cb_the.Text = loaithe;
            txtghichu.Text = ghichu;
            txttg.Text = tg.ToString();
            // conn.Excute_new("select * from TranDau_CauThu");
          



        }
    }
}
