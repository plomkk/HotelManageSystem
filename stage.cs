using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 酒店管理系统
{
    public partial class stage : Form
    {
        public stage()
        {
            InitializeComponent();
        }

        private void 功能1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
          前台查询订单信息 C = new 前台查询订单信息();
            C.Show();
            this.Hide();
            
        }

        private void 功能2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客房预定 S = new 客房预定(1);
            S.Show();
            this.Hide();
        }

        private void stage_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void 功能3ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void RoomInfo_Click(object sender, EventArgs e)
        {
            RoomInfo Room = new RoomInfo();
            Room.Show();
            this.Hide();
        }

        private void Checkin_Click(object sender, EventArgs e)
        {
            Checkin checkin = new Checkin();
            checkin.Show();
            this.Hide();
        }

        private void CheckOut_Click(object sender, EventArgs e)
        {
            CheckOut checkout = new CheckOut();
            checkout.Show();
            this.Hide();
        }

        private void 功能4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            前台修改订单信息 s = new 前台修改订单信息();
            this.Hide();
            s.Show();
        }
    }
}
