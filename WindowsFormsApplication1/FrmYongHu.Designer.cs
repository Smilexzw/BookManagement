namespace WindowsFormsApplication1
{
    partial class FrmYongHu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmYongHu));
            this.dgvYongHu = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHu)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvYongHu
            // 
            this.dgvYongHu.AllowUserToResizeColumns = false;
            this.dgvYongHu.AllowUserToResizeRows = false;
            this.dgvYongHu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYongHu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvYongHu.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvYongHu.Location = new System.Drawing.Point(0, 0);
            this.dgvYongHu.Name = "dgvYongHu";
            this.dgvYongHu.RowHeadersVisible = false;
            this.dgvYongHu.RowTemplate.Height = 27;
            this.dgvYongHu.Size = new System.Drawing.Size(418, 375);
            this.dgvYongHu.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "UserName";
            this.Column1.HeaderText = "用户";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "Passpwd";
            this.Column2.HeaderText = "密码";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "LoginType";
            this.Column3.HeaderText = "管理类型";
            this.Column3.Name = "Column3";
            // 
            // FrmYongHu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 375);
            this.Controls.Add(this.dgvYongHu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmYongHu";
            this.ShowInTaskbar = false;
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FrmYongHu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYongHu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvYongHu;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}