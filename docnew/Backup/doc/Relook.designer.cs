namespace doc
{
    partial class Relook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Relook));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btncancle = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnok = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtoffice = new System.Windows.Forms.TextBox();
            this.txtuname = new System.Windows.Forms.TextBox();
            this.btnserchn = new System.Windows.Forms.Button();
            this.txtsen = new System.Windows.Forms.TextBox();
            this.btnsercho = new System.Windows.Forms.Button();
            this.txtseo = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(10, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(346, 221);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "uid";
            this.Column1.HeaderText = "工号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "uname";
            this.Column2.HeaderText = "医生姓名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "office";
            this.Column3.HeaderText = "科室";
            this.Column3.Name = "Column3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.btncancle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnok);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtoffice);
            this.panel2.Controls.Add(this.txtuname);
            this.panel2.Controls.Add(this.btnserchn);
            this.panel2.Controls.Add(this.txtsen);
            this.panel2.Controls.Add(this.btnsercho);
            this.panel2.Controls.Add(this.txtseo);
            this.panel2.Location = new System.Drawing.Point(362, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(165, 221);
            this.panel2.TabIndex = 7;
            // 
            // btncancle
            // 
            this.btncancle.Location = new System.Drawing.Point(96, 195);
            this.btncancle.Name = "btncancle";
            this.btncancle.Size = new System.Drawing.Size(49, 23);
            this.btncancle.TabIndex = 9;
            this.btncancle.Text = "取消";
            this.btncancle.UseVisualStyleBackColor = true;
            this.btncancle.Click += new System.EventHandler(this.btncancle_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "科室";
            // 
            // btnok
            // 
            this.btnok.Location = new System.Drawing.Point(20, 195);
            this.btnok.Name = "btnok";
            this.btnok.Size = new System.Drawing.Size(52, 23);
            this.btnok.TabIndex = 8;
            this.btnok.Text = "确定";
            this.btnok.UseVisualStyleBackColor = true;
            this.btnok.Click += new System.EventHandler(this.btnok_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "医生姓名";
            // 
            // txtoffice
            // 
            this.txtoffice.Location = new System.Drawing.Point(9, 150);
            this.txtoffice.Name = "txtoffice";
            this.txtoffice.Size = new System.Drawing.Size(117, 21);
            this.txtoffice.TabIndex = 12;
            // 
            // txtuname
            // 
            this.txtuname.Location = new System.Drawing.Point(9, 102);
            this.txtuname.Name = "txtuname";
            this.txtuname.Size = new System.Drawing.Size(117, 21);
            this.txtuname.TabIndex = 10;
            // 
            // btnserchn
            // 
            this.btnserchn.Location = new System.Drawing.Point(96, 53);
            this.btnserchn.Name = "btnserchn";
            this.btnserchn.Size = new System.Drawing.Size(59, 21);
            this.btnserchn.TabIndex = 9;
            this.btnserchn.Text = "选择名子";
            this.btnserchn.UseVisualStyleBackColor = true;
            this.btnserchn.Click += new System.EventHandler(this.btnserchn_Click);
            // 
            // txtsen
            // 
            this.txtsen.Location = new System.Drawing.Point(91, 14);
            this.txtsen.Name = "txtsen";
            this.txtsen.Size = new System.Drawing.Size(71, 21);
            this.txtsen.TabIndex = 8;
            // 
            // btnsercho
            // 
            this.btnsercho.Location = new System.Drawing.Point(13, 53);
            this.btnsercho.Name = "btnsercho";
            this.btnsercho.Size = new System.Drawing.Size(59, 21);
            this.btnsercho.TabIndex = 7;
            this.btnsercho.Text = "选择科";
            this.btnsercho.UseVisualStyleBackColor = true;
            // 
            // txtseo
            // 
            this.txtseo.Location = new System.Drawing.Point(9, 14);
            this.txtseo.Name = "txtseo";
            this.txtseo.Size = new System.Drawing.Size(70, 21);
            this.txtseo.TabIndex = 6;
            // 
            // Relook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = global::doc.Properties.Resources._6583c92fa950f32a1e30890c;
            this.ClientSize = new System.Drawing.Size(530, 271);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(538, 305);
            this.Name = "Relook";
            this.Text = "挂号查看";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnserchn;
        private System.Windows.Forms.TextBox txtsen;
        private System.Windows.Forms.Button btnsercho;
        private System.Windows.Forms.TextBox txtseo;
        private System.Windows.Forms.Button btnok;
        private System.Windows.Forms.Button btncancle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtoffice;
        private System.Windows.Forms.TextBox txtuname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}