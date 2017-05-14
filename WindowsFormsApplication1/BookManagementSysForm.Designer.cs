namespace WindowsFormsApplication1
{
    partial class BookManagementSysForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookManagementSysForm));
            this.MsBook = new System.Windows.Forms.MenuStrip();
            this.tsmiBookGuanLi = new System.Windows.Forms.ToolStripMenuItem();
            this.图书添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.图书查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookborrow = new System.Windows.Forms.ToolStripMenuItem();
            this.用户借书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户还书ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.系统管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用户设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.计算器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.记事本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmihelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbtnBook = new System.Windows.Forms.ToolStripButton();
            this.tsbtnYHGL = new System.Windows.Forms.ToolStripButton();
            this.tsbtnTuiChu = new System.Windows.Forms.ToolStripButton();
            this.tsbnYongHuZiLiao = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tsbnXiuGaiMM = new System.Windows.Forms.ToolStripButton();
            this.MsBook.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MsBook
            // 
            this.MsBook.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBookGuanLi,
            this.tsmiBookborrow,
            this.系统管理XToolStripMenuItem,
            this.工具管理ToolStripMenuItem,
            this.tsmihelp});
            this.MsBook.Location = new System.Drawing.Point(0, 0);
            this.MsBook.Name = "MsBook";
            this.MsBook.Size = new System.Drawing.Size(1445, 28);
            this.MsBook.TabIndex = 1;
            this.MsBook.Text = "menuStrip1";
            // 
            // tsmiBookGuanLi
            // 
            this.tsmiBookGuanLi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.图书添加ToolStripMenuItem,
            this.图书修改ToolStripMenuItem,
            this.图书删除ToolStripMenuItem,
            this.图书查询ToolStripMenuItem});
            this.tsmiBookGuanLi.Name = "tsmiBookGuanLi";
            this.tsmiBookGuanLi.Size = new System.Drawing.Size(81, 24);
            this.tsmiBookGuanLi.Text = "图书管理";
            // 
            // 图书添加ToolStripMenuItem
            // 
            this.图书添加ToolStripMenuItem.Name = "图书添加ToolStripMenuItem";
            this.图书添加ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.图书添加ToolStripMenuItem.Text = "图书添加";
            this.图书添加ToolStripMenuItem.Click += new System.EventHandler(this.图书添加ToolStripMenuItem_Click);
            // 
            // 图书修改ToolStripMenuItem
            // 
            this.图书修改ToolStripMenuItem.Name = "图书修改ToolStripMenuItem";
            this.图书修改ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.图书修改ToolStripMenuItem.Text = "图书修改";
            this.图书修改ToolStripMenuItem.Click += new System.EventHandler(this.图书修改ToolStripMenuItem_Click);
            // 
            // 图书删除ToolStripMenuItem
            // 
            this.图书删除ToolStripMenuItem.Name = "图书删除ToolStripMenuItem";
            this.图书删除ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.图书删除ToolStripMenuItem.Text = "图书删除";
            this.图书删除ToolStripMenuItem.Click += new System.EventHandler(this.图书删除ToolStripMenuItem_Click);
            // 
            // 图书查询ToolStripMenuItem
            // 
            this.图书查询ToolStripMenuItem.Name = "图书查询ToolStripMenuItem";
            this.图书查询ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.图书查询ToolStripMenuItem.Text = "图书查询";
            this.图书查询ToolStripMenuItem.Click += new System.EventHandler(this.图书查询ToolStripMenuItem_Click);
            // 
            // tsmiBookborrow
            // 
            this.tsmiBookborrow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户借书ToolStripMenuItem,
            this.用户还书ToolStripMenuItem});
            this.tsmiBookborrow.Name = "tsmiBookborrow";
            this.tsmiBookborrow.Size = new System.Drawing.Size(141, 24);
            this.tsmiBookborrow.Text = "流通外借出纳管理";
            // 
            // 用户借书ToolStripMenuItem
            // 
            this.用户借书ToolStripMenuItem.Name = "用户借书ToolStripMenuItem";
            this.用户借书ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.用户借书ToolStripMenuItem.Text = "用户借书";
            this.用户借书ToolStripMenuItem.Click += new System.EventHandler(this.用户借书ToolStripMenuItem_Click);
            // 
            // 用户还书ToolStripMenuItem
            // 
            this.用户还书ToolStripMenuItem.Name = "用户还书ToolStripMenuItem";
            this.用户还书ToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.用户还书ToolStripMenuItem.Text = "用户还书";
            this.用户还书ToolStripMenuItem.Click += new System.EventHandler(this.用户还书ToolStripMenuItem_Click);
            // 
            // 系统管理XToolStripMenuItem
            // 
            this.系统管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新登录ToolStripMenuItem,
            this.用户设置ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.系统管理XToolStripMenuItem.Name = "系统管理XToolStripMenuItem";
            this.系统管理XToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.系统管理XToolStripMenuItem.Text = "系统管理";
            // 
            // 重新登录ToolStripMenuItem
            // 
            this.重新登录ToolStripMenuItem.Name = "重新登录ToolStripMenuItem";
            this.重新登录ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.重新登录ToolStripMenuItem.Text = "重新登录";
            this.重新登录ToolStripMenuItem.Click += new System.EventHandler(this.重新登录ToolStripMenuItem_Click);
            // 
            // 用户设置ToolStripMenuItem
            // 
            this.用户设置ToolStripMenuItem.Name = "用户设置ToolStripMenuItem";
            this.用户设置ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.用户设置ToolStripMenuItem.Text = "用户管理";
            this.用户设置ToolStripMenuItem.Click += new System.EventHandler(this.用户设置ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // 工具管理ToolStripMenuItem
            // 
            this.工具管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.计算器ToolStripMenuItem,
            this.记事本ToolStripMenuItem});
            this.工具管理ToolStripMenuItem.Name = "工具管理ToolStripMenuItem";
            this.工具管理ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.工具管理ToolStripMenuItem.Text = "工具管理";
            // 
            // 计算器ToolStripMenuItem
            // 
            this.计算器ToolStripMenuItem.Name = "计算器ToolStripMenuItem";
            this.计算器ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.计算器ToolStripMenuItem.Text = "计算器";
            this.计算器ToolStripMenuItem.Click += new System.EventHandler(this.计算器ToolStripMenuItem_Click);
            // 
            // 记事本ToolStripMenuItem
            // 
            this.记事本ToolStripMenuItem.Name = "记事本ToolStripMenuItem";
            this.记事本ToolStripMenuItem.Size = new System.Drawing.Size(123, 24);
            this.记事本ToolStripMenuItem.Text = "记事本";
            this.记事本ToolStripMenuItem.Click += new System.EventHandler(this.记事本ToolStripMenuItem_Click);
            // 
            // tsmihelp
            // 
            this.tsmihelp.Name = "tsmihelp";
            this.tsmihelp.Size = new System.Drawing.Size(51, 24);
            this.tsmihelp.Text = "帮助";
            this.tsmihelp.Click += new System.EventHandler(this.tsmihelp_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnBook,
            this.tsbtnYHGL,
            this.tsbtnTuiChu,
            this.tsbnYongHuZiLiao,
            this.tsbnXiuGaiMM});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1445, 27);
            this.toolStrip1.TabIndex = 8;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbtnBook
            // 
            this.tsbtnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnBook.Image")));
            this.tsbtnBook.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnBook.Name = "tsbtnBook";
            this.tsbtnBook.Size = new System.Drawing.Size(89, 24);
            this.tsbtnBook.Text = "用户管理";
            this.tsbtnBook.Click += new System.EventHandler(this.tsbtnBook_Click);
            // 
            // tsbtnYHGL
            // 
            this.tsbtnYHGL.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnYHGL.Image")));
            this.tsbtnYHGL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnYHGL.Name = "tsbtnYHGL";
            this.tsbtnYHGL.Size = new System.Drawing.Size(119, 24);
            this.tsbtnYHGL.Text = "用户信息管理";
            this.tsbtnYHGL.Click += new System.EventHandler(this.tsbtnYHGL_Click);
            // 
            // tsbtnTuiChu
            // 
            this.tsbtnTuiChu.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnTuiChu.Image")));
            this.tsbtnTuiChu.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnTuiChu.Name = "tsbtnTuiChu";
            this.tsbtnTuiChu.Size = new System.Drawing.Size(89, 24);
            this.tsbtnTuiChu.Text = "退出系统";
            this.tsbtnTuiChu.Click += new System.EventHandler(this.tsbtnTuiChu_Click);
            // 
            // tsbnYongHuZiLiao
            // 
            this.tsbnYongHuZiLiao.Image = ((System.Drawing.Image)(resources.GetObject("tsbnYongHuZiLiao.Image")));
            this.tsbnYongHuZiLiao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnYongHuZiLiao.Name = "tsbnYongHuZiLiao";
            this.tsbnYongHuZiLiao.Size = new System.Drawing.Size(89, 24);
            this.tsbnYongHuZiLiao.Text = "用户详情";
            this.tsbnYongHuZiLiao.Click += new System.EventHandler(this.tsbnYongHuZiLiao_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1013);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1445, 25);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(205, 20);
            this.toolStripStatusLabel1.Text = "||欢迎使用图书信息管理系统||";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(127, 20);
            this.toolStripStatusLabel2.Text = "      当前系统时间:";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(144, 20);
            this.toolStripStatusLabel3.Text = "显示当前的系统时间";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(97, 20);
            this.toolStripStatusLabel4.Text = "      欢迎用户:";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(144, 20);
            this.toolStripStatusLabel5.Text = "显示当前登录的用户";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 55);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(251, 958);
            this.treeView1.TabIndex = 10;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
            // 
            // tsbnXiuGaiMM
            // 
            this.tsbnXiuGaiMM.Image = ((System.Drawing.Image)(resources.GetObject("tsbnXiuGaiMM.Image")));
            this.tsbnXiuGaiMM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbnXiuGaiMM.Name = "tsbnXiuGaiMM";
            this.tsbnXiuGaiMM.Size = new System.Drawing.Size(89, 24);
            this.tsbnXiuGaiMM.Text = "修改密码";
            this.tsbnXiuGaiMM.Click += new System.EventHandler(this.tsbnXiuGaiMM_Click);
            // 
            // BookManagementSysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1445, 1038);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.MsBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MsBook;
            this.MaximizeBox = false;
            this.Name = "BookManagementSysForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "欢迎使用图书信息管理系统！";
            this.Load += new System.EventHandler(this.BookManagementSysForm_Load);
            this.MsBook.ResumeLayout(false);
            this.MsBook.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MsBook;
        private System.Windows.Forms.ToolStripMenuItem tsmihelp;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookGuanLi;
        private System.Windows.Forms.ToolStripMenuItem 系统管理XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户设置ToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbtnBook;
        private System.Windows.Forms.ToolStripButton tsbtnTuiChu;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripButton tsbtnYHGL;
        private System.Windows.Forms.ToolStripMenuItem 图书添加ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书修改ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书删除ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 图书查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookborrow;
        private System.Windows.Forms.ToolStripMenuItem 用户借书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 用户还书ToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton tsbnYongHuZiLiao;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 计算器ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 记事本ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripButton tsbnXiuGaiMM;
    }
}