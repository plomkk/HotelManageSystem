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
    public partial class Checkin : Form
    {
        public Checkin()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select * from [order] where [ID]=" + textBox1.Text.Trim();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            Console.WriteLine(dt.Tables.Count);
            Console.WriteLine(dt.Tables);
            if (dt.Tables[0].Rows.Count != 0)//如果查询到记录则显示
            {
                String sql1 = "update [order] set [id_room]=" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + ",[price]=" + dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() + " where [ID]=" + textBox1.Text.Trim();
                String sql2 = "update [order] set [state]='已入住'";
                String sql3 = "update [room] set [state]='使用中'where [ID]=" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                SqlCommand cmd1 = new SqlCommand(sql1, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                SqlCommand cmd3 = new SqlCommand(sql3, conn);
                cmd1.CommandText = sql1;
                cmd2.CommandText = sql2;
                cmd3.CommandText = sql3;
                cmd1.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                cmd3.ExecuteNonQuery();
                MessageBox.Show("入住办理成功");
                conn.Close();
               
            }
            else//没有记录则查询失败
            {
                MessageBox.Show("没有此订单号", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select * from [room] where [type]='" + Room.Text.Trim() + "' and state='空闲'";
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
                MessageBox.Show("没有空闲房间", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void Checkin_Load(object sender, EventArgs e)
        {
            Room.Items.Add("单人房");
            Room.Items.Add("双人房");
            Room.Items.Add("三人房");
            Room.Items.Add("豪华套房");
            Room.Items.Add("蜜月套房");
            Room.Items.Add("商务套房");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            stage s = new stage();
            s.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            客房预定 S = new 客房预定(1);
            S.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
