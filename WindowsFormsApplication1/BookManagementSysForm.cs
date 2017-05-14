using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class BookManagementSysForm : Form
    {
        public BookManagementSysForm()
        {
            InitializeComponent();
        }

        private void BookManagementSysForm_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();//清空导航菜单
            //调用GetMenu方法，将menuStrip1控件的子菜单添加到treeView1控件中
            GetMenu(treeView1,MsBook );
            this.treeView1.ExpandAll();
            //设置statusStrip1的属性(显示时间)
            this.toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString();
        }

        #region  将MenuStrip控件中的信息添加到TreeView控件中
        /// <summary>
        /// 将MenuStrip控件中的信息添加到TreeView控件中
        /// </summary>
        /// <param name="treeV">TreeView控件</param>
        /// <param name="MenuS">MenuStrip控件</param>
        public void GetMenu(TreeView treeV, MenuStrip MenuS)
        {
            for (int i = 0; i < MenuS.Items.Count; i++) //遍历MenuStrip组件中的一级菜单项
            {
                //将一级菜单项的名称添加到TreeView组件的根节点中，并设置当前节点的子节点newNode1
                TreeNode newNode1 = treeV.Nodes.Add(MenuS.Items[i].Text);
                //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                ToolStripDropDownItem newmenu = (ToolStripDropDownItem)MenuS.Items[i];
                //判断当前菜单项中是否有二级菜单项
                if (newmenu.HasDropDownItems && newmenu.DropDownItems.Count > 0)
                    for (int j = 0; j < newmenu.DropDownItems.Count; j++)    //遍历二级菜单项
                    {
                        //将二级菜单名称添加到TreeView组件的子节点newNode1中，并设置当前节点的子节点newNode2
                        TreeNode newNode2 = newNode1.Nodes.Add(newmenu.DropDownItems[j].Text);
                        //将当前菜单项的所有相关信息存入到ToolStripDropDownItem对象中
                        ToolStripDropDownItem newmenu2 = (ToolStripDropDownItem)newmenu.DropDownItems[j];
                        //判断二级菜单项中是否有三级菜单项
                        if (newmenu2.HasDropDownItems && newmenu2.DropDownItems.Count > 0)
                            for (int p = 0; p < newmenu2.DropDownItems.Count; p++)    //遍历三级菜单项
                                //将三级菜单名称添加到TreeView组件的子节点newNode2中
                                newNode2.Nodes.Add(newmenu2.DropDownItems[p].Text);
                    }
            }
        }
        #endregion

        #region 选中节点加载事件
        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            if (e.Node.Text.Trim()=="图书添加")
            {
                FrmTianJia frmTianJia = new FrmTianJia();
                frmTianJia.ShowDialog();
                frmTianJia.Dispose();
            }
            else if (e.Node.Text.Trim() == "图书修改")
            {
                FrmXiuGai frmXiuGai = new FrmXiuGai();
                frmXiuGai.ShowDialog();
                frmXiuGai.Dispose();
            }
            else if (e.Node.Text.Trim() == "图书删除")
            {
                FrmShanChu frmShanChu = new FrmShanChu();
                frmShanChu.ShowDialog();
                frmShanChu.Dispose();
            }
            else if (e.Node.Text.Trim() == "图书查询")
            {
                BookManagermentFrom from = new BookManagermentFrom();
                from.ShowDialog();
                from.Dispose();
            }
            else if (e.Node.Text.Trim() == "用户借书")
            {
                FrmBooksBorrow frmBooksBorrow = new FrmBooksBorrow();
                frmBooksBorrow.ShowDialog();
                frmBooksBorrow.Dispose();
            }
            else if (e.Node.Text.Trim() == "用户还书")
            {
                FrmBooksReturn frmBookReturn = new FrmBooksReturn();
                frmBookReturn.ShowDialog();
                frmBookReturn.Dispose();
            }
            else if (e.Node.Text.Trim() == "重新登录")
            {
                DialogResult dr = MessageBox.Show("是否注销用户", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dr == DialogResult.Yes)
                {
                    FrmLogin frmLogin = new FrmLogin();
                    frmLogin.Show();
                    this.Hide();
                }
                else
                {

                }
            }
            else if (e.Node.Text.Trim() == "用户管理")
            {
                FrmYongHu frmYongHu = new FrmYongHu();
                frmYongHu.ShowDialog();
                frmYongHu.Dispose();
            }
            else if (e.Node.Text.Trim() == "退出系统")
            {
                Application.Exit();    //退出系统
            }
            else if (e.Node.Text.Trim() == "计算器")
            {
                System.Diagnostics.Process.Start("calc.exe");
            }
            else if (e.Node.Text.Trim() == "记事本")
            {
                System.Diagnostics.Process.Start("notepad.exe");
            }
            else if (e.Node.Text.Trim() == "帮助")
            {
                MessageBox.Show("欢迎使用该图书管理！！！");
            }
        } 
        #endregion

        #region 菜单栏加载事件

        private void 图书添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmTianJia frmTianJia = new FrmTianJia();
            frmTianJia.Show();
        }

        private void 图书修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmXiuGai frmXiuGai = new FrmXiuGai();
            frmXiuGai.Show();
        }

        private void 图书删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmShanChu frmShanChu = new FrmShanChu();
            frmShanChu.Show();
        }

        private void 图书查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookManagermentFrom from = new BookManagermentFrom();
            from.Show();
        }
        private void 用户借书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBooksBorrow frmBooksBorrow = new FrmBooksBorrow();
            frmBooksBorrow.Show();
        }

        private void 用户还书ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBooksReturn frmBooksReturn = new FrmBooksReturn();
            frmBooksReturn.ShowDialog();
        }
        private void 重新登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销用户", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {

            }
        }
        private void 用户设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmYongHu frmYongHu = new FrmYongHu();
            frmYongHu.ShowDialog();
        }

        private void 退出系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void 计算器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void 记事本ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void tsmihelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("欢迎使用图书管理\n联系人：徐章旺\n联系电话：18379368078\nQQ：1114998422", "帮助", MessageBoxButtons.OK);
        }
     
        #endregion

        #region 快捷菜单加载事件
        private void tsbtnBook_Click(object sender, EventArgs e)
        {
            FrmYongHu frmYongHu = new FrmYongHu();
            frmYongHu.Show();
        }
        private void tsbtnYHGL_Click(object sender, EventArgs e)
        {
            FrmYongHuXinXiGuanLi frmYongHuXinXiGuanLi = new FrmYongHuXinXiGuanLi();
            frmYongHuXinXiGuanLi.ShowDialog();
        }
        private void tsbnYongHuZiLiao_Click(object sender, EventArgs e)
        {
            FrmYongHuXQ frmYongHuXQ = new FrmYongHuXQ();
            frmYongHuXQ.ShowDialog();
        }
        private void tsbtnTuiChu_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("是否注销用户", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                FrmLogin frmLogin = new FrmLogin();
                frmLogin.Show();
                this.Hide();
            }
            else
            {

            }
        }

        private void tsbnXiuGaiMM_Click(object sender, EventArgs e)
        {
            FrmForgetMiMa frmForgetMiMa = new FrmForgetMiMa(this.toolStripStatusLabel5.Text);
            frmForgetMiMa.ShowDialog();
        }
        #endregion

        public void SetUserName(string name)
        {
            this.toolStripStatusLabel5.Text = name;
        }
    }
}
