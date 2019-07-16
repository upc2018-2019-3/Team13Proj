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
    public partial class zh : Form
    {
        private DataSet ds = new DataSet();
        public static string ff= ""; 
        public zh()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void zh_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sex = "男";  //默认性别为男
            if (this.radioButton2.Checked == true)
            {
                sex = "女";
            }
            
            //判断用户名，密码，科室，年龄不能为空
            if (this.textBox6.Text.Trim() == "")
            {
                MessageBox.Show("姓名不能为空");
                this.Focus();
                return;
            }
            if (this.textBox1.Text.Trim() == "")
            {
                MessageBox.Show("账号不能为空");
                this.Focus();
                return;
            }
            if (this.radioButton1.Checked == false && this.radioButton2.Checked == false)
            {
                MessageBox.Show("性别不能为空");
                this.Focus();
                return;
            }
            if (this.textBox2.Text.Trim() == "")
            {
                MessageBox.Show("年龄不能为空");
                this.Focus();
                return;
            }
            string sql = "update dbo.login set uname='" + this.textBox6.Text.Trim() + "',age='" + this.textBox2.Text.Trim() + "',sex='" + sex + "'where uid='" + this.textBox1.Text.Trim() + "'";
            SqlConnection con = DBhelper.Gethelper();//调用DBhelp类中的方法，连接数据库
            SqlCommand com = new SqlCommand(sql, con);//创建command对象执行SQL语句
            con.Open();
            int count = com.ExecuteNonQuery();
            con.Close();
            if (count > 0)         //判断数据库中受影响的行数
            {
                string Message = string.Format("修改成功！");
                MessageBox.Show(Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.textBox1.Clear();
            this.textBox6.Clear();
            this.textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.textBox3.Text.Trim() == ""|this.textBox7.Text.Trim()=="")                              //判断输入的身份证格式
            {
                MessageBox.Show("输入正确的登录密码或账号");
                this.textBox3.Focus();                                        //重新输入
                return;
            }
            else
            {
                SqlConnection con = DBhelper.Gethelper();                      //打开连接
                try
                {
                    ff= this.textBox3.Text;                                  //变量接收身份证验证文本框值
                    if (this.textBox4.Text!=this.textBox5.Text)
                    {
                        MessageBox.Show("新密码不一致", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox4.Clear();
                        this.textBox5.Clear();//值清空
                        this.textBox4.Focus();                                 //聚焦身份证文本框
                    }
                    else
                    {
                        string sql = "update dbo.login set pwd='" + this.textBox4.Text.Trim() + "'where uid='" + this.textBox7.Text.Trim() + "'";
                        SqlCommand com = new SqlCommand(sql, con);//创建command对象执行SQL语句
                        con.Open();
                        int count = com.ExecuteNonQuery();
                        con.Close();
                        if (count > 0)         //判断数据库中受影响的行数
                        {
                            string Message = string.Format("保存成功！");
                            MessageBox.Show(Message, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }
                }
                catch (Exception)
                {
                    this.textBox1.Clear();
                    MessageBox.Show("保存失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.textBox7.Clear();
            this.textBox4.Clear();
            this.textBox5.Clear();
            this.textBox3.Clear();
        }
    }
}
