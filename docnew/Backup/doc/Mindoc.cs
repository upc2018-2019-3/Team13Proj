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
    /// ҽ�����壬��ʾ�鿴��Ա
    /// </summary>

    public partial class Mindoc : Form
    {
        public static string name1 = ""; //��ȡ���
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

            string sql = "select [name],kemu from dbo.Friend where id='" + Login.denglu + "'"; //uid��¼���ʺ�
            DataSet ds = Getds(sql); //����DataSet������÷���
            lblDocName.Text = ds.Tables[0].Rows[0][0].ToString();
            lblKemu.Text = ds.Tables[0].Rows[0][1].ToString();
            Getcount(sql); //���÷������¶�ȡ����
        }

        public string Getcount(string sql)
        {
            SqlConnection con = DBhelper.Gethelper();
            sql = "select friend from dbo.Friend where id='" + Login.denglu + "'"; //��ѯҽ���ж��ٲ�Ա�õ�SQL���
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string reng = com.ExecuteScalar().ToString();  //ִ��SQL��䷵��һ��һ�е�ֵ
            string[] bb = reng.Split('|');   //��'|'Ϊ�ָ���ָ��ַ���
            int temp = bb.Length - 1;    //ִ��һ�μ���һ������

            lblCount.Text = Convert.ToString(temp);
            return sql;
        }
        public static DataSet Getds(string sql)
        {
            SqlConnection con = DBhelper.Gethelper(); //����SqlConnection����
            SqlDataAdapter da = new SqlDataAdapter(sql, con); //����DataAdapter����
            DataSet ds = new DataSet(); //����DataSet����
            con.Open(); //������
            da.Fill(ds); //�������
            return ds;
        }
        private void btnfind_Click(object sender, EventArgs e)
        {
            //���Ʋ�������
            this.dgv1.Visible = false;
            this.btnagin1.Visible = false;
            this.dgvinfo.Visible = true;
            this.btnfind.Visible = false;
            this.BtnYingZheng.Visible = true;
            int friend = 0;
            if (dgv1.SelectedCells.Count == 0) //û��ѡ���κ���
            {
                MessageBox.Show("��ѡ��һ������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                try
                {
                    //��ȡDataGredview��ѡ�е��еĵ�һ����Ԫ���ֵ
                    friend = int.Parse(this.dgv1.CurrentRow.Cells[0].Value.ToString());
                    name1 = friend + "";
                    SqlConnection con = DBhelper.Gethelper();
                    string sql = "select psfz from [user] where pid='" + name1 + "'"; //��ѯ�������֤�õ�SQL���
                    SqlCommand com = new SqlCommand(sql, con);
                    con.Open();
                    string name2 = com.ExecuteScalar().ToString(); //ִ��SQL��䷵�����֤��
                    con.Close();

                    sql = "select a.pname,a.page,a.psex,b.bingkuang,a.data from [user] as a inner join dbo.bingkuang as b on (a.psfz=b.psfzId) where psfz='" + name2 + "'"; //�Բ������֤Ϊ������ѯ�������
                    DataSet ds = Getds(sql);
                    this.dgvinfo.DataSource = ds.Tables[0]; //�����ǰ������


                    con = DBhelper.Gethelper();
                    sql = "select friend from dbo.Friend where id='" + Login.denglu + "'"; //��ѯ�����õ�SQL���
                    com = new SqlCommand(sql, con);
                    con.Open();
                    string frind1 = com.ExecuteScalar().ToString(); //ִ��SQL���
                    con.Close();

                    if (frind1.Length > 0) //�ж��Ƿ��в���
                    {
                        int index = frind1.IndexOf(name1);  //���˱�ŵ�����ֵ
                        string frind5 = frind1.Substring(0, index);  //��ȡû�����Ĳ���
                        string frind2 = frind1.Substring(index + 5); //��ȡû�����Ĳ���
                        string str = frind5 + frind2;
                        sql = "update dbo.Friend set friend='" + str + "' where id='" + Login.denglu + "'"; //���¹ҺŲ��˵�SQL���
                        Getzsgc(sql);//���÷���ִ��SQL���
                        Getguahao(sql);  //���¶�ȡ����
                    }
                    
                }
                catch (Exception)
                {
                    MessageBox.Show("û�в�����");
                }
            }
        }

        private void picfind_Click(object sender, EventArgs e)
        {
            string sql = "";
            Getcount(sql);//���ÿ��Ʋ��˵ķ���
            Getguahao(sql); //��ȡ����
        }

        public string Getguahao(string sql)
        {
            SqlConnection con = DBhelper.Gethelper();
            sql = "select friend from dbo.Friend where id='" + Login.denglu + "'";
            SqlCommand com = new SqlCommand(sql, con);
            con.Open();
            string reng = com.ExecuteScalar().ToString();
            string[] bb = reng.Split('|');  //��'|'�ָ��ַ���
            string kk = "";  //���������洢���˱��
            for (int i = 0; i < bb.Length - 1; i++)
            {
                kk = kk + bb[i] + ","; //��","���ָ������ַ���
            }
            if (kk.Length > 0)
            {
                //��ѯָ��ֵ��SQL���
                sql = "select pid,pname,page,psex,adds,data from [user] where pid in (" + kk.Substring(0, kk.Length - 1) + ")";
                DataSet ds = Getds(sql);
                this.dgv1.DataSource = ds.Tables[0]; //�¹ҺŲ������DataGredview
            }
            else
            {
                DataSet ds = new DataSet("a"); //����ds����
                this.dgv1.DataSource = ds.Tables["a"];//�������dgv1
            }

            return sql;
        }

        private void BtnYingZheng_Click(object sender, EventArgs e)
        {
            this.lblCount.Text = Convert.ToString((Convert.ToInt32(this.lblCount.Text) - 1));
            btnTiJiao objbtn = new btnTiJiao(); //����objbtn����
            objbtn.Show();  //��ʾbtnTiJiao����
            this.BtnYingZheng.Visible = false;
            this.dgvinfo.Visible = false;
            this.btnfind.Visible = true;
            this.dgv1.Visible = true;
            this.btnagin1.Visible = true;
        }
        //�����ɾ�Ĳ�ķ���
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
