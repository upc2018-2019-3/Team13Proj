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
    public partial class Newusers : Form
    {
        public Newusers()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            int accounts = 0;
            string sex = "��";  //Ĭ���Ա�Ϊ��
            if (this.radiogirl.Checked == true)  
            {
                sex = "Ů";
            }
            string type = "�Һ�̨";
            if (this.DrRadio.Checked == true)
            {
                type = "ҽ��";
            }
            //�ж��û��������룬���ң����䲻��Ϊ��
            if (this.trueName.Text.Trim() == "")
            {
                MessageBox.Show("�û�������Ϊ��");
                this.Focus();
                return;
            }
            if (this.code.Text.Trim() == "")
            {
                MessageBox.Show("���벻��Ϊ��");
                this.Focus();
                return;
            }
            if (this.DrRadio.Checked == true && this.subjectText.Text == "")
                
            {
                MessageBox.Show("���Ҳ���Ϊ��");
                this.Focus();
                return;
            }
            if (this.ageAasked.Text.Trim() == "")
            {
                MessageBox.Show("���䲻��Ϊ��");
                this.Focus();
                return;
            }
            //�����ݿ����ע���SQL���
            string sql = "insert into dbo.login values (" + this.code.Text.Trim() + ",'" + this.trueName.Text.Trim() + "','" + sex + "'," + this.ageAasked.Text.Trim() + ",'" + type + "','" + this.subjectText.Text.Trim() + "')";
            SqlConnection con = DBhelper.Gethelper();//����DBhelp���еķ������������ݿ�
            SqlCommand com = new SqlCommand(sql, con);//����command����ִ��SQL���
            con.Open();
            int count = com.ExecuteNonQuery();
            con.Close();
            if (count > 0)         //�ж����ݿ�����Ӱ�������
            {
                con.Open();
                string sql1 = "select top 1 uid from dbo.login order by uid desc"; //�����ݿ��е����ݰ��������в����ҳ���һ��                
                com.CommandText = sql1;
                accounts = Convert.ToInt32(com.ExecuteScalar());//�����ʺ�
                string Message = string.Format("ע��ɹ��������ʺ���{0}", accounts);
                MessageBox.Show(Message, "ע��ɹ�", MessageBoxButtons.OK, MessageBoxIcon.Information);
                con.Close();
            }
            sql = "insert into dbo.Friend(id,kemu,name) values(" + accounts + ",'" + this.subjectText.Text + "','" + this.trueName.Text + "')";
            Mindoc.Getzsgc(sql);
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            this.subject.Visible = false; //�����ѡ��Һ�̨��ť�󽫿�������
            this.subjectText.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            this.subject.Visible = true;//�����ҽ����������ʾ����
            this.subjectText.Visible = true;
        }
    }
}