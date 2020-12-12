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
    public partial class Earnings : Form
    {
        public Earnings()
        {
            InitializeComponent();
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-MGER175;Initial Catalog=Hotel;Integrated Security=True");
            conn.Open();
            String strSQL = "Select [ID],[id_room],[type_room],[price] from [order] where [state]='已退房'";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSQL, conn);
            DataSet dt = new DataSet();
            sqlDataAdapter.Fill(dt);
            dataGridView1.DataSource = dt.Tables[0];
            dataGridView1.Columns[0].HeaderText = "订单编号";
            dataGridView1.Columns[1].HeaderText = "房间号";
            dataGridView1.Columns[2].HeaderText = "房型";
            dataGridView1.Columns[3].HeaderText = "收益";

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
