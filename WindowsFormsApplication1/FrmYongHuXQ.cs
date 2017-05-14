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
    public partial class FrmYongHuXQ : Form
    {
        public FrmYongHuXQ()
        {
            InitializeComponent();
        }

        #region  清除检索条件
        private void ClearCondition()
        {
            this.txtXueHao.Text = "";
            this.txtName.Text = "";
            this.cboSex.Text = "";
            this.cboInstitute.Text = "";
            this.txtClass.Text = "";
            this.txtIDcard.Text = "";
            this.dateTimePicker1.Text = "";
            this.txtTel.Text = "";
            this.txtQQ.Text = "";
            this.txtMail.Text = "";
        }
        #endregion

        #region 检查用户输入用户信息是否有效
        /// <summary>
        /// 检查用户输入用户信息是否有效
        /// </summary>
        /// <returns>ture 表示有效，false 表示无效</returns>
        public bool CheckInput()
        {
            bool result = false;
            if (string.IsNullOrEmpty(this.txtXueHao.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtName.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.cboSex.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.cboInstitute.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtIDcard.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.dateTimePicker1.Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtTel .Text.Trim()))
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtQQ .Text == "")
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtMail .Text == "")
            {
                MessageBox.Show("请完善用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region 添加用户信息
        private void btnSure_Click(object sender, EventArgs e)
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
                    string sql = string.Format("select count(*) from[dbo].[Person_information] where StudentID='{0}'",
                        this.txtXueHao.Text.Trim());
                    sqlcmd.CommandText = sql;
                    int n = (int)sqlcmd.ExecuteScalar();
                    if (n >= 1)
                    {
                        MessageBox.Show("该用户已存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand(@"insert into [dbo].[Person_information] values('" + txtXueHao.Text.Trim() + "','" + txtName.Text.Trim() + "','" + cboSex.Text.Trim() + "','" + cboInstitute.Text.Trim() + "','" + txtClass.Text.Trim() + "','" + txtIDcard.Text.Trim() + "','" + dateTimePicker1.Text.Trim() + "','" + txtTel.Text.Trim() + "','" + txtQQ.Text.Trim() + "','" + txtMail.Text.Trim() + "')", conn);
                        int i = (int)cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("添加成功!", "提示", MessageBoxButtons.OK);
                            this.ClearCondition();
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

        private void FrmYongHuXQ_Load(object sender, EventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }
    }
}
