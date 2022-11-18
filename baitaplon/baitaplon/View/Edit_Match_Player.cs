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
    public partial class Edit_Match_Player : Form
    {
        public string madoi, mact;
        public Edit_Match_Player()
        {
            InitializeComponent();
            showDataCBCT();
            showDataCBMaTD();
        }
        ProcessConnect conn = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            cb_matd.Text = Match_Player_SS.matd;
            cb_ct.Text = Match_Player_SS.mact;
            cb_matd.Enabled = false;
            

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
        private new bool Validate()
        {


            if (string.IsNullOrEmpty(cb_ct.Text))
            {
                MessageBox.Show("Không được để trống mã cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                return false;
            }
            

            if (string.IsNullOrEmpty(cb_matd.Text))
            {
                MessageBox.Show("Không được để trống mã trận đấu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
                return false;
            }
            return true;
        }

            private void btn_add_Click(object sender, EventArgs e)
        {
           if( this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn thêm thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)

                {
                    string query = $"Insert into TranDau_CauThu(MaTD,MaCT) values  (N'{cb_matd.Text}',N'{cb_ct.Text}')";
                   
                    conn.Excute(query);

                    MessageBox.Show("thêm thành công!");

                    this.Hide();

                    //dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");


                }
            }
        }

     

        private void dgv_tdct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          //  cb_matd.Text = dgv_tdct.CurrentRow.Cells[0].Value.ToString();
            //cb_ct.Text = dgv_tdct.CurrentRow.Cells[1].Value.ToString();
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnpdate_Click(object sender, EventArgs e)

        {
            if (this.Validate())
            {
                string mact = cb_ct.Text;
                string matd = cb_matd.Text;

                if (MessageBox.Show("Bạn có muốn update đội bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {

                    conn.Excute($"update TranDau_CauThu set  MaCT = '{mact}' Where MaTD = N'{matd}' and MaCT = N'{Match_Player_SS.mact}'  ");
                    MessageBox.Show("Update thành công!", "Update cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();

                    //dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                }

            }

        }
                

       
    }
}
