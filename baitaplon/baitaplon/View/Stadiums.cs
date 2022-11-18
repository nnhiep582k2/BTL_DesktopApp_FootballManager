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

namespace baitaplon.View
{
    public partial class Stadiums : Form
    {
        public Stadiums()
        {
            InitializeComponent();
        }
        ProcessConnect db = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private void Stadiums_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(40, 182, 150);
            dataGridViewStadium.DataSource = db.getTable("select * from sanbong");
            this.dataGridViewStadium.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewStadium.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewStadium.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewStadium.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewStadium.ColumnHeadersHeight = 40;
            dataGridViewStadium.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 11, FontStyle.Bold);
            dataGridViewStadium.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewStadium.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dataGridViewStadium.EnableHeadersVisualStyles = false;
            dataGridViewStadium.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dataGridViewStadium.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Content
            dataGridViewStadium.ReadOnly = true;
            dataGridViewStadium.BorderStyle = BorderStyle.None;
            dataGridViewStadium.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dataGridViewStadium.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridViewStadium.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridViewStadium.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dataGridViewStadium.DefaultCellStyle.Font = new Font("Arial", 11);
            dataGridViewStadium.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewStadium.BackgroundColor = Color.FromArgb(235, 237, 240);
            dataGridViewStadium.Columns["MaSan"].HeaderText = "MÃ SÂN";
            dataGridViewStadium.Columns["TenSan"].HeaderText = "TÊN SÂN";
            dataGridViewStadium.Columns["DiaChi"].HeaderText = "ĐỊA CHỈ";
            dataGridViewStadium.Columns["SoGhe"].HeaderText = "SỐ GHẾ";
        }

        private void dataGridViewStadium_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Stadiums_SS.MaSan = dataGridViewStadium.CurrentRow.Cells[0].Value.ToString();
            Stadiums_SS.TenSan = dataGridViewStadium.CurrentRow.Cells[1].Value.ToString();
            Stadiums_SS.ViTri = dataGridViewStadium.CurrentRow.Cells[2].Value.ToString();
            Stadiums_SS.SoGhe = int.Parse(dataGridViewStadium.CurrentRow.Cells[3].Value.ToString());
        }

        private void dataGridViewStadium_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
