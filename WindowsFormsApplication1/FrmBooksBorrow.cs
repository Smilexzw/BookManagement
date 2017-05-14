using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class FrmBooksBorrow : Form
    {
        public FrmBooksBorrow()
        {
            InitializeComponent();
        }


        #region 总的图书有关代码

        #region  绑定图书信息
        private void Bindbooks()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = "select Id,Title,Author,Bookisbn,Leibie,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books] ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "cs");

                //4.绑定控件
                this.dgvBooks.DataSource = ds.Tables["cs"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region 绑定图书类别
        private void BingbookCategory()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建CMD对象
                string sql = "select * from [dbo].[Categories]";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //3.创建daareader对象
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    //4.绑定控件
                    cboCategory.Items.Add(reader["CategoryName"]);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //关闭连接
                conn.Close();
            }

        }
        #endregion

        #region  多条件检索图书信息
        private void SearchBooks()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = @" select Title,Author,Leibie,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
where 1=1";
                if (this.txtBook.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Title like '%{0}%' ", this.txtBook.Text);
                }
                if (this.cboCategory.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Leibie ='{0}'  ", this.cboCategory.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "books");
                //4.绑定控件
                this.dgvBooks.DataSource = ds.Tables["books"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region  清除图书检索条件
        private void ClearCondition()
        {
            this.txtBook.Text = "";
            this.cboCategory.Text = "";
            this.Bindbooks();
        }
        #endregion
        
        #endregion

        #region 用户的总信息
        #region  绑定用户信息
        private void BindUser()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = "select Id,StudentID,Name,Sex,Institute,Class,IdCard,Birthday,Telephone,QQ,Mail from[dbo].[Person_information]  ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "User");

                //4.绑定控件
                this.dgvUser.DataSource = ds.Tables["User"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region  多条件检索用户信息
        private void SearchUser()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = @" select Id,StudentID,Name,Sex,Institute,Class,IdCard,Birthday,Telephone,QQ,Mail from[dbo].[Person_information]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
where 1=1";
                if (this.txtUserName.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and StudentID ='{0}'", this.txtUserName.Text);
                }
                if (this.cboInstitute.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Institute ='{0}'  ", this.cboInstitute.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "User");
                //4.绑定控件
                this.dgvUser.DataSource = ds.Tables["User"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        #endregion

        #region  清除用户检索条件
        private void ClearUser()
        {
            this.txtUserName.Text = "";
            this.cboInstitute.Text = "";
            this.BindUser();
        }
        #endregion 

        #endregion

        #region  清除用户检索条件
        private void ClearYongHu()
        {
            txtJieShuUser.Text = "";
            txtClass.Text = "";
            txtInstitute.Text = "";
            txtStudentID.Text = "";
            txtSex.Text = "";
        }
        #endregion

        #region  清除图书检索条件
        private void ClearBooks()
        {
            textBook.Text ="";
            textAuthor.Text = "";
            textISBN.Text = "";
            textLeiBie.Text = "";
            textPublishCompany.Text =""; 
            textPublishDate.Text ="";
            textUnitPrice.Text = "";
        }
        #endregion

        #region 按钮的加载事件
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchBooks();
        }

        private void btnsearchUser_Click(object sender, EventArgs e)
        {
            this.SearchUser();
        }

        private void btnQueXiao_Click(object sender, EventArgs e)
        {
            this.ClearUser();
        }

        private void dgvBooks_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBook.Text = dgvBooks.SelectedCells[1].Value.ToString();
            textAuthor.Text = dgvBooks.SelectedCells[2].Value.ToString();
            textISBN.Text = dgvBooks.SelectedCells[3].Value.ToString();
            textLeiBie.Text = dgvBooks.SelectedCells[4].Value.ToString();
            textPublishCompany.Text = dgvBooks.SelectedCells[5].Value.ToString();
            textPublishDate.Text = dgvBooks.SelectedCells[6].Value.ToString();
            textUnitPrice.Text = dgvBooks.SelectedCells[7].Value.ToString();
        }

        private void dgvUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtStudentID.Text = dgvUser.SelectedCells[1].Value.ToString();
            txtJieShuUser.Text = dgvUser.SelectedCells[2].Value.ToString();
            txtSex.Text = dgvUser.SelectedCells[3].Value.ToString();
            txtInstitute.Text = dgvUser.SelectedCells[4].Value.ToString();
            txtClass.Text = dgvUser.SelectedCells[5].Value.ToString();
        }

        private void btnUserClaer_Click(object sender, EventArgs e)
        {
            txtJieShuUser.Text = "";
            txtClass.Text = "";
            txtInstitute.Text = "";
            txtStudentID.Text = "";
            txtSex.Text = "";
        }

        private void btnBookClear_Click(object sender, EventArgs e)
        {
            textAuthor.Text = "";
            textBook.Text = "";
            textISBN.Text = "";
            textLeiBie.Text = "";
            textUnitPrice.Text = "";
            textPublishDate.Text = "";
            textPublishCompany.Text = "";

        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            if (this.txtJieShuUser.Text.Trim() == "" || this.textBook.Text.Trim() == "")
            {
                MessageBox.Show("请完善借书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                #region 借书
                SqlConnection conn = new SqlConnection(DBHelper.connString);
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"insert into [dbo].[BorrowBook] values('" + txtJieShuUser.Text + "','" + txtStudentID.Text + "','" + txtClass.Text + "','" + txtInstitute.Text + "','" + txtSex.Text + "','" + dateTimePicker1.Text + "','" + textBook.Text + "','" + textISBN.Text + "','" + textAuthor.Text + "','" + textLeiBie.Text + "','" + textPublishCompany.Text + "','" + textPublishDate.Text + "','" + textUnitPrice.Text + "')", conn);
                    int i = (int)cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        this.ClearBooks();
                        this.ClearYongHu();
                        MessageBox.Show("借书成功!!!");
                    }
                    SqlCommand sqlcmd = new SqlCommand(@"insert into [dbo].[BorrowJiLu] values('" + txtJieShuUser.Text + "','" + txtStudentID.Text + "','" + txtClass.Text + "','" + txtInstitute.Text + "','" + textBook.Text + "','" + textISBN.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker1.Text + "','" + textPublishCompany.Text + "','" + textAuthor.Text + "','" + textLeiBie.Text + "')", conn);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
                #endregion
            }
        }

        private void btnQuXiaoborrow_Click(object sender, EventArgs e)
        {
            this.ClearBooks();
            this.ClearUser();
        }

        private void btnUserClaer_Click_1(object sender, EventArgs e)
        {
            this.ClearYongHu();
        }

        private void btnBookClear_Click_1(object sender, EventArgs e)
        {
            this.ClearBooks();
        }
        #endregion

        private void FrmBooksBorrow_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = System.DateTime.Now;
            this.Top = 175;
            this.Left = 410;

            #region  图书信息
            this.Bindbooks();
            this.BingbookCategory();
            //设置为整行被选中    
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置dgvbooks的DefaultCellStyle.SelectionBackColor属性，使其选择行的颜色为黄绿色
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dgvBooks控件的ReadOnly属性，使其为只读
            dgvBooks.ReadOnly = true;
            this.dgvBooks.AutoGenerateColumns = false; 
            #endregion

            #region 用户信息
            this.BindUser();
            //设置为整行被选中  
            this.dgvUser.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置dgvbooks的DefaultCellStyle.SelectionBackColor属性，使其选择行的颜色为黄绿色
            dgvUser.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dgvBooks控件的ReadOnly属性，使其为只读
            dgvUser.ReadOnly = true; 
            #endregion

        }
    }
}
