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
    public partial class FrmForgetMiMa : Form
    {
        public FrmForgetMiMa()
        {
            InitializeComponent();
        }

        #region 检查用户输入数据是否有效
        /// <summary>
        /// 检查用户输入数据是否有效
        /// </summary>
        /// <returns>ture 表示有效，false 表示无效</returns>
        public bool CheckInput()
        {
            bool result = false;
            if (string.IsNullOrEmpty(this.txtUserName.Text.Trim()))
            {
                MessageBox.Show("用户名不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.comboBox1 .Text == "请选择")
            {
                MessageBox.Show("请选择密保问题", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtAnswer .Text.Trim()))
            {
                MessageBox.Show("密保答案不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (string.IsNullOrEmpty(this.txtMiMa.Text.Trim()))
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }     
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region 修改密码
        private void button1_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                //创建数据库连接对象
                SqlConnection conn = new SqlConnection(DBHelper.connString);
                //打开连接
                try
                {
                    conn.Open();
                    //创建SQL语句
                    string selectsql = string.Format("select count(*) from  [dbo].[User] where  UserName='{0}'and MiBaoWenTi='{1}'and Answer='{2}' ",
                          this.txtUserName.Text.Trim(), this.comboBox1.Text.Trim(), this.txtAnswer.Text.Trim());
                    SqlCommand sqlcmd = new SqlCommand(selectsql, conn);
                    int i = (int)sqlcmd.ExecuteScalar();
                    if (i >= 1)
                    {
                        SqlCommand cmd = new SqlCommand(@"update [dbo].[User]  set UserName ='" + txtUserName.Text.Trim() + "',MiBaoWenTi='" + comboBox1.Text.Trim() + "',Answer='" + txtAnswer.Text.Trim() + "',Passpwd='" + txtMiMa.Text.Trim() + "'where UserName='" + txtUserName.Text + "'", conn);
                        int a = (int)cmd.ExecuteNonQuery();
                        if (a >= 1)
                        {
                            MessageBox.Show("修改成功!!!");
                        }
                    }
                    else 
                    {
                        MessageBox.Show("查无此人，请确认用户信息", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("出现异常" + ex.Message);
                }
                //关闭连接
                finally
                {
                    conn.Close();
                }
            }
        }
        #endregion

        #region  清除检索条件
        private void ClearCondition()
        {
            this.txtUserName.Text = "";
            this.comboBox1.Text = "";
            this.txtAnswer.Text = "";
            this.txtMiMa.Text = "";
        }
        #endregion


        private void button2_Click(object sender, EventArgs e)
        {
            this.ClearCondition();
        }

        public FrmForgetMiMa(string text)
        {
            InitializeComponent();
            this.txtUserName.Text = text;
        }
    }
}
