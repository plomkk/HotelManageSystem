namespace 酒店管理系统
{
    partial class stage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.功能1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.功能4ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.Checkin = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckOut = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.注销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能1ToolStripMenuItem,
            this.功能2ToolStripMenuItem,
            this.功能3ToolStripMenuItem,
            this.功能4ToolStripMenuItem,
            this.RoomInfo,
            this.Checkin,
            this.CheckOut,
            this.toolStripMenuItem3,
            this.注销ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1016, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // 功能1ToolStripMenuItem
            // 
            this.功能1ToolStripMenuItem.Name = "功能1ToolStripMenuItem";
            this.功能1ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.功能1ToolStripMenuItem.Text = "查询订单信息";
            this.功能1ToolStripMenuItem.Click += new System.EventHandler(this.功能1ToolStripMenuItem_Click);
            // 
            // 功能2ToolStripMenuItem
            // 
            this.功能2ToolStripMenuItem.Name = "功能2ToolStripMenuItem";
            this.功能2ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.功能2ToolStripMenuItem.Text = "客房预订";
            this.功能2ToolStripMenuItem.Click += new System.EventHandler(this.功能2ToolStripMenuItem_Click);
            // 
            // 功能3ToolStripMenuItem
            // 
            this.功能3ToolStripMenuItem.Name = "功能3ToolStripMenuItem";
            this.功能3ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.功能3ToolStripMenuItem.Text = "取消订单";
            this.功能3ToolStripMenuItem.Click += new System.EventHandler(this.功能3ToolStripMenuItem_Click);
            // 
            // 功能4ToolStripMenuItem
            // 
            this.功能4ToolStripMenuItem.Name = "功能4ToolStripMenuItem";
            this.功能4ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.功能4ToolStripMenuItem.Text = "修改订单信息";
            this.功能4ToolStripMenuItem.Click += new System.EventHandler(this.功能4ToolStripMenuItem_Click);
            // 
            // RoomInfo
            // 
            this.RoomInfo.Name = "RoomInfo";
            this.RoomInfo.Size = new System.Drawing.Size(113, 24);
            this.RoomInfo.Text = "查询房间信息";
            this.RoomInfo.Click += new System.EventHandler(this.RoomInfo_Click);
            // 
            // Checkin
            // 
            this.Checkin.Name = "Checkin";
            this.Checkin.Size = new System.Drawing.Size(113, 24);
            this.Checkin.Text = "办理入住手续";
            this.Checkin.Click += new System.EventHandler(this.Checkin_Click);
            // 
            // CheckOut
            // 
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.Size = new System.Drawing.Size(113, 24);
            this.CheckOut.Text = "办理退房手续";
            this.CheckOut.Click += new System.EventHandler(this.CheckOut_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(83, 24);
            this.toolStripMenuItem3.Text = "申报修理";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // 注销ToolStripMenuItem
            // 
            this.注销ToolStripMenuItem.Name = "注销ToolStripMenuItem";
            this.注销ToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.注销ToolStripMenuItem.Text = "注销";
            this.注销ToolStripMenuItem.Click += new System.EventHandler(this.注销ToolStripMenuItem_Click);
            // 
            // stage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "stage";
            this.Text = "前台主界面";
            this.Load += new System.EventHandler(this.stage_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能4ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomInfo;
        private System.Windows.Forms.ToolStripMenuItem Checkin;
        private System.Windows.Forms.ToolStripMenuItem CheckOut;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem 注销ToolStripMenuItem;
    }
}