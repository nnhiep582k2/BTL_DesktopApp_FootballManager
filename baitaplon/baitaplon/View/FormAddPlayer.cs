using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using baitaplon.Model;

namespace baitaplon.View
{
    public partial class FormAddPlayer : Form
    {
        string sqlString = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";
        private SqlDataAdapter dataAdapter;
        private SqlCommand sqlCommand;
        public string maCT, tenCT, maViTri, ngaySinh, maQuocTich, maDoi;
        public int soAo, soBanThang, soTheVang, soTheDo, soLanRaSan;
        public string status = "Add";
        public PictureBox pBox;

        private void btnStatus_Click(object sender, EventArgs e)
        {
            if (this.status == "Add")
            {
                this.InsertPlayer();
            }
            else if (this.status == "Edit")
            {
                this.UpdatePlayer();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.ResetData();
            txtMa.Focus();
        }

        public FormAddPlayer()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(40, 182, 150);
        }

        private void getData(string query, ComboBox cbb, string lname)
        {
            DataTable dt = getTable(query);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show($"Chưa có {lname}, Bạn cần thêm {lname} ở More!");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb.Items.Add(dt.Rows[i][lname].ToString());
            }
        }

        private Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                return Image.FromStream(ms);
            }
        }

        private void cbbQTich_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void FormAddPlayer_Load(object sender, EventArgs e)
        {
            txtMa.Text = maCT;
            txtTen.Text = tenCT;
            cbbViTri.Text = maViTri;
            DateTime s;
            if (DateTime.TryParse(ngaySinh, out s))
            {
                dateTimePickerDOB.Value = DateTime.Parse(ngaySinh);
            }
            else
            {
                dateTimePickerDOB.Value = DateTime.Now;
            }
            cbbQTich.Text = maQuocTich;
            cbbDoi.Text = maDoi;
            txtSoAo.Text = soAo.ToString();
            txtSoBT.Text = soBanThang.ToString();
            txtTheVang.Text = soTheVang.ToString();
            txtTheDo.Text = soTheDo.ToString();
            txtLanRaSan.Text = soLanRaSan.ToString();


            

            if (this.status.Equals("Edit"))
            {
                if (pBox.Image != null)
                {
                    pictureBox1.Image = pBox.Image;
                }
                else
                {
                    pictureBox1.Image = null;
                }

            }
            

            this.getData("select MaVitri from Vitri", cbbViTri, "MaVitri");
            this.getData("select MaQuocTich from QuocTich", cbbQTich, "MaQuocTich");
            this.getData("select MaDoi from DoiBong", cbbDoi, "MaDoi");

            if (this.status == "Add")
            {
                cbbViTri.Text = "Chọn mã vị trí";
                cbbQTich.Text = "Chọn mã quốc tịch";
                cbbDoi.Text = "Chọn mã đội";
                btnStatus.Text = "Add";
                this.Text = "Thêm mới cầu thủ";
            }
            else if (this.status == "Edit")
            {
                btnStatus.Text = "Edit";
                txtMa.Enabled = false;
                this.Text = "Sửa thông tin cầu thủ";
            }
        }

        private new bool Validate()
        {
            Regex cMa = new Regex(@"CT[0-9]");
            Regex cTen = new Regex(@"[0-9]");
            if (string.IsNullOrEmpty(txtMa.Text))
            {
                MessageBox.Show("Không được để trống mã cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return false;
            }
            if (!cMa.IsMatch(txtMa.Text))
            {
                MessageBox.Show("Mã cầu thủ phải bắt đầu bằng CT và theo sau là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMa.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtTen.Text))
            {
                MessageBox.Show("Không được để trống tên cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (cTen.IsMatch(txtTen.Text))
            {
                MessageBox.Show("Tên cầu thủ không được chứa số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTen.Focus();
                return false;
            }
            if (cbbViTri.Text == "Chọn mã vị trí" || cbbViTri.Items.IndexOf(cbbViTri.Text) == -1)
            {
                MessageBox.Show("Vị trí của cầu thủ không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbViTri.Focus();
                return false;
            }
            DateTime dateNow = DateTime.Now;
            DateTime dob = DateTime.Parse(dateTimePickerDOB.Text);
            if (dob > dateNow)
            {
                MessageBox.Show("Ngày sinh không được lớn hơn ngày hôm nay", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateTimePickerDOB.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(txtSoAo.Text))
            {
                MessageBox.Show("Không được để trống số áo của cầu thủ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoAo.Focus();
                return false;
            }
            if (txtSoAo.Text == "0")
            {
                MessageBox.Show("Số áo của cầu thủ phải khác 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoAo.Focus();
                return false;
            }
            int s;
            if (!int.TryParse(txtSoAo.Text, out s))
            {
                MessageBox.Show("Số áo không hợp lệ, phải là số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoAo.Focus();
                return false;
            }
            if (cbbQTich.Text == "Chọn mã quốc tịch" || cbbQTich.Items.IndexOf(cbbQTich.Text) == -1)
            {
                MessageBox.Show("Mã quốc tịch không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbQTich.Focus();
                return false;
            }
            if (cbbDoi.Text == "Chọn mã đội" || cbbDoi.Items.IndexOf(cbbDoi.Text) == -1)
            {
                MessageBox.Show("Mã đội không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cbbDoi.Focus();
                return false;
            }
            return true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Chọn ảnh";
            dialog.Filter = "Image Files(*.jpg;*.jpeg;*bmp;*.png)|*.jpg;*.jpeg;*bmp;*.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = dialog.FileName;
                txtUrl.Text = dialog.FileName;
            }
        }

        private byte[] ImageToByteArray(PictureBox pictureBox)
        {
            MemoryStream ms = new MemoryStream();
            pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            return ms.ToArray();
        }

        public void InsertPlayer()
        {
            if (this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn thêm cầu thủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(sqlString))
                        {
                            conn.Open();

                            string query =
                                @"INSERT INTO CauThu (MaCT,TenCT,MaVitri,NgaySinh,SoAo,MaQuocTich,Anh,MaDoi) VALUES(@MaCT,@TenCT,@MaVitri,@NgaySinh,@SoAo,@MaQuocTich,@Anh,@MaDoi);";

                            var insertCommand = new SqlCommand(query, conn);

                            insertCommand.Parameters.Add("@MaCT", SqlDbType.NVarChar, 10).Value = txtMa.Text;
                            insertCommand.Parameters.Add("@TenCT", SqlDbType.NVarChar, 30).Value = txtTen.Text;
                            insertCommand.Parameters.Add("@MaVitri", SqlDbType.NVarChar, 10).Value = cbbViTri.Text;
                            insertCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
                            insertCommand.Parameters.Add("@SoAo", SqlDbType.Int).Value = txtSoAo.Text;
                            insertCommand.Parameters.Add("@MaQuocTich", SqlDbType.NVarChar, 10).Value = cbbQTich.Text;
                            insertCommand.Parameters.Add("@Anh", SqlDbType.Image).Value = ImageToByteArray(pictureBox1);
                            insertCommand.Parameters.Add("@MaDoi", SqlDbType.NVarChar, 10).Value = cbbDoi.Text;
                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Thêm thành công!", "Thêm cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.ResetData();
                            this.Hide();

                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        public void UpdatePlayer()
        {
            if (this.Validate())
            {
                if (MessageBox.Show("Bạn có muốn sửa thông tin cầu thủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    try
                    {
                        using (SqlConnection conn = new SqlConnection(sqlString))
                        {
                            conn.Open();

                            string query =
                                @"update CauThu set TenCT = @TenCT, MaViTri = @MaVitri, NgaySinh = @NgaySinh, MaQuocTich = @MaQuocTich, MaDoi = @MaDoi, Anh = @Anh, SoAo = @SoAo where MaCT = @MaCT;";

                            var insertCommand = new SqlCommand(query, conn);

                            insertCommand.Parameters.Add("@MaCT", SqlDbType.NVarChar, 10).Value = txtMa.Text;
                            insertCommand.Parameters.Add("@TenCT", SqlDbType.NVarChar, 30).Value = txtTen.Text;
                            insertCommand.Parameters.Add("@MaVitri", SqlDbType.NVarChar, 10).Value = cbbViTri.Text;
                            insertCommand.Parameters.Add("@NgaySinh", SqlDbType.Date).Value = dateTimePickerDOB.Value.ToString("yyyy-MM-dd");
                            insertCommand.Parameters.Add("@SoAo", SqlDbType.Int).Value = txtSoAo.Text;
                            insertCommand.Parameters.Add("@MaQuocTich", SqlDbType.NVarChar, 10).Value = cbbQTich.Text;
                            insertCommand.Parameters.Add("@Anh", SqlDbType.Image).Value = ImageToByteArray(pictureBox1);
                            insertCommand.Parameters.Add("@MaDoi", SqlDbType.NVarChar, 10).Value = cbbDoi.Text;
                            insertCommand.ExecuteNonQuery();

                            MessageBox.Show("Sửa thành công!", "Sửa thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.ResetData();
                            this.Hide();

                            conn.Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public DataTable getTable(string query)
        {
            DataTable table = new DataTable();
            using (SqlConnection sqlConnection = new SqlConnection(sqlString))
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(table);
                sqlConnection.Close();
            }

            return table;

        }

        public void Excute(string query)
        {
            using (SqlConnection sqlConnection = new SqlConnection(sqlString))
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();
            }
        }

        private void ResetData()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            cbbViTri.Text = "Chọn mã vị trí";
            dateTimePickerDOB.Value = DateTime.Now;
            cbbQTich.Text = "Chọn mã quốc tịch";
            cbbDoi.Text = "Chọn mã đội";
            txtSoAo.Text = "";
            txtSoBT.Text = "";
            txtTheVang.Text = "";
            txtTheDo.Text = "";
            txtLanRaSan.Text = "";
            txtUrl.Text = "";
            pictureBox1.ImageLocation = null;
        }
    }
}
