namespace CodeCreator
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.XMLListForm = new System.Windows.Forms.TabPage();
            this.ProjectListForm = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // XMLListForm
            // 
            this.XMLListForm.Location = new System.Drawing.Point(4, 22);
            this.XMLListForm.Name = "XMLListForm";
            this.XMLListForm.Padding = new System.Windows.Forms.Padding(3);
            this.XMLListForm.Size = new System.Drawing.Size(792, 424);
            this.XMLListForm.TabIndex = 3;
            this.XMLListForm.Text = "生成";
            this.XMLListForm.UseVisualStyleBackColor = true;
            this.XMLListForm.Click += new System.EventHandler(this.XMLListForm_Click);
            // 
            // ProjectListForm
            // 
            this.ProjectListForm.Location = new System.Drawing.Point(4, 22);
            this.ProjectListForm.Name = "ProjectListForm";
            this.ProjectListForm.Padding = new System.Windows.Forms.Padding(3);
            this.ProjectListForm.Size = new System.Drawing.Size(792, 424);
            this.ProjectListForm.TabIndex = 0;
            this.ProjectListForm.Text = "项目";
            this.ProjectListForm.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.ProjectListForm);
            this.tabControl1.Controls.Add(this.XMLListForm);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "CodeCreator";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage XMLListForm;
        private System.Windows.Forms.TabPage ProjectListForm;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

