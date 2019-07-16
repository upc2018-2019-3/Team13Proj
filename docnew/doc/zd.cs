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
    public partial class zd : Form
    {
        private DataSet ds = new DataSet();
        public static string sfz = "";    //接收身份证号输入 
        public zd()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.textBox1.Text.Trim() == "")                              //判断输入的身份证格式
            {
                MessageBox.Show("输入正确的身份证号");
                this.textBox1.Focus();                                        //重新输入
                return;
            }
            else
            {
                SqlConnection con = DBhelper.Gethelper();                      //打开连接
                try
                {
                    sfz = this.textBox1.Text;                                  //变量接收身份证验证文本框值
                    if (sfz.Length < 18 && sfz.Length > 15)
                    {
                        MessageBox.Show("身份证格式不正确", "输入提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.textBox1.Clear();                                 //值清空
                        this.textBox1.Focus();                                 //聚焦身份证文本框
                    }
                    else
                    {
                        string sql = "select bingkuang from [bingkuang] where psfzId='" + this.textBox1.Text.Trim() + "'";
                        SqlCommand com = new SqlCommand(sql, con);//查询有未有过病史判断是否来过调用方法重新创建数据集
                        SqlDataAdapter da = new SqlDataAdapter(com);
                        da.Fill(ds);
                        List<String> list = new List<string>();
                        foreach (DataRow row in ds.Tables[0].Rows)
                        {
                            list.Add(row[0].ToString());
                        }
                        richTextBox1.Lines = list.ToArray();        //将值赋给各属性文本框
                    }
                }
                catch (Exception)
                {
                    this.textBox1.Clear();
                    MessageBox.Show("未找到，请您先挂号", "挂号提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private DataSet getds(string sql)
        {
            throw new NotImplementedException();
        }
    }
}
