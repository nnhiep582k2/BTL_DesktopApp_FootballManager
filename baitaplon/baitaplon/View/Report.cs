
using baitaplon.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace baitaplon.View
{
    public partial class Report : Form
    {
        public Report()
        {
            InitializeComponent();
            menuStrip2.Cursor = Cursors.Hand;
        }

        bool isMatch;
        bool isPlayer;

        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void Report_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void matchResultInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxBody.Visible = false;

            cbSelect.Visible = true;

            cbSelect.Items.Clear();
            cbSelect.Focus();

            lbCBSelect.Text = "Mã trận đấu";
            DataTable dt = db.getTable("select MaTD from TranDau");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbSelect.Items.Add(dt.Rows[i]["MaTD"].ToString());
            }
            MessageBox.Show("Mời bạn chọn mã trận đấu");
            isMatch = true;
            isPlayer = false;

        }

        private void playerListReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxBody.Visible = false ;
            cbSelect.Visible = true;

            cbSelect.Items.Clear();
            cbSelect.Focus();
            lbCBSelect.Text = "Tên đội bóng";
            DataTable dt = db.getTable("select TenDoi from DoiBong");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbSelect.Items.Add(dt.Rows[i]["TenDoi"].ToString());
            }
            MessageBox.Show("Mời bạn chọn tên đội bóng");
            isPlayer = true;
            isMatch = false;
            this.Dock = DockStyle.Fill;
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void cbSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbSelect.SelectedIndex != -1)
            {

                if (isMatch == true && isPlayer == false)
                {
                    try
                    {
                        reportViewer1.LocalReport.DataSources.Clear();
                        reportViewer1.LocalReport.ReportEmbeddedResource = "baitaplon.Reports.MatchResult.rdlc";
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "MatchResult";

                        string maTD = cbSelect.SelectedItem.ToString();

                        reportDataSource.Value = db.getTable($"select * from TranDau where MaTD = N'{maTD}'");
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        this.reportViewer1.RefreshReport();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else if (isMatch == false && isPlayer == true)
                {

                    try
                    {
                        reportViewer1.LocalReport.DataSources.Clear();

                        reportViewer1.LocalReport.ReportEmbeddedResource = "baitaplon.Reports.PlayerList.rdlc";
                        ReportDataSource reportDataSource = new ReportDataSource();
                        reportDataSource.Name = "playerList";

                        string tenDB = cbSelect.SelectedItem.ToString();

                        reportDataSource.Value = db.getTable($"select * from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi where TenDoi = N'{tenDB}'");
                        reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                        this.reportViewer1.RefreshReport();

                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }

                }
            }

        }

        private void listOfThreePlayersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            picBoxBody.Visible = false;

            cbSelect.Items.Clear();
            lbCBSelect.Text = "";
            cbSelect.Visible = false;
            isPlayer = false;
            isMatch = false;

            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "baitaplon.Reports.TopThreePlayer.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "TopThreePlayer";


                reportDataSource.Value = db.getTable($"select top(3) with ties MaCT,TenCT,MaViTri,NgaySinh,SoAo,SoBanThang,SoTheVang,SoTheDo,MaQuocTich,SoLanRaSan,Anh,MaDoi from CauThu order by SoBanThang desc");
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            picBoxBody.Visible = false;

            cbSelect.Items.Clear();
            lbCBSelect.Text = "";
            cbSelect.Visible = false;
            isPlayer = false;
            isMatch = false;

            try
            {
                reportViewer1.LocalReport.ReportEmbeddedResource = "baitaplon.Reports.TopThreePlayer.rdlc";
                ReportDataSource reportDataSource = new ReportDataSource();
                reportDataSource.Name = "TopThreePlayer";


                reportDataSource.Value = db.getTable($"select top(3) with ties MaCT,TenCT,MaViTri,NgaySinh,SoAo,CauThu.SoBanThang,SoTheVang,SoTheDo,MaQuocTich,SoLanRaSan,TenDoi,HLV from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi order by CauThu.SoBanThang desc");
                reportViewer1.LocalReport.DataSources.Add(reportDataSource);
                this.reportViewer1.RefreshReport();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void playListToolStripMenuItem_Click(object sender, EventArgs e)

        {
            lbCBSelect.Text = "Tên đội bóng";
            cbSelect.Visible = true;
            cbSelect.Items.Clear();
            DataTable dt = db.getTable("select TenDoi from DoiBong");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbSelect.Items.Add(dt.Rows[i]["TenDoi"].ToString());
            }
            if (cbSelect.Text != "")
            {
                if (cbSelect.Text.StartsWith("TD"))
                {
                    MessageBox.Show("Mời bạn chọn tên đội bóng cho phủ hợp");
                    return;
                }
              
                Excel.Application application = new Excel.Application();
                Excel.Workbook workbook = application.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                worksheet.get_Range("A6:M7").Font.Bold = true;
                worksheet.get_Range("A6").Value = $"BÁO CÁO DANH SÁCH CÁC CẦU THỦ ĐỘI BÓNG {cbSelect.Text.ToUpper()}";
                worksheet.get_Range("A6").Font.Size = 25;
                worksheet.get_Range("A6").Font.Color = Color.FromArgb(7, 58, 64);

                //trộn
                worksheet.get_Range("A6:M6").Merge(true);

                worksheet.get_Range("A8:M8").Font.Bold = true;
                worksheet.get_Range("A8").Value = "Giải bóng đá Premier League 2022";
                worksheet.get_Range("A8").Font.Size = 15;
                worksheet.get_Range("A8").Font.Color = Color.FromArgb(7, 58, 64);

                //trộn
                worksheet.get_Range("A8:M8").Merge(true);


                //range
                worksheet.get_Range("A10:M10").Font.Size = 13;
                worksheet.get_Range("A11:M70").Font.Size = 11;

                worksheet.get_Range("A10:M10").Interior.Color = Color.FromArgb(11, 158, 158);

                //căn giữa
                worksheet.get_Range("A6:M70").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.get_Range("A10:M10").RowHeight = 30;
                worksheet.get_Range("A6:M70").VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.get_Range("A10").Value = "STT";
                worksheet.get_Range("A10").ColumnWidth = 5;

                worksheet.get_Range("B10").Value = "Mã cầu thủ";
                worksheet.get_Range("B10").ColumnWidth = 15;

                worksheet.get_Range("C10").Value = "Tên cầu thủ";
                worksheet.get_Range("C10").ColumnWidth = 25;

                worksheet.get_Range("D10").Value = "Mã vị trí";
                worksheet.get_Range("D10").ColumnWidth = 10;

                worksheet.get_Range("E10").Value = "Ngày sinh";
                worksheet.get_Range("E10").ColumnWidth = 20;

                worksheet.get_Range("F10").Value = "Số áo";
                worksheet.get_Range("F10").ColumnWidth = 10;


                worksheet.get_Range("G10").Value = "Số bàn thắng";
                worksheet.get_Range("G10").ColumnWidth = 15;


                worksheet.get_Range("H10").Value = "Số thẻ vàng";
                worksheet.get_Range("H10").ColumnWidth = 15;


                worksheet.get_Range("I10").Value = "Số thẻ đỏ";
                worksheet.get_Range("I10").ColumnWidth = 10;


                worksheet.get_Range("J10").Value = "Mã quốc tịch";
                worksheet.get_Range("J10").ColumnWidth = 15;

                worksheet.get_Range("K10").Value = "Số lần ra sân";
                worksheet.get_Range("K10").ColumnWidth = 15;


                worksheet.get_Range("L10").Value = "Tên đội";
                worksheet.get_Range("L10").ColumnWidth = 25;

                worksheet.get_Range("M10").Value = "HLV của đội";
                worksheet.get_Range("M10").ColumnWidth = 17;
                //Màu chữ header
                worksheet.get_Range("A10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("B10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("C10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("D10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("E10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("F10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("G10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("H10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("I10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("J10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("K10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("L10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("M10").Font.Color = Color.FromArgb(235, 237, 240);


                DataTable dataTable = new DataTable();
                dataTable = db.getTable($"select * from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi where TenDoi = N'{cbSelect.Text.Trim()}'");
                //màu hàng 


                worksheet.get_Range($"A10:M10").Interior.Color = Color.FromArgb(11, 158, 158); //xanh chuooi

                worksheet.get_Range($"A11:M11").Interior.Color = Color.FromArgb(108, 175, 218); //xanh dam

                for (int i = 11; i < dataTable.Rows.Count + 11; i++)
                {

                    if (i % 2 == 0)
                    {
                        worksheet.get_Range($"A{i}:M{i}").Interior.Color = Color.FromArgb(211, 245, 238);//xanh nhat
                    }
                    worksheet.get_Range($"A{i}:M{i}").RowHeight = 30;

                }



                //


                int n = dataTable.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    worksheet.get_Range("A" + (i + 11).ToString()).Value = (i + 1).ToString();
                    worksheet.get_Range("B" + (i + 11).ToString()).Value = dataTable.Rows[i][0].ToString();
                    worksheet.get_Range("C" + (i + 11).ToString()).Value = dataTable.Rows[i][1].ToString();
                    worksheet.get_Range("D" + (i + 11).ToString()).Value = dataTable.Rows[i][2].ToString();
                    worksheet.get_Range("E" + (i + 11).ToString()).Value = dataTable.Rows[i][3].ToString();
                    worksheet.get_Range("F" + (i + 11).ToString()).Value = dataTable.Rows[i][4].ToString();
                    worksheet.get_Range("G" + (i + 11).ToString()).Value = dataTable.Rows[i][5].ToString();
                    worksheet.get_Range("H" + (i + 11).ToString()).Value = dataTable.Rows[i][6].ToString();
                    worksheet.get_Range("I" + (i + 11).ToString()).Value = dataTable.Rows[i][7].ToString();
                    worksheet.get_Range("J" + (i + 11).ToString()).Value = dataTable.Rows[i][8].ToString();
                    worksheet.get_Range("K" + (i + 11).ToString()).Value = dataTable.Rows[i][9].ToString();
                    worksheet.get_Range("L" + (i + 11).ToString()).Value = dataTable.Rows[i][13].ToString();
                    worksheet.get_Range("M" + (i + 11).ToString()).Value = dataTable.Rows[i][14].ToString();
                }

                worksheet.Activate();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "CauThu(*.xlsx)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog.FileName.ToString());
                    MessageBox.Show("Lưu file thành công");
                }


            }
            else
            {

                MessageBox.Show("Mời bạn chọn tên đội bóng");
            }






        }

        private void matchResultToolStripMenuItem_Click(object sender, EventArgs e)
        {

            lbCBSelect.Text = "Mã trận đấu";

            cbSelect.Visible = true;
            cbSelect.Items.Clear();

            DataTable dt = db.getTable("select MaTD from TranDau");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbSelect.Items.Add(dt.Rows[i]["MaTD"].ToString());
            }
            if (cbSelect.Text != "")
            {
                if (!cbSelect.Text.StartsWith("TD"))
                {
                    MessageBox.Show("Mã trận đấu không đúng cần chọn mã trận đấu phù hợp bắt đầu là TD!");
                    return;
                }


                Excel.Application application = new Excel.Application();
                Excel.Workbook workbook = application.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
                Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

                worksheet.get_Range("A6:M7").Font.Bold = true;
                worksheet.get_Range("A6").Value = "BÁO CÁO TÓM TẮT KẾT QUẢ TRẬN ĐẤU";
                worksheet.get_Range("A6").Font.Size = 25;
                worksheet.get_Range("A6").Font.Color = Color.FromArgb(7, 58, 64);

                //trộn
                worksheet.get_Range("A6:M6").Merge(true);


                worksheet.get_Range("A8:M8").Font.Bold = true;
                worksheet.get_Range("A8").Value = "Giải bóng đá Premier League 2022";
                worksheet.get_Range("A8").Font.Size = 15;
                worksheet.get_Range("A8").Font.Color = Color.FromArgb(7, 58, 64);

                //trộn
                worksheet.get_Range("A8:M8").Merge(true);

                //range
                worksheet.get_Range("A10:M10").Font.Size = 13;
                worksheet.get_Range("A11:M70").Font.Size = 11;
                worksheet.get_Range("A10:M10").Interior.Color = Color.FromArgb(11, 158, 158);

                //căn giữa
                worksheet.get_Range("A6:M70").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.get_Range("A10:M10").RowHeight = 30;
                worksheet.get_Range("A6:M70").VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;

                worksheet.get_Range("A10").Value = "STT";
                worksheet.get_Range("A10").ColumnWidth = 5;

                worksheet.get_Range("B10").Value = "Mã trận đấu";
                worksheet.get_Range("B10").ColumnWidth = 15;

                worksheet.get_Range("C10").Value = "Lượt đấu";
                worksheet.get_Range("C10").ColumnWidth = 10;

                worksheet.get_Range("D10").Value = "Vòng đấu";
                worksheet.get_Range("D10").ColumnWidth = 10;

                worksheet.get_Range("E10").Value = "Mã đội nhà";
                worksheet.get_Range("E10").ColumnWidth = 15;

                worksheet.get_Range("F10").Value = "Mã đội khách";
                worksheet.get_Range("F10").ColumnWidth = 15;


                worksheet.get_Range("G10").Value = "Số bàn thắng DN";
                worksheet.get_Range("G10").ColumnWidth = 18;


                worksheet.get_Range("H10").Value = "Số bàn thua DN";
                worksheet.get_Range("H10").ColumnWidth = 18;


                worksheet.get_Range("I10").Value = "Số thẻ vàng DN";
                worksheet.get_Range("I10").ColumnWidth = 18;


                worksheet.get_Range("J10").Value = "Số thẻ đỏ DN";
                worksheet.get_Range("J10").ColumnWidth = 18;


                worksheet.get_Range("K10").Value = "Số thẻ vàng DK";
                worksheet.get_Range("K10").ColumnWidth = 18;


                worksheet.get_Range("L10").Value = "Số thẻ đỏ DK";
                worksheet.get_Range("L10").ColumnWidth = 18;


                worksheet.get_Range("M10").Value = "Ghi chú";
                worksheet.get_Range("M10").ColumnWidth = 20;


                //Màu chữ header
                worksheet.get_Range("A10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("B10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("C10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("D10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("E10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("F10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("G10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("H10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("I10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("J10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("K10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("L10").Font.Color = Color.FromArgb(235, 237, 240);
                worksheet.get_Range("M10").Font.Color = Color.FromArgb(235, 237, 240);
                //màu hàng
                worksheet.get_Range($"A10:M10").Interior.Color = Color.FromArgb(11, 158, 158); //xanh chuooi
                worksheet.get_Range($"A11:M11").Interior.Color = Color.FromArgb(108, 175, 218); //xanh dam

                DataTable dataTable = new DataTable();
                dataTable = db.getTable($"select * from TranDau where MaTD = N'{cbSelect.Text.Trim()}'");
                for (int i = 11; i < dataTable.Rows.Count + 11; i++)
                {

                    if (i % 2 == 0)
                    {
                        worksheet.get_Range($"A{i}:M{i}").Interior.Color = Color.FromArgb(211, 245, 238);//xanh nhat
                    }
                    worksheet.get_Range($"A{i}:M{i}").RowHeight = 30;

                }

                //


                int n = dataTable.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    worksheet.get_Range("A" + (i + 11).ToString()).Value = (i + 1).ToString();
                    worksheet.get_Range("B" + (i + 11).ToString()).Value = dataTable.Rows[i][0].ToString();
                    worksheet.get_Range("C" + (i + 11).ToString()).Value = dataTable.Rows[i][1].ToString();
                    worksheet.get_Range("D" + (i + 11).ToString()).Value = dataTable.Rows[i][2].ToString();
                    worksheet.get_Range("E" + (i + 11).ToString()).Value = dataTable.Rows[i][3].ToString();
                    worksheet.get_Range("F" + (i + 11).ToString()).Value = dataTable.Rows[i][4].ToString();
                    worksheet.get_Range("G" + (i + 11).ToString()).Value = dataTable.Rows[i][5].ToString();
                    worksheet.get_Range("H" + (i + 11).ToString()).Value = dataTable.Rows[i][6].ToString();
                    worksheet.get_Range("I" + (i + 11).ToString()).Value = dataTable.Rows[i][7].ToString();
                    worksheet.get_Range("J" + (i + 11).ToString()).Value = dataTable.Rows[i][8].ToString();
                    worksheet.get_Range("K" + (i + 11).ToString()).Value = dataTable.Rows[i][9].ToString();
                    worksheet.get_Range("L" + (i + 11).ToString()).Value = dataTable.Rows[i][10].ToString();
                    worksheet.get_Range("M" + (i + 11).ToString()).Value = dataTable.Rows[i][11].ToString();
                }

                worksheet.Activate();

                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "TranDau(*.xlsx)|*.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    worksheet.SaveAs(saveFileDialog.FileName.ToString());
                    MessageBox.Show("Lưu file thành công");
                }




            }
            else
            {
                MessageBox.Show("Mời bạn chọn mã trận đấu");
            }



        }

        private void topThreePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cbSelect.Visible = false;
            lbCBSelect.Text = "";
            Excel.Application application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add(Excel.XlWBATemplate.xlWBATWorksheet);
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Worksheets[1];

            worksheet.get_Range("A6:M7").Font.Bold = true;
            worksheet.get_Range("A6").Value = "BÁO CÁO DANH SÁCH 3 CẦU THỦ GHI NHIỀU BÀN THẮNG NHẤT";
            worksheet.get_Range("A6").Font.Size = 25;
            worksheet.get_Range("A6").Font.Color = Color.FromArgb(7, 58, 64);

            //trộn
            worksheet.get_Range("A6:M5").Merge(true);

            worksheet.get_Range("A8:M8").Font.Bold = true;
            worksheet.get_Range("A8").Value = "Giải bóng đá Premier League 2022";
            worksheet.get_Range("A8").Font.Size = 15;
            worksheet.get_Range("A8").Font.Color = Color.FromArgb(7, 58, 64);

            //trộn
            worksheet.get_Range("A8:M8").Merge(true);


            //range
            worksheet.get_Range("A10:M10").Font.Size = 13;
            worksheet.get_Range("A11:M70").Font.Size = 11;
            worksheet.get_Range("A10:M10").Interior.Color = Color.FromArgb(11, 158, 158);

            //căn giữa
            worksheet.get_Range("A6:M70").HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;

            worksheet.get_Range("A10:M10").RowHeight = 30;
            worksheet.get_Range("A6:M70").VerticalAlignment = Excel.XlHAlign.xlHAlignCenter;


            worksheet.get_Range("A10").Value = "STT";
            worksheet.get_Range("A10").ColumnWidth = 5;

            worksheet.get_Range("B10").Value = "Mã cầu thủ";
            worksheet.get_Range("B10").ColumnWidth = 15;

            worksheet.get_Range("C10").Value = "Tên cầu thủ";
            worksheet.get_Range("C10").ColumnWidth = 25;

            worksheet.get_Range("D10").Value = "Mã vị trí";
            worksheet.get_Range("D10").ColumnWidth = 10;

            worksheet.get_Range("E10").Value = "Ngày sinh";
            worksheet.get_Range("E10").ColumnWidth = 20;

            worksheet.get_Range("F10").Value = "Số áo";
            worksheet.get_Range("F10").ColumnWidth = 10;


            worksheet.get_Range("G10").Value = "Số bàn thắng";
            worksheet.get_Range("G10").ColumnWidth = 15;


            worksheet.get_Range("H10").Value = "Số thẻ vàng";
            worksheet.get_Range("H10").ColumnWidth = 15;


            worksheet.get_Range("I10").Value = "Số thẻ đỏ";
            worksheet.get_Range("I10").ColumnWidth = 10;


            worksheet.get_Range("J10").Value = "Mã quốc tịch";
            worksheet.get_Range("J10").ColumnWidth = 15;

            worksheet.get_Range("K10").Value = "Số lần ra sân";
            worksheet.get_Range("K10").ColumnWidth = 15;


            worksheet.get_Range("L10").Value = "Tên đội bóng";
            worksheet.get_Range("L10").ColumnWidth = 25;

            worksheet.get_Range("M10").Value = "HLV của đội";
            worksheet.get_Range("M10").ColumnWidth = 17;

            //Màu chữ header
            worksheet.get_Range("A10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("B10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("C10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("D10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("E10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("F10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("G10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("H10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("I10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("J10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("K10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("L10").Font.Color = Color.FromArgb(235, 237, 240);
            worksheet.get_Range("M10").Font.Color = Color.FromArgb(235, 237, 240);




            //màu hàng



            worksheet.get_Range($"A10:M10").Interior.Color = Color.FromArgb(11, 158, 158); //xanh chuooi
            worksheet.get_Range($"A11:M11").Interior.Color = Color.FromArgb(108, 175, 218); //xanh dam

            DataTable dataTable = new DataTable();
            dataTable = db.getTable($"select top(3) with ties MaCT,TenCT,MaViTri,NgaySinh,SoAo,CauThu.SoBanThang,SoTheVang,SoTheDo,MaQuocTich,SoLanRaSan,TenDoi,HLV from CauThu join DoiBong on DoiBong.MaDoi = CauThu.MaDoi order by CauThu.SoBanThang desc");
            for (int i = 11; i < dataTable.Rows.Count + 11; i++)
            {

                if (i % 2 == 0)
                {
                    worksheet.get_Range($"A{i}:M{i}").Interior.Color = Color.FromArgb(211, 245, 238);//xanh nhat
                }

                worksheet.get_Range($"A{i}:M{i}").RowHeight = 30;
            }
            //chieu cao cot

            //



            int n = dataTable.Rows.Count;
            for (int i = 0; i < n; i++)
            {
                worksheet.get_Range("A" + (i + 11).ToString()).Value = (i + 1).ToString();
                worksheet.get_Range("B" + (i + 11).ToString()).Value = dataTable.Rows[i][0].ToString();
                worksheet.get_Range("C" + (i + 11).ToString()).Value = dataTable.Rows[i][1].ToString();
                worksheet.get_Range("D" + (i + 11).ToString()).Value = dataTable.Rows[i][2].ToString();
                worksheet.get_Range("E" + (i + 11).ToString()).Value = dataTable.Rows[i][3].ToString();
                worksheet.get_Range("F" + (i + 11).ToString()).Value = dataTable.Rows[i][4].ToString();
                worksheet.get_Range("G" + (i + 11).ToString()).Value = dataTable.Rows[i][5].ToString();
                worksheet.get_Range("H" + (i + 11).ToString()).Value = dataTable.Rows[i][6].ToString();
                worksheet.get_Range("I" + (i + 11).ToString()).Value = dataTable.Rows[i][7].ToString();
                worksheet.get_Range("J" + (i + 11).ToString()).Value = dataTable.Rows[i][8].ToString();
                worksheet.get_Range("K" + (i + 11).ToString()).Value = dataTable.Rows[i][9].ToString();
                worksheet.get_Range("L" + (i + 11).ToString()).Value = dataTable.Rows[i][10].ToString();
                worksheet.get_Range("M" + (i + 11).ToString()).Value = dataTable.Rows[i][11].ToString();
            }

            worksheet.Activate();

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CauThu(*.xlsx)|*.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                worksheet.SaveAs(saveFileDialog.FileName.ToString());
                MessageBox.Show("Lưu file thành công");
            }



        }

        private void excelToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
