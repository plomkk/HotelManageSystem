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
    public partial class 顾客_查询订单 : Form
    {
        public 顾客_查询订单()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select* from [order] where [name1]='" + name.Text.Trim()+ "'and [id_name1]='" + id_number.Text.Trim() + "'"; 
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
                MessageBox.Show("查询成功");
                SqlCommand comm = new SqlCommand(strSQL, conn);
                conn.Close();
               
            }
            else//没有记录则查询失败
            {
                MessageBox.Show("查询失败");
            }
            



        }
    }
}
