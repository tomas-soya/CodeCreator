using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CodeCreator.Utils
{
    public static class FileUtils
    {

        //获得指定路径下所有子目录名
        public static TreeNode GetDirectory(string path)
        {
            TreeNode node = new TreeNode();
            DirectoryInfo root = new DirectoryInfo(path);
            node.Text = root.Name;
            node.Tag = root.FullName;
            foreach (DirectoryInfo d in root.GetDirectories())
            {
                node.Nodes.Add(GetDirectory(d.FullName));
            }
            foreach (FileInfo f in root.GetFiles("*.xml"))
            {
                TreeNode xnode = new TreeNode();
                xnode.Text = f.Name.Replace(".xml","");
                xnode.Tag = f.FullName;
                node.Nodes.Add(xnode);
            }
            return node;
        }

        public static List<FileInfo> GetXMLList(string path)
        {
            DirectoryInfo root = new DirectoryInfo(path);
            return root.GetFiles("*.xml").ToList();
        }


        public static XmlDocument GetXMLDoc(string path)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);
            return xml;
        }


        public static void ClearDir()
        {
            string path = GlobalVariable.ResultPath;
            try
            {
                if(!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                    return;
                }
                DirectoryInfo dir = new DirectoryInfo(path);
                FileSystemInfo[] fileinfo = dir.GetFileSystemInfos();  //返回目录中所有文件和子目录
                foreach (FileSystemInfo i in fileinfo)
                {
                    if (i is DirectoryInfo)            //判断是否文件夹
                    {
                        DirectoryInfo subdir = new DirectoryInfo(i.FullName);
                        subdir.Delete(true);          //删除子目录和文件
                    }
                    else
                    {
                        File.Delete(i.FullName);      //删除指定文件
                    }
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void SaveFile(string code, string fileName)
        {
            FileStream fs = new FileStream(GlobalVariable.ResultPath+ fileName, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(code);
            sw.Close();
        }

        public static void ShowResult()
        {
            System.Diagnostics.Process.Start("explorer.exe", GlobalVariable.ResultPath);
        }


    }
}
