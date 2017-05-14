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
    public partial class FrmZhuCe : Form
    {
        public FrmZhuCe()
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
            if (string.IsNullOrEmpty(this.txtUserName .Text.Trim()))
            {
                MessageBox.Show("请输入用户名", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtMiMa .Text.Trim()))
            {
                MessageBox.Show("请输入密码", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.txtQueRen .Text==""||this.txtQueRen .Text!=this.txtMiMa .Text.Trim())
            {
                MessageBox.Show("密码错误，请从新输入", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.cboLogin .Text.Trim()))
            {
                MessageBox.Show("请选则管理类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.comboBox1 .Text.Trim()))
            {
                MessageBox.Show("请选择密保问题", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(this.txtAnswer .Text.Trim()))
            {
                MessageBox.Show("请输入答密保问题", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                result = true;
            }
            return result;
        }
        #endregion

        #region 注册
        private void btnZhuCe_Click(object sender, EventArgs e)
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
                    string sql = string.Format("select count(*) from [dbo].[User] where UserName ='{0}'",
                        this.txtUserName.Text.Trim());
                    sqlcmd.CommandText = sql;
                    int n = (int)sqlcmd.ExecuteScalar();
                    if (n >= 1)
                    {
                        MessageBox.Show("该用户已存在!", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        SqlCommand cmd = new SqlCommand("insert into [dbo].[User] values('" + txtUserName.Text.Trim() + "','" + txtMiMa.Text.Trim() + "','" + cboLogin.Text.Trim() + "','" + comboBox1.Text.Trim() + "','" + txtAnswer.Text.Trim()+ "')", conn);
                        int i = (int)cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("注册成功，请完善相关的信息!!!", "提示", MessageBoxButtons.OK);
                            this.Close();
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

        private void txtUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 0x20) e.KeyChar = (char)0;  //禁止空格键
            if ((e.KeyChar == 0x2D) && (((TextBox)sender).Text.Length == 0)) return;   //处理负数
            if (e.KeyChar > 0x20)
            {
                try
                {
                    double.Parse(((TextBox)sender).Text + e.KeyChar.ToString());
                }
                catch
                {
                    e.KeyChar = (char)0;   //处理非法字符
                }
            }   
        }

        private void btnGuanBi_Click(object sender, EventArgs e)
        {
            this.Close();
        }
                                
        private void FrmZhuCe_Load(object sender, EventArgs e)
        {
            this.Top = 120;
            this.Left = 1010;
            cboLogin.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboLogin.SelectedIndex = 0;
        }
    }
}
