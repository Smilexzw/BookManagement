using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication1
{
    public partial class BookManagermentFrom : Form
    {
        public BookManagermentFrom()
        {
            InitializeComponent();
        }

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
                string sql = "select Title,Leibie,Author,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books] ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "cs");

                //4.绑定控件
                this.dgvBooks .DataSource = ds.Tables["cs"];

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
                string sql =@" select Title,Author,Leibie,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
where 1=1";
                if (this.txtTitle.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Title like '%{0}%' ", this.txtTitle.Text);
                }

                if (this.txtAuthor.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Author like '%{0}%' ", this.txtAuthor.Text);
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

        #region  清除检索条件
        private void ClearCondition()
        {
            this.txtAuthor.Text = "";
            this.txtTitle.Text = "";
            this.cboCategory.Text = "";
            this.Bindbooks();
        }
        #endregion


        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.SearchBooks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }

        private void BookManagermentFrom_Load(object sender, EventArgs e)
        {
            //设置为整行被选中    
            this.dgvBooks.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            //设置dgvbooks的DefaultCellStyle.SelectionBackColor属性，使其选择行的颜色为黄绿色
            dgvBooks.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dgvBooks控件的ReadOnly属性，使其为只读
            dgvBooks.ReadOnly = true;
            this.dgvBooks.AutoGenerateColumns = false;
            this.Bindbooks();
            this.BingbookCategory();
            //消除DataGridView控件中的最后一行空白
            this.dgvBooks.AllowUserToAddRows = false;
        }

        private void dgvBooks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
