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
    /// ������Ϣ���Һ����в�����������ʵ�ֲ�ѯ���½�����
    /// </summary>
   
    public partial class register : Form
    {
        public static string sfz = "";    //�������֤������ 
        public static int Num = 0;         //�˾�̬�������ڽ����Զ����ɱ��
        private DataSet ds = new DataSet(); //�������ݼ�
        public register()
        {
            InitializeComponent();
        }
        private void �Һ�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;     //����Һţ�����������Ϣ��ѯ���Һ�
            panel1.Visible = true;
        }
        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;      //�˹���ͨ���������ʵ���½���������  
            panel1.Visible = false;
        }
        private void btnUp_Click_1(object sender, EventArgs e)      //�ύ��ť
        {
            sfz = this.txtsfz.Text;                                   //��������ֵ
            if (this.txtsfz.Text.Trim() == "")                        //�ж����֤Ϊ��Ϊ��
            {
                MessageBox.Show("���������֤");
                this.txtsfz.Focus();
            }
            else if (this.txtage.Text.Trim() == "")
            {
                MessageBox.Show("����������");
                this.txtage.Focus();
            }
            else if (this.txtname.Text.Trim() == "")
            {
                MessageBox.Show("��������ʵ����");
                this.txtname.Focus();
            }
            else if (this.txtphone.Text.Trim() == "")
            {
                MessageBox.Show("��������ϵ��ʽ");
                this.txtphone.Focus();
            }
            else if (this.txtadd.Text.Trim() == "")
            {
                MessageBox.Show("������סַ");
                this.txtadd.Focus();
            }
            else
            {
                try
                {
                    long sfz1 = Convert.ToInt64(this.txtsfz.Text);                //�������֤�ı�������ǿתINT�͵����֤�ı����ֵ
                    int age7 = Convert.ToInt32(this.txtage.Text);                //��������ı�������ǿתINT�͵������ı����ֵ
                    if (age7 >= 1 && age7 <= 130)                                      //�ж�����淶
                    {
                        SqlConnection con = DBhelper.Gethelper();                //����SqlConnection����
                        string sex = "��";                                       //����������ʼֵ����
                        if (this.radioButton2.Checked == true)                   //�û�ѡ��İ�ť2��ѡ�еĻ�������Ϊ Ů
                        {
                            sex = "Ů";
                        }
                        string sql = "insert into [user](pname,psex,page,blood,phone,psfz,[money],adds) values('" + this.txtname.Text.Trim() + "','" + sex + "','" + this.txtage.Text.Trim() + "','" + this.cbxblood.SelectedItem.ToString() + "','" + this.txtphone.Text.Trim() + "','" + this.txtsfz.Text.Trim() + "','0','" + this.txtadd.Text.Trim() + "') ";
                        SqlCommand com = new SqlCommand(sql, con);              //��[user]������Ӳ�����Ϣ,����SqlCommand����   
                        con.Open();                                             //������  
                        int temp = com.ExecuteNonQuery();                       //������������SqlCommand�����ExecuteNonQuery����
                        if (temp != 0)
                        {
                            sql = "select top 1 [pid] from [user] order by [pid] desc";     //�������еõ�[user]������ע���û����Զ�������
                            com.CommandText = sql;                                          //��ȡSQL���  
                            Num = Convert.ToInt32(com.ExecuteScalar().ToString());          //�þ�̬��������ǿתINT�͵Ĳ�ѯ�����ص�1��1�е�ֵ��ID
                            string aa = string.Format("���ĹҺű����{0}", Num);
                            MessageBox.Show(aa, "���Ӳ���ע��ɹ���", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            con.Close();                                                    //����aa�������ո�ʽ������ַ�������Ϣ�򵯳��ɹ���Ϣ
                            Relook obj1 = new Relook();                                     //����ע��󼴽���ҺŴ���
                            obj1.Show();
                            this.Hide();                                                    //�˴�������
                        }
                    }
                    else
                    {
                        MessageBox.Show("�����ʽ����ȷ", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtage.Focus();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("����������", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        private void btnserch_Click_1(object sender, EventArgs e)            //��ѯ��ť
        {
            if (this.txtsfz1.Text.Trim() == "")                              //�ж���������֤��ʽ
            {
                MessageBox.Show("������ȷ�����֤��");
                this.txtsfz1.Focus();                                        //��������
                return;
            }
            else
            {
                SqlConnection con = DBhelper.Gethelper();                      //������
                try
                {
                    sfz = this.txtsfz1.Text;                                  //�����������֤��֤�ı���ֵ
                    if (sfz.Length < 18 && sfz.Length > 15)
                    {
                        MessageBox.Show("���֤��ʽ����ȷ", "������ʾ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.txtsfz1.Clear();                                 //ֵ���
                        this.txtsfz1.Focus();                                 //�۽����֤�ı���
                    }
                    else
                    {
                        string sql = "select pname,psex,page,blood,phone,adds from [user] where psfz='" + this.txtsfz1.Text.Trim() + "'";
                        DataSet ds = getds(sql);                                   //��ѯ��δ�й���ʷ�ж��Ƿ��������÷������´������ݼ�
                        txtname1.Text = ds.Tables[0].Rows[0][0].ToString();        //��ֵ�����������ı���
                        txtsex1.Text = ds.Tables[0].Rows[0][1].ToString();
                        txtage1.Text = ds.Tables[0].Rows[0][2].ToString();
                        txtblood.Text = ds.Tables[0].Rows[0][3].ToString();
                        txtphone1.Text = ds.Tables[0].Rows[0][4].ToString();
                        txtadd1.Text = ds.Tables[0].Rows[0][5].ToString();
                        txtbh.Text = Num.ToString();
                    }
                }
                catch (Exception)
                {
                    this.txtsfz1.Clear();
                    MessageBox.Show("δ�ҵ��������ȹҺ�", "�Һ���ʾ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    panel2.Visible = true;                                       //ע�Ს�����ڴ򿪣���ѯ�ҺŴ��ڹر�
                    panel1.Visible = false;
                }
            }
        }
        public static DataSet getds(string sql)                            //��̬getds�����Ա����
        {
            SqlConnection con = DBhelper.Gethelper();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            return ds;
        }
        private void btnrtn_Click(object sender, EventArgs e)              //���ز�ѯ�ҺŴ���
        {
            panel1.Visible = true;
            panel2.Visible = false;
        }
        

        private void txtsfz1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main frm = new main();
            frm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void register_Load(object sender, EventArgs e)
        {

        }

       

        
    }
}