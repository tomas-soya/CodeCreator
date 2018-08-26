using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CodeCreator.Models;
using CodeCreator.Utils;

namespace CodeCreator.Forms
{
    public partial class XMLListForm : Form
    {
        public XMLListForm()
        {
            InitializeComponent();
            //Load += new EventHandler(XMLListForm_Load);
        }

        private void XMLListForm_Load(object sender, EventArgs e)
        {
            if (GlobalVariable.WorkingProject == null)
            {
                return;
            }
            FieldList.AutoGenerateColumns = false;
            FieldList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            FieldList.EditMode = DataGridViewEditMode.EditOnEnter;

            CodeCreatorUtils.DataToCombobox(typeof(GlobalVariable.FieldType), ((DataGridViewComboBoxColumn)FieldList.Columns["FieldType"]));
            CodeCreatorUtils.DataToCombobox(typeof(GlobalVariable.InputType), ((DataGridViewComboBoxColumn)FieldList.Columns["InputType"]));

            GlobalVariable.CheckedXmls = new List<string>();
            LoadXMLList();
            LoadTableList();
        }

        private void LoadXMLList()
        {
            tree_XMLList.CheckBoxes = true;
            tree_XMLList.Nodes.Clear();
            tree_XMLList.Nodes.Add(FileUtils.GetDirectory("./CodeTemplates"));
            tree_XMLList.ExpandAll();
        }

        public void LoadTableList()
        {
            DataTableList.DataSource = SQLiteUtils.GetDatas<Models.DataTable>();
            DataTableList.DisplayMember = "TableName";
        }

        private void tree_XMLList_AfterCheck(object sender, TreeViewEventArgs e)
        {
            //设置级联选中
            tree_XMLList.AfterCheck -= tree_XMLList_AfterCheck;
            RefreshChecked(e.Node);
            DoChilds(e.Node,e.Node.Checked);
            DoParents(e.Node, e.Node.Checked);
            tree_XMLList.AfterCheck += tree_XMLList_AfterCheck;
        }

        private void DoChilds(TreeNode n, bool check)
        {
            if (n.Nodes.Count == 0)
                return;
            RefreshChecked(n);
            foreach (TreeNode c in n.Nodes)
            {
                c.Checked = check;
                DoChilds(c, check);
            }
        }
        private void DoParents(TreeNode n,bool check)
        {
            if (n.Parent == null)
                return;
            RefreshChecked(n);
            if (check == false)
            {
                n.Parent.Checked = check;
                DoParents(n.Parent,check);
            }
        }

        private void RefreshChecked(TreeNode n)
        {
            string s = n.Tag.ToString();
            if (n.Checked)
            {
                if (!GlobalVariable.CheckedXmls.Contains(s))
                    GlobalVariable.CheckedXmls.Add(s);
            }
            else
                    if (GlobalVariable.CheckedXmls.Contains(s))
                GlobalVariable.CheckedXmls.Remove(s);
        }


        private void save_Click(object sender, EventArgs e)
        {
            var list = (List<Field>)FieldList.DataSource;
            SQLiteUtils.UpdateData(list);
        }

        private void RefreshTableList_Click(object sender, EventArgs e)
        {
            SQLiteUtils.RefreshTableList();
            LoadTableList();
        }

        private void RefreshFieldList_Click(object sender, EventArgs e)
        {
            SQLiteUtils.RefreshFieldList();
            LoadFieldList();
        }

        private void LoadFieldList()
        {
            FieldList.DataSource = SQLiteUtils.GetFieldListByTableID(GlobalVariable.WorkingDataTable.Id).OrderBy(tb => tb.OrderIndex).ToList();
        }

        private void DataTableList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (DataTableList.SelectedItem == null)
                return;
            GlobalVariable.WorkingDataTable = (Models.DataTable)DataTableList.SelectedItem;
            TBCHName.Text = GlobalVariable.WorkingDataTable.CHName;
            LableWidth.Text = GlobalVariable.WorkingDataTable.LableWidth.ToString();
            LoadFieldList();
        }

        private void saveTable_Click(object sender, EventArgs e)
        {
            GlobalVariable.WorkingDataTable.CHName= TBCHName.Text;
            GlobalVariable.WorkingDataTable.LableWidth=int.Parse(LableWidth.Text);
            SQLiteUtils.UpdateData(GlobalVariable.WorkingDataTable);
        }

        private void Generate_Click(object sender, EventArgs e)
        {
            List<Models.DataTable> tables = new List<Models.DataTable>();

            foreach (var a in DataTableList.CheckedItems)
            {
                tables.Add((Models.DataTable)a);
            }
            CodeCreatorUtils.CreateCode(tables, GlobalVariable.CheckedXmls);
        }
    }
}
