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
    public partial class FrmTianJia : Form
    {
        public FrmTianJia()
        {
            InitializeComponent();
        }

        #region button按钮的代码
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.txtAuthor.Text = "";
            this.txtBook.Text = "";
            this.cbocategory.Text  = "";
            this.txtCompany.Text = "";
            this.txtcontent.Text = "";
            this.dateTimePicker1 .Text  = "";
            this.txtISBN.Text = "";
            this.txtprice.Text = "";
        }
        #endregion

        #region 检查用户输入图书信息是否有效
        /// <summary>
        /// 检查用户输入图书信息是否有效
        /// </summary>
        /// <returns>ture 表示有效，false 表示无效</returns>
        public bool CheckInput()
        {
            bool result = false;
            if (string.IsNullOrEmpty(this.txtBook .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtAuthor .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtISBN .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtCompany .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtcontent.Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtprice .Text.Trim()))
            {
                MessageBox.Show("请完善图书信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cbocategory .Text == "")
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
         
        #region 添加图书
        private void btnsure_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                string str = "Data Source=XZW-1113;Initial Catalog=Bookmanagements;Integrated Security=True";
                SqlConnection conn = new SqlConnection(str); ;
                try
                {
                    conn.Open();
                    SqlCommand sqlcmd = new SqlCommand();
                    sqlcmd.Connection = conn;
                    //创建SQL语句
                    string sql = string.Format("select count(*) from[dbo].[Books] where Title='{0}'",
                        this.txtBook.Text.Trim());
                    sqlcmd.CommandText = sql;
                    int n = (int)sqlcmd.ExecuteScalar();
                    if (n >= 1)
                    {
                        MessageBox.Show("该图书已存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(@"insert into [dbo].[Books] values('" + txtBook.Text.Trim() + "','" + cbocategory.Text.Trim() + "','" + txtAuthor.Text.Trim() + "','" + txtISBN.Text.Trim() + "','" + txtCompany.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "','" + txtcontent.Text.Trim() + "','" + txtprice.Text.Trim() + "')", conn);
                        int i = (int)cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK);
                            this.txtAuthor.Text = "";
                            this.txtBook.Text = "";
                            this.cbocategory.Text = "";
                            this.txtCompany.Text = "";
                            this.txtcontent.Text = "";
                            this.dateTimePicker1.Text = "";
                            this.txtISBN.Text = "";
                            this.txtprice.Text = "";
                        }
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

        private void FrmTianJia_Load(object sender, EventArgs e)
        {

        }
    }
}
 