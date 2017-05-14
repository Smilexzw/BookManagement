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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭窗体
            this.Close();
        }

        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //光标聚集在txtUserName
            txtUserName.Focus();
            //选中下拉列表的第一项
            this.cboLoginType.SelectedIndex = 0;    
            //设置Comcobox的ReadOnly属性
            cboLoginType.DropDownStyle = ComboBoxStyle.DropDownList;
            Name = this.txtUserName.Text.Trim();
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
            else if (string.IsNullOrEmpty(this.txtPwd.Text.Trim()))
            {
                MessageBox.Show("密码不能为空", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (this.cboLoginType.Text == "请选择")
            {
                MessageBox.Show("请选择登录类型", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                result = true;
            }
            return result;
        } 
        #endregion

        #region 登录
        /// <summary>
        /// 登录
        /// </summary>
        /// <returns>ture，表示登陆成功。false，表示登录失败</returns>
        public bool Login()
        {
            //定义标识变量
            bool result = false;

            //创建数据库连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开数据库连接
                conn.Open();
                //创建SQL语句
                string sql = string.Format("select count(*) from [dbo].[User] where UserName ='{0}' and Passpwd ='{1}'and LoginType='{2}' ",
                    this.txtUserName.Text.Trim(), this.txtPwd.Text.Trim(), this.cboLoginType.Text.Trim());
                //创建命令对象SQLcommand
                SqlCommand cmd = new SqlCommand(sql, conn);
                int i = (int)cmd.ExecuteScalar();
                if (i > 0)
                {
                    result = true;
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
            return result;
        }
        #endregion


        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                if (Login ())
                {
                    string Name;
                    Name = this.txtUserName.Text.Trim();
                    if (this.cboLoginType.Text == "学员")
                    {
                        //打开BookManagementSysForm窗体
                        this.Hide();
                        FrmStudent frmStudent = new FrmStudent();
                        frmStudent.SetUserName(Name);
                        frmStudent.Show();
                    }
                    else if (this.cboLoginType.Text == "管理员")
                    {
                        //打开BookManagementSysForm窗体
                        this.Hide();
                        BookManagementSysForm from2 = new BookManagementSysForm();
                        from2.SetUserName(Name);
                        from2.Show();
                    }
                }
                else
                {
                    MessageBox.Show("登录失败，用户名或密码错误", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUserName.Clear();
                    txtPwd.Clear();
                    txtUserName.Focus();
                    //选中下拉列表的第一项
                    this.cboLoginType.SelectedIndex = 0; 

                }
            }
        }

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

        private void btnZhuCe_Click(object sender, EventArgs e)
        {
            FrmZhuCe frmZhuCe = new FrmZhuCe();
            frmZhuCe.ShowDialog ();
        }

        private void btnWangJi_Click(object sender, EventArgs e)
        {
            FrmForgetMiMa frmForgetMiMa = new FrmForgetMiMa();
            frmForgetMiMa.ShowDialog();
        }
    }
}
