using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 酒店管理系统
{
    public partial class 管理_审理报修 : Form
    {
        public 管理_审理报修()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            admin a = new admin();
            this.Close();
            a.Show();
        }

        private void 管理_审理报修_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“hotelDataSet1.fix”中。您可以根据需要移动或删除它。
            this.fixTableAdapter2.Fill(this.hotelDataSet1.fix);
            // TODO: 这行代码将数据加载到表“hotelDatafdname.fix”中。您可以根据需要移动或删除它。
            //this.fixTableAdapter1.Fill(this.hotelDatafdname.fix);

        }

        private void bt_sure_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-U9OI8BO;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            DialogResult dr = MessageBox.Show("请问是否通过审理？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {  
                string sql = "update [fix] set [if_sure]='" + "已确认"+"'where ID='"+dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "'";
                string sqll= "update [room] set [State]='" + "修理" + "'where ID='" + dataGridView1.CurrentRow.Cells[0].Value.ToString().Trim() + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlCommand cmdd = new SqlCommand(sql, conn);
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();   
                cmdd.CommandText = sqll;
                cmdd.ExecuteNonQuery();
               
                MessageBox.Show("已成功通过报修！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);           
            }
            else
            {
                this.Show();
            }
        }
    }
}
