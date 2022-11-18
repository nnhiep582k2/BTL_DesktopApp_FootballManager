using baitaplon.Model;
using baitaplon.View;
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
    public partial class Layout : Form
    {
        private Form currenFormChild;
        private Control currenControl;
        bool sideBar;
        public static string tenDoi, maDoi, banThang, tenCauThu;
        public static string tenDoiNha, goal, redCard;
        //static public txtMa;
        public Layout()
        {
            InitializeComponent();
        }

        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {

            btnClub.Size = new System.Drawing.Size(262, 60);
            btnPlayer.Size = new System.Drawing.Size(262, 60);
            btnMatch.Size = new System.Drawing.Size(262, 60);
            btnResult.Size = new System.Drawing.Size(262, 60);
            btnReport.Size = new System.Drawing.Size(262, 60);
            btnMore.Size = new System.Drawing.Size(262, 60);
            btnLogout.Size = new System.Drawing.Size(262, 60);
            StateSearch(false);

            txtSearchByName.Visible = false;
        }


        private void getData(string query, ComboBox cbb, string lname)
        {
            DataTable dt = db.getTable(query);
            if (dt.Rows.Count <= 0)
            {
                MessageBox.Show($"Chưa có {lname}, Bạn cần thêm {lname} ở More!");
            }
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbb.Items.Add(dt.Rows[i][lname].ToString());
            }
        }

        private void StateSearch(bool s)
        {

            PictureBox imageControl = new PictureBox();
            PictureBox imageControl2 = new PictureBox();
            cbSearch1.Visible = s;
            cbSearch2.Visible = s;
            cbSearch3.Visible = s;

            panel_bottom_right.Visible = s;
            panel_bottom_center.Visible = s;
            if (s == false)
            {
                imageControl.SizeMode = PictureBoxSizeMode.StretchImage;
                Bitmap image = new Bitmap("C:\\Users\\Admin\\Desktop\\BTL-C#\\baitaplon\\baitaplon\\Resources\\logo_home_1.png");
                imageControl.Dock = DockStyle.Fill;
                imageControl.Image = (Image)image;
                panel_bottom.Controls.Add(imageControl);

            }
            else
            {
                imageControl.Visible = !s;
                imageControl2.Visible = !s;
                picHome.Visible = !s;

            }
        }


        private void OpenChildForm(Form childForm)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            currenFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_body.Controls.Add(childForm);
            panel_body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }



        private void btnClub_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Club());
            lbtitle.Text = btnClub.Text;

            StateSearch(false);
            panel_bottom_right.Visible = true;
            panel_bottom_center.Visible = true;

            txtSearchByName.Visible = false;
            pictureBoxSearchByName.Visible = false;
            panel_bottom.Visible = true;
            cbSearch1.Visible = false;
            cbSearch1.Items.Clear();
        }



        private void btnPlayer_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Player());
            maDoi = "";
            tenDoi = "";
            banThang = "";
            Player.v_banthang = "";
            Player.v_tendoi = "";
            Player.v_madoi = "";
            lbtitle.Text = btnPlayer.Text;
            panel_searchByName.Visible = true;
            panel_bottom.Visible = true;
            StateSearch(true);
            cbSearch1.Items.Clear();
            cbSearch2.Items.Clear();
            cbSearch2.Visible = false;
            txtSearchByName.Visible = true;
            pictureBoxSearchByName.Visible = true;
            cbSearch3.Items.Clear();

            cbSearch1.Text = "Search by team";
            cbSearch2.Text = "Search by name";
            cbSearch3.Text = "Search by goal";

            this.getData("select tendoi from doibong", cbSearch1, "tendoi");
            this.getData("select distinct SoBanThang from doibong", cbSearch3, "SoBanThang");
        }

        private void btnMatch_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Match());
            lbtitle.Text = btnMatch.Text;
            tenDoiNha = "";
            goal = "";
            redCard = "";
            Match.v_tendoinha = "";
            Match.v_goal = "";
            Match.v_redCard = "";
            txtSearchByName.Visible = false;
            pictureBoxSearchByName.Visible = false;
            panel_searchByName.Visible = false;
            StateSearch(true);
            cbSearch1.Items.Clear();
            cbSearch2.Items.Clear();
            cbSearch3.Items.Clear();
            cbSearch1.Text = "Search by home team";
            cbSearch2.Text = "Search by goal";
            cbSearch3.Text = "Search by red card";
            panel_bottom.Visible = true;

            this.getData("select tendoi from doibong join trandau on TranDau.madoinha = doibong.madoi", cbSearch1, "tendoi");
            this.getData("select distinct SoBanThangDoiNha from TranDau", cbSearch2, "SoBanThangDoiNha");
            this.getData("select distinct SoTheDoDoiNha from TranDau", cbSearch3, "SoTheDoDoiNha");
        }

        private void picImage_official_Click(object sender, EventArgs e)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            lbtitle.Text = "Home";
            StateSearch(false);
            picHome.Visible = true;

            txtSearchByName.Visible = false;
            pictureBoxSearchByName.Visible = false;

            panel_bottom.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_body_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel_bottom_center_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cbSeacrh1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Player"))
            {
                tenDoi = cbSearch1.SelectedItem.ToString();
                Player.v_tendoi = tenDoi;
                maDoi = "";
                banThang = "";
                txtSearchByName.Text = "";
                btnPlayer_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Match"))
            {
                tenDoiNha = cbSearch1.SelectedItem.ToString();
                Match.v_tendoinha = tenDoiNha;
                goal = "";
                redCard = "";
                btnMatch_Click(sender, e);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Result(this));
            lbtitle.Text = btnResult.Text;

            txtSearchByName.Visible = false;
            pictureBoxSearchByName.Visible = false;
            StateSearch(false);
            cbSearch1.Items.Clear();

            panel_bottom_right.Visible = true;
            panel_bottom_center.Visible = true;

            panel_bottom.Visible = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Report());
            lbtitle.Text = btnReport.Text;

            StateSearch(false);
            panel_bottom.Visible = false;
        }

        private void stateMenu(bool s, string club, string player, string match, string logout, string report, string more, string result)
        {

            picImage_official.Visible = s;
            btnClub.Text = club;
            btnPlayer.Text = player;
            btnMatch.Text = match;
            btnLogout.Text = logout;
            btnReport.Text = report;
            btnMore.Text = more;
            btnResult.Text = result;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }

        private void timerSidebar_Tick(object sender, EventArgs e)
        {
            if (sideBar)
            {
                stateMenu(false, "", "", "", "", "", "", "");
                panel_left.Padding = new Padding(0, 200, 0, 0);
                panel_left.Width -= 10;
                if (panel_left.Width == panel_left.MinimumSize.Width)
                {
                    sideBar = false;
                    timerSidebar.Stop();
                }

            }
            else
            {
                stateMenu(true, "Club", "Player", "Match", "Logout", "Report", "More", "Result");

                panel_left.Padding = new Padding(0, 0, 0, 0);
                panel_left.Width += 10;
                if (panel_left.Width == panel_left.MaximumSize.Width)
                {
                    sideBar = true;
                    timerSidebar.Stop();
                }
            }
        }

        private void panel_bottom_Paint(object sender, PaintEventArgs e)
        {

        }

        private void picImageAdd_Click(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Club"))
            {
                add_clup add_Clup = new add_clup();
                add_Clup.ShowDialog();
                btnClub_Click(sender, e);

            }

            else if (lbtitle.Text.Equals("Player"))
            {
                FormAddPlayer formAddPlayer = new FormAddPlayer();
                formAddPlayer.ShowDialog();
                btnPlayer_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Match"))
            {
                AddMatch addMatch = new AddMatch();
                addMatch.ShowDialog();
                btnMatch_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Nationalities"))
            {
                Add_Nationalities add_Nationalities = new Add_Nationalities();
                add_Nationalities.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Locations"))
            {
                Add_Location add_Location = new Add_Location();
                add_Location.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Provinces"))
            {
                Add_Provinces add_Provinces = new Add_Provinces();
                add_Provinces.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Stadiums"))
            {
                Add_Stadium add_Stadium = new Add_Stadium();
                add_Stadium.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Match-Goal"))
            {
                Add_Match_Goal add_Match_Goal = new Add_Match_Goal();
                add_Match_Goal.ShowDialog();
                button1_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Match-Card"))
            {
                Add_Match_Card add_Match_Card = new Add_Match_Card();
                add_Match_Card.ShowDialog();
                button1_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Match-Player"))
            {
                Add_Match_Player add_Match_player = new Add_Match_Player();
                add_Match_player.ShowDialog();
                button1_Click(sender, e);

            }
        }

        private void cbSearch2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Player"))
            {
                maDoi = cbSearch2.SelectedItem.ToString();
                Player.v_madoi = maDoi;
                tenDoi = "";
                banThang = "";
                btnPlayer_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Match"))
            {
                goal = cbSearch2.SelectedItem.ToString();
                Match.v_goal = goal;
                tenDoiNha = "";
                redCard = "";
                btnMatch_Click(sender, e);
            }
        }

        private void cbSearch3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Player"))
            {
                banThang = cbSearch3.SelectedItem.ToString();
                Player.v_banthang = banThang;
                tenDoi = "";
                maDoi = "";

                txtSearchByName.Text = "";
                btnPlayer_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Match"))
            {
                redCard = cbSearch3.SelectedItem.ToString();
                Match.v_redCard = redCard;
                tenDoiNha = "";
                goal = "";
                btnMatch_Click(sender, e);
            }
        }

        private void picHome_Click(object sender, EventArgs e)
        {

        }

        private void txtSearchByName_Enter(object sender, EventArgs e)
        {
            if (txtSearchByName.Text == "Search by name...")
            {
                txtSearchByName.Text = "";
                txtSearchByName.ForeColor = Color.Black;
            }
        }

        private void txtSearchByName_Leave(object sender, EventArgs e)
        {
            if (txtSearchByName.Text == "")
            {
                txtSearchByName.Text = "Search by name...";
                txtSearchByName.ForeColor = Color.Silver;
            }
        }

        private void txtSearchByName_TextChanged(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Player"))
            {
                 
                Player.v_tenCT = txtSearchByName.Text;
                
                btnPlayer_Click(sender, e);
            }
        }

        private void picImageRemove_Click(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Club"))
            {
                ConnAdd conn = new ConnAdd();

                try
                {
                    string ma = DoiBongs.madb;
                    if (MessageBox.Show("Bạn có muốn xóa đội bóng không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        /*
                            DataTable dt = new DataTable();
                            dt = conn.table($"select * from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                            DataTable dt_CauThu = new DataTable();
                            dt_CauThu = conn.table($"select * from CauThu where MaDoi = N'{ma}'");
                        if (dt.Rows.Count > 0)
                            {
                                DataTable dt_trandau = new DataTable();
                                dt_trandau = conn.table($"select MaTD from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                                string maTD = dt_trandau.Rows[0][0].ToString();
                                DataTable dt_the = new DataTable();
                                dt_the = conn.table($"select * from TranDau_The where MaTD = N'{maTD}'");
                                DataTable dt_BanThang = new DataTable();
                                dt_BanThang = conn.table($"select * from TranDau_BanThang where MaTD = N'{maTD}'");
                                DataTable dt_cauthu = new DataTable();
                                dt_cauthu = conn.table($"select * from TranDau_CauThu where MaTD = N'{maTD}'");

                                if(dt_the.Rows.Count > 0)
                                {
                                    conn.Excute_new($"delete from TranDau_The where MaTD = N'{maTD}'");
                                }

                                if (dt_BanThang.Rows.Count > 0)
                                {
                                    conn.Excute_new($"delete from TranDau_BanThang where MaTD = N'{maTD}'");

                                }
                                if (dt_cauthu.Rows.Count > 0)
                                {
                                    conn.Excute_new($"delete from TranDau_CauThu where MaTD = N'{maTD}'");

                                }

                        }
                        if(dt_CauThu.Rows.Count > 0)
                        {

                            DataTable dt_trandau = new DataTable();
                            dt_trandau = conn.table($"select MaCT from CauThu where MaDoi = N'{ma}'");
                            string maCT1= dt_trandau.Rows[0][0].ToString();

                            DataTable dt_the1 = new DataTable();
                            dt_the1 = conn.table($"select * from TranDau_The where MaCT = N'{maCT1}'");

                            DataTable dt_BanThang1 = new DataTable();
                            dt_BanThang1 = conn.table($"select * from TranDau_BanThang where MaCT = N'{maCT1}'");

                            DataTable dt_cauthu1 = new DataTable();
                            dt_cauthu1 = conn.table($"select * from TranDau_CauThu where MaCT = N'{maCT1}'");



                            if (dt_the1.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_The where MaCT = N'{maCT1}'");
                            }

                            if (dt_BanThang1.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_BanThang where MaCT = N'{maCT1}'");

                            }
                            if (dt_cauthu1.Rows.Count > 0)
                            {
                                conn.Excute_new($"delete from TranDau_CauThu where MaCT = N'{maCT1}'");

                            }
                        }
                            conn.Excute_new($"delete from CauThu where MaDoi = N'{ma}'");
                            conn.Excute_new($"delete from TranDau where MaDoiNha = N'{ma}' or MaDoiKhach = N'{ma}'");
                        */
                        conn.Excute_new($"delete from DoiBong where MaDoi = N'{ma}'");


                        MessageBox.Show("Xóa thành công!", "Xóa đội bóng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnClub_Click(sender, e);



                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi! Bạn cần xóa mã đội trong bảng đang tham chiếu đến đội bóng trước.  ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }




            else if (lbtitle.Text.Equals("Player"))
            {

                string ma = Players.maCT;
                if (MessageBox.Show("Bạn có muốn xóa cầu thủ không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        db.Excute($"delete from CauThu where MaCT = '{ma}'");
                        MessageBox.Show("Xóa thành công!", "Xóa cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnPlayer_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã cầu thủ trong bảng đang tham chiếu đến cầu thủ trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            else if (lbtitle.Text.Equals("Match"))
            {
                string ma = Matchs.MaTD;



                if (MessageBox.Show("Bạn có muốn xóa trận đấu không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {

                        db.Excute($"delete from TranDau where MaTD = N'{ma}'");
                        MessageBox.Show("Xóa thành công!", "Xóa cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnMatch_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã trận đấu trong bảng đang tham chiếu đến trận đấu trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (lbtitle.Text.Equals("Nationalities"))
            {

                string s = Nationalities_SS.maQT;
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {

                        string query = "delete from QuocTich where MaQuocTich = '" + s + "'";
                        db.Excute(query);
                        btnMore_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã quốc tịch trong bảng đang tham chiếu đến quốc tịch trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (lbtitle.Text.Equals("Locations"))
            {

                string s = Locations_SS.maViTri;
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {

                        string query = "delete from Vitri where MaViTri = '" + s + "'";
                        db.Excute(query);
                        btnMore_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã vị trí trong bảng đang tham chiếu đến vị trí trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (lbtitle.Text.Equals("Provinces"))
            {

                string s = Province_SS.maTinh;
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {

                        string query = "delete from Tinh where MaTinh = '" + s + "'";
                        db.Excute(query);
                        btnMore_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã tỉnh trong bảng đang tham chiếu đến tỉnh trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (lbtitle.Text.Equals("Stadiums"))
            {

                string ma = Stadiums_SS.MaSan;
             
                if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
             == System.Windows.Forms.DialogResult.Yes)
                {

                    try
                    {

                        db.Excute($"delete from sanbong where MaSan = '{ma}'");
                        MessageBox.Show("Xóa thành công!", "Xóa sân bóng", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        btnMore_Click(sender, e);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã sân trong bảng đang tham chiếu đến sân trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else if (lbtitle.Text.Equals("Match-Goal"))
            {


                string mact = Match_Goal_SS.mact;
                string matd = Match_Goal_SS.matd;
                if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    db.Excute($"delete from TranDau_BanThang where MaTD = N'{matd}' and MaCT = N'{mact}'");
                    MessageBox.Show("Xóa thành công!", "Xóa Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1_Click(sender, e);
                    /*
                    try
                    {
                        db.Excute($"delete from TranDau_BanThang where MaTD = N'{matd}' and MaCT = N'{mact}'");
                        MessageBox.Show("Xóa thành công!", "Xóa Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        //  dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã cầu thủ, mã trận đấu trong bảng đang tham chiếu đến trận đấu, bàn thắng trước. ", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    */
                }

            }
            else if (lbtitle.Text.Equals("Match-Card"))
            {

                    string mact = Match_Card_SS.mact;
                    string matd = Match_Card_SS.matd;
                    if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            db.Excute($"delete from TranDau_The where MaTD = N'{matd}' and MaCT = N'{mact}'");
                            MessageBox.Show("Xóa thành công!", "Xóa Thông tin", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            button1_Click(sender, e);

                        //  dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                    }
                    catch (Exception ex)
                        {
                            MessageBox.Show("Lỗi! Bạn cần xóa mã cầu thủ, mã trận đấu trong bảng đang tham chiếu đến trận đấu, thẻ trước.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                

            }
            else if (lbtitle.Text.Equals("Match-Player"))
            {

                string mact = Match_Player_SS.mact;
                string matd = Match_Player_SS.matd;
                if (MessageBox.Show("Bạn có muốn xóa thông tin không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    try
                    {
                        db.Excute($"delete from TranDau_CauThu where MaCT = '{mact}' and MaTD = '{matd}'");
                        MessageBox.Show("Xóa thành công!", "Xóa cầu thủ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        button1_Click(sender, e);
                        //  dgv_tdct.DataSource = conn.table("select * from TranDau_CauThu");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi! Bạn cần xóa mã cầu thủ, mã trận đấu trong bảng đang tham chiếu đến trận đấu, cầu thủ trước.", ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }


            }

        }

    private void picImageEdit_Click(object sender, EventArgs e)
        {
            if (lbtitle.Text.Equals("Club"))
            {
                update_club editClub = new update_club();
                editClub.madoi = DoiBongs.madb;
                editClub.tendoi = DoiBongs.tendb;
                editClub.hlv = DoiBongs.hvldb;
                editClub.pBox = DoiBongs.anh;
                editClub.masan = DoiBongs.masan;
                editClub.matinh = DoiBongs.matinh;
                editClub.ShowDialog();
                btnClub_Click(sender, e);
            }

            else if (lbtitle.Text.Equals("Player"))
            {
                Player player = new Player();
                player.mode = "Edit";

                FormAddPlayer formAdd = new FormAddPlayer();
                formAdd.status = "Edit";

                formAdd.maCT = Players.maCT;
                formAdd.tenCT = Players.tenCT;
                formAdd.maViTri = Players.maViTri;
                formAdd.ngaySinh = Players.ngaySinh;
                formAdd.soAo = Players.soAo;
                formAdd.soBanThang = Players.soBanThang;
                formAdd.soTheVang = Players.soTheVang;
                formAdd.soTheDo = Players.soTheDo;
                formAdd.maQuocTich = Players.maQuocTich;
                formAdd.soLanRaSan = Players.soLanRaSan;
                formAdd.maDoi = Players.maDoi;
                formAdd.pBox = Players.anh;
                formAdd.ShowDialog();
                btnPlayer_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Match"))
            {
                EditMatch editMatch = new EditMatch();

                editMatch.MaTD = Matchs.MaTD ;
                editMatch.LuotDau = Matchs.LuotDau ;
                editMatch.VongDau = Matchs.VongDau ;
                editMatch.MaDN = Matchs.MaDN ;
                editMatch.MaDK = Matchs.MaDK ;
                editMatch.SBThang = Matchs.SBThang ;
                editMatch.SBThua = Matchs.SBThua ;
                editMatch.StvDN = Matchs.StvDN ;
                editMatch.StdDN = Matchs.StdDN;
                editMatch.StvDK = Matchs.StvDK ;
                editMatch.StdDK = Matchs.StdDK ;
                editMatch.Ghichu = Matchs.Ghichu;

                editMatch.ShowDialog();
                btnMatch_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Nationalities"))
            {
                Edit_Nationalities edit_Nationalities = new Edit_Nationalities();
                edit_Nationalities.ShowDialog();
                btnMore_Click(sender, e);
            }
            else if (lbtitle.Text.Equals("Locations"))
            {
                Edit_Location edit_Location = new Edit_Location();
                edit_Location.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Provinces"))
            {
                Edit_Provinces edit_Provinces = new Edit_Provinces();
                edit_Provinces.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Stadiums"))
            {
                Edit_Stadium edit_Stadium = new Edit_Stadium();
                edit_Stadium.ShowDialog();
                btnMore_Click(sender, e);

            }
            else if (lbtitle.Text.Equals("Match-Goal"))
            {
                Edit_Match_Goal edit_Match_Goal = new Edit_Match_Goal();
                edit_Match_Goal.ShowDialog();
                button1_Click(sender, e);



            }
            else if (lbtitle.Text.Equals("Match-Card"))
            {
                Edit_Match_Card edit_Match_Card = new Edit_Match_Card();
                edit_Match_Card.ShowDialog();
                button1_Click(sender, e);



            }
            else if (lbtitle.Text.Equals("Match-Player"))
            {
                Edit_Match_Player edit_Match_Player = new Edit_Match_Player();
                edit_Match_Player.ShowDialog();
                button1_Click(sender, e);



            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (currenFormChild != null)
            {
                currenFormChild.Close();
            }
            lbtitle.Text = "Home";
            StateSearch(false);
            picHome.Visible = true;
            panel_bottom.Visible = true;
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login login = new Login();
                this.Hide();
                login.Show();
            }
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new More(this));
            lbtitle.Text = btnMore.Text;

            txtSearchByName.Visible = false;
            pictureBoxSearchByName.Visible = false;
            StateSearch(false);
            cbSearch1.Items.Clear();

            panel_bottom_right.Visible = true;
            panel_bottom_center.Visible = true;

            panel_bottom.Visible = true;

        }
    }
}
