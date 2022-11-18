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
    public partial class Locations : Form
    {
        public Locations()
        {
            InitializeComponent();
            dgvVitri.DataSource =  connectData.getTable("select * from Vitri");
            SetupDataGridView();
        }

        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");

        private void SetupDataGridView()
        {
            // Header
            dgvVitri.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvVitri.ColumnHeadersHeight = 50;
            dgvVitri.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dgvVitri.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVitri.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvVitri.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvVitri.EnableHeadersVisualStyles = false;
            dgvVitri.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgvVitri.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            // Content

            dgvVitri.BorderStyle = BorderStyle.None;
            dgvVitri.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgvVitri.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvVitri.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvVitri.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgvVitri.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvVitri.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvVitri.BackgroundColor = Color.FromArgb(235, 237, 240);
            dgvVitri.RowTemplate.Height = 40;
            dgvVitri.Columns["MaViTri"].Width = 0;
            dgvVitri.Columns["TenViTri"].Width = 600;

            dgvVitri.Columns["MaViTri"].HeaderText = "MÃ VỊ TRÍ";
            dgvVitri.Columns["TenViTri"].HeaderText = "TÊN VỊ TRÍ";

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
            Locations_SS.maViTri = dgvVitri.SelectedRows[0].Cells[0].Value.ToString();
            Locations_SS.tenViTri = dgvVitri.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
