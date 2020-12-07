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
            String sql = "insert into [order]([ID],name1,id_name1,name2,id_name2,name3,id_name3,type_room,price,checkin_date,checkout_date,numberofdays,phonenumber,state)values('" + ID.Text + "','" + name1.Text.Trim() + "','" + id_name1.Text.Trim() + "','" + name2.Text.Trim() + "','" + id_name2.Text.Trim() + "','" + name3.Text.Trim() + "','" + id_name3.Text.Trim() + "','" + type_room.Text.Trim() + "','" +Int32.Parse( price.Text.Trim()) + "','" +checkin_date.Text.Trim() + "','" +checkout_date.Text.Trim() + "','" +Int32.Parse(numberofdays.Text.Trim()) + "','" +phonenumber.Text.Trim() + "','" +state.Text.Trim()+ "')";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);
            state.Text = "未入住";
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

        private void 前台线下预定_Load(object sender, EventArgs e)
        {

        }
    }
}
