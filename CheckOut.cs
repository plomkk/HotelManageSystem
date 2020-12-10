﻿using System;
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
    public partial class CheckOut : Form
    {
        public CheckOut()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select* from [order] where [id]='" + textBox1.Text.Trim() + "'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = "btnModify";
            btn.HeaderText = "退住修改";
            btn.DefaultCellStyle.NullValue = "退住";
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
            dataGridView1.Columns.Add(btn);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "btnModify")
            {
                DataGridViewColumn column = dataGridView1.Columns[e.ColumnIndex];
                SqlConnection conn = new SqlConnection("Data Source=DESKTOP-RD7CTBN;Initial Catalog=Hotel;Integrated Security=True");
                conn.Open();
                String strSQL = "Update [order] Set state='未入住'";
                SqlCommand cmdUpdate = new SqlCommand(strSQL, conn);
                int result = cmdUpdate.ExecuteNonQuery();
                if (result == 1)
                {
                    Console.WriteLine("更新记录操作成功");
                    MessageBox.Show("已成功退房");
                }
                else
                {
                    Console.WriteLine("更新记录操作失败");
                }
            }
        }
    }
}
