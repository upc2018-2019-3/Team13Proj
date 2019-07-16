﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace doc
{
    public partial class wk : Form
    {
        private DataSet ds = new DataSet();                      //创建DataSet对象
        private SqlDataAdapter da;                                //创建SqlDataAdapter对象
        public static string name1;                              //姓名静态变量
        public static string office1;  //科室静态变量 
        public wk()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main obj = new main();
            obj.Show();
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from login where office='外科' and type='医生'";
            da = new SqlDataAdapter(sql, con);                   //SqlDataAdapter对象接收
            con.Open();
            DataTable dt = new DataTable();//打开连接
            da.Fill(dt);                                //填充数据集 
            this.dataGridView2.DataSource = dt;        //源表login
        }

        private void wk_Load(object sender, EventArgs e)
        {
            button2.PerformClick();
        }
      
    }
}
