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
            String sql1 = "update [order] set [id_room]=" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + ",[price]="+ dataGridView1.CurrentRow.Cells[2].Value.ToString().Trim()+" where [ID]=" + textBox1.Text.Trim();
            String sql2 = "update [order] set [state]='已入住'";
            String sql3 = "update [room] set [state]='不可用'where [ID]="+ dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
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
            String strSQL = "Select * from [room] where [type]='" + Room.Text.Trim() + "' and state='可用'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "房间编号";
            dataGridView1.Columns[1].HeaderText = "类型";
            dataGridView1.Columns[2].HeaderText = "价格";
            dataGridView1.Columns[3].HeaderText = "容量";
            dataGridView1.Columns[4].HeaderText = "状态";
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
    }
}
