﻿using System;
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
    public partial class customer : Form
    {
        public customer()
        {
            InitializeComponent();
        }

        private void 功能1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            顾客查询订单信息 C = new 顾客查询订单信息();
            C.Show();
            this.Hide();
        }

        private void customer_Load(object sender, EventArgs e)
        {

        }

        private void 功能2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            顾客修改订单信息 c = new 顾客修改订单信息();
            c.Show();
            this.Hide();
        }

        private void 线上预订ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            客房预定 S = new 客房预定(0);
            S.Show();
            this.Hide();
        }
    }
}
