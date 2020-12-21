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
    public partial class RoomInfo : Form
    {
        int flag;
        public RoomInfo(int f)
        {
            InitializeComponent();
            flag = f;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "select * from [room] where [id]='"+textBox1.Text.Trim()+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL,conn);
            DataSet dt = new DataSet();
            Console.WriteLine(dt.Tables.Count);
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "房间ID";
            dataGridView1.Columns[1].HeaderText = "房间类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "容纳人数";
            dataGridView1.Columns[4].HeaderText = "状态";
            if (dt.Tables[0].Rows.Count != 0)//如果查询到记录则显示
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

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "select * from [room]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "房间ID";
            dataGridView1.Columns[1].HeaderText = "房间类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "容纳人数";
            dataGridView1.Columns[4].HeaderText = "状态";
            if (dt.Tables[0].Rows.Count != 0)//如果查询到记录则显示
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

        private void RoomInfo_Load(object sender, EventArgs e)
        {
            Room.Items.Add("单人房");
            Room.Items.Add("双人房");
            Room.Items.Add("三人房");
            Room.Items.Add("豪华套房");
            Room.Items.Add("蜜月套房");
            Room.Items.Add("商务套房");

            type.Items.Add("绿野仙踪");                                                                               
            type.Items.Add("海洋公园");                                                                                            
            type.Items.Add("天空之镜");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                customer s = new customer();
                s.Show();
                this.Hide();
            }
            else
            {
                stage s = new stage();
                s.Show();
                this.Hide();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select * from [room] where [type]='" + Room.Text.Trim()+"'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "房间编号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "容量";
            dataGridView1.Columns[4].HeaderText = "状态";
            if (dt.Tables[0].Rows.Count != 0)//如果查询到记录则显示
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


        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select * from [room] where [theme]='" + type.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "房间编号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "容量";
            dataGridView1.Columns[4].HeaderText = "状态";
            if (dt.Tables[0].Rows.Count != 0)//如果查询到记录则显示
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
    }
}
