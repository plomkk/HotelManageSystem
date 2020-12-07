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
    public partial class 前台线下预定 : Form
    {
        public 前台线下预定()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-0GCTIPK\\MSSQLSERVER1;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String sql = "insert into order(ID,name1,id_name1,name2,id_name2,name3,id_name3,type_room,price,checkin_date,checkout_date,numberofdays,phonenumber,state)values('" + D1.Text.Trim() + "','" + G1.Text.Trim() + "','" + S1.Text.Trim() + "','" + G2.Text.Trim() + "','" + S2.Text.Trim() + "','" + G3.Text.Trim() + "','" + S3.Text.Trim() + "','" + F.Text.Trim() + "','" + M.Text.Trim() + "','" +R.Text.Trim() + "','" +T.Text.Trim() + "','" +int.Parse(D.Text.Trim()) + "','" +L.Text.Trim() + "','" +int.Parse(Z.Text.Trim()) + "')";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            Z.Text = "未入住";
            sqlCommand.ExecuteNonQuery();
            Console.WriteLine("增加数据成功");
            conn.Close();
        }
        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            stage s = new stage();
            s.Show();
        }
    }
}
