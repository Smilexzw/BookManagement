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
    public partial class FrmYongHu : Form
    {
        public FrmYongHu()
        {
            InitializeComponent();
        }


        #region  绑定用户信息
        private void BindYongHu()
        {
            //1.创建连接对象
            SqlConnection conn = new SqlConnection(DBHelper.connString);
            try
            {
                //打开连接
                conn.Open();
                //2.创建数据适配器
                string sql = "select UserName,Passpwd ,LoginType from [dbo].[User]";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3.创建DATESET对象
                DataSet ds = new System.Data.DataSet();
                da.Fill(ds, "User");

                //4.绑定控件
                this.dgvYongHu .DataSource = ds.Tables["User"];

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
        private void FrmYongHu_Load(object sender, EventArgs e)
        {
             this.BindYongHu();
            //设置为整行被选中
            dgvYongHu.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置为被选中的整行的颜色为黄绿色
            dgvYongHu.DefaultCellStyle.SelectionBackColor = Color.YellowGreen;
            //设置dataGridView1控件的ReadOnly属性，使其为只读
            dgvYongHu.ReadOnly = true;
        }
    }
}
