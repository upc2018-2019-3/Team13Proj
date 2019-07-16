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
    /// <summary>
    /// 病历信息，挂号需有病历，本功能实现查询和新建病历
    /// </summary>
    public partial class register : Form
    {
        public static string sfz = "";    //接收身份证号输入 
        public static int Num = 0;         //此静态变量用于接收自动生成编号
        private DataSet ds = new DataSet(); //创建数据集
        public register()
        {
            InitializeComponent();
        }
        private void 挂号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;     //点击挂号，弹出病历信息查询及挂号
            panel1.Visible = true;
        }
        private void 病历ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;      //此功能通过隐藏面板实现新建病历功能  
            panel1.Visible = false;
        }
        private void btnUp_Click_1(object sender, EventArgs e)      //提交按钮
        {
            sfz = this.txtsfz.Text;                                   //给变量赋值
            if (this.txtsfz.Text.Trim() == "")                        //判断身份证为不为空
            {
                MessageBox.Show("请输入身份证");
                this.txtsfz.Focus();
            }
            else if (this.txtage.Text.Trim() == "")
            {
                MessageBox.Show("请输入年龄");
                this.txtage.Focus();
            }
            else if (this.txtname.Text.Trim() == "")
            {
                MessageBox.Show("请输入真实姓名");
                this.txtname.Focus();
            }
            else if (this.txtphone.Text.Trim() == "")
            {
                MessageBox.Show("请输入联系方式");
                this.txtphone.Focus();
            }
            else if (this.txtadd.Text.Trim() == "")
            {
                MessageBox.Show("请输入住址");
                this.txtadd.Focus();
            }
            else
            {
                try
                {
                    long sfz1 = Convert.ToInt64(this.txtsfz.Text);                //声明身份证的变量接受强转INT型的身份证文本框的值
                    int age7 = Convert.ToInt32(this.txtage.Text);                //声明年龄的变量接受强转INT型的年龄文本框的值
                    if (age7 >= 1 && age7 <= 130)                                      //判断年龄规范
                    {
                        SqlConnection con = DBhelper.Gethelper();                //声明SqlConnection对象
                        string sex = "男";                                       //给变量附初始值＝男
                        if (this.radioButton2.Checked == true)                   //用户选择的按钮2被选中的话，变量为 女
                        {
                            sex = "女";
                        }
                        string sql = "insert into [user](pname,psex,page,blood,phone,psfz,[money],adds) values('" + this.txtname.Text.Trim() + "','" + sex + "','" + this.txtage.Text.Trim() + "','" + this.cbxblood.SelectedItem.ToString() + "','" + this.txtphone.Text.Trim() + "','" + this.txtsfz.Text.Trim() + "','0','" + this.txtadd.Text.Trim() + "') ";
                        SqlCommand com = new SqlCommand(sql, con);              //往[user]表里添加病人信息,声明SqlCommand对象   
                        con.Open();                                             //打开连接  
                        int temp = com.ExecuteNonQuery();                       //声明变量接收SqlCommand对象的ExecuteNonQuery方法
                        if (temp != 0)
                        {
                            sql = "select top 1 [pid] from [user] order by [pid] desc";     //降序排列得到[user]表中新注册用户的自动增长列
                            com.CommandText = sql;                                          //获取SQL语句  
                            Num = Convert.ToInt32(com.ExecuteScalar().ToString());          //用静态变量接收强转INT型的查询所返回的1行1列的值即ID
                            string aa = string.Format("您的电子病历号是{0}", Num);
                            MessageBox.Show(aa, "电子病历注册成功！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();                                                    //声明aa变量接收格式化后的字符串用消息框弹出成功信息
                            Relook obj1 = new Relook();                                     //病历注册后即进入挂号窗口
                            obj1.Show();
                            this.Hide();                                                    //此窗体隐藏
                        }
                    }
                    else
                    {
                        MessageBox.Show("年龄格式不正确", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtage.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("请输入数字", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnserch_Click_1(object sender, EventArgs e)            //查询按钮
        {
            if (this.txtsfz1.Text.Trim() == "")                              //判断输入的身份证格式
            {
                MessageBox.Show("输入正确的身份证号");
                this.txtsfz1.Focus();                                        //重新输入
                return;
            }
            else
            {
                SqlConnection con = DBhelper.Gethelper();                      //打开连接
                try
                {
                    sfz = this.txtsfz1.Text;                                  //变量接收身份证验证文本框值
                    if (sfz.Length < 18 && sfz.Length > 15)
                    {
                        MessageBox.Show("身份证格式不正确", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtsfz1.Clear();                                 //值清空
                        this.txtsfz1.Focus();                                 //聚焦身份证文本框
                    }
                    else
                    {
                        string sql = "select pname,psex,page,blood,phone,adds from [user] where psfz='" + this.txtsfz1.Text.Trim() + "'";
                        DataSet ds = getds(sql);                                   //查询有未有过病史判断是否来过调用方法重新创建数据集
                        txtname1.Text = ds.Tables[0].Rows[0][0].ToString();        //将值赋给各属性文本框
                        txtsex1.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtage1.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtblood.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtphone1.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtadd1.Text = ds.Tables[0].Rows[0][5].ToString();
                    }
                }
                catch (Exception)
                {
                    this.txtsfz1.Clear();
                    MessageBox.Show("未找到，请您先注册病历", "注册提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Visible = true;                                       //注册病历窗口打开，查询挂号窗口关闭
                    panel1.Visible = false;
                }
            }
        }
        public static DataSet getds(string sql)                            //静态getds方法以便调用
        {
            SqlConnection con = DBhelper.Gethelper();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        private void btnrtn_Click(object sender, EventArgs e)              //返回查询挂号窗体
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        private void btnregito_Click_2(object sender, EventArgs e)             //挂号按钮
        {
            if (this.txtsfz1.Text.Trim() == "")                               //判断身份证号文本框为空否
            {
                MessageBox.Show("输入身份证号或填写新病历");
                return;
            }
            else
            {
                string sql = "select psfz from [user] where psfz='" + txtsfz1.Text.Trim() + "'";
                SqlConnection con = DBhelper.Gethelper();                    //验证该身份证有否病史
                SqlCommand com = new SqlCommand(sql, con);
                con.Open();
                try
                {
                    string idcard = com.ExecuteScalar().ToString();              //声明变量查询返回第一行第一列的值
                    if (idcard == txtsfz1.Text.Trim())                            //找到记录的记录是否与文本框一致
                    {
                        sql = "insert into [user](pname,psex,page,blood,phone,psfz,[money],adds) values('" + this.txtname1.Text.Trim() + "','" + txtsex1.Text.Trim() + "','" + this.txtage1.Text.Trim() + "','" + txtblood.Text + "','" + this.txtphone1.Text.Trim() + "','" + this.txtsfz1.Text.Trim() + "','0','" + this.txtadd1.Text.Trim() + "') ";
                        com = new SqlCommand(sql, con);                           //将有病史的病人的资料重新插入数据库一次
                        int temp = com.ExecuteNonQuery();                          //声明变量获取插入成功的行数，只要不为0就成功
                        if (temp != 0)
                        {
                            sql = "select top 1 [pid] from [user] order by [pid] desc";           //找到此人本次看病的编号
                            com.CommandText = sql;
                            Num = Convert.ToInt32(com.ExecuteScalar().ToString());
                            string aa = string.Format("您本次挂号临时编号为{0}", Num);
                            MessageBox.Show(aa, "领取成功！", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();
                            Relook obj = new Relook();                                          //挂号窗口打开，此窗体隐藏
                            obj.Show();
                            this.Hide();
                        }
                    }
                }
                catch (Exception)
                {
                    this.txtsfz1.Clear();
                    MessageBox.Show("输入有错，请输入正确的身份证号查询或注册新病历！");
                }
            }
        }
    }
}