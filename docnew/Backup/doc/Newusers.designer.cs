namespace doc
{
    partial class Newusers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Newusers));
            this.name = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.subject = new System.Windows.Forms.Label();
            this.type = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.trueName = new System.Windows.Forms.TextBox();
            this.subjectText = new System.Windows.Forms.TextBox();
            this.radioBoy = new System.Windows.Forms.RadioButton();
            this.radiogirl = new System.Windows.Forms.RadioButton();
            this.save = new System.Windows.Forms.Button();
            this.close = new System.Windows.Forms.Button();
            this.code = new System.Windows.Forms.TextBox();
            this.sex = new System.Windows.Forms.Label();
            this.registerRadio = new System.Windows.Forms.RadioButton();
            this.DrRadio = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ageAasked = new System.Windows.Forms.MaskedTextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.Transparent;
            this.name.Location = new System.Drawing.Point(38, 26);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(65, 12);
            this.name.TabIndex = 0;
            this.name.Text = "真是姓名：";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.Transparent;
            this.pwd.Location = new System.Drawing.Point(38, 67);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(59, 12);
            this.pwd.TabIndex = 0;
            this.pwd.Text = "密   码：";
            // 
            // subject
            // 
            this.subject.AutoSize = true;
            this.subject.BackColor = System.Drawing.Color.Transparent;
            this.subject.Location = new System.Drawing.Point(38, 200);
            this.subject.Name = "subject";
            this.subject.Size = new System.Drawing.Size(59, 12);
            this.subject.TabIndex = 0;
            this.subject.Text = "科   室：";
            // 
            // type
            // 
            this.type.AutoSize = true;
            this.type.BackColor = System.Drawing.Color.Transparent;
            this.type.Location = new System.Drawing.Point(38, 162);
            this.type.Name = "type";
            this.type.Size = new System.Drawing.Size(59, 12);
            this.type.TabIndex = 0;
            this.type.Text = "类   型：";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.Transparent;
            this.age.Location = new System.Drawing.Point(38, 130);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(59, 12);
            this.age.TabIndex = 0;
            this.age.Text = "年   龄：";
            // 
            // trueName
            // 
            this.trueName.Location = new System.Drawing.Point(125, 23);
            this.trueName.Name = "trueName";
            this.trueName.Size = new System.Drawing.Size(110, 21);
            this.trueName.TabIndex = 1;
            // 
            // subjectText
            // 
            this.subjectText.Location = new System.Drawing.Point(130, 191);
            this.subjectText.Name = "subjectText";
            this.subjectText.Size = new System.Drawing.Size(110, 21);
            this.subjectText.TabIndex = 8;
            // 
            // radioBoy
            // 
            this.radioBoy.AutoSize = true;
            this.radioBoy.Checked = true;
            this.radioBoy.Location = new System.Drawing.Point(19, 4);
            this.radioBoy.Name = "radioBoy";
            this.radioBoy.Size = new System.Drawing.Size(35, 16);
            this.radioBoy.TabIndex = 3;
            this.radioBoy.TabStop = true;
            this.radioBoy.Text = "男";
            this.radioBoy.UseVisualStyleBackColor = true;
            // 
            // radiogirl
            // 
            this.radiogirl.AutoSize = true;
            this.radiogirl.Location = new System.Drawing.Point(75, 4);
            this.radiogirl.Name = "radiogirl";
            this.radiogirl.Size = new System.Drawing.Size(35, 16);
            this.radiogirl.TabIndex = 4;
            this.radiogirl.TabStop = true;
            this.radiogirl.Text = "女";
            this.radiogirl.UseVisualStyleBackColor = true;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(57, 249);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(66, 24);
            this.save.TabIndex = 10;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(169, 249);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(66, 24);
            this.close.TabIndex = 11;
            this.close.Text = "关闭";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(125, 58);
            this.code.Name = "code";
            this.code.PasswordChar = '*';
            this.code.Size = new System.Drawing.Size(110, 21);
            this.code.TabIndex = 2;
            // 
            // sex
            // 
            this.sex.AutoSize = true;
            this.sex.BackColor = System.Drawing.Color.Transparent;
            this.sex.Location = new System.Drawing.Point(38, 98);
            this.sex.Name = "sex";
            this.sex.Size = new System.Drawing.Size(59, 12);
            this.sex.TabIndex = 0;
            this.sex.Text = "性   别：";
            // 
            // registerRadio
            // 
            this.registerRadio.AutoSize = true;
            this.registerRadio.BackColor = System.Drawing.Color.Transparent;
            this.registerRadio.Location = new System.Drawing.Point(4, 10);
            this.registerRadio.Name = "registerRadio";
            this.registerRadio.Size = new System.Drawing.Size(59, 16);
            this.registerRadio.TabIndex = 6;
            this.registerRadio.TabStop = true;
            this.registerRadio.Text = "挂号台";
            this.registerRadio.UseVisualStyleBackColor = false;
            this.registerRadio.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // DrRadio
            // 
            this.DrRadio.AutoSize = true;
            this.DrRadio.BackColor = System.Drawing.Color.Transparent;
            this.DrRadio.Location = new System.Drawing.Point(72, 7);
            this.DrRadio.Name = "DrRadio";
            this.DrRadio.Size = new System.Drawing.Size(47, 16);
            this.DrRadio.TabIndex = 7;
            this.DrRadio.TabStop = true;
            this.DrRadio.Text = "医生";
            this.DrRadio.UseVisualStyleBackColor = false;
            this.DrRadio.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.radiogirl);
            this.groupBox1.Controls.Add(this.radioBoy);
            this.groupBox1.Location = new System.Drawing.Point(125, 90);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(118, 20);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.DrRadio);
            this.groupBox2.Controls.Add(this.registerRadio);
            this.groupBox2.Location = new System.Drawing.Point(116, 148);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(127, 32);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            // 
            // ageAasked
            // 
            this.ageAasked.Location = new System.Drawing.Point(130, 121);
            this.ageAasked.Mask = "99";
            this.ageAasked.Name = "ageAasked";
            this.ageAasked.PromptChar = '0';
            this.ageAasked.Size = new System.Drawing.Size(60, 21);
            this.ageAasked.TabIndex = 14;
            this.ageAasked.ValidatingType = typeof(int);
            // 
            // Newusers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doc.Properties.Resources.b02f002cafb372fe8b139918;
            this.ClientSize = new System.Drawing.Size(279, 313);
            this.Controls.Add(this.ageAasked);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.close);
            this.Controls.Add(this.save);
            this.Controls.Add(this.subjectText);
            this.Controls.Add(this.code);
            this.Controls.Add(this.trueName);
            this.Controls.Add(this.type);
            this.Controls.Add(this.sex);
            this.Controls.Add(this.age);
            this.Controls.Add(this.subject);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.name);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(287, 347);
            this.MinimumSize = new System.Drawing.Size(287, 347);
            this.Name = "Newusers";
            this.Text = "用户注册";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Label subject;
        private System.Windows.Forms.Label type;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.TextBox trueName;
        private System.Windows.Forms.TextBox subjectText;
        private System.Windows.Forms.RadioButton radioBoy;
        private System.Windows.Forms.RadioButton radiogirl;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label sex;
        private System.Windows.Forms.RadioButton registerRadio;
        private System.Windows.Forms.RadioButton DrRadio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MaskedTextBox ageAasked;
    }
}