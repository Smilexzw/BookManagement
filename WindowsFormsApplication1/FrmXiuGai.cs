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
    public partial class FrmXiuGai : Form
    {
        public FrmXiuGai()
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
                string sql = "select Id,Title,Author,Bookisbn,Leibie,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books] ";
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
                string sql = @" select Title,Author,Leibie,Bookisbn,PublishCompany,PublishDate,Bookcontent,UnitPrice from[dbo].[Books]                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                        
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
            this.txtAuthor.Text = "";
            this.txtBook.Text = "";
            this.cbocategory.Text = "";
            this.txtCompany.Text = "";
            this.txtcontent.Text = "";
            this.dateTimePicker1.Text = "";
            this.txtISBN.Text = "";
            this.txtprice.Text = "";
        }
        #endregion

        #region button按钮的加载事件
        private void btnsearch_Click(object sender, EventArgs e)
        {
            this.SearchBooks();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }
        private void btnXiuGai_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                SqlConnection conn = new SqlConnection(DBHelper.connString );
                try
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand(@"update [dbo].[Books] set Title='" + txtBook.Text.Trim() + "',Leibie='" + cbocategory.Text.Trim() + "',Author='" + txtAuthor.Text.Trim() + "',Bookisbn='" + txtISBN.Text.Trim() + "',PublishCompany='" + txtCompany.Text.Trim() + "',PublishDate='" + dateTimePicker1.Text.Trim() + "',Bookcontent='" + txtcontent.Text.Trim() + "',UnitPrice='" + txtprice.Text.Trim() + "'where Id='" + txtId.Text + "'", conn);
                    int i = (int)cmd.ExecuteNonQuery();
                    if (i >= 1)
                    {
                        Bindbooks();
                        MessageBox.Show("修改成功!!!");
                        ClearCondition();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现异常" + ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region 检查用户输入数据是否有效
        /// <summary>
        /// 检查用户输入数据是否有效
        /// </summary>
        /// <returns>ture 表示有效，false 表示无效</returns>
        public bool CheckInput()
        {
            bool result = false;
            if (string.IsNullOrEmpty(this.txtBook .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtISBN .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtAuthor .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.cbocategory .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.dateTimePicker1 .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtprice .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtCompany .Text == "")
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtcontent .Text == "")
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

        private void FrmXiuGai_Load(object sender, EventArgs e)
        {
            //设置为整行被选中    
            this.dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置dgvbooks的DefaultCellStyle.SelectionBackColor属性，使其选择行的颜色为黄绿色
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dgvBooks控件的ReadOnly属性，使其为只读
            dataGridView1.ReadOnly = true;
            this.Bindbooks();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dataGridView1.SelectedCells[0].Value.ToString();
            txtBook.Text = dataGridView1.SelectedCells[1].Value.ToString();
            txtAuthor.Text = dataGridView1.SelectedCells[2].Value.ToString();          
            txtISBN.Text = dataGridView1.SelectedCells[3].Value.ToString();
            cbocategory.Text = dataGridView1.SelectedCells[4 ].Value.ToString();
            txtCompany.Text = dataGridView1.SelectedCells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedCells[6].Value.ToString();
            txtcontent.Text = dataGridView1.SelectedCells[7].Value.ToString();
            txtprice.Text = dataGridView1.SelectedCells[8].Value.ToString();    
        }
    }
}
