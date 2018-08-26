//using Microsoft.VisualStudio.Data;
using CodeCreator.Forms;
using Microsoft.Data.ConnectionUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeCreator
{

    public partial class MainForm : Form
    {
        public abstract class DataConnectionDialog : IDisposable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
        public MainForm()
        {
            InitializeComponent();

            //DataConnectionDialog dialog = new DataConnectionDialog();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            TabChanged();
        }


        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TabChanged();
        }

        private void TabChanged()
        {
            //已加载则无视
            //if (tabControl1.SelectedTab.Controls.Count > 0)
            //    return;
            tabControl1.SelectedTab.Controls.Clear();
            string FormName = tabControl1.SelectedTab.Name;
            Form form = Assembly.GetExecutingAssembly().CreateInstance("CodeCreator.Forms." + tabControl1.SelectedTab.Name) as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
            tabControl1.SelectedTab.Controls.Add(form);
            this.Size =new Size(form.Size.Width + 25, form.Size.Height + 60);
        }

        private void XMLListForm_Click(object sender, EventArgs e)
        {

        }
    }
}
