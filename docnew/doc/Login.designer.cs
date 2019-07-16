namespace doc
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.uid = new System.Windows.Forms.Label();
            this.uType = new System.Windows.Forms.Label();
            this.pwd = new System.Windows.Forms.Label();
            this.land = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.pwdText = new System.Windows.Forms.TextBox();
            this.userType = new System.Windows.Forms.ComboBox();
            this.zhuce = new System.Windows.Forms.Button();
            this.num = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // uid
            // 
            this.uid.AutoSize = true;
            this.uid.BackColor = System.Drawing.Color.Transparent;
            this.uid.Location = new System.Drawing.Point(45, 48);
            this.uid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uid.Name = "uid";
            this.uid.Size = new System.Drawing.Size(98, 18);
            this.uid.TabIndex = 0;
            this.uid.Text = "帐   号 ：";
            // 
            // uType
            // 
            this.uType.AutoSize = true;
            this.uType.BackColor = System.Drawing.Color.Transparent;
            this.uType.Location = new System.Drawing.Point(45, 120);
            this.uType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.uType.Name = "uType";
            this.uType.Size = new System.Drawing.Size(98, 18);
            this.uType.TabIndex = 1;
            this.uType.Text = "用户类型：";
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.BackColor = System.Drawing.Color.Transparent;
            this.pwd.Location = new System.Drawing.Point(45, 188);
            this.pwd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(98, 18);
            this.pwd.TabIndex = 2;
            this.pwd.Text = "密    码：";
            // 
            // land
            // 
            this.land.Location = new System.Drawing.Point(48, 243);
            this.land.Margin = new System.Windows.Forms.Padding(4);
            this.land.Name = "land";
            this.land.Size = new System.Drawing.Size(100, 33);
            this.land.TabIndex = 4;
            this.land.Text = "登录";
            this.land.UseVisualStyleBackColor = true;
            this.land.Click += new System.EventHandler(this.land_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(166, 243);
            this.cancel.Margin = new System.Windows.Forms.Padding(4);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(100, 33);
            this.cancel.TabIndex = 5;
            this.cancel.Text = "返回";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // pwdText
            // 
            this.pwdText.Location = new System.Drawing.Point(166, 183);
            this.pwdText.Margin = new System.Windows.Forms.Padding(4);
            this.pwdText.Name = "pwdText";
            this.pwdText.PasswordChar = '*';
            this.pwdText.Size = new System.Drawing.Size(178, 28);
            this.pwdText.TabIndex = 3;
            // 
            // userType
            // 
            this.userType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userType.FormattingEnabled = true;
            this.userType.Items.AddRange(new object[] {
            "挂号",
            "医生"});
            this.userType.Location = new System.Drawing.Point(166, 116);
            this.userType.Margin = new System.Windows.Forms.Padding(4);
            this.userType.Name = "userType";
            this.userType.Size = new System.Drawing.Size(178, 26);
            this.userType.TabIndex = 2;
            this.userType.SelectedIndexChanged += new System.EventHandler(this.userType_SelectedIndexChanged);
            // 
            // zhuce
            // 
            this.zhuce.Location = new System.Drawing.Point(290, 243);
            this.zhuce.Margin = new System.Windows.Forms.Padding(4);
            this.zhuce.Name = "zhuce";
            this.zhuce.Size = new System.Drawing.Size(100, 33);
            this.zhuce.TabIndex = 6;
            this.zhuce.Text = "注册";
            this.zhuce.UseVisualStyleBackColor = true;
            this.zhuce.Click += new System.EventHandler(this.zhuce_Click);
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(166, 48);
            this.num.Margin = new System.Windows.Forms.Padding(4);
            this.num.Mask = "99999";
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(175, 28);
            this.num.TabIndex = 1;
            this.num.ValidatingType = typeof(int);
            this.num.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.num_MaskInputRejected);
            // 
            // Login
            // 
            this.AcceptButton = this.land;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doc.Properties.Resources.图片6;
            this.ClientSize = new System.Drawing.Size(417, 297);
            this.Controls.Add(this.num);
            this.Controls.Add(this.userType);
            this.Controls.Add(this.pwdText);
            this.Controls.Add(this.zhuce);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.land);
            this.Controls.Add(this.pwd);
            this.Controls.Add(this.uType);
            this.Controls.Add(this.uid);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(439, 353);
            this.Name = "Login";
            this.Text = "登录";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uid;
        private System.Windows.Forms.Label uType;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.Button land;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox pwdText;
        private System.Windows.Forms.ComboBox userType;
        private System.Windows.Forms.Button zhuce;
        private System.Windows.Forms.MaskedTextBox num;
    }
}

