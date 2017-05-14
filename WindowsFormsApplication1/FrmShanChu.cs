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
    public partial class FrmShanChu : Form
    {
        public FrmShanChu()
        {
            InitializeComponent();
        }


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
                string sql = "select Id,Title,Author,Leibie,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books] ";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "cs");

                //4.绑定控件
                this.dataGridView1.DataSource = ds.Tables["cs"];

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

        #region  检索图书信息
        private void SearchBooks()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = @" select Id,Title,Author,Leibie,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
where 1=1";
                if (this.textBox1.Text.Trim() != "")
                {
                    sql = sql + string.Format(" and Title like '%{0}%' ", this.textBox1.Text);
                }
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "books");
                //4.绑定控件
                this.dataGridView1.DataSource = ds.Tables["books"];

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
            this.textBox1.Text = "";
        }
        #endregion

        #region button按钮的事件
        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.SearchBooks();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }

        private void btnsure_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确定删除选中的一行吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                SqlConnection conn = new SqlConnection("Data Source=XZW-1113;Initial Catalog=Bookmanagements;Integrated Security=True");
                //打开数据库
                conn.Open();
                //创建一个SqlCommand对象
                SqlCommand cmd = new SqlCommand("delete from [dbo].[Books] where Id=" + this.dataGridView1.CurrentRow.Cells[0].Value + "", conn);
                cmd.ExecuteNonQuery();
                //关闭数据库
                conn.Close();
            }
            else { }
        }
        #endregion


        
        private void FrmShanChu_Load(object sender, EventArgs e)
        {
            //设置为整行被选中    
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            //设置dgvbooks的DefaultCellStyle.SelectionBackColor属性，使其选择行的颜色为黄绿色
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dgvBooks控件的ReadOnly属性，使其为只读
            dataGridView1.ReadOnly = true;
            this.Bindbooks();
        }
    }
}
