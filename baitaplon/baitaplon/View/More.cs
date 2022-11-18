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
    public partial class More : Form
    {
        Layout layout_official;
        public More(Layout layout)
        {
            InitializeComponent();
            layout_official = layout;
        }
        private Form currenFormChild;
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
        public void nationalitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Nationalities());
            layout_official.lbtitle.Text = "Nationalities";
        }

        private void More_Load(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
        }

        private void menuItemLocation_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Locations());
            layout_official.lbtitle.Text = "Locations";
        }

        private void menuItemProvices_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Provices());
            layout_official.lbtitle.Text = "Provinces";
        }

        private void menuItemStadium_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Stadiums());
            layout_official.lbtitle.Text = "Stadiums";
        }
    }
}
