﻿
namespace 酒店管理系统
{
    partial class 客房预定
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
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.TextBox();
            this.phonenumber = new System.Windows.Forms.TextBox();
            this.type_room = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.checkin_date = new System.Windows.Forms.DateTimePicker();
            this.checkout_date = new System.Windows.Forms.DateTimePicker();
            this.numberofdays = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.name1 = new System.Windows.Forms.TextBox();
            this.name2 = new System.Windows.Forms.TextBox();
            this.name3 = new System.Windows.Forms.TextBox();
            this.id_name1 = new System.Windows.Forms.TextBox();
            this.id_name2 = new System.Windows.Forms.TextBox();
            this.id_name3 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "订单编号";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "联系电话";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(406, 319);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "房间类型";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(406, 259);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "入住天数 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 87);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 15);
            this.label12.TabIndex = 11;
            this.label12.Text = "退房日期";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(11, 23);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 12;
            this.label13.Text = "入住日期";
            // 
            // ID
            // 
            this.ID.Location = new System.Drawing.Point(118, 40);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(193, 25);
            this.ID.TabIndex = 13;
            this.ID.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // phonenumber
            // 
            this.phonenumber.Location = new System.Drawing.Point(82, 219);
            this.phonenumber.Name = "phonenumber";
            this.phonenumber.Size = new System.Drawing.Size(250, 25);
            this.phonenumber.TabIndex = 17;
            // 
            // type_room
            // 
            this.type_room.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_room.FormattingEnabled = true;
            this.type_room.Items.AddRange(new object[] {
            "单人间",
            "双人间",
            "三人间",
            "豪华套房",
            "蜜月套房",
            "商务套房"});
            this.type_room.Location = new System.Drawing.Point(496, 314);
            this.type_room.Name = "type_room";
            this.type_room.Size = new System.Drawing.Size(200, 23);
            this.type_room.TabIndex = 25;
            this.type_room.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(271, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 36);
            this.button1.TabIndex = 26;
            this.button1.Text = "预定";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(418, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 27;
            this.button2.Text = "返回";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // checkin_date
            // 
            this.checkin_date.Location = new System.Drawing.Point(100, 16);
            this.checkin_date.Name = "checkin_date";
            this.checkin_date.Size = new System.Drawing.Size(200, 25);
            this.checkin_date.TabIndex = 35;
            // 
            // checkout_date
            // 
            this.checkout_date.Location = new System.Drawing.Point(100, 84);
            this.checkout_date.Name = "checkout_date";
            this.checkout_date.Size = new System.Drawing.Size(200, 25);
            this.checkout_date.TabIndex = 36;
            // 
            // numberofdays
            // 
            this.numberofdays.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.numberofdays.FormattingEnabled = true;
            this.numberofdays.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14"});
            this.numberofdays.Location = new System.Drawing.Point(496, 256);
            this.numberofdays.Name = "numberofdays";
            this.numberofdays.Size = new System.Drawing.Size(200, 23);
            this.numberofdays.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(539, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(226, 24);
            this.label8.TabIndex = 38;
            this.label8.Text = "欢迎来到海云酒店！";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "顾客1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "顾客2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "顾客3";
            // 
            // name1
            // 
            this.name1.Location = new System.Drawing.Point(82, 22);
            this.name1.Name = "name1";
            this.name1.Size = new System.Drawing.Size(100, 25);
            this.name1.TabIndex = 14;
            // 
            // name2
            // 
            this.name2.Location = new System.Drawing.Point(82, 87);
            this.name2.Name = "name2";
            this.name2.Size = new System.Drawing.Size(100, 25);
            this.name2.TabIndex = 15;
            // 
            // name3
            // 
            this.name3.Location = new System.Drawing.Point(82, 156);
            this.name3.Name = "name3";
            this.name3.Size = new System.Drawing.Size(100, 25);
            this.name3.TabIndex = 16;
            // 
            // id_name1
            // 
            this.id_name1.Location = new System.Drawing.Point(209, 22);
            this.id_name1.Name = "id_name1";
            this.id_name1.Size = new System.Drawing.Size(117, 25);
            this.id_name1.TabIndex = 18;
            // 
            // id_name2
            // 
            this.id_name2.Location = new System.Drawing.Point(209, 87);
            this.id_name2.Name = "id_name2";
            this.id_name2.Size = new System.Drawing.Size(117, 25);
            this.id_name2.TabIndex = 19;
            // 
            // id_name3
            // 
            this.id_name3.Location = new System.Drawing.Point(209, 156);
            this.id_name3.Name = "id_name3";
            this.id_name3.Size = new System.Drawing.Size(117, 25);
            this.id_name3.TabIndex = 20;
            this.id_name3.TextChanged += new System.EventHandler(this.id_name3_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.id_name3);
            this.groupBox1.Controls.Add(this.id_name2);
            this.groupBox1.Controls.Add(this.id_name1);
            this.groupBox1.Controls.Add(this.name3);
            this.groupBox1.Controls.Add(this.name2);
            this.groupBox1.Controls.Add(this.name1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.phonenumber);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(30, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 276);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "入住个人信息";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkout_date);
            this.groupBox2.Controls.Add(this.checkin_date);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Location = new System.Drawing.Point(395, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 129);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "选择日期";
            // 
            // 客房预定
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 447);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.numberofdays);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.type_room);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Name = "客房预定";
            this.Text = "客房预定";
            this.Load += new System.EventHandler(this.前台线下预定_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox phonenumber;
        private System.Windows.Forms.ComboBox type_room;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker checkin_date;
        private System.Windows.Forms.DateTimePicker checkout_date;
        private System.Windows.Forms.ComboBox numberofdays;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox name1;
        private System.Windows.Forms.TextBox name2;
        private System.Windows.Forms.TextBox name3;
        private System.Windows.Forms.TextBox id_name1;
        private System.Windows.Forms.TextBox id_name2;
        private System.Windows.Forms.TextBox id_name3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}