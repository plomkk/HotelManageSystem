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
    public partial class 客房预定 : Form
    {
        int flag;
        public 客房预定(int f)
        {
            InitializeComponent();
            flag = f;

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

            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String sql = "insert into [order]([ID],[name1],[id_name1],[name2],[id_name2],[name3],[id_name3],[type_room],[checkin_date],[checkout_date],[numberofdays],[phonenumber],[state])values('" + ID.Text.Trim() + "','" + name1.Text.Trim() + "','" + id_name1.Text.Trim() + "','" + name2.Text.Trim() + "','" + id_name2.Text.Trim() + "','" + name3.Text.Trim() + "','" + id_name3.Text.Trim() + "','" + type_room.Text.Trim() + "','" + checkin_date.Text.Trim() + "','" + checkout_date.Text.Trim() + "','" + Int32.Parse(numberofdays.Text) + "','" + phonenumber.Text.Trim() + "','未入住')";
            SqlCommand sqlCommand = new SqlCommand(sql, conn);

            sqlCommand.ExecuteNonQuery();
            MessageBox.Show("预订成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            int Day = Int32.Parse(numberofdays.Text);
            int price;
            if (type_room.Text.Trim() == "单人间")
            {
                price = 330 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            else if (type_room.Text.Trim() == "双人间")
            {
                price = 440 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            else if (type_room.Text.Trim() == "三人间")
            {
                price = 550 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            else if (type_room.Text.Trim() == "豪华套房")
            {
                price = 660 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            else if (type_room.Text.Trim() == "蜜月套房")
            {
                price = 999 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }
            else if (type_room.Text.Trim() == "商务套房")
            {
                price = 880 * Day;
                MessageBox.Show("您的订单金额为" + price + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                String sql1 = "update [order] set [price]='" + price + "' where [ID]='" + ID.Text.Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql1, conn);
                cmd.CommandText = sql1;
                cmd.ExecuteNonQuery();
            }



        }
        private void label14_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void 前台线下预定_Load(object sender, EventArgs e)
        {

        }

        private void id_name3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
