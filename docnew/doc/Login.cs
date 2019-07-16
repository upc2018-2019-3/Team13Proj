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
            obj.Show();//��ת��ע�ᴰ��
        }

        private void land_Click(object sender, EventArgs e)
        {


            try
            {
                //�ж��û��������룬��½���Ͳ���Ϊ��
                if (this.num.Text.Trim() == "")
                {
                    MessageBox.Show("�������û���");
                    this.Focus();
                    return;
                }
                else if (this.pwdText.Text.Trim() == "")
                {
                    MessageBox.Show("����������");
                    this.Focus();
                    return;
                }
                else if (this.userType.Text.Trim() == "")
                {
                    MessageBox.Show("�û����Ͳ���Ϊ��");
                    this.Focus();
                    return;
                }
            }
            catch
            {
                throw;
            }
              denglu =Convert.ToInt32(this.num.Text.Trim());//���ı����ֵ������̬����
            //����½����Ϊ�Һ�̨ʱ���һ�ȡ��ȷ���ʺ����������ת�Һ�̨����
    if (this.userType.Text == "�Һ�")
            {

                string sql = "select count(*) from dbo.login where uid='" + this.num.Text.Trim().ToString() + "'and pwd='" + this.pwdText.Text.Trim().ToString() + "' and type='�Һ�̨'";

                bool yn = loginType(sql);//����loginType����
                if (yn == true)
                {
                    uc objreg = new uc();
                    objreg.Show();
                }
                else
                {
                    MessageBox.Show("�ʺŻ��������");
                    return;
                }
            }
            //����½����Ϊҽ��ʱ���һ�ȡ��ȷ���ʺ����������ת��ҽ������
            if (this.userType.Text == "ҽ��")
            {

                string sql = "select count(*) from dbo.login where uid='" + this.num.Text.Trim().ToString() + "'and pwd='" + this.pwdText.Text.Trim().ToString() + "'and type='ҽ��'";

                bool yn = loginType(sql);//����loginType����
                if (yn == true)
                {
                    sql = "update [login] set stata=0 where uid='"+denglu+"'";
                    if (Mindoc.Getzsgc(sql))//���÷���ִ��SQL���
                    {
                        Mindoc objmin = new Mindoc();
                        objmin.Show();//��ҽ������
                    }
                
                }
                else
                {
                    MessageBox.Show("�ʺŻ��������");
                    return;
                }
            }
            this.Hide();//����������
        }
        //����loginType������һ��sql����
        public bool loginType(string sql)
        {
            int count = 0;

            SqlConnection con = DBhelper.Gethelper();//�������ݿ�
            try
            {
                SqlCommand com = new SqlCommand(sql, con);//����command������SQL���
                con.Open();
                count = (int)com.ExecuteScalar();//����һ��һ�е�ֵ
                if (count == 1)//������ֵ����1�ͷ���return
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
                con.Close();//�ر�����
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
