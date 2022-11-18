using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace baitaplon
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }
        public bool checkAccount(string ac)//check taikhoan va matkhau
        {
            return Regex.IsMatch(ac, "^[a-zA-Z0-9]{6,24}$");
        }
        public bool checkEmail(String em)
        {
            return Regex.IsMatch(em, @"^[a-zA-Z0-9_.]{3,20}@gmail.com$");
        }
        Modify modify = new Modify();
        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tendn=txtTenDN.Text;
            string matkhau=txtMK.Text;
            string xnmatkhau = txtNMK.Text;
            string email=txtEmail.Text;
            if (!checkAccount(tendn)) { MessageBox.Show("Tên đăng nhập quá ngắn hoặc chưa đúng định dạng!!");return;}
            if (!checkAccount(matkhau)) { MessageBox.Show("Mật khẩu quá ngắn (lớn hơn 6 kí tự)!!"); return; }
            if (xnmatkhau != matkhau) { MessageBox.Show("Xác nhận mật khẩu chưa chính xác vui lòng nhập lại!! ");return; }
            if (!checkEmail(email)) { MessageBox.Show("Email chưa chính xác hoặc chưa nhập!!"); return; }
            if (modify.TaiKhoans("Select * from TaiKhoan where Email = '"+email+"'").Count != 0) { MessageBox.Show("Email này đã được đăng ký vui lòng đăng ký email khác!!");return; }
            try
            {
                string query = "Insert into TaiKhoan values('" + tendn + "','" + matkhau + "','" + email + "') ";
                modify.Command(query);
                if(MessageBox.Show("Bạn đã đăng ký thành công!","Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {

                    Login login = new Login();
                    this.Hide();
                    login.Show();
                }
            }
            catch
            {
                MessageBox.Show("Tên đăng nhập này đã được đăng ký,Vui lòng đăng ký tên đăng nhập khác!!");
            }
        }

        private void Dangky_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void txtTenDN_Enter(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "Username")
            {
                txtTenDN.Text = "";
                txtTenDN.ForeColor = Color.Black;
            }
        }

        private void txtTenDN_Leave(object sender, EventArgs e)
        {
            if (txtTenDN.Text == "")
            {
                txtTenDN.Text = "Username";
                txtTenDN.ForeColor = Color.Silver;
            }

        }

        private void txtTenDN_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMK_Enter(object sender, EventArgs e)
        {
            if (txtMK.Text == "Password")
            {
                txtMK.Text = "";
                txtMK.ForeColor = Color.Black;
            }
        }
        private void txtMK_Leave(object sender, EventArgs e)
        {
            if (txtMK.Text == "")
            {
                txtMK.Text = "Password";
                txtMK.ForeColor = Color.Silver;
            }
        }

        

        private void txtNMK_Enter(object sender, EventArgs e)
        {
            if (txtNMK.Text == "Confirm Password")
            {
                txtNMK.Text = "";
                txtNMK.ForeColor = Color.Black;
            }
        }

        private void txtNMK_Leave(object sender, EventArgs e)
        {
            if (txtNMK.Text == "")
            {
                txtNMK.Text = "Confirm Password";
                txtNMK.ForeColor = Color.Silver;
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.Black;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                txtEmail.Text = "Email";
                txtEmail.ForeColor = Color.Silver;
            }
        }
    }
}
