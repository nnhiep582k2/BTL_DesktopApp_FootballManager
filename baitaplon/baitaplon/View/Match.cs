using baitaplon.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using baitaplon.Model;
using System.Collections;

namespace baitaplon
{
    public partial class Match : Form
    {
        public Match()
        {
            InitializeComponent();
            this.dgvMatch.DefaultCellStyle.Font = new Font("Arial", 11);
        }
        SqlConnection connect;
        public static string v_tendoinha, v_goal, v_redCard;
        private void Match_Load(object sender, EventArgs e)
        {
            connect = new SqlConnection();
            connect.ConnectionString = "Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True";
            connect.Open();
            SqlDataAdapter dataAdap;
            DataTable dt = new DataTable();
            if (!string.IsNullOrEmpty(v_tendoinha))
            {
                dataAdap = new SqlDataAdapter($"select MaTD, LuotDau, VongDau, MaDoiNha, MaDoiKhach, SoBanThangDoiNha, SoBanThuaDoiNha, SoTheVangDoiNha, SoTheDoDoiNha, SoTheVangDoiKhach, SoTheDoDoiKhach, Ghichu from TranDau join doibong on trandau.MaDoiNha = doibong.madoi where tendoi = N'{v_tendoinha}'", connect);
                v_goal = "";
                v_redCard = "";
            }
            else if (!string.IsNullOrEmpty(v_goal))
            {
                dataAdap = new SqlDataAdapter($"select * from TranDau where SoBanThangDoiNha = {int.Parse(v_goal)}", connect);
                v_tendoinha = "";
                v_redCard = "";
            }
            else if (!string.IsNullOrEmpty(v_redCard))
            {
                dataAdap = new SqlDataAdapter($"select * from TranDau where SoTheDoDoiNha = {int.Parse(v_redCard)}", connect);
                v_tendoinha = "";
                v_goal = "";
            }
            else
            {
                dataAdap = new SqlDataAdapter("select * from TranDau", connect);
            }
            dataAdap.Fill(dt);
            dgvMatch.DataSource = dt;
            SetupDataGridView();
            connect.Close();
        }
        int index = -1;
        private void dgvMatch_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index=e.RowIndex;
            EditMatch editMatch = new EditMatch();
            editMatch.MaTD = dgvMatch.SelectedRows[0].Cells[0].Value.ToString();
            editMatch.LuotDau = int.Parse(dgvMatch.SelectedRows[0].Cells[1].Value.ToString());
            editMatch.VongDau = int.Parse(dgvMatch.SelectedRows[0].Cells[2].Value.ToString());
            editMatch.MaDN = dgvMatch.SelectedRows[0].Cells[3].Value.ToString();
            editMatch.MaDK = dgvMatch.SelectedRows[0].Cells[4].Value.ToString();
            editMatch.SBThang = int.Parse(dgvMatch.SelectedRows[0].Cells[5].Value.ToString());
            editMatch.SBThua = int.Parse(dgvMatch.SelectedRows[0].Cells[6].Value.ToString());
            editMatch.StvDN = int.Parse(dgvMatch.SelectedRows[0].Cells[7].Value.ToString());
            editMatch.StdDN = int.Parse(dgvMatch.SelectedRows[0].Cells[8].Value.ToString());
            editMatch.StvDK = int.Parse(dgvMatch.SelectedRows[0].Cells[9].Value.ToString());
            editMatch.StdDK = int.Parse(dgvMatch.SelectedRows[0].Cells[10].Value.ToString());
            editMatch.Ghichu = dgvMatch.SelectedRows[0].Cells[11].Value.ToString();


            Matchs.MaTD = editMatch.MaTD;
            Matchs.LuotDau = editMatch.LuotDau;
            Matchs.VongDau = editMatch.VongDau;
            Matchs.MaDN = editMatch.MaDN;
            Matchs.MaDK = editMatch.MaDK;
            Matchs.SBThang = editMatch.SBThang;
            Matchs.SBThua = editMatch.SBThua;
            Matchs.StvDN = editMatch.StvDN;
            Matchs.StdDN = editMatch.StdDN;
            Matchs.StvDK = editMatch.StvDK;
            Matchs.StdDK = editMatch.StdDK;
            Matchs.Ghichu = editMatch.Ghichu;

        }

        private void dgvMatch_DoubleClick(object sender, EventArgs e)
        {

            EditMatch editMatch = new EditMatch();
         
            editMatch.MaTD = dgvMatch.SelectedRows[0].Cells[0].Value.ToString();
            editMatch.LuotDau = int.Parse (dgvMatch.SelectedRows[0].Cells[1].Value.ToString()); 
            editMatch.VongDau = int.Parse (dgvMatch.SelectedRows[0].Cells[2].Value.ToString()); 
            editMatch.MaDN = dgvMatch.SelectedRows[0].Cells[3].Value.ToString(); 
            editMatch.MaDK = dgvMatch.SelectedRows[0].Cells[4].Value.ToString(); 
            editMatch.SBThang = int.Parse (dgvMatch.SelectedRows[0].Cells[5].Value.ToString()); 
            editMatch.SBThua = int.Parse (dgvMatch.SelectedRows[0].Cells[6].Value.ToString()); 
            editMatch.StvDN = int.Parse (dgvMatch.SelectedRows[0].Cells[7].Value.ToString()); 
            editMatch.StdDN = int.Parse (dgvMatch.SelectedRows[0].Cells[8].Value.ToString()); 
            editMatch.StvDK = int.Parse (dgvMatch.SelectedRows[0].Cells[9].Value.ToString()); 
            editMatch.StdDK = int.Parse (dgvMatch.SelectedRows[0].Cells[10].Value.ToString()); 
            editMatch.Ghichu = dgvMatch.SelectedRows[0].Cells[11].Value.ToString(); 
           

           Matchs.MaTD  = editMatch.MaTD ;
           Matchs.LuotDau  = editMatch.LuotDau ;
           Matchs.VongDau  = editMatch.VongDau ;
           Matchs.MaDN  = editMatch.MaDN ;
           Matchs.MaDK  = editMatch.MaDK ;
           Matchs.SBThang  = editMatch.SBThang ;
           Matchs.SBThua  = editMatch.SBThua ;
           Matchs.StvDN  = editMatch.StvDN ;
           Matchs.StdDN  = editMatch.StdDN ;
           Matchs.StvDK  = editMatch.StvDK ;
           Matchs.StdDK  = editMatch.StdDK ;
            Matchs.Ghichu = editMatch.Ghichu;

            editMatch.ShowDialog();
        

        }
        //   public void DeleteMatch()
        // {
        //     string ma = dgvMatch.CurrentRow.Cells[0].Value.ToString();
        //     if (MessageBox.Show("Bạn có muốn xóa cầu thủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
        //  {
        //      try
        //  {
        // connect.Excute($"delete from TranDau where MaTD = '{ma}'");
        //   MessageBox.Show("Xóa thành công!", "Xóa trận đấu", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //     // dgvMatch.DataSource = connect.getTable("select * from CauThu");
        //   }
        //      catch (Exception ex)
        //    {
        //    MessageBox.Show("Lỗi", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
        //      // }
        //  }
        //     }
        private void SetupDataGridView()
        {
            // Header
            dgvMatch.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvMatch.ColumnHeadersHeight = 50;
            dgvMatch.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dgvMatch.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMatch.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvMatch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMatch.EnableHeadersVisualStyles = false;
            dgvMatch.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgvMatch.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Content
            dgvMatch.ReadOnly = true;
            dgvMatch.BorderStyle = BorderStyle.None;
            dgvMatch.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgvMatch.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvMatch.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvMatch.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgvMatch.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvMatch.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvMatch.BackgroundColor = Color.FromArgb(235, 237, 240);
            dgvMatch.RowTemplate.Height = 40;
            dgvMatch.Columns["MaTD"].Width = 70;
            dgvMatch.Columns["LuotDau"].Width = 50;
            dgvMatch.Columns["VongDau"].Width = 50;
            dgvMatch.Columns["MaDoiNha"].Width = 70;
            dgvMatch.Columns["MaDoiKhach"].Width = 70;
            dgvMatch.Columns["SoBanThangDoiNha"].Width = 50;
            dgvMatch.Columns["SoBanThuaDoiNha"].Width = 50;
            dgvMatch.Columns["SoTheVangDoiNha"].Width = 80;
            dgvMatch.Columns["SoTheDoDoiNha"].Width = 65;
            dgvMatch.Columns["SoTheVangDoiKhach"].Width = 70;
            dgvMatch.Columns["SoTheDoDoiKhach"].Width = 60;
            dgvMatch.Columns["GhiChu"].Width = 80;
            dgvMatch.Columns["MaTD"].HeaderText = "MÃ TRẬN ĐẤU";
            dgvMatch.Columns["LuotDau"].HeaderText = "LƯỢT  ĐẤU";
            dgvMatch.Columns["VongDau"].HeaderText = "VÒNG  DẤU";
            dgvMatch.Columns["MaDoiNha"].HeaderText = "MÃ ĐỘI NHÀ";
            dgvMatch.Columns["MaDoiKhach"].HeaderText = "MÃ ĐỘI KHÁCH";
            dgvMatch.Columns["SoBanThangDoiNha"].HeaderText = "BÀN THẮNG";
            dgvMatch.Columns["SoBanThuaDoiNha"].HeaderText = "BÀN THUA";
            dgvMatch.Columns["SoTheVangDoiNha"].HeaderText = "THẺ VÀNG ĐỘI NHÀ";
            dgvMatch.Columns["SoTheDoDoiNha"].HeaderText = "THẺ ĐỎ   ĐỘI NHÀ";
            dgvMatch.Columns["SoTheVangDoiKhach"].HeaderText = "THẺ VÀNG  ĐỘI KHÁCH";
            dgvMatch.Columns["SoTheDoDoiKhach"].HeaderText = "THẺ ĐỎ ĐỘI KHÁCH";
            dgvMatch.Columns["GhiChu"].HeaderText = "GHI CHÚ";
        }

        private void dgvMatch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        public void DeleteMatch()
        {
            string ma = dgvMatch.CurrentRow.Cells[0].Value.ToString();

           


            if (MessageBox.Show("Bạn có muốn xóa trận đấu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
              
                    db.Excute($"delete from TranDau where MaTD = N'{ma}'");
                    MessageBox.Show("Xóa thành công!", "Xóa cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvMatch.DataSource = db.getTable("select * from TranDau");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi! Bạn cần xóa mã trận đấu trong bảng đang tham chiếu đến đội bóng trước.  ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void dgvMatch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                this.DeleteMatch();
            }
        }
    }
}
