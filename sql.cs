using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;//引用数据库里用到
using System.Data.SqlClient;//连接SQL所使用的命名空间（sqlconnection）

namespace 酒店管理系统
{
    class SQL
        
    {
        private string sqlstr = "Data Source=DESKTOP-MGER175;Initial Catalog=Hotel;Integrated Security=True";
        //连接字符串连接数据库   https://www.csdn.net/gather_2e/MtTaYg2sMjMxLWJsb2cO0O0O.html
        private SqlConnection con;  //https://blog.csdn.net/susan19890313/article/details/6980393
        private SqlCommand cmd;  //https://blog.csdn.net/feiduan1211/article/details/81541477
        public SQL()
        {
            con = new SqlConnection(sqlstr);
            cmd = con.CreateCommand();
        }
        public void Exec(string sqlText)
        {
            con.Open();  //连接处于打开状态
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlText;
            cmd.ExecuteNonQuery();
            con.Close();//关闭连接
        }
        public DataTable ExecRt(string sqlText)
        {
            con.Open();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlText;
            //cmd.ExecuteNonQuery();
            DataSet dt = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);//创建数据适配器实例
            adapter.Fill(dt);//使用方法填充，调用dt命令
            DataTable myTable = null;
            if (dt.Tables.Count != 0)     //如果dt中表数目不为空
                myTable = dt.Tables[0];//返回第一个表格数据
            con.Close();
            return myTable;
        }
    }
}
