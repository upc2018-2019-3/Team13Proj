using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace doc
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            this.BackgroundImageLayout = ImageLayout.Stretch;
        }

       

        
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void 外科ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                     //此窗体隐藏
            wk frm = new wk();
            frm.Show();

        }


        private void 患者服务ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 儿科ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            ek frm = new ek();
            frm.Show();
        }

        private void 妇科ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();                     //此窗体隐藏
            fk frm = new fk();
            frm.Show();
        }

        

  
        private void 医师入口ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login frm = new Login();
            frm.Show();
        }

        private void 科室设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
