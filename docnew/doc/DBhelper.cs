using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace doc
{
    /// <summary>
    /// ����ά�����ݿ������ַ����� Connectin ����
    /// </summary>
    class DBhelper
    {
        public static SqlConnection Gethelper()
        {
            try
            {
                    //���ݿ���������
                    string url = "data source=140.143.95.23;initial catalog=DOC;user id=sa;pwd=1111qqqq@";
                    //���ݿ����� Connectin ����
                    return new SqlConnection(url);
            }
            catch (Exception)
            {
                 throw;
            }
           
        }
    }
}
