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
    public partial class ProjectListForm : Form
    {
        public ProjectListForm()
        {
            InitializeComponent();
        }

        private void ProjectListForm_Load(object sender, EventArgs e)
        {
            LoadProjectList();

            CodeCreatorUtils.DataToCombobox(typeof(GlobalVariable.DBType), DBType);

            if (GlobalVariable.WorkingProject != null)
            {
                listBox1.SelectedItem = GlobalVariable.WorkingProject;
            }
        }

        private void LoadProjectList()
        {
            listBox1.DataSource = SQLiteUtils.GetDatas<Project>();
            listBox1.DisplayMember = "CHName";
            listBox1.ValueMember = "Id";
        }

        private void add_Click(object sender, EventArgs e)
        {
            var p = CodeCreatorUtils.FormToData<Project>(this);
            p.Id = Guid.NewGuid().ToString();
            SQLiteUtils.InsertData(p);
            LoadProjectList();
            GlobalVariable.WorkingProject = p;
        }

        private void save_Click(object sender, EventArgs e)
        {
            var p = CodeCreatorUtils.FormToData<Project>(this);
            SQLiteUtils.UpdateData(p);
            LoadProjectList();
            GlobalVariable.WorkingProject = p;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GlobalVariable.WorkingProject = (Project)listBox1.SelectedItem;
            CodeCreatorUtils.DataToForm(GlobalVariable.WorkingProject, this);
        }
    }
}
