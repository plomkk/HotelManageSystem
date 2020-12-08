using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店管理系统
{
    public partial class 取消订单 : Form
    {
        int flag;
        public 取消订单(int f)
        {
            InitializeComponent();
            flag = f;
        }

        private void 取消订单_Load(object sender, EventArgs e)
        {


        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0GCTIPK\\MSSQLSERVER1;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            DialogResult dr = MessageBox.Show("确定删除此订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                string sql = "delete from [order] where [ID]='" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();
                MessageBox.Show("已成功删除所选订单，预订取消成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Show();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                this.Close();
                stage s = new stage();
                s.Show();
            }
            else
            {
                this.Close();
                customer c = new customer();
                c.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0GCTIPK\\MSSQLSERVER1;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select* from [order] where ([id_name1]='" + id_name.Text.Trim() + "'or[id_name2]='" + id_name.Text.Trim() + "'or [id_name3]='" + id_name.Text.Trim() + "')";
            SqlDataAdapter adp = new SqlDataAdapter(strSQL, conn);//建立一个数据适配器和数据集
            DataSet ds = new DataSet();
            adp.Fill(ds);//把查询的内容放入数据集中
            dataGridView1.DataSource = ds.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单编号";
            dataGridView1.Columns[1].HeaderText = "顾客1";
            dataGridView1.Columns[2].HeaderText = "身份证号1";
            dataGridView1.Columns[3].HeaderText = "顾客2";
            dataGridView1.Columns[4].HeaderText = "身份证号2";
            dataGridView1.Columns[5].HeaderText = "顾客3";
            dataGridView1.Columns[6].HeaderText = "身份证号3";
            dataGridView1.Columns[7].HeaderText = "房间号";
            dataGridView1.Columns[8].HeaderText = "房间类型";
            dataGridView1.Columns[9].HeaderText = "订单价格";
            dataGridView1.Columns[10].HeaderText = "入住时间";
            dataGridView1.Columns[11].HeaderText = "退房时间";
            dataGridView1.Columns[12].HeaderText = "入住天数";
            dataGridView1.Columns[13].HeaderText = "联系方式";
            dataGridView1.Columns[14].HeaderText = "订单状态";
            if (ds.Tables[0].Rows.Count != 0)//如果查询到记录则显示
            {
                MessageBox.Show("查询成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                SqlCommand comm = new SqlCommand(strSQL, conn);
                conn.Close();

            }
            else//没有记录则查询失败
            {
                MessageBox.Show("查询失败", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

       
    }
}
