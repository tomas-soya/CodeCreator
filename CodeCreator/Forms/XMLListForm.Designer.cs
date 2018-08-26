namespace CodeCreator.Forms
{
    partial class XMLListForm
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
            this.tree_XMLList = new System.Windows.Forms.TreeView();
            this.Generate = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.Button();
            this.FieldList = new System.Windows.Forms.DataGridView();
            this.FieldName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldDBType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FieldType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.InputType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ForSearch = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ForList = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ForDetail = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.InputValidate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.NumricValidate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Visible = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.RefreshTableList = new System.Windows.Forms.Button();
            this.RefreshFieldList = new System.Windows.Forms.Button();
            this.DataTableList = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LableWidth = new System.Windows.Forms.TextBox();
            this.TBCHName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.saveTable = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FieldList)).BeginInit();
            this.SuspendLayout();
            // 
            // tree_XMLList
            // 
            this.tree_XMLList.Location = new System.Drawing.Point(872, 48);
            this.tree_XMLList.Name = "tree_XMLList";
            this.tree_XMLList.Size = new System.Drawing.Size(205, 388);
            this.tree_XMLList.TabIndex = 0;
            this.tree_XMLList.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tree_XMLList_AfterCheck);
            // 
            // Generate
            // 
            this.Generate.Location = new System.Drawing.Point(1002, 12);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(75, 28);
            this.Generate.TabIndex = 1;
            this.Generate.Text = "生成";
            this.Generate.UseVisualStyleBackColor = true;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(791, 12);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 28);
            this.save.TabIndex = 3;
            this.save.Text = "保存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // FieldList
            // 
            this.FieldList.AllowUserToAddRows = false;
            this.FieldList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FieldList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldName,
            this.CHName,
            this.FieldDBType,
            this.FieldType,
            this.InputType,
            this.ForSearch,
            this.ForList,
            this.ForDetail,
            this.InputValidate,
            this.NumricValidate,
            this.Visible});
            this.FieldList.Location = new System.Drawing.Point(176, 48);
            this.FieldList.Name = "FieldList";
            this.FieldList.RowTemplate.Height = 23;
            this.FieldList.Size = new System.Drawing.Size(690, 388);
            this.FieldList.TabIndex = 5;
            // 
            // FieldName
            // 
            this.FieldName.DataPropertyName = "FieldName";
            this.FieldName.HeaderText = "字段名";
            this.FieldName.Name = "FieldName";
            this.FieldName.ReadOnly = true;
            // 
            // CHName
            // 
            this.CHName.DataPropertyName = "CHName";
            this.CHName.HeaderText = "中文名";
            this.CHName.Name = "CHName";
            // 
            // FieldDBType
            // 
            this.FieldDBType.DataPropertyName = "FieldDBType";
            this.FieldDBType.HeaderText = "DB类型";
            this.FieldDBType.Name = "FieldDBType";
            this.FieldDBType.ReadOnly = true;
            // 
            // FieldType
            // 
            this.FieldType.DataPropertyName = "FieldType";
            this.FieldType.HeaderText = "字段类型";
            this.FieldType.Name = "FieldType";
            // 
            // InputType
            // 
            this.InputType.DataPropertyName = "InputType";
            this.InputType.HeaderText = "输入框";
            this.InputType.Name = "InputType";
            // 
            // ForSearch
            // 
            this.ForSearch.DataPropertyName = "ForSearch";
            this.ForSearch.HeaderText = "查询";
            this.ForSearch.Name = "ForSearch";
            // 
            // ForList
            // 
            this.ForList.DataPropertyName = "ForList";
            this.ForList.HeaderText = "列表";
            this.ForList.Name = "ForList";
            // 
            // ForDetail
            // 
            this.ForDetail.DataPropertyName = "ForDetail";
            this.ForDetail.HeaderText = "详情";
            this.ForDetail.Name = "ForDetail";
            // 
            // InputValidate
            // 
            this.InputValidate.DataPropertyName = "InputValidate";
            this.InputValidate.HeaderText = "必填";
            this.InputValidate.Name = "InputValidate";
            // 
            // NumricValidate
            // 
            this.NumricValidate.DataPropertyName = "NumricValidate";
            this.NumricValidate.HeaderText = "数字";
            this.NumricValidate.Name = "NumricValidate";
            // 
            // Visible
            // 
            this.Visible.DataPropertyName = "Visible";
            this.Visible.HeaderText = "可见";
            this.Visible.Name = "Visible";
            // 
            // RefreshTableList
            // 
            this.RefreshTableList.Location = new System.Drawing.Point(13, 12);
            this.RefreshTableList.Name = "RefreshTableList";
            this.RefreshTableList.Size = new System.Drawing.Size(75, 28);
            this.RefreshTableList.TabIndex = 6;
            this.RefreshTableList.Text = "刷新";
            this.RefreshTableList.UseVisualStyleBackColor = true;
            this.RefreshTableList.Click += new System.EventHandler(this.RefreshTableList_Click);
            // 
            // RefreshFieldList
            // 
            this.RefreshFieldList.Location = new System.Drawing.Point(710, 12);
            this.RefreshFieldList.Name = "RefreshFieldList";
            this.RefreshFieldList.Size = new System.Drawing.Size(75, 28);
            this.RefreshFieldList.TabIndex = 7;
            this.RefreshFieldList.Text = "刷新";
            this.RefreshFieldList.UseVisualStyleBackColor = true;
            this.RefreshFieldList.Click += new System.EventHandler(this.RefreshFieldList_Click);
            // 
            // DataTableList
            // 
            this.DataTableList.FormattingEnabled = true;
            this.DataTableList.Location = new System.Drawing.Point(13, 48);
            this.DataTableList.Name = "DataTableList";
            this.DataTableList.Size = new System.Drawing.Size(157, 388);
            this.DataTableList.TabIndex = 8;
            this.DataTableList.SelectedValueChanged += new System.EventHandler(this.DataTableList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "列宽";
            // 
            // LableWidth
            // 
            this.LableWidth.Location = new System.Drawing.Point(221, 3);
            this.LableWidth.Name = "LableWidth";
            this.LableWidth.Size = new System.Drawing.Size(138, 21);
            this.LableWidth.TabIndex = 10;
            // 
            // TBCHName
            // 
            this.TBCHName.Location = new System.Drawing.Point(221, 30);
            this.TBCHName.Name = "TBCHName";
            this.TBCHName.Size = new System.Drawing.Size(138, 21);
            this.TBCHName.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "中文名";
            // 
            // saveTable
            // 
            this.saveTable.Location = new System.Drawing.Point(93, 12);
            this.saveTable.Name = "saveTable";
            this.saveTable.Size = new System.Drawing.Size(75, 28);
            this.saveTable.TabIndex = 13;
            this.saveTable.Text = "保存";
            this.saveTable.UseVisualStyleBackColor = true;
            this.saveTable.Click += new System.EventHandler(this.saveTable_Click);
            // 
            // XMLListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.saveTable);
            this.Controls.Add(this.TBCHName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LableWidth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataTableList);
            this.Controls.Add(this.RefreshFieldList);
            this.Controls.Add(this.RefreshTableList);
            this.Controls.Add(this.FieldList);
            this.Controls.Add(this.save);
            this.Controls.Add(this.Generate);
            this.Controls.Add(this.tree_XMLList);
            this.Name = "XMLListForm";
            this.Text = "生成";
            this.Load += new System.EventHandler(this.XMLListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FieldList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tree_XMLList;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.DataGridView FieldList;
        private System.Windows.Forms.Button RefreshTableList;
        private System.Windows.Forms.Button RefreshFieldList;
        private System.Windows.Forms.CheckedListBox DataTableList;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldDBType;
        private System.Windows.Forms.DataGridViewComboBoxColumn FieldType;
        private System.Windows.Forms.DataGridViewComboBoxColumn InputType;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ForSearch;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ForList;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ForDetail;
        private System.Windows.Forms.DataGridViewCheckBoxColumn InputValidate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NumricValidate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Visible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox LableWidth;
        private System.Windows.Forms.TextBox TBCHName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button saveTable;
    }
}