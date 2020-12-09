using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店管理系统
{
    public partial class 前台修改订单信息 : Form
    {
        public 前台修改订单信息()
        {
            InitializeComponent();
        }

        private void 前台修改订单信息_Load(object sender, EventArgs e)
        {
            //打开数据库连接
            String mycon = @"Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(mycon);//新建数据库连接实例
            sqlConnection.Open();

            SqlDataAdapter adp1 = new SqlDataAdapter("select distinct type from room", sqlConnection);//从room表中筛选出所有客房的类型
            DataSet ds1 = new DataSet();//建立DataSet对象
            adp1.Fill(ds1);//把筛选出的客房类型填入数据集中
            type.DisplayMember = "type";//要为此控件显示的属性
            type.ValueMember = "type";//控件中项实际值的属性
            type.DataSource = ds1.Tables[0].DefaultView;//获取combox的数据源

            SqlDataAdapter adp2 = new SqlDataAdapter("select ID from [order]", sqlConnection);//从order表中筛选出所有客房的类型
            DataSet ds2 = new DataSet();//建立DataSet对象

            adp2.Fill(ds2);//把筛选出的订单编号填入数据集中
            id_order.DisplayMember = "ID";//要为此控件显示的属性
            id_order.ValueMember = "ID";//控件中项实际值的属性
            id_order.DataSource = ds2.Tables[0].DefaultView;//获取combox的数据源


            sqlConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            stage c = new stage();
            this.Close();
            c.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //打开数据库连接
            String mycon = @"Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True";//数据库实例连接字符串
            SqlConnection sqlConnection = new SqlConnection(mycon);//新建数据库连接实例
            sqlConnection.Open();

            try
            {
                DialogResult dr = MessageBox.Show("确定修改此订单？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    String strSQL = "Select* from [order] where [ID]='" + id_order.Text.Trim() + "'";
                    SqlDataAdapter adp = new SqlDataAdapter(strSQL, mycon);//建立一个数据适配器和数据集
                    DataSet ds = new DataSet();
                    adp.Fill(ds);//把查询的内容放入数据集中

                    string sql = "update [order] set [ID]='" + id_order.Text.Trim() + "',[name1]='" + name1.Text.Trim() + "',[name2]='" + name2.Text.Trim() + "',[name3]='" + name3.Text.Trim() + "',[id_name1]='" + id_number1.Text.Trim() + "',[id_name2]='" + id_number2.Text.Trim() + "',[id_name3]='" + id_number3.Text.Trim() + "',[type_room]='" + type.Text.Trim() + "',[phonenumber]='" + phonenumber.Text.Trim() + "',[checkin_date]='" + checkin_date.Text.Trim() + "',[checkout_date]='" + checkout_date.Text.Trim() + "',[numberofdays]='" + Int32.Parse(numberofdays.Text.Trim()) + "'";
                    SqlCommand cmd = new SqlCommand(sql, sqlConnection);
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                    int numberofday = Int32.Parse(numberofdays.Text);
                    int totalmoney;

                    if (type.Text.Trim() == "单人房")
                    {
                        totalmoney = 330 * numberofday;
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();

                    }
                    else if (type.Text.Trim() == "双人房")
                    {
                        totalmoney = 440 * numberofday;
                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (type.Text.Trim() == "三人房")
                    {
                        totalmoney = 550 * numberofday;
                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (type.Text.Trim() == "豪华套房")
                    {
                        totalmoney = 660 * numberofday;
                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (type.Text.Trim() == "蜜月套房")
                    {
                        totalmoney = 990 * numberofday;
                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else if (type.Text.Trim() == "商务套房")
                    {
                        totalmoney = 880 * numberofday;
                        String sql2 = "update [order] set [price]='" + totalmoney + "' where [ID]='" + id_order.Text.Trim() + "'";
                        SqlCommand cmd2 = new SqlCommand(sql2, sqlConnection);
                        cmd.CommandText = sql2;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("订单修改成功！您修改后的订单金额为" + totalmoney + "元", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch { }



        }
    }
}
