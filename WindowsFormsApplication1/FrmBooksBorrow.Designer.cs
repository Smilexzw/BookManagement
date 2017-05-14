namespace WindowsFormsApplication1
{
    partial class FrmBooksBorrow
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBook = new System.Windows.Forms.TextBox();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboInstitute = new System.Windows.Forms.ComboBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnQueXiao = new System.Windows.Forms.Button();
            this.btnsearchUser = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvUser = new System.Windows.Forms.DataGridView();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnUserClaer = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInstitute = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtJieShuUser = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.btnBookClear = new System.Windows.Forms.Button();
            this.textUnitPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.textPublishDate = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.textPublishCompany = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textLeiBie = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.textAuthor = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.textISBN = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBook = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnborrow = new System.Windows.Forms.Button();
            this.btnQuXiaoborrow = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBook);
            this.groupBox1.Controls.Add(this.cboCategory);
            this.groupBox1.Controls.Add(this.btnClear);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(635, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(486, 396);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "书籍搜索";
            // 
            // txtBook
            // 
            this.txtBook.Location = new System.Drawing.Point(74, 28);
            this.txtBook.Name = "txtBook";
            this.txtBook.Size = new System.Drawing.Size(152, 25);
            this.txtBook.TabIndex = 7;
            // 
            // cboCategory
            // 
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(302, 30);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(162, 23);
            this.cboCategory.TabIndex = 6;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(363, 349);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(104, 31);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "取消";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(246, 349);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 31);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "搜索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "类别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "书名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvBooks);
            this.groupBox2.Location = new System.Drawing.Point(20, 71);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(450, 272);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "图书信息";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToResizeColumns = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBooks.Location = new System.Drawing.Point(3, 21);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowTemplate.Height = 27;
            this.dgvBooks.Size = new System.Drawing.Size(444, 248);
            this.dgvBooks.TabIndex = 1;
            this.dgvBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellClick);
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Id";
            this.Column9.HeaderText = "ID";
            this.Column9.Name = "Column9";
            this.Column9.Visible = false;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Title";
            this.Column1.HeaderText = "标题";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Author";
            this.Column2.HeaderText = "作者";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "Bookisbn";
            this.Column3.HeaderText = "ISBN";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "Leibie";
            this.Column4.HeaderText = "类别";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PublishCompany";
            this.Column5.HeaderText = "出版社";
            this.Column5.Name = "Column5";
            this.Column5.Visible = false;
            this.Column5.Width = 124;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PublishDate";
            this.Column6.HeaderText = "出版日期";
            this.Column6.Name = "Column6";
            this.Column6.Visible = false;
            this.Column6.Width = 124;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Bookcontent";
            this.Column7.HeaderText = "内容";
            this.Column7.Name = "Column7";
            this.Column7.Visible = false;
            this.Column7.Width = 124;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Column8.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column8.HeaderText = "单价";
            this.Column8.Name = "Column8";
            this.Column8.Visible = false;
            this.Column8.Width = 124;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboInstitute);
            this.groupBox3.Controls.Add(this.txtUserName);
            this.groupBox3.Controls.Add(this.btnQueXiao);
            this.groupBox3.Controls.Add(this.btnsearchUser);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Location = new System.Drawing.Point(66, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(486, 396);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "用户搜索";
            // 
            // cboInstitute
            // 
            this.cboInstitute.FormattingEnabled = true;
            this.cboInstitute.Items.AddRange(new object[] {
            "软件院",
            "国土院",
            "人文院",
            "职师院",
            "经管院",
            "农科院",
            "动科院",
            "园林院"});
            this.cboInstitute.Location = new System.Drawing.Point(308, 30);
            this.cboInstitute.Name = "cboInstitute";
            this.cboInstitute.Size = new System.Drawing.Size(162, 23);
            this.cboInstitute.TabIndex = 9;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(87, 28);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(152, 25);
            this.txtUserName.TabIndex = 8;
            // 
            // btnQueXiao
            // 
            this.btnQueXiao.Location = new System.Drawing.Point(366, 349);
            this.btnQueXiao.Name = "btnQueXiao";
            this.btnQueXiao.Size = new System.Drawing.Size(104, 31);
            this.btnQueXiao.TabIndex = 6;
            this.btnQueXiao.Text = "取消";
            this.btnQueXiao.UseVisualStyleBackColor = true;
            this.btnQueXiao.Click += new System.EventHandler(this.btnQueXiao_Click);
            // 
            // btnsearchUser
            // 
            this.btnsearchUser.Location = new System.Drawing.Point(246, 349);
            this.btnsearchUser.Name = "btnsearchUser";
            this.btnsearchUser.Size = new System.Drawing.Size(104, 31);
            this.btnsearchUser.TabIndex = 5;
            this.btnsearchUser.Text = "搜索";
            this.btnsearchUser.UseVisualStyleBackColor = true;
            this.btnsearchUser.Click += new System.EventHandler(this.btnsearchUser_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "院系";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "用户名";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvUser);
            this.groupBox4.Location = new System.Drawing.Point(20, 71);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(450, 272);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "用户信息";
            // 
            // dgvUser
            // 
            this.dgvUser.AllowUserToResizeColumns = false;
            this.dgvUser.AllowUserToResizeRows = false;
            this.dgvUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column10,
            this.Column11,
            this.Column14,
            this.Column12,
            this.Column20,
            this.Column15,
            this.Column16,
            this.Column13,
            this.Column17,
            this.Column18,
            this.Column19});
            this.dgvUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUser.Location = new System.Drawing.Point(3, 21);
            this.dgvUser.Name = "dgvUser";
            this.dgvUser.RowHeadersVisible = false;
            this.dgvUser.RowTemplate.Height = 27;
            this.dgvUser.Size = new System.Drawing.Size(444, 248);
            this.dgvUser.TabIndex = 0;
            this.dgvUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUser_CellClick);
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Id";
            this.Column10.HeaderText = "ID";
            this.Column10.Name = "Column10";
            this.Column10.Visible = false;
            // 
            // Column11
            // 
            this.Column11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column11.DataPropertyName = "StudentID";
            this.Column11.HeaderText = "学号";
            this.Column11.Name = "Column11";
            // 
            // Column14
            // 
            this.Column14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column14.DataPropertyName = "Name";
            this.Column14.HeaderText = "姓名";
            this.Column14.Name = "Column14";
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Sex";
            this.Column12.HeaderText = "性别";
            this.Column12.Name = "Column12";
            this.Column12.Visible = false;
            // 
            // Column20
            // 
            this.Column20.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column20.DataPropertyName = "Institute";
            this.Column20.HeaderText = "院系";
            this.Column20.Name = "Column20";
            // 
            // Column15
            // 
            this.Column15.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column15.DataPropertyName = "Class";
            this.Column15.HeaderText = "班级";
            this.Column15.Name = "Column15";
            // 
            // Column16
            // 
            this.Column16.DataPropertyName = "IdCard";
            this.Column16.HeaderText = "身份证号";
            this.Column16.Name = "Column16";
            this.Column16.Visible = false;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "Birthday";
            this.Column13.HeaderText = "生日";
            this.Column13.Name = "Column13";
            this.Column13.Visible = false;
            // 
            // Column17
            // 
            this.Column17.DataPropertyName = "Telephone";
            this.Column17.HeaderText = "电话";
            this.Column17.Name = "Column17";
            this.Column17.Visible = false;
            // 
            // Column18
            // 
            this.Column18.DataPropertyName = "QQ";
            this.Column18.HeaderText = "QQ";
            this.Column18.Name = "Column18";
            this.Column18.Visible = false;
            // 
            // Column19
            // 
            this.Column19.DataPropertyName = "Mail";
            this.Column19.HeaderText = "E-Mail";
            this.Column19.Name = "Column19";
            this.Column19.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnUserClaer);
            this.groupBox6.Controls.Add(this.dateTimePicker1);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.txtSex);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.txtStudentID);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.txtClass);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtInstitute);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.txtJieShuUser);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(66, 414);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1055, 106);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "借书人信息";
            // 
            // btnUserClaer
            // 
            this.btnUserClaer.Location = new System.Drawing.Point(883, 37);
            this.btnUserClaer.Name = "btnUserClaer";
            this.btnUserClaer.Size = new System.Drawing.Size(104, 31);
            this.btnUserClaer.TabIndex = 20;
            this.btnUserClaer.Text = "清除";
            this.btnUserClaer.UseVisualStyleBackColor = true;
            this.btnUserClaer.Click += new System.EventHandler(this.btnUserClaer_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(615, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(156, 25);
            this.dateTimePicker1.TabIndex = 19;
            this.dateTimePicker1.Value = new System.DateTime(2017, 4, 1, 0, 0, 0, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(516, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 15);
            this.label10.TabIndex = 18;
            this.label10.Text = "借书日期";
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(340, 60);
            this.txtSex.Name = "txtSex";
            this.txtSex.ReadOnly = true;
            this.txtSex.Size = new System.Drawing.Size(152, 25);
            this.txtSex.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(279, 66);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 15);
            this.label9.TabIndex = 16;
            this.label9.Text = "性别";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(87, 60);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(152, 25);
            this.txtStudentID.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 63);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "证件号";
            // 
            // txtClass
            // 
            this.txtClass.Location = new System.Drawing.Point(619, 24);
            this.txtClass.Name = "txtClass";
            this.txtClass.ReadOnly = true;
            this.txtClass.Size = new System.Drawing.Size(152, 25);
            this.txtClass.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(543, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "班级";
            // 
            // txtInstitute
            // 
            this.txtInstitute.Location = new System.Drawing.Point(340, 18);
            this.txtInstitute.Name = "txtInstitute";
            this.txtInstitute.ReadOnly = true;
            this.txtInstitute.Size = new System.Drawing.Size(152, 25);
            this.txtInstitute.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(276, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "院系";
            // 
            // txtJieShuUser
            // 
            this.txtJieShuUser.Location = new System.Drawing.Point(87, 18);
            this.txtJieShuUser.Name = "txtJieShuUser";
            this.txtJieShuUser.ReadOnly = true;
            this.txtJieShuUser.Size = new System.Drawing.Size(152, 25);
            this.txtJieShuUser.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(35, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 0;
            this.label5.Text = "用户";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.btnBookClear);
            this.groupBox7.Controls.Add(this.textUnitPrice);
            this.groupBox7.Controls.Add(this.label17);
            this.groupBox7.Controls.Add(this.textPublishDate);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Controls.Add(this.textPublishCompany);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.textLeiBie);
            this.groupBox7.Controls.Add(this.label14);
            this.groupBox7.Controls.Add(this.textAuthor);
            this.groupBox7.Controls.Add(this.label13);
            this.groupBox7.Controls.Add(this.textISBN);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.textBook);
            this.groupBox7.Controls.Add(this.label11);
            this.groupBox7.Location = new System.Drawing.Point(66, 530);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(1055, 106);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "书籍信息";
            // 
            // btnBookClear
            // 
            this.btnBookClear.Location = new System.Drawing.Point(883, 62);
            this.btnBookClear.Name = "btnBookClear";
            this.btnBookClear.Size = new System.Drawing.Size(104, 31);
            this.btnBookClear.TabIndex = 32;
            this.btnBookClear.Text = "清除";
            this.btnBookClear.UseVisualStyleBackColor = true;
            this.btnBookClear.Click += new System.EventHandler(this.btnBookClear_Click_1);
            // 
            // textUnitPrice
            // 
            this.textUnitPrice.Location = new System.Drawing.Point(604, 67);
            this.textUnitPrice.Name = "textUnitPrice";
            this.textUnitPrice.ReadOnly = true;
            this.textUnitPrice.Size = new System.Drawing.Size(152, 25);
            this.textUnitPrice.TabIndex = 31;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(543, 73);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 30;
            this.label17.Text = "单价";
            // 
            // textPublishDate
            // 
            this.textPublishDate.Location = new System.Drawing.Point(340, 58);
            this.textPublishDate.Name = "textPublishDate";
            this.textPublishDate.ReadOnly = true;
            this.textPublishDate.Size = new System.Drawing.Size(152, 25);
            this.textPublishDate.TabIndex = 29;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(250, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 15);
            this.label16.TabIndex = 28;
            this.label16.Text = "出版日期";
            // 
            // textPublishCompany
            // 
            this.textPublishCompany.Location = new System.Drawing.Point(77, 55);
            this.textPublishCompany.Name = "textPublishCompany";
            this.textPublishCompany.ReadOnly = true;
            this.textPublishCompany.Size = new System.Drawing.Size(152, 25);
            this.textPublishCompany.TabIndex = 27;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(16, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 15);
            this.label15.TabIndex = 26;
            this.label15.Text = "出版社";
            // 
            // textLeiBie
            // 
            this.textLeiBie.Location = new System.Drawing.Point(854, 27);
            this.textLeiBie.Name = "textLeiBie";
            this.textLeiBie.ReadOnly = true;
            this.textLeiBie.Size = new System.Drawing.Size(152, 25);
            this.textLeiBie.TabIndex = 25;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(793, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 15);
            this.label14.TabIndex = 24;
            this.label14.Text = "类别";
            // 
            // textAuthor
            // 
            this.textAuthor.Location = new System.Drawing.Point(604, 27);
            this.textAuthor.Name = "textAuthor";
            this.textAuthor.ReadOnly = true;
            this.textAuthor.Size = new System.Drawing.Size(152, 25);
            this.textAuthor.TabIndex = 23;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(543, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 15);
            this.label13.TabIndex = 22;
            this.label13.Text = "作者";
            // 
            // textISBN
            // 
            this.textISBN.Location = new System.Drawing.Point(325, 30);
            this.textISBN.Name = "textISBN";
            this.textISBN.ReadOnly = true;
            this.textISBN.Size = new System.Drawing.Size(152, 25);
            this.textISBN.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(264, 36);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 15);
            this.label12.TabIndex = 20;
            this.label12.Text = "ISBN";
            // 
            // textBook
            // 
            this.textBook.Location = new System.Drawing.Point(77, 24);
            this.textBook.Name = "textBook";
            this.textBook.ReadOnly = true;
            this.textBook.Size = new System.Drawing.Size(152, 25);
            this.textBook.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 15);
            this.label11.TabIndex = 18;
            this.label11.Text = "书名";
            // 
            // btnborrow
            // 
            this.btnborrow.Location = new System.Drawing.Point(881, 662);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(104, 31);
            this.btnborrow.TabIndex = 5;
            this.btnborrow.Text = "确认借书";
            this.btnborrow.UseVisualStyleBackColor = true;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // btnQuXiaoborrow
            // 
            this.btnQuXiaoborrow.Location = new System.Drawing.Point(1017, 662);
            this.btnQuXiaoborrow.Name = "btnQuXiaoborrow";
            this.btnQuXiaoborrow.Size = new System.Drawing.Size(104, 31);
            this.btnQuXiaoborrow.TabIndex = 6;
            this.btnQuXiaoborrow.Text = "取消借书";
            this.btnQuXiaoborrow.UseVisualStyleBackColor = true;
            this.btnQuXiaoborrow.Click += new System.EventHandler(this.btnQuXiaoborrow_Click);
            // 
            // FrmBooksBorrow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 716);
            this.Controls.Add(this.btnQuXiaoborrow);
            this.Controls.Add(this.btnborrow);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmBooksBorrow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户借书";
            this.Load += new System.EventHandler(this.FrmBooksBorrow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUser)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.TextBox txtBook;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cboInstitute;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnQueXiao;
        private System.Windows.Forms.Button btnsearchUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column20;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column19;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnUserClaer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtClass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtInstitute;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtJieShuUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button btnBookClear;
        private System.Windows.Forms.TextBox textUnitPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox textPublishDate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox textPublishCompany;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox textLeiBie;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textAuthor;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox textISBN;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBook;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Button btnQuXiaoborrow;
    }
}