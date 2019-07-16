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
    /// �ҺŴ��壬�鿴ҽ������ʵ�ֹҺŹ���
    /// </summary>
    public partial class Relook : Form
    {
        private DataSet ds = new DataSet();                      //����DataSet����
        private SqlDataAdapter da;                                //����SqlDataAdapter����
        public static string name1;                              //������̬����
        public static string office1;                            //���Ҿ�̬����
        public Relook()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='ҽ��'";
            da = new SqlDataAdapter(sql, con);                   //SqlDataAdapter�������
            con.Open();                                          //������
            da.Fill(ds);                                //������ݼ� 
            this.dataGridView1.DataSource = ds.Tables[0];        //Դ��login
        }
        
        private void btnserchn_Click(object sender, EventArgs e)      //��ѯҽ��������ť
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='ҽ��' and uname='" + this.txtsen.Text.Trim() + "'";
            da = new SqlDataAdapter(sql, con);
            con.Open();                                              //DataSet����
            ds.Reset();
            da.Fill(ds, "login");
            dataGridView1.DataSource = ds.Tables["login"];
        }
        private void btncancle_Click(object sender, EventArgs e)      //ȡ����ť
        {
            this.Dispose();                                         //�˴�������
            register obj = new register();                          //�ҺŲ�ѯ�������
            obj.Show();
        }
        private void btnok_Click(object sender, EventArgs e)      //ȷ����ť
        {
            SqlConnection con = DBhelper.Gethelper();
            con.Open();
            string sid = Convert.ToString(register.Num);            //����sid������ȡǿתString���register���Num����
            string sid1 = sid + "|";                                //����sid1������ȡsid��"|"
            int tem = 0;                                            //����int�͵�tem����

            if (dataGridView1.SelectedCells.Count == 0)             //�ж��û���δѡ��dataGridView�ĵ�Ԫ��
            {
                MessageBox.Show("��ѡ��һ��ҽ����", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else                                                    //��ȡ��ǰѡ�е���һ�е�һ����Ԫ���ֵ��obj��תΪString��ǿתint����tem����           
            {
                tem = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                string sql1 = "select friend from Friend where id='" + tem + "'";    //��ѯ����Ϊҽ����id
                SqlCommand com = new SqlCommand(sql1, con);
                try
                {
                    string bianhao = com.ExecuteScalar().ToString();                 //��string��bianhao�������շ��ص�ֵ
                    string sidd = bianhao + sid1;                                   //��bianhao��sid1��������sidd
                    sql1 = "update Friend set friend='" + sidd + "' where id='" + tem + "'";     //��sidd��ֵ���µ�����Ϊ��ҽ��id�ŵ���friend����
                    Getz(sql1);                                       //���� Getz����ִ��
                    MessageBox.Show("�Һųɹ���");                    //�ɹ��󷵻ز�ѯ�ҺŴ���
                    register obj = new register();
                    obj.Show();
                    this.Hide();                                      //�ô�������
                }
                catch (Exception)
                {
                    MessageBox.Show("ѡ���д�", "��ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            con.Close();                                           //�ر�����
        }
        public static bool Getz(string sql1)                      //��̬bool�͵�Getz����
        {
            SqlConnection con1 = DBhelper.Gethelper();            //���� SqlConnection����
            SqlCommand com2 = new SqlCommand(sql1, con1);
            con1.Open();
            int count = com2.ExecuteNonQuery();                  //������Ӱ�������
            if (count > 0)                                       //�����Ӱ������
            {                                                     //����true
                return true;
            }                 
            else
            {
                return false;
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtuname.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();       //����ҽ������
            this.txtoffice.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();      //����ҽ������
        }

        private void btnsercho_Click_1(object sender, EventArgs e)
        {
            SqlConnection con = DBhelper.Gethelper();
            string sql = "select uid,uname,office from [login] where stata='0' and type='ҽ��' and office='" + this.txtseo.Text.Trim() + "'";
            da = new SqlDataAdapter(sql, con);
            con.Open();                                           //���տ��Ҳ�ѯ�����ҵ��ÿ���ҽ��
            ds.Reset();                                            //DataSet����
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