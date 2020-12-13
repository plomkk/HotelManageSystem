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
    public partial class Fix : Form
    {
        public Fix()
        {
            InitializeComponent();
        }

        private void Fix_Load(object sender, EventArgs e)
        {
            string constr = "Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";
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

        private void bt_back_Click(object sender, EventArgs e)
        {
            stage s = new stage();
            this.Close();
            s.Show();
        }

        private void bt_submit_Click(object sender, EventArgs e)
        {
            String mycon = @"Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(mycon);//新建数据库连接实例
            sqlConnection.Open();
            DialogResult dr = MessageBox.Show("确定提交审理？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                String strSQL = "Select State from [room] where [ID]='" + cb_id.Text.Trim() + "'";
                SqlDataAdapter adp = new SqlDataAdapter(strSQL, mycon);//建立一个数据适配器和数据集
                DataSet ds = new DataSet();
                adp.Fill(ds);//把查询的内容放入数据集中
                String concrete = tb_concrete.Text.Trim();
                string sql = "insert into fix(ID,concrete,if_sure) values('" + cb_id.Text.Trim() +"','"+ tb_concrete.Text.Trim()+ "','" + "待审理"+ "')";
                SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("申报修理成功！");
            }
        }
    }
}
