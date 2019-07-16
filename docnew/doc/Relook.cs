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
    /// 挂号窗体，查看医生科室实现挂号功能
    /// </summary>
    public partial class Relook : Form
    {
        private DataSet ds = new DataSet();                      //创建DataSet对象
        private SqlDataAdapter da;                                //创建SqlDataAdapter对象
        public static string name1;                              //姓名静态变量
        public static string office1;                            //科室静态变量
        public Relook()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='医生'";
            da = new SqlDataAdapter(sql, con);                   //SqlDataAdapter对象接收
            con.Open();                                          //打开连接
            da.Fill(ds);                                //填充数据集 
            this.dataGridView1.DataSource = ds.Tables[0];        //源表login
        }
        
        private void btnserchn_Click(object sender, EventArgs e)      //查询医生姓名按钮
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='医生' and uname='" + this.txtsen.Text.Trim() + "'";
            da = new SqlDataAdapter(sql, con);
            con.Open();                                              //DataSet重置
            ds.Reset();
            da.Fill(ds, "login");
            dataGridView1.DataSource = ds.Tables["login"];
        }
        private void btncancle_Click(object sender, EventArgs e)      //取消按钮
        {
            this.Dispose();                                         //此窗体隐藏
            register obj = new register();                          //挂号查询窗体出现
            obj.Show();
        }
        private void btnok_Click(object sender, EventArgs e)      //确定按钮
        {
            SqlConnection con = DBhelper.Gethelper();
            con.Open();
            string sid = Convert.ToString(register.Num);            //声明sid变量获取强转String后的register类的Num变量
            string sid1 = sid + "|";                                //声明sid1变量获取sid和"|"
            int tem = 0;                                            //声明int型的tem变量

            if (dataGridView1.SelectedCells.Count == 0)             //判断用户有未选择dataGridView的单元格
            {
                MessageBox.Show("请选择一个医生！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else                                                    //获取当前选中的这一行第一个单元格的值，obj型转为String后强转int型用tem接收           
            {
                tem = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string sql1 = "select friend from Friend where id='" + tem + "'";    //查询条件为医生的id
                SqlCommand com = new SqlCommand(sql1, con);
                try
                {
                    string bianhao = com.ExecuteScalar().ToString();                 //用string型bianhao变量接收返回的值
                    string sidd = bianhao + sid1;                                   //将bianhao和sid1变量赋给sidd
                    sql1 = "update Friend set friend='" + sidd + "' where id='" + tem + "'";     //将sidd的值更新到条件为该医生id号的行friend的列
                    Getz(sql1);                                       //调用 Getz方法执行
                    MessageBox.Show("挂号成功！");                    //成功后返回查询挂号窗体
                    register obj = new register();
                    obj.Show();
                    this.Hide();                                      //该窗体隐藏
                }
                catch (Exception)
                {
                    MessageBox.Show("选择有错", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            con.Close();                                           //关闭连接
        }
        public static bool Getz(string sql1)                      //静态bool型的Getz方法
        {
            SqlConnection con1 = DBhelper.Gethelper();            //创建 SqlConnection对象
            SqlCommand com2 = new SqlCommand(sql1, con1);
            con1.Open();
            int count = com2.ExecuteNonQuery();                  //接收受影响的行数
            if (count > 0)                                       //如果有影响行数
            {                                                     //返回true
                return true;
            }                 
            else
            {
                return false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtuname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();       //接收医生姓名
            this.txtoffice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();      //接收医生科室
        }

        private void btnsercho_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='医生' and office='" + this.txtseo.Text.Trim() + "'";
            da = new SqlDataAdapter(sql, con);
            con.Open();                                           //按照科室查询条件找到该科室医生
            ds.Reset();                                            //DataSet重置
            da.Fill(ds, "login");
            dataGridView1.DataSource = ds.Tables["login"];
        }

        private void txtuname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtoffice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}