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
    /// 医生窗体，演示查看病员
    /// </summary>

    public partial class Mindoc : Form
    {
        public static string name1 = ""; //获取编号
        public Mindoc()
        {
            InitializeComponent();
        }
        private void Mindoc_Load(object sender, EventArgs e)
        {
            this.dgvinfo.Visible = false; 
            this.dgv1.Visible = true;
            this.btnfind.Visible = true;
            this.BtnYingZheng.Visible = false;

            string sql = "select [name],kemu from dbo.Friend where id='" + Login.denglu + "'"; //uid登录的帐号
            DataSet ds = Getds(sql); //创建DataSet对象调用方法
            lblDocName.Text = ds.Tables[0].Rows[0][0].ToString();
            lblKemu.Text = ds.Tables[0].Rows[0][1].ToString();
            Getcount(sql); //调用方法重新读取数据
        }

        public string Getcount(string sql)
        {
            SqlConnection con = DBhelper.Gethelper();
            sql = "select friend from dbo.Friend where id='" + Login.denglu + "'"; //查询医生有多少病员用的SQL语句
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string reng = com.ExecuteScalar().ToString();  //执行SQL语句返回一行一列的值
            string[] bb = reng.Split('|');   //以'|'为分割符分割字符串
            int temp = bb.Length - 1;    //执行一次减少一个病人

            lblCount.Text = Convert.ToString(temp);
            return sql;
        }
        public static DataSet Getds(string sql)
        {
            SqlConnection con = DBhelper.Gethelper(); //创建SqlConnection对象
            SqlDataAdapter da = new SqlDataAdapter(sql, con); //创建DataAdapter对象
            DataSet ds = new DataSet(); //创建DataSet对象
            con.Open(); //打开连接
            da.Fill(ds); //填充数据
            return ds;
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            //控制病人数量
            this.dgv1.Visible = false;
            this.btnagin1.Visible = false;
            this.dgvinfo.Visible = true;
            this.btnfind.Visible = false;
            this.BtnYingZheng.Visible = true;
            int friend = 0;
            if (dgv1.SelectedCells.Count == 0) //没有选择任何列
            {
                MessageBox.Show("请选择一个病人", "操作提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //获取DataGredview中选中的行的第一个单元格的值
                    friend = int.Parse(this.dgv1.CurrentRow.Cells[0].Value.ToString());
                    name1 = friend + "";
                    SqlConnection con = DBhelper.Gethelper();
                    string sql = "select psfz from [user] where pid='" + name1 + "'"; //查询病人身份证用的SQL语句
                    SqlCommand com = new SqlCommand(sql, con);
                    con.Open();
                    string name2 = com.ExecuteScalar().ToString(); //执行SQL语句返回身份证号
                    con.Close();

                    sql = "select a.pname,a.page,a.psex,b.bingkuang,a.data from [user] as a inner join dbo.bingkuang as b on (a.psfz=b.psfzId) where psfz='" + name2 + "'"; //以病人身份证为条件查询相关内容
                    DataSet ds = Getds(sql);
                    this.dgvinfo.DataSource = ds.Tables[0]; //填充以前病历表


                    con = DBhelper.Gethelper();
                    sql = "select friend from dbo.Friend where id='" + Login.denglu + "'"; //查询病人用的SQL语句
                    com = new SqlCommand(sql, con);
                    con.Open();
                    string frind1 = com.ExecuteScalar().ToString(); //执行SQL语句
                    con.Close();

                    if (frind1.Length > 0) //判断是否还有病人
                    {
                        int index = frind1.IndexOf(name1);  //病人编号的索引值
                        string frind5 = frind1.Substring(0, index);  //截取没看过的病人
                        string frind2 = frind1.Substring(index + 5); //截取没看过的病人
                        string str = frind5 + frind2;
                        sql = "update dbo.Friend set friend='" + str + "' where id='" + Login.denglu + "'"; //更新挂号病人的SQL语句
                        Getzsgc(sql);//调用方法执行SQL语句
                        Getguahao(sql);  //重新读取数据
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("没有病人了");
                }
            }
        }

        private void picfind_Click(object sender, EventArgs e)
        {
            string sql = "";
            Getcount(sql);//调用控制病人的方法
            Getguahao(sql); //读取数据
        }

        public string Getguahao(string sql)
        {
            SqlConnection con = DBhelper.Gethelper();
            sql = "select friend from dbo.Friend where id='" + Login.denglu + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string reng = com.ExecuteScalar().ToString();
            string[] bb = reng.Split('|');  //以'|'分割字符串
            string kk = "";  //声明变量存储病人编号
            for (int i = 0; i < bb.Length - 1; i++)
            {
                kk = kk + bb[i] + ","; //以","作分割连接字符串
            }
            if (kk.Length > 0)
            {
                //查询指定值的SQL语句
                sql = "select pid,pname,page,psex,adds,data from [user] where pid in (" + kk.Substring(0, kk.Length - 1) + ")";
                DataSet ds = Getds(sql);
                this.dgv1.DataSource = ds.Tables[0]; //新挂号病人填充DataGredview
            }
            else
            {
                DataSet ds = new DataSet("a"); //创建ds对象
                this.dgv1.DataSource = ds.Tables["a"];//重新填充dgv1
            }

            return sql;
        }

        private void BtnYingZheng_Click(object sender, EventArgs e)
        {
            this.lblCount.Text = Convert.ToString((Convert.ToInt32(this.lblCount.Text) - 1));
            btnTiJiao objbtn = new btnTiJiao(); //创建objbtn对象
            objbtn.Show();  //显示btnTiJiao窗体
            this.BtnYingZheng.Visible = false;
            this.dgvinfo.Visible = false;
            this.btnfind.Visible = true;
            this.dgv1.Visible = true;
            this.btnagin1.Visible = true;
        }
        //完成增删改查的方法
        public static bool Getzsgc(string sql)
        {
            SqlConnection con = DBhelper.Gethelper();
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            int temp = com.ExecuteNonQuery();
            if (temp != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "";
            Getguahao(sql);
            Getcount(sql);
        }

        private void btnClose2_Click(object sender, EventArgs e)
        {
            this.Close();
            string sql = "update [login] set stata='1' where uid='" +Login.denglu + "'";
            Getzsgc(sql);
        }

    }
}
