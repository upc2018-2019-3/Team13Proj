using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace doc
{
    public partial class uc : Form
    {
        public uc()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void 账号设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zh child = new zh();
            child.MdiParent = this;
            child.Show();
        }

        private void 预约挂号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            register frm = new register();
            frm.Show();
        }

        private void 查看诊断ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            zd child2 = new zd();
            child2.MdiParent = this;
            child2.Show();
        }

        private void 返回ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main frm = new main();
            frm.Show();
        }
    }
}
