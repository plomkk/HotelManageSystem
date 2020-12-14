namespace 酒店管理系统
{
    partial class 管理_审理报修
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_sure = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hotelDataSet = new 酒店管理系统.HotelDataSet();
            this.fixBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fixTableAdapter = new 酒店管理系统.HotelDataSetTableAdapters.fixTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.concreteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ifsureDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fixBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hotelDatafdname = new 酒店管理系统.HotelDatafdname();
            this.fixTableAdapter1 = new 酒店管理系统.HotelDatafdnameTableAdapters.fixTableAdapter();
            this.hotelDataSet1 = new 酒店管理系统.HotelDataSet1();
            this.fixBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fixTableAdapter2 = new 酒店管理系统.HotelDataSet1TableAdapters.fixTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatafdname)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文楷体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(263, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 43);
            this.label1.TabIndex = 1;
            this.label1.Text = "全部报修信息：";
            // 
            // bt_sure
            // 
            this.bt_sure.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.bt_sure.Location = new System.Drawing.Point(154, 372);
            this.bt_sure.Name = "bt_sure";
            this.bt_sure.Size = new System.Drawing.Size(106, 45);
            this.bt_sure.TabIndex = 2;
            this.bt_sure.Text = "确认";
            this.bt_sure.UseVisualStyleBackColor = true;
            this.bt_sure.Click += new System.EventHandler(this.bt_sure_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("华文楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.Location = new System.Drawing.Point(472, 372);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "返回上级";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // hotelDataSet
            // 
            this.hotelDataSet.DataSetName = "HotelDataSet";
            this.hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fixBindingSource
            // 
            this.fixBindingSource.DataMember = "fix";
            this.fixBindingSource.DataSource = this.hotelDataSet;
            // 
            // fixTableAdapter
            // 
            this.fixTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.concreteDataGridViewTextBoxColumn,
            this.ifsureDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fixBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 105);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(776, 235);
            this.dataGridView1.TabIndex = 4;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.iDDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.iDDataGridViewTextBoxColumn.HeaderText = "房间ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // concreteDataGridViewTextBoxColumn
            // 
            this.concreteDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.concreteDataGridViewTextBoxColumn.DataPropertyName = "concrete";
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.concreteDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.concreteDataGridViewTextBoxColumn.HeaderText = "损坏部件";
            this.concreteDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.concreteDataGridViewTextBoxColumn.Name = "concreteDataGridViewTextBoxColumn";
            // 
            // ifsureDataGridViewTextBoxColumn
            // 
            this.ifsureDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ifsureDataGridViewTextBoxColumn.DataPropertyName = "if_sure";
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Highlight;
            this.ifsureDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.ifsureDataGridViewTextBoxColumn.HeaderText = "是否确认";
            this.ifsureDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ifsureDataGridViewTextBoxColumn.Name = "ifsureDataGridViewTextBoxColumn";
            // 
            // fixBindingSource1
            // 
            this.fixBindingSource1.DataMember = "fix";
            this.fixBindingSource1.DataSource = this.hotelDatafdname;
            // 
            // hotelDatafdname
            // 
            this.hotelDatafdname.DataSetName = "HotelDatafdname";
            this.hotelDatafdname.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fixTableAdapter1
            // 
            this.fixTableAdapter1.ClearBeforeFill = true;
            // 
            // hotelDataSet1
            // 
            this.hotelDataSet1.DataSetName = "HotelDataSet1";
            this.hotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fixBindingSource2
            // 
            this.fixBindingSource2.DataMember = "fix";
            this.fixBindingSource2.DataSource = this.hotelDataSet1;
            // 
            // fixTableAdapter2
            // 
            this.fixTableAdapter2.ClearBeforeFill = true;
            // 
            // 管理_审理报修
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_sure);
            this.Controls.Add(this.label1);
            this.Name = "管理_审理报修";
            this.Text = "管理_审理报修";
            this.Load += new System.EventHandler(this.管理_审理报修_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDatafdname)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fixBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_sure;
        private System.Windows.Forms.Button button2;
        private HotelDataSet hotelDataSet;
        private System.Windows.Forms.BindingSource fixBindingSource;
        private HotelDataSetTableAdapters.fixTableAdapter fixTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private HotelDatafdname hotelDatafdname;
        private System.Windows.Forms.BindingSource fixBindingSource1;
        private HotelDatafdnameTableAdapters.fixTableAdapter fixTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn concreteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ifsureDataGridViewTextBoxColumn;
        private HotelDataSet1 hotelDataSet1;
        private System.Windows.Forms.BindingSource fixBindingSource2;
        private HotelDataSet1TableAdapters.fixTableAdapter fixTableAdapter2;
    }
}