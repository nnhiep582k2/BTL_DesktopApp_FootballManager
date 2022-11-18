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
    public partial class Provices : Form
    {
        public Provices()
        {
            InitializeComponent();
        }
        ProcessConnect connectData = new ProcessConnect("Data Source=NNHIEP\\SQLEXPRESS;Initial Catalog=QLGiaiBongNHA;Integrated Security=True");
        private void Provices_Load(object sender, EventArgs e)
        {
            dgvTinh.DataSource = connectData.getTable("select * from Tinh");
            SetupDataGridView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Province_SS.maTinh = dgvTinh.SelectedRows[0].Cells[0].Value.ToString();
            Province_SS.tenTinh = dgvTinh.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void SetupDataGridView()
        {
            // Header
            dgvTinh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvTinh.ColumnHeadersHeight = 50;
            dgvTinh.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 8, FontStyle.Bold);
            dgvTinh.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTinh.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Raised;
            dgvTinh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTinh.EnableHeadersVisualStyles = false;
            dgvTinh.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(11, 158, 158);
            dgvTinh.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
           
            dgvTinh.BorderStyle = BorderStyle.None;
            dgvTinh.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(211, 245, 238);
            dgvTinh.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTinh.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dgvTinh.DefaultCellStyle.SelectionBackColor = Color.FromArgb(96, 156, 219);
            dgvTinh.DefaultCellStyle.Font = new Font("Arial", 11);
            dgvTinh.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTinh.BackgroundColor = Color.FromArgb(235, 237, 240);
            dgvTinh.RowTemplate.Height = 40;
            dgvTinh.Columns["MaTinh"].Width = 0;
            dgvTinh.Columns["TenTinh"].Width = 600;

            dgvTinh.Columns["MaTinh"].HeaderText = "MÃ TỈNH";
            dgvTinh.Columns["TenTinh"].HeaderText = "TÊN TỈNH";

        }

        private void dgvTinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Province_SS.maTinh = dgvTinh.SelectedRows[0].Cells[0].Value.ToString();
            Province_SS.tenTinh = dgvTinh.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}
