﻿namespace 酒店管理系统
{
    partial class customer
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
            this.线上预订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消预订ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.功能1ToolStripMenuItem,
            this.功能2ToolStripMenuItem,
            this.线上预订ToolStripMenuItem,
            this.取消预订ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.功能2ToolStripMenuItem.Size = new System.Drawing.Size(113, 24);
            this.功能2ToolStripMenuItem.Text = "修改订单信息";
            this.功能2ToolStripMenuItem.Click += new System.EventHandler(this.功能2ToolStripMenuItem_Click);
            // 
            // 线上预订ToolStripMenuItem
            // 
            this.线上预订ToolStripMenuItem.Name = "线上预订ToolStripMenuItem";
            this.线上预订ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.线上预订ToolStripMenuItem.Text = "客房预订";
            this.线上预订ToolStripMenuItem.Click += new System.EventHandler(this.线上预订ToolStripMenuItem_Click);
            // 
            // 取消预订ToolStripMenuItem
            // 
            this.取消预订ToolStripMenuItem.Name = "取消预订ToolStripMenuItem";
            this.取消预订ToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.取消预订ToolStripMenuItem.Text = "取消预订";
            this.取消预订ToolStripMenuItem.Click += new System.EventHandler(this.取消预订ToolStripMenuItem_Click);
            // 
            // customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "customer";
            this.Text = "顾客主界面";
            this.Load += new System.EventHandler(this.customer_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 功能1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 功能2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 线上预订ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消预订ToolStripMenuItem;
    }
}