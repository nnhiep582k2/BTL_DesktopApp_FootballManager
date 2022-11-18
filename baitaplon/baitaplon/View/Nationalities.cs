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
    public partial class Nationalities : Form
    {
        public Nationalities()
        {
            InitializeComponent();
            dgvQuoctich.DataSource =  connectData.getTable("select * from QuocTich");
            SetupDataGridView();
        }

        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void SetupDataGridView()
        {
            // Header
            dgvQuoctich.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvQuoctich.ColumnHeadersHeight = 50;
            dgvQuoctich.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dgvQuoctich.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQuoctich.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvQuoctich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvQuoctich.EnableHeadersVisualStyles = false;
            dgvQuoctich.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgvQuoctich.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Content

            dgvQuoctich.BorderStyle = BorderStyle.None;
            dgvQuoctich.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgvQuoctich.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvQuoctich.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvQuoctich.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgvQuoctich.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvQuoctich.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvQuoctich.BackgroundColor = Color.FromArgb(235, 237, 240);
            dgvQuoctich.RowTemplate.Height = 40;
            dgvQuoctich.Columns["MaQuocTich"].Width = 0;
            dgvQuoctich.Columns["TenQuocTich"].Width = 600;

            dgvQuoctich.Columns["MaQuocTich"].HeaderText = "MÃ QUỐC TỊCH";
            dgvQuoctich.Columns["TenQuocTich"].HeaderText = "TÊN QUỐC TỊCH";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Nationalities_Load(object sender, EventArgs e)
        {

        }

        private void dgvQuoctich_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvQuoctich_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            Nationalities_SS.maQT = dgvQuoctich.SelectedRows[0].Cells[0].Value.ToString();
            Nationalities_SS.tenQT = dgvQuoctich.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
