using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace doc
{
    public partial class Newusers : Form
    {
        public Newusers()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int accounts = 0;
            string sex = "男";  //默认性别为男
            if (this.radiogirl.Checked == true)  
            {
                sex = "女";
            }
            string type = "挂号台";
            if (this.DrRadio.Checked == true)
            {
                type = "医生";
            }
            //判断用户名，密码，科室，年龄不能为空
            if (this.trueName.Text.Trim() == "")
            {
                MessageBox.Show("用户名不能为空");
                this.Focus();
                return;
            }
            if (this.code.Text.Trim() == "")
            {
                MessageBox.Show("密码不能为空");
                this.Focus();
                return;
            }
            if (this.DrRadio.Checked == true && this.subjectText.Text == "")
                
            {
                MessageBox.Show("科室不能为空");
                this.Focus();
                return;
            }
            if (this.ageAasked.Text.Trim() == "")
            {
                MessageBox.Show("年龄不能为空");
                this.Focus();
                return;
            }
            //向数据库插入注册的SQL语句
            string sql = "insert into dbo.login values (" + this.code.Text.Trim() + ",'" + this.trueName.Text.Trim() + "','" + sex + "'," + this.ageAasked.Text.Trim() + ",'" + type + "','" + this.subjectText.Text.Trim() + "')";
            SqlConnection con = DBhelper.Gethelper();//调用DBhelp类中的方法，连接数据库
            SqlCommand com = new SqlCommand(sql, con);//创建command对象执行SQL语句
            con.Open();
            int count = com.ExecuteNonQuery();
            con.Close();
            if (count > 0)         //判断数据库中受影响的行数
            {
                con.Open();
                string sql1 = "select top 1 uid from dbo.login order by uid desc"; //将数据库中的数据按降序排列并查找出第一个                
                com.CommandText = sql1;
                accounts = Convert.ToInt32(com.ExecuteScalar());//生成帐号
                string Message = string.Format("注册成功！您的帐号是{0}", accounts);
                MessageBox.Show(Message, "注册成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            sql = "insert into dbo.Friend(id,kemu,name) values(" + accounts + ",'" + this.subjectText.Text + "','" + this.trueName.Text + "')";
            Mindoc.Getzsgc(sql);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.subject.Visible = false; //当点击选择挂号台按钮后将科室隐藏
            this.subjectText.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.subject.Visible = true;//当点击医生将科室显示出来
            this.subjectText.Visible = true;
        }
    }
}