using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace doc
{
    /// <summary>
    /// 此类维护数据库连接字符串和 Connectin 对象
    /// </summary>
    class DBhelper
    {
        public static SqlConnection Gethelper()
        {
            try
            {
                    //数据库连接资料
                    string url = "data source=140.143.95.23;initial catalog=DOC;user id=sa;pwd=1111qqqq@";
                    //数据库连接 Connectin 对象
                    return new SqlConnection(url);
            }
            catch (Exception)
            {
                 throw;
            }
           
        }
    }
}
