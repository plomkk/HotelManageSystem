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
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void admin_Load(object sender, EventArgs e)
        {

        }

        private void 功能1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Earnings earnings = new Earnings();
            earnings.Show();
            this.Hide();
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 功能2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            管理_修改房间信息 a = new 管理_修改房间信息();
            this.Close();
            a.Show();
        }
    }
}
