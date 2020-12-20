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
    public partial class Form1 : Form
    {
        String userid = null;
        String iden;        //身份identify顾客/前台/管理
        String name;
        SQL sql = new SQL(); //sql.cs里创建的类
        DataTable dt = new DataTable();//建一个数据表存返回结果  https://www.cnblogs.com/scmail81/p/9355112.html
        String s;
        
        public Form1()
        {
            InitializeComponent();
            tip.Hide();
            login_success.Hide();
            panel1.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
          
        }
      
        private void login_Click(object sender, EventArgs e)
        {
            String id = user_id.Text;
            String pwd =user_pwd.Text;  
            if (isCustomer.Checked)
                iden = "customer";
            else if (isStage.Checked)
                iden = "stage";
            else
                iden = "admin";
           dt = sql.ExecRt("exec login '" + id + "','"+iden+ "','" + pwd + "','"+ name +"'" );


            if (dt.Rows.Count == 0)//如果表中行为0
            {
                tip.Show();//标签提示失败
            }
            else //成功登陆
            {
                if(iden=="customer")
                {
                    customer C = new customer();
                    C.Show();
                    this.Hide();
                   
                }
                else if (iden == "stage")
                {
                    stage S = new stage();
                    S.Show();
                    this.Hide();
                }
                else
                {
                    admin a = new admin();
                    a.Show();
                    this.Hide();
                }
                userid = id;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void register_Click(object sender, EventArgs e)
        {
            register_panel.Show();
            login_success.Hide();
            panel1.Hide();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            register_panel.Hide();
            login_success.Hide();
            panel1.Show();
            tip.Hide();
        }

        private void button2_Click(object sender, EventArgs e)//注册按钮
        {
            String iden;
            name = re_name.Text;
           
            if (isCustomer.Checked)
                iden = "customer";
            else if (isStage.Checked)
                iden = "stage";
            else
                iden = "admin";
            s = "exec register '" + re_id.Text + "','" + iden + "','" + re_pwd.Text + "','" + re_name.Text + "'";
            dt = sql.ExecRt(s);
            if (dt != null && dt.Rows.Count > 0)//注册失败
            {
                tip2.Text = "fail:"+dt.Rows[0][0].ToString();
            }
            else
            {
                tip2.Text = "注册成功";
            }
        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel1.Show();
            login_success.Hide();
            register_panel.Hide();
        }

        private void tip_Click(object sender, EventArgs e)
        {

        }

        private void login_success_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
