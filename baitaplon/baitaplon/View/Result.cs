
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
    public partial class Result : Form
    {
        Layout layout_official;
        public Result(Layout layout)
        {
            InitializeComponent();
            layout_official = layout;
        }
        private Form currenFormChild;
        private void Result_Load(object sender, EventArgs e)
        {
            menuStrip1.Cursor = Cursors.Hand;
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
        private void matchGoalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Match_Goal());
            layout_official.lbtitle.Text = "Match-Goal";
        }

        private void matchCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Match_Card());
            layout_official.lbtitle.Text = "Match-Card";
        }

        private void matchPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Match_Player());
            layout_official.lbtitle.Text = "Match-Player";
        }
    }
}
