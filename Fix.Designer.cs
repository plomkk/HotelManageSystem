namespace 酒店管理系统
{
    partial class Fix
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
            this.cb_id = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_concrete = new System.Windows.Forms.TextBox();
            this.bt_submit = new System.Windows.Forms.Button();
            this.bt_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(236, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "房间ID：";
            // 
            // cb_id
            // 
            this.cb_id.FormattingEnabled = true;
            this.cb_id.Location = new System.Drawing.Point(384, 99);
            this.cb_id.Name = "cb_id";
            this.cb_id.Size = new System.Drawing.Size(125, 23);
            this.cb_id.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文楷体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(128, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "请输入受损部件：";
            // 
            // tb_concrete
            // 
            this.tb_concrete.Location = new System.Drawing.Point(384, 181);
            this.tb_concrete.Name = "tb_concrete";
            this.tb_concrete.Size = new System.Drawing.Size(206, 25);
            this.tb_concrete.TabIndex = 3;
            // 
            // bt_submit
            // 
            this.bt_submit.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_submit.Location = new System.Drawing.Point(176, 299);
            this.bt_submit.Name = "bt_submit";
            this.bt_submit.Size = new System.Drawing.Size(110, 41);
            this.bt_submit.TabIndex = 4;
            this.bt_submit.Text = "提交审理";
            this.bt_submit.UseVisualStyleBackColor = true;
            this.bt_submit.Click += new System.EventHandler(this.bt_submit_Click);
            // 
            // bt_back
            // 
            this.bt_back.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_back.Location = new System.Drawing.Point(456, 299);
            this.bt_back.Name = "bt_back";
            this.bt_back.Size = new System.Drawing.Size(110, 41);
            this.bt_back.TabIndex = 5;
            this.bt_back.Text = "返回上级";
            this.bt_back.UseVisualStyleBackColor = true;
            this.bt_back.Click += new System.EventHandler(this.bt_back_Click);
            // 
            // Fix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 450);
            this.Controls.Add(this.bt_back);
            this.Controls.Add(this.bt_submit);
            this.Controls.Add(this.tb_concrete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cb_id);
            this.Controls.Add(this.label1);
            this.Name = "Fix";
            this.Text = "Fix";
            this.Load += new System.EventHandler(this.Fix_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_concrete;
        private System.Windows.Forms.Button bt_submit;
        private System.Windows.Forms.Button bt_back;
    }
}