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
    public partial class FrmBooksReturn : Form
    {
        public FrmBooksReturn()
        {
            InitializeComponent();
        }


        #region  绑定用户借书信息
        private void Bindbooksborrow()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = "select Id,Name,StudentID,Class,Institute,Sex,BorrowDay,Book,ISBN,Author,Category,PublishCompany,PublishDate,UnitPrice from [dbo].[BorrowBook]  ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "BorrowBook");

                //4.绑定控件
                this.dataGridView1.DataSource = ds.Tables["BorrowBook"];

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

        #region 还书
        private void btnReturn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=XZW-1113;Initial Catalog=Bookmanagements;Integrated Security=True");
            if (this.dataGridView1.SelectedRows.Count > 0)
            {
                DataRowView drv = dataGridView1.SelectedRows[0].DataBoundItem as DataRowView;
                drv.Delete();
            }
            //打开数据库
            conn.Open();
            //创建一个SqlCommand对象
            SqlCommand cmd1 = new SqlCommand("delete from [dbo].[BorrowBook] where Id=" + this.dataGridView1.CurrentRow.Cells[0].Value + "", conn);
            cmd1.ExecuteNonQuery();
            //关闭数据库
            conn.Close();
        }
        #endregion

        #region  多条件检索用户借书信息
        private void SearchBooksborrow()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = @" select Id,Name,StudentID,Class,Institute,Sex,BorrowDay,Book,ISBN,Author,Category,PublishCompany,PublishDate,UnitPrice from [dbo].[BorrowBook]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
where 1=1";
                if (this.txtUser .Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Name like '%{0}%' ", this.txtUser .Text);
                }

                if (this.txtStudentID .Text.Trim() != "")
                {
                    sql = sql + string.Format(" and StudentID ='{0}'", this.txtStudentID .Text);
                }

                if (this.txtBook .Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Book like '%{0}%'  ", this.txtBook .Text);
                }
                if (this.txtISBN .Text.Trim() != "")
                {
                    sql = sql + string.Format(" and ISBN  ='{0}'  ", this.txtBook.Text);
                }

                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "BorrowBook");
                //4.绑定控件
                this.dataGridView1.DataSource = ds.Tables["BorrowBook"];

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

        #region  清除检索条件
        private void ClearCondition()
        {
            this.txtUser .Text = "";
            this.txtStudentID .Text = "";
            this.txtISBN .Text = "";
            this.txtBook.Text = "";
            this.Bindbooksborrow();
        }
        #endregion


        private void FrmBooksReturn_Load(object sender, EventArgs e)
        {
            this.Top = 175;
            this.Left = 410;
            //绑定用户借书信息
            this.Bindbooksborrow();
            //设置dataGridView1的属性为选中一行
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置选中的一行颜色为黄绿色
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            dataGridView1.ReadOnly = true;
            //消除DataGridView控件中最后一行空白行
            this.dataGridView1.AllowUserToAddRows = false; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.SearchBooksborrow();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }
    }
}
