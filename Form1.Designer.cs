namespace 酒店管理系统
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.user_id = new System.Windows.Forms.TextBox();
            this.user_pwd = new System.Windows.Forms.TextBox();
            this.isCustomer = new System.Windows.Forms.RadioButton();
            this.isStage = new System.Windows.Forms.RadioButton();
            this.isAdmin = new System.Windows.Forms.RadioButton();
            this.register = new System.Windows.Forms.Button();
            this.login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tip = new System.Windows.Forms.Label();
            this.login_success = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.register_panel = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.re_name = new System.Windows.Forms.TextBox();
            this.tip2 = new System.Windows.Forms.Label();
            this.re_id = new System.Windows.Forms.TextBox();
            this.back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.re_pwd = new System.Windows.Forms.TextBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.login_success.SuspendLayout();
            this.register_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(469, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "海云酒店后台管理系统";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(160, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "USER_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(146, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "PASSWORD";
            // 
            // user_id
            // 
            this.user_id.Location = new System.Drawing.Point(373, 30);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(203, 25);
            this.user_id.TabIndex = 3;
            this.user_id.TextChanged += new System.EventHandler(this.user_id_TextChanged);
            // 
            // user_pwd
            // 
            this.user_pwd.Location = new System.Drawing.Point(373, 143);
            this.user_pwd.Name = "user_pwd";
            this.user_pwd.Size = new System.Drawing.Size(203, 25);
            this.user_pwd.TabIndex = 4;
            // 
            // isCustomer
            // 
            this.isCustomer.AutoSize = true;
            this.isCustomer.Location = new System.Drawing.Point(132, 258);
            this.isCustomer.Name = "isCustomer";
            this.isCustomer.Size = new System.Drawing.Size(88, 19);
            this.isCustomer.TabIndex = 5;
            this.isCustomer.TabStop = true;
            this.isCustomer.Text = "我是顾客";
            this.isCustomer.UseVisualStyleBackColor = true;
            // 
            // isStage
            // 
            this.isStage.AutoSize = true;
            this.isStage.Location = new System.Drawing.Point(345, 258);
            this.isStage.Name = "isStage";
            this.isStage.Size = new System.Drawing.Size(88, 19);
            this.isStage.TabIndex = 6;
            this.isStage.TabStop = true;
            this.isStage.Text = "我是前台";
            this.isStage.UseVisualStyleBackColor = true;
            // 
            // isAdmin
            // 
            this.isAdmin.AutoSize = true;
            this.isAdmin.Location = new System.Drawing.Point(539, 258);
            this.isAdmin.Name = "isAdmin";
            this.isAdmin.Size = new System.Drawing.Size(103, 19);
            this.isAdmin.TabIndex = 7;
            this.isAdmin.TabStop = true;
            this.isAdmin.Text = "我是管理员";
            this.isAdmin.UseVisualStyleBackColor = true;
            // 
            // register
            // 
            this.register.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register.Location = new System.Drawing.Point(208, 315);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(126, 43);
            this.register.TabIndex = 8;
            this.register.Text = "注册";
            this.register.UseVisualStyleBackColor = true;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // login
            // 
            this.login.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.login.Location = new System.Drawing.Point(431, 315);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(126, 43);
            this.login.TabIndex = 9;
            this.login.Text = "登陆";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tip);
            this.panel1.Controls.Add(this.user_id);
            this.panel1.Controls.Add(this.login);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.register);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.isAdmin);
            this.panel1.Controls.Add(this.user_pwd);
            this.panel1.Controls.Add(this.isStage);
            this.panel1.Controls.Add(this.isCustomer);
            this.panel1.Location = new System.Drawing.Point(24, 101);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(769, 383);
            this.panel1.TabIndex = 10;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tip
            // 
            this.tip.AutoSize = true;
            this.tip.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip.ForeColor = System.Drawing.Color.Red;
            this.tip.Location = new System.Drawing.Point(248, 205);
            this.tip.Name = "tip";
            this.tip.Size = new System.Drawing.Size(269, 20);
            this.tip.TabIndex = 10;
            this.tip.Text = "无此账户或密码错误，请检查";
            this.tip.Click += new System.EventHandler(this.tip_Click);
            // 
            // login_success
            // 
            this.login_success.Controls.Add(this.button1);
            this.login_success.Controls.Add(this.textBox1);
            this.login_success.Location = new System.Drawing.Point(12, 55);
            this.login_success.Name = "login_success";
            this.login_success.Size = new System.Drawing.Size(791, 437);
            this.login_success.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(458, 107);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 142);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 25);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "未完待续......";
            // 
            // register_panel
            // 
            this.register_panel.Controls.Add(this.label7);
            this.register_panel.Controls.Add(this.re_name);
            this.register_panel.Controls.Add(this.tip2);
            this.register_panel.Controls.Add(this.re_id);
            this.register_panel.Controls.Add(this.back);
            this.register_panel.Controls.Add(this.label5);
            this.register_panel.Controls.Add(this.register_button);
            this.register_panel.Controls.Add(this.label6);
            this.register_panel.Controls.Add(this.radioButton1);
            this.register_panel.Controls.Add(this.re_pwd);
            this.register_panel.Controls.Add(this.radioButton2);
            this.register_panel.Controls.Add(this.radioButton3);
            this.register_panel.Location = new System.Drawing.Point(112, 55);
            this.register_panel.Name = "register_panel";
            this.register_panel.Size = new System.Drawing.Size(564, 488);
            this.register_panel.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(97, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 28);
            this.label7.TabIndex = 21;
            this.label7.Text = "NAME";
            // 
            // re_name
            // 
            this.re_name.Location = new System.Drawing.Point(268, 210);
            this.re_name.Name = "re_name";
            this.re_name.Size = new System.Drawing.Size(203, 25);
            this.re_name.TabIndex = 22;
            // 
            // tip2
            // 
            this.tip2.AutoSize = true;
            this.tip2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tip2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tip2.ForeColor = System.Drawing.Color.Red;
            this.tip2.Location = new System.Drawing.Point(286, 251);
            this.tip2.Name = "tip2";
            this.tip2.Size = new System.Drawing.Size(0, 20);
            this.tip2.TabIndex = 20;
            this.tip2.Click += new System.EventHandler(this.label4_Click);
            // 
            // re_id
            // 
            this.re_id.Location = new System.Drawing.Point(268, 68);
            this.re_id.Name = "re_id";
            this.re_id.Size = new System.Drawing.Size(203, 25);
            this.re_id.TabIndex = 13;
            // 
            // back
            // 
            this.back.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.back.Location = new System.Drawing.Point(326, 353);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(126, 43);
            this.back.TabIndex = 19;
            this.back.Text = "返回上级";
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(55, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 28);
            this.label5.TabIndex = 11;
            this.label5.Text = "USER_ID";
            // 
            // register_button
            // 
            this.register_button.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.register_button.Location = new System.Drawing.Point(103, 353);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(126, 43);
            this.register_button.TabIndex = 18;
            this.register_button.Text = "注册";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(41, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 28);
            this.label6.TabIndex = 12;
            this.label6.Text = "PASSWORD";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(434, 296);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(103, 19);
            this.radioButton1.TabIndex = 17;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "我是管理员";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // re_pwd
            // 
            this.re_pwd.Location = new System.Drawing.Point(268, 140);
            this.re_pwd.Name = "re_pwd";
            this.re_pwd.Size = new System.Drawing.Size(203, 25);
            this.re_pwd.TabIndex = 14;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(240, 296);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(88, 19);
            this.radioButton2.TabIndex = 16;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "我是前台";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 296);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 19);
            this.radioButton3.TabIndex = 15;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "我是顾客";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1379, 593);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.register_panel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.login_success);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.login_success.ResumeLayout(false);
            this.login_success.PerformLayout();
            this.register_panel.ResumeLayout(false);
            this.register_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.TextBox user_pwd;
        private System.Windows.Forms.RadioButton isCustomer;
        private System.Windows.Forms.RadioButton isStage;
        private System.Windows.Forms.RadioButton isAdmin;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.Button login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label tip;
        private System.Windows.Forms.Panel login_success;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel register_panel;
        private System.Windows.Forms.Label tip2;
        private System.Windows.Forms.TextBox re_id;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox re_pwd;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        protected internal System.Windows.Forms.Button register_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox re_name;
        private System.Windows.Forms.Button button1;
    }
}

