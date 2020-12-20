using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 酒店管理系统
{
    public partial class 管理_修改房间信息 : Form
    {
        public 管理_修改房间信息()
        {
            InitializeComponent();
        }

        private void 管理_修改房间信息_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";
            //"user id=sa;pwd=;";
            SqlConnection con = new SqlConnection(constr);
            string sql = "select ID from room";
            SqlCommand com = new SqlCommand(sql, con);
            try
            {
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(com);
                ada.Fill(dt);
                cb_id.DataSource = dt;
                cb_id.DisplayMember = "ID";
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据库连接异常，详细信息：" + ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void bt_sure_Click(object sender, EventArgs e)
        {
            String mycon = @"Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(mycon);//新建数据库连接实例
            sqlConnection.Open();
            DialogResult dr = MessageBox.Show("确定修改？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                String strSQL = "Select State from [room] where [ID]='" + cb_id.Text.Trim() + "'";
                SqlDataAdapter adp = new SqlDataAdapter(strSQL, mycon);//建立一个数据适配器和数据集
                DataSet ds = new DataSet();
                adp.Fill(ds);//把查询的内容放入数据集中
                String State = "w";
                String theme = "w";
                if (rb_busy.Checked)
                {
                    State = "使用中";
                }
                if (rb_use.Checked)
                {
                    State = "空闲";
                }
                if (rb_fix.Checked)
                {
                    State = "修理";
                }
                else { }
                if (rb_t1.Checked)
                {
                    theme = "绿野仙踪";
                }
                if (rb_t2.Checked)
                {
                    theme = "海洋公园";
                }
                if (rb_t3.Checked)
                {
                    theme = "冰河世纪";
                }
                if (rb_t4.Checked)
                {
                    theme = "天空之镜";
                }
                string sql = "update [room] set [State]='" + State + "',[theme]='" + theme + "' where ID='" + cb_id.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("修改成功");
            }
        }

        private void bt_back_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Close();
            a.Show();
        }
    }
}
