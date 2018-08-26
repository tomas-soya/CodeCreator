namespace CodeCreator.Forms
{
    partial class ProjectListForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.save = new System.Windows.Forms.Button();
            this.add = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.CHName = new System.Windows.Forms.TextBox();
            this.NameSpace = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ConnString = new System.Windows.Forms.TextBox();
            this.Id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.DBType = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(145, 424);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(479, 13);
            this.save.Margin = new System.Windows.Forms.Padding(2);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(56, 26);
            this.save.TabIndex = 2;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // add
            // 
            this.add.Location = new System.Drawing.Point(419, 13);
            this.add.Margin = new System.Windows.Forms.Padding(2);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(56, 26);
            this.add.TabIndex = 3;
            this.add.Text = "添加";
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "中文名";
            // 
            // CHName
            // 
            this.CHName.Location = new System.Drawing.Point(258, 42);
            this.CHName.Margin = new System.Windows.Forms.Padding(2);
            this.CHName.Name = "CHName";
            this.CHName.Size = new System.Drawing.Size(277, 21);
            this.CHName.TabIndex = 5;
            // 
            // NameSpace
            // 
            this.NameSpace.Location = new System.Drawing.Point(258, 67);
            this.NameSpace.Margin = new System.Windows.Forms.Padding(2);
            this.NameSpace.Name = "NameSpace";
            this.NameSpace.Size = new System.Drawing.Size(277, 21);
            this.NameSpace.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "命名空间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(166, 95);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "连接字符串";
            // 
            // ConnString
            // 
            this.ConnString.Location = new System.Drawing.Point(258, 92);
            this.ConnString.Margin = new System.Windows.Forms.Padding(2);
            this.ConnString.Multiline = true;
            this.ConnString.Name = "ConnString";
            this.ConnString.Size = new System.Drawing.Size(277, 65);
            this.ConnString.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.Location = new System.Drawing.Point(258, 188);
            this.Id.Margin = new System.Windows.Forms.Padding(2);
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(277, 21);
            this.Id.TabIndex = 12;
            this.Id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "数据库类型";
            // 
            // DBType
            // 
            this.DBType.FormattingEnabled = true;
            this.DBType.Location = new System.Drawing.Point(258, 163);
            this.DBType.Name = "DBType";
            this.DBType.Size = new System.Drawing.Size(277, 20);
            this.DBType.TabIndex = 14;
            // 
            // ProjectListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DBType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.ConnString);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameSpace);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CHName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.add);
            this.Controls.Add(this.save);
            this.Controls.Add(this.listBox1);
            this.Name = "ProjectListForm";
            this.Text = "ProjectListForm";
            this.Load += new System.EventHandler(this.ProjectListForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox CHName;
        private System.Windows.Forms.TextBox NameSpace;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ConnString;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox DBType;
    }
}