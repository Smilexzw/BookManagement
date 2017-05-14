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
    public partial class FrmStudent : Form
    {
        public FrmStudent()
        {
            InitializeComponent();
        }

        public void SetUserName(string name)
        {
            this.toolStripStatusLabel5.Text = name;
        }

        private void FrmStudent_Load(object sender, EventArgs e)
        {
            //设置statusStrip1的属性(显示时间)
            this.toolStripStatusLabel3.Text = DateTime.Now.ToShortDateString();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            FrmForgetMiMa frmForgetMiMa = new FrmForgetMiMa(this.toolStripStatusLabel5.Text);
            frmForgetMiMa.ShowDialog();
        }
    }
}
