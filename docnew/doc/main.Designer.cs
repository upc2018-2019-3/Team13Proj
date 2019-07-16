namespace doc
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.科室设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.外科ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.儿科ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.妇科ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.患者服务ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.医师入口ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.科室设置ToolStripMenuItem,
            this.患者服务ToolStripMenuItem,
            this.医师入口ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(605, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "挂号";
            // 
            // 科室设置ToolStripMenuItem
            // 
            this.科室设置ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.外科ToolStripMenuItem,
            this.儿科ToolStripMenuItem,
            this.妇科ToolStripMenuItem});
            this.科室设置ToolStripMenuItem.Name = "科室设置ToolStripMenuItem";
            this.科室设置ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.科室设置ToolStripMenuItem.Text = "科室设置";
            this.科室设置ToolStripMenuItem.Click += new System.EventHandler(this.科室设置ToolStripMenuItem_Click);
            // 
            // 外科ToolStripMenuItem
            // 
            this.外科ToolStripMenuItem.Name = "外科ToolStripMenuItem";
            this.外科ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.外科ToolStripMenuItem.Text = "外科";
            this.外科ToolStripMenuItem.Click += new System.EventHandler(this.外科ToolStripMenuItem_Click);
            // 
            // 儿科ToolStripMenuItem
            // 
            this.儿科ToolStripMenuItem.Name = "儿科ToolStripMenuItem";
            this.儿科ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.儿科ToolStripMenuItem.Text = "儿科";
            this.儿科ToolStripMenuItem.Click += new System.EventHandler(this.儿科ToolStripMenuItem_Click);
            // 
            // 妇科ToolStripMenuItem
            // 
            this.妇科ToolStripMenuItem.Name = "妇科ToolStripMenuItem";
            this.妇科ToolStripMenuItem.Size = new System.Drawing.Size(152, 28);
            this.妇科ToolStripMenuItem.Text = "妇科";
            this.妇科ToolStripMenuItem.Click += new System.EventHandler(this.妇科ToolStripMenuItem_Click);
            // 
            // 患者服务ToolStripMenuItem
            // 
            this.患者服务ToolStripMenuItem.Name = "患者服务ToolStripMenuItem";
            this.患者服务ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.患者服务ToolStripMenuItem.Text = "患者服务";
            this.患者服务ToolStripMenuItem.Click += new System.EventHandler(this.患者服务ToolStripMenuItem_Click);
            // 
            // 医师入口ToolStripMenuItem
            // 
            this.医师入口ToolStripMenuItem.Name = "医师入口ToolStripMenuItem";
            this.医师入口ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.医师入口ToolStripMenuItem.Text = "医师入口";
            this.医师入口ToolStripMenuItem.Click += new System.EventHandler(this.医师入口ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(58, 28);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::doc.Properties.Resources.首页3;
            this.ClientSize = new System.Drawing.Size(605, 339);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(7000, 7000);
            this.Name = "main";
            this.Text = "A市市立医院";
            this.Load += new System.EventHandler(this.main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 科室设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 患者服务ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 外科ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儿科ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 妇科ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 医师入口ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
    }
}