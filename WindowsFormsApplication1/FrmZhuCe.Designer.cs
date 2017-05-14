namespace WindowsFormsApplication1
{
    partial class FrmZhuCe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmZhuCe));
            this.label1 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMiMa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQueRen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnZhuCe = new System.Windows.Forms.Button();
            this.btnGuanBi = new System.Windows.Forms.Button();
            this.cboLogin = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.txtAnswer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(95, 39);
            this.txtUserName.MaxLength = 8;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(137, 25);
            this.txtUserName.TabIndex = 4;
            this.txtUserName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUserName_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "密码";
            // 
            // txtMiMa
            // 
            this.txtMiMa.Location = new System.Drawing.Point(95, 88);
            this.txtMiMa.Name = "txtMiMa";
            this.txtMiMa.PasswordChar = '*';
            this.txtMiMa.Size = new System.Drawing.Size(137, 25);
            this.txtMiMa.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "确认密码";
            // 
            // txtQueRen
            // 
            this.txtQueRen.Location = new System.Drawing.Point(95, 136);
            this.txtQueRen.Name = "txtQueRen";
            this.txtQueRen.PasswordChar = '*';
            this.txtQueRen.Size = new System.Drawing.Size(137, 25);
            this.txtQueRen.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "登录类型";
            // 
            // btnZhuCe
            // 
            this.btnZhuCe.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnZhuCe.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnZhuCe.Location = new System.Drawing.Point(49, 355);
            this.btnZhuCe.Name = "btnZhuCe";
            this.btnZhuCe.Size = new System.Drawing.Size(94, 56);
            this.btnZhuCe.TabIndex = 11;
            this.btnZhuCe.Text = "注册";
            this.btnZhuCe.UseVisualStyleBackColor = true;
            this.btnZhuCe.Click += new System.EventHandler(this.btnZhuCe_Click);
            // 
            // btnGuanBi
            // 
            this.btnGuanBi.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGuanBi.Font = new System.Drawing.Font("宋体", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGuanBi.Location = new System.Drawing.Point(164, 355);
            this.btnGuanBi.Name = "btnGuanBi";
            this.btnGuanBi.Size = new System.Drawing.Size(94, 56);
            this.btnGuanBi.TabIndex = 12;
            this.btnGuanBi.Text = "关闭";
            this.btnGuanBi.UseVisualStyleBackColor = true;
            this.btnGuanBi.Click += new System.EventHandler(this.btnGuanBi_Click);
            // 
            // cboLogin
            // 
            this.cboLogin.FormattingEnabled = true;
            this.cboLogin.Items.AddRange(new object[] {
            "请选择",
            "学员",
            "管理员"});
            this.cboLogin.Location = new System.Drawing.Point(95, 186);
            this.cboLogin.Name = "cboLogin";
            this.cboLogin.Size = new System.Drawing.Size(137, 23);
            this.cboLogin.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.txtAnswer);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboLogin);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtQueRen);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtMiMa);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtUserName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 321);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "你的爱好是什么？",
            "你的父亲是谁？",
            "你的女朋友是谁？"});
            this.comboBox1.Location = new System.Drawing.Point(95, 231);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(134, 23);
            this.comboBox1.TabIndex = 26;
            // 
            // txtAnswer
            // 
            this.txtAnswer.Location = new System.Drawing.Point(95, 275);
            this.txtAnswer.MaxLength = 8;
            this.txtAnswer.Name = "txtAnswer";
            this.txtAnswer.Size = new System.Drawing.Size(137, 25);
            this.txtAnswer.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 24;
            this.label5.Text = "密保答案";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 23;
            this.label6.Text = "密保问题";
            // 
            // FrmZhuCe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuanBi);
            this.Controls.Add(this.btnZhuCe);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmZhuCe";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmZhuCe_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMiMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQueRen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnZhuCe;
        private System.Windows.Forms.Button btnGuanBi;
        private System.Windows.Forms.ComboBox cboLogin;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;

    }
}