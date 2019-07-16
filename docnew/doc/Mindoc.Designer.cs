namespace doc
{
    partial class Mindoc
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mindoc));
            this.lblDocName = new System.Windows.Forms.Label();
            this.dgvinfo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblKemu = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.dgv1 = new System.Windows.Forms.DataGridView();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnYingZheng = new System.Windows.Forms.Button();
            this.btnfind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picfind = new System.Windows.Forms.PictureBox();
            this.picfaces = new System.Windows.Forms.PictureBox();
            this.btnagin1 = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfaces)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDocName
            // 
            this.lblDocName.AutoSize = true;
            this.lblDocName.BackColor = System.Drawing.Color.Transparent;
            this.lblDocName.Location = new System.Drawing.Point(111, 18);
            this.lblDocName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDocName.Name = "lblDocName";
            this.lblDocName.Size = new System.Drawing.Size(62, 18);
            this.lblDocName.TabIndex = 0;
            this.lblDocName.Text = "label1";
            // 
            // dgvinfo
            // 
            this.dgvinfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvinfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.Column6,
            this.Column7});
            this.dgvinfo.Location = new System.Drawing.Point(38, 113);
            this.dgvinfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvinfo.Name = "dgvinfo";
            this.dgvinfo.RowTemplate.Height = 23;
            this.dgvinfo.Size = new System.Drawing.Size(820, 424);
            this.dgvinfo.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "pname";
            this.dataGridViewTextBoxColumn2.HeaderText = "姓名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "page";
            this.dataGridViewTextBoxColumn3.HeaderText = "年龄";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "psex";
            this.dataGridViewTextBoxColumn4.HeaderText = "性别";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "bingkuang";
            this.Column6.HeaderText = "病况";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "data";
            this.Column7.HeaderText = "时间";
            this.Column7.Name = "Column7";
            // 
            // lblKemu
            // 
            this.lblKemu.AutoSize = true;
            this.lblKemu.BackColor = System.Drawing.Color.Transparent;
            this.lblKemu.Location = new System.Drawing.Point(207, 18);
            this.lblKemu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKemu.Name = "lblKemu";
            this.lblKemu.Size = new System.Drawing.Size(62, 18);
            this.lblKemu.TabIndex = 0;
            this.lblKemu.Text = "label1";
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.Transparent;
            this.lblCount.Location = new System.Drawing.Point(152, 60);
            this.lblCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(62, 18);
            this.lblCount.TabIndex = 0;
            this.lblCount.Text = "label1";
            this.lblCount.Click += new System.EventHandler(this.lblCount_Click);
            // 
            // dgv1
            // 
            this.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column3,
            this.Column4,
            this.Column2,
            this.Column1,
            this.Column5});
            this.dgv1.Location = new System.Drawing.Point(0, 114);
            this.dgv1.Margin = new System.Windows.Forms.Padding(4);
            this.dgv1.Name = "dgv1";
            this.dgv1.RowTemplate.Height = 23;
            this.dgv1.Size = new System.Drawing.Size(896, 424);
            this.dgv1.TabIndex = 2;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "pid";
            this.Column8.HeaderText = "编号";
            this.Column8.Name = "Column8";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "pname";
            this.Column3.HeaderText = "姓名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "page";
            this.Column4.HeaderText = "年龄";
            this.Column4.Name = "Column4";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "psex";
            this.Column2.HeaderText = "性别";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "adds";
            this.Column1.HeaderText = "地址";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "data";
            this.Column5.HeaderText = "时间";
            this.Column5.Name = "Column5";
            // 
            // BtnYingZheng
            // 
            this.BtnYingZheng.Location = new System.Drawing.Point(722, 548);
            this.BtnYingZheng.Margin = new System.Windows.Forms.Padding(4);
            this.BtnYingZheng.Name = "BtnYingZheng";
            this.BtnYingZheng.Size = new System.Drawing.Size(112, 34);
            this.BtnYingZheng.TabIndex = 3;
            this.BtnYingZheng.Text = "应症";
            this.BtnYingZheng.UseVisualStyleBackColor = true;
            this.BtnYingZheng.Click += new System.EventHandler(this.BtnYingZheng_Click);
            // 
            // btnfind
            // 
            this.btnfind.Location = new System.Drawing.Point(722, 547);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(112, 34);
            this.btnfind.TabIndex = 3;
            this.btnfind.Text = "查看";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(111, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "有";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(189, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 18);
            this.label2.TabIndex = 5;
            this.label2.Text = "个病人等候";
            // 
            // picfind
            // 
            this.picfind.BackColor = System.Drawing.Color.Transparent;
            this.picfind.Image = global::doc.Properties.Resources.Search;
            this.picfind.Location = new System.Drawing.Point(328, 54);
            this.picfind.Margin = new System.Windows.Forms.Padding(4);
            this.picfind.Name = "picfind";
            this.picfind.Size = new System.Drawing.Size(16, 16);
            this.picfind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picfind.TabIndex = 4;
            this.picfind.TabStop = false;
            this.picfind.Click += new System.EventHandler(this.picfind_Click);
            // 
            // picfaces
            // 
            this.picfaces.Image = global::doc.Properties.Resources._45;
            this.picfaces.Location = new System.Drawing.Point(6, 8);
            this.picfaces.Margin = new System.Windows.Forms.Padding(4);
            this.picfaces.Name = "picfaces";
            this.picfaces.Size = new System.Drawing.Size(96, 87);
            this.picfaces.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picfaces.TabIndex = 4;
            this.picfaces.TabStop = false;
            this.picfaces.Click += new System.EventHandler(this.picfaces_Click);
            // 
            // btnagin1
            // 
            this.btnagin1.Location = new System.Drawing.Point(612, 547);
            this.btnagin1.Margin = new System.Windows.Forms.Padding(4);
            this.btnagin1.Name = "btnagin1";
            this.btnagin1.Size = new System.Drawing.Size(100, 33);
            this.btnagin1.TabIndex = 6;
            this.btnagin1.Text = "刷新";
            this.btnagin1.UseVisualStyleBackColor = true;
            this.btnagin1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(490, 548);
            this.btnClose2.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(112, 34);
            this.btnClose2.TabIndex = 7;
            this.btnClose2.Text = "返回";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.btnClose2_Click);
            // 
            // Mindoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::doc.Properties.Resources.图片6;
            this.ClientSize = new System.Drawing.Size(866, 573);
            this.Controls.Add(this.btnClose2);
            this.Controls.Add(this.btnagin1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picfind);
            this.Controls.Add(this.picfaces);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.BtnYingZheng);
            this.Controls.Add(this.dgv1);
            this.Controls.Add(this.dgvinfo);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.lblKemu);
            this.Controls.Add(this.lblDocName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(888, 629);
            this.MinimumSize = new System.Drawing.Size(888, 629);
            this.Name = "Mindoc";
            this.Text = "医生界面";
            this.Load += new System.EventHandler(this.Mindoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvinfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picfaces)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDocName;
        private System.Windows.Forms.DataGridView dgvinfo;
        private System.Windows.Forms.Label lblKemu;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.DataGridView dgv1;
        private System.Windows.Forms.Button BtnYingZheng;
        private System.Windows.Forms.PictureBox picfaces;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.PictureBox picfind;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button btnagin1;
        private System.Windows.Forms.Button btnClose2;
    }
}

