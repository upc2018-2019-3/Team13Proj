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
    /// 医生窗体，演示完成应诊功能
    /// </summary>
    public partial class btnTiJiao : Form
    {
        public btnTiJiao()
        {
            InitializeComponent();
        }

        private void btnTiJiao_Load(object sender, EventArgs e)
        {
            //查询医生姓名和科室的SQL语句
            string sql = "select uname,office from dbo.login where uid='"+Login.denglu+"'";
            DataSet ds = Mindoc.Getds(sql);   //创建ds对象
            lblDocName1.Text = ds.Tables[0].Rows[0][0].ToString();  
            lblKemuName1.Text = ds.Tables[0].Rows[0][1].ToString();


            //查询新挂号病人的SQL语句
            sql = "select psfz,pname,page,psex,blood,phone,adds,data from [user] where pid='" + Mindoc.name1 + "'"; 
            ds = Mindoc.Getds(sql);  //创建ds对象
            this.txtnum.Text = ds.Tables[0].Rows[0][0].ToString();
            this.txtName.Text = ds.Tables[0].Rows[0][1].ToString();
            this.txtSex.Text = ds.Tables[0].Rows[0][2].ToString();
            this.txtage.Text = ds.Tables[0].Rows[0][3].ToString();
            this.txtBlood.Text = ds.Tables[0].Rows[0][4].ToString();
            this.txtPhone.Text = ds.Tables[0].Rows[0][5].ToString();
            this.txtAdds.Text = ds.Tables[0].Rows[0][6].ToString();
            this.txtTime.Text =ds.Tables[0].Rows[0][7].ToString();

        }

        private void BtnYingZheng_Click(object sender, EventArgs e)
        {
            //使用try  catch 判断年龄不能为字符
            try
            {
                double mn = Convert.ToDouble(this.txtMoney.Text);
                //判断成功执行SQL语句
                string sql = "insert into bingkuang values ('" + this.txtnum.Text.Trim() + "','" + this.txtName.Text.Trim() + "','" + this.txtSex.Text.Trim() + "','" + this.txtage.Text.Trim() + "','" + this.txtBlood.Text.Trim() + "','" + this.txtPhone.Text.Trim() + "','" + this.txtBingKuang.Text.Trim() + "'," + mn + ",'" + this.txtAdds.Text.Trim() + "')";
                if (Mindoc.Getzsgc(sql))
                {
                    MessageBox.Show("操作成功");
                    this.Hide(); //本窗体隐藏
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("年龄格式不正确","操作提示",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Show();
                this.txtMoney.Focus();//如果输入不是数字返回到txtMoney文本框
            }
        }

        private void btnAgin_Click(object sender, EventArgs e)
        {
            this.txtMoney.Clear(); //清空txtMoney文本框
            this.txtBingKuang.Clear();//清空txtBingKuang文本框
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //关闭本窗体
           
        }

    }
}