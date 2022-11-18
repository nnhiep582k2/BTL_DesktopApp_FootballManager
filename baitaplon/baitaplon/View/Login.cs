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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
           
           
        }

        Modify modify = new Modify();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "")
            {
                panel7.Visible = true;
                txtUserName.Focus();
                return;
                
            }
            else if (txtPassword.Text == "")
            {
                panel9.Visible = true;
                txtPassword.Focus();
                return ;
            }
            else
            {
                string query="Select * from TaiKhoan where TenTaiKhoan = '"+txtUserName.Text+"' and MatKhau ='"+txtPassword.Text+"'";
                if (modify.TaiKhoans(query).Count!=0)
                {
                    Layout layoutEventHandler = new Layout();
                    this.Hide();
                    layoutEventHandler.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            txtUserName.SelectAll();
        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            txtPassword.SelectAll();
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                txtUserName.Text = "";
                return;
            }
            panel7.Visible=false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "";
                return;
            }
            if (!txtPassword.Text.Equals("Password"))
            {
                txtPassword.PasswordChar = '*';
            }
            panel9.Visible=false;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Register dangky = new Register();
            this.Hide();
            dangky.Show();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ForgetPassWord quenMatKhau = new ForgetPassWord();
            this.Hide();
            quenMatKhau.Show();

        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
           if(txtUserName.Text=="Username")
            {
                txtUserName.Text = "";
                txtUserName.ForeColor = Color.Black;
            }
        }

        private void txtUserName_Leave(object sender, EventArgs e)
        {
            if(txtUserName.Text=="")
            {
                txtUserName.Text = "Username";
                txtUserName.ForeColor = Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.Black;
            }

        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.Silver;
            }
        }
    }
}
