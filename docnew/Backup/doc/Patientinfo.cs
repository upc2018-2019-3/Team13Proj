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
    /// ҽ�����壬��ʾ���Ӧ�﹦��
    /// </summary>
    public partial class btnTiJiao : Form
    {
        public btnTiJiao()
        {
            InitializeComponent();
        }

        private void btnTiJiao_Load(object sender, EventArgs e)
        {
            //��ѯҽ�������Ϳ��ҵ�SQL���
            string sql = "select uname,office from dbo.login where uid='"+Login.denglu+"'";
            DataSet ds = Mindoc.Getds(sql);   //����ds����
            lblDocName1.Text = ds.Tables[0].Rows[0][0].ToString();  
            lblKemuName1.Text = ds.Tables[0].Rows[0][1].ToString();


            //��ѯ�¹ҺŲ��˵�SQL���
            sql = "select psfz,pname,page,psex,blood,phone,adds,data from [user] where pid='" + Mindoc.name1 + "'"; 
            ds = Mindoc.Getds(sql);  //����ds����
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
            //ʹ��try  catch �ж����䲻��Ϊ�ַ�
            try
            {
                double mn = Convert.ToDouble(this.txtMoney.Text);
                //�жϳɹ�ִ��SQL���
                string sql = "insert into bingkuang values ('" + this.txtnum.Text.Trim() + "','" + this.txtName.Text.Trim() + "','" + this.txtSex.Text.Trim() + "','" + this.txtage.Text.Trim() + "','" + this.txtBlood.Text.Trim() + "','" + this.txtPhone.Text.Trim() + "','" + this.txtBingKuang.Text.Trim() + "'," + mn + ",'" + this.txtAdds.Text.Trim() + "')";
                if (Mindoc.Getzsgc(sql))
                {
                    MessageBox.Show("�����ɹ�");
                    this.Hide(); //����������
                }
                else
                {
                    MessageBox.Show("����ʧ��");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("�����ʽ����ȷ","������ʾ",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Show();
                this.txtMoney.Focus();//������벻�����ַ��ص�txtMoney�ı���
            }
        }

        private void btnAgin_Click(object sender, EventArgs e)
        {
            this.txtMoney.Clear(); //���txtMoney�ı���
            this.txtBingKuang.Clear();//���txtBingKuang�ı���
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); //�رձ�����
           
        }

    }
}