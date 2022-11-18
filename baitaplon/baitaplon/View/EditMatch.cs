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
    public partial class EditMatch : Form
    {
        public EditMatch()
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
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (check() && Validate())
            {
                if (MessageBox.Show("Bạn có muốn sửa trận đấu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        db.Excute($"update TranDau set LuotDau =N'{txtLuotDau.Text}',VongDau=N'{txtVongDau.Text}',MaDoiNha=N'{cbMaDN.Text}',MaDoiKhach=N'{cbMaDK.Text}',Ghichu=N'{txtGhiChu.Text}' where MaTD = N'{txtMaTD.Text}'");

                        MessageBox.Show("Sửa thành công!", "Sửa thông tin trận đấu", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
        private string maDK;
        private int stdDK;
        private string maTD;
        private int luotDau;
        private int vongDau;
        private string maDN;
        private int sBThang;
        private int sBThua;
        private int stvDN;
        private int stdDN;
        private int stvDK;
        private string ghichu;

        public string MaDK { get => maDK; set => maDK = value; }
        public int StdDK { get => stdDK; set => stdDK = value; }
        public string MaTD { get => maTD; set => maTD = value; }
        public int LuotDau { get => luotDau; set => luotDau = value; }
        public int VongDau { get => vongDau; set => vongDau = value; }
        public string MaDN { get => maDN; set => maDN = value; }
        public int SBThang { get => sBThang; set => sBThang = value; }
        public int SBThua { get => sBThua; set => sBThua = value; }
        public int StvDN { get => stvDN; set => stvDN = value; }
        public int StdDN { get => stdDN; set => stdDN = value; }
        public int StvDK { get => stvDK; set => stvDK = value; }
        public string Ghichu { get => ghichu; set => ghichu = value; }

        private void EditMatch_Load(object sender, EventArgs e)
        {
            txtMaTD.Text = MaTD;
            txtLuotDau.Text = LuotDau.ToString();
            txtVongDau.Text = VongDau.ToString();
            cbMaDN.Text = MaDN;
            cbMaDK.Text = MaDK;
            txtBThang.Text = SBThang.ToString();
            txtBanThua.Text = SBThua.ToString();
            txtSTVDN.Text = StvDN.ToString();
            txtSTDDN.Text = StdDN.ToString();
            txtSTVDK.Text = StvDK.ToString();
            txtSTDDK.Text = StdDK.ToString();
            txtGhiChu.Text= Ghichu;
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";
            connect.Open();
            txtMaTD.Enabled = false;

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

        private void btnBack_Click(object sender, EventArgs e)
        {
            Match match=new Match();
            this.Hide();
            match.Show();
        }
    }
}
