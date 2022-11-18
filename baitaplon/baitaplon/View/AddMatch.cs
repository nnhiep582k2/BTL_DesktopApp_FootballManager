using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitaplon.Model;
using System.IO;

namespace baitaplon.View
{
    public partial class AddMatch : Form
    {
        public AddMatch()
        {
            InitializeComponent();
        }
        SqlConnection connect;

        private void showDataCBMaDoiNha()
        {

            DataTable dt = new DataTable();
            string mdk = "";
            if (cbMaDK.Text != "")
            {
                mdk = cbMaDK.Text;
                SqlDataAdapter dataAdap = new SqlDataAdapter($"select MaDoi from DoiBong where MaDoi <> N'{mdk}'", connect);
                dataAdap.Fill(dt);
            }
            else
            {
                SqlDataAdapter dataAdap = new SqlDataAdapter($"select MaDoi from DoiBong", connect);
                dataAdap.Fill(dt);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaDN.Items.Add(dt.Rows[i]["MaDoi"].ToString());
            }
        }

        private void showDataCBMaDoiKhach()
        {
            DataTable dt = new DataTable();
            string mdn = "";
            if (cbMaDN.Text != "")
            {
                mdn = cbMaDN.Text;
                SqlDataAdapter dataAdap = new SqlDataAdapter($"select MaDoi from DoiBong where MaDoi <> N'{mdn}'", connect);
                dataAdap.Fill(dt);
            }
            else
            {
                SqlDataAdapter dataAdap = new SqlDataAdapter($"select MaDoi from DoiBong", connect);
                dataAdap.Fill(dt);
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbMaDK.Items.Add(dt.Rows[i]["MaDoi"].ToString());
            }
        }
        public void show()
        {
            SqlDataAdapter dataAdap = new SqlDataAdapter("select * from TranDau", connect);
            DataTable dt = new DataTable();
            dataAdap.Fill(dt);

        }
        private bool check()
        {
            if (txtMaTD.Text.Trim() == "")
            {
                MessageBox.Show("Mã trận đấu không được để trống", "Thông báo");
                return false;
            }
            if (txtLuotDau.Text.Trim() == "")
            {
                MessageBox.Show("Lượt đấu không được để trống", "Thông báo");
                return false;
            }
            if (txtVongDau.Text.Trim() == "")
            {
                MessageBox.Show("Vòng đấu không được để trống", "Thông báo");
                return false;
            }
            if (cbMaDN.Text.Trim() == "")
            {
                MessageBox.Show("Mã đội nhà không được để trống", "Thông báo");
                return false;
            }
            if (cbMaDK.Text.Trim() == "")
            {
                MessageBox.Show("Mã đội khách không được để trống", "Thông báo");
                return false;
            }

            return true;
        }
        private void resetForm()
        {
            txtMaTD.Text = "";
            txtLuotDau.Text = "";
            txtVongDau.Text = "";
            cbMaDN.Text = "";
            cbMaDK.Text = "";
            txtBThang.Text = "";
            txtBanThua.Text = "";
            txtSTVDN.Text = "";
            txtSTDDN.Text = "";
            txtSTVDK.Text = "";
            txtSTDDK.Text = "";
            txtGhiChu.Text = "";
        }
        private new bool Validate()
        {
            Regex ma = new Regex(@"TD[0-9]");
            Regex ld = new Regex(@"[0-9]");
            Regex vd = new Regex(@"[0-9]");
            if (!ma.IsMatch(txtMaTD.Text))
            {
                MessageBox.Show("Mã trận đấu phải bắt đầu bằng TD và theo sau là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaTD.Focus();
                return false;
            }
            int s;
            if (!int.TryParse(txtLuotDau.Text, out s))
            {
                MessageBox.Show("Lượt đấu phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuotDau.Focus();
                return false;
            }
            if (!int.TryParse(txtVongDau.Text, out s))
            {
                MessageBox.Show("Vòng đấu phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtVongDau.Focus();
                return false;
            }
            return true;
        }
        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        
        private void btnThem_Click(object sender, EventArgs e)
        {

            if (check()&&Validate())
            {
                if (MessageBox.Show("Bạn có muốn thêm trận đấu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Excute($"Insert into TranDau (MaTD,LuotDau,VongDau,MaDoiNha,MaDoiKhach,GhiChu) values (N'{txtMaTD.Text}',N'{txtLuotDau.Text}',N'{txtVongDau.Text}',N'{cbMaDN.Text}',N'{cbMaDK.Text}',N'{txtGhiChu.Text}')");

                        MessageBox.Show("Thêm thành công!", "Thêm trận đấu", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.resetForm();
                        this.Hide();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        

        private void btnBack_Click(object sender, EventArgs e)
        {
            Match match= new Match();
            this.Hide();
            match.Show();
        }
        public string maTD, luotDau, vongDau, maDN, maDK, ghiChu;

        public int sBThang, sBThua, stvDN, stdDN, stvDK, stdDK;
         
        private void AddMatch_Load(object sender, EventArgs e)
        {
            txtMaTD.Text = maTD;
            txtLuotDau.Text = luotDau;
            txtVongDau.Text = vongDau;
            cbMaDN.Text = maDN;
            cbMaDK.Text = maDK;
            txtBThang.Text = sBThang.ToString();
            txtBanThua.Text = sBThua.ToString();
            txtSTVDN.Text = stvDN.ToString();
            txtSTDDN.Text = stdDN.ToString();
            txtSTVDK.Text = stvDK.ToString();
            txtSTDDK.Text = stdDK.ToString();
            txtGhiChu.Text = ghiChu;
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";
            connect.Open();
            show();
            connect.Close();
            showDataCBMaDoiNha();
            showDataCBMaDoiKhach();
        }

        private void cbMaDN_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaDK.Items.Clear();
            showDataCBMaDoiNha();
            showDataCBMaDoiKhach();
        }

        private void cbMaDK_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMaDN.Items.Clear();
            showDataCBMaDoiNha();
            showDataCBMaDoiKhach();
        }
    }
}
