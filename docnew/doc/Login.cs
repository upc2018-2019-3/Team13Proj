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
    
    public partial class Login : Form
    {
        public static int denglu = 0;
        public Login()
        {
            InitializeComponent();
        }
        private void cancel_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main frm = new main();
            frm.Show();
        }

        private void zhuce_Click(object sender, EventArgs e)
        {
            Newusers obj = new Newusers();
            obj.Show();//跳转到注册窗体
        }

        private void land_Click(object sender, EventArgs e)
        {


            try
            {
                //判断用户名，密码，登陆类型不能为空
                if (this.num.Text.Trim() == "")
                {
                    MessageBox.Show("请输入用户名");
                    this.Focus();
                    return;
                }
                else if (this.pwdText.Text.Trim() == "")
                {
                    MessageBox.Show("请输入密码");
                    this.Focus();
                    return;
                }
                else if (this.userType.Text.Trim() == "")
                {
                    MessageBox.Show("用户类型不能为空");
                    this.Focus();
                    return;
                }
            }
            catch
            {
                throw;
            }
              denglu =Convert.ToInt32(this.num.Text.Trim());//将文本框的值付给静态变量
            //当登陆类型为挂号台时并且获取正确的帐号与密码就跳转挂号台窗体
    if (this.userType.Text == "挂号")
            {

                string sql = "select count(*) from dbo.login where uid='" + this.num.Text.Trim().ToString() + "'and pwd='" + this.pwdText.Text.Trim().ToString() + "' and type='挂号台'";

                bool yn = loginType(sql);//调用loginType方法
                if (yn == true)
                {
                    uc objreg = new uc();
                    objreg.Show();
                }
                else
                {
                    MessageBox.Show("帐号或密码错误！");
                    return;
                }
            }
            //当登陆类型为医生时并且获取正确的帐号与密码就跳转到医生窗体
            if (this.userType.Text == "医生")
            {

                string sql = "select count(*) from dbo.login where uid='" + this.num.Text.Trim().ToString() + "'and pwd='" + this.pwdText.Text.Trim().ToString() + "'and type='医生'";

                bool yn = loginType(sql);//调用loginType方法
                if (yn == true)
                {
                    sql = "update [login] set stata=0 where uid='"+denglu+"'";
                    if (Mindoc.Getzsgc(sql))//调用方法执行SQL语句
                    {
                        Mindoc objmin = new Mindoc();
                        objmin.Show();//打开医生窗体
                    }
                
                }
                else
                {
                    MessageBox.Show("帐号或密码错误！");
                    return;
                }
            }
            this.Hide();//本窗体隐藏
        }
        //创建loginType方法传一个sql参数
        public bool loginType(string sql)
        {
            int count = 0;

            SqlConnection con = DBhelper.Gethelper();//连接数据库
            try
            {
                SqlCommand com = new SqlCommand(sql, con);//创建command对象处理SQL语句
                con.Open();
                count = (int)com.ExecuteScalar();//返回一行一列的值
                if (count == 1)//当返回值大于1就返回return
                {
                    return true;
                }
            }
            catch (Exception )
            {
                return false;
            }
            finally
            {
                con.Close();//关闭连接
            }
            return false;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void userType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void num_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
