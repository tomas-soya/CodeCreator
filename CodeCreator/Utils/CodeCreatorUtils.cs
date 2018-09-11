using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace CodeCreator.Utils
{
    public static class CodeCreatorUtils
    {
        /// <summary>
        /// 绑定数据到Form上
        /// </summary>
        /// <typeparam name="T">绑定数据的实体类型</typeparam>
        /// <param name="t">待绑定数据</param>
        /// <param name="form">目标窗体（传this即可）</param>
        public static void DataToForm<T>(T t, Form form)
        {
            if (t == null)
                return;
            var p = typeof(T).GetProperties();
            foreach (var a in p)
            {
                if (form.Controls[a.Name] != null)
                {
                    var value = a.GetValue(t) ?? "";
                    form.Controls[a.Name].Text = value.ToString();
                }
                    
            }
        }

        /// <summary>
        /// 从Form中取出数据
        /// </summary>
        /// <typeparam name="T">目标实体类型</typeparam>
        /// <param name="form">数据所在窗体（传this即可）</param>
        /// <returns></returns>
        public static T FormToData<T>(Form form)
        {
            var t = Activator.CreateInstance<T>();
            var p = typeof(T).GetProperties();
            foreach(var a in p)
            {
                if (form.Controls[a.Name] != null)
                {
                    a.SetValue(t, form.Controls[a.Name].Text);
                }
                    
            }
            return t;
        }

        public static void DataToCombobox(Type t,dynamic box)
        {
            box.Items.Clear();
            var p = t.GetFields();
            dynamic s = t.Assembly.CreateInstance(t.FullName);
            foreach (var a in p)
            {
                box.Items.Add(a.GetValue(s));
            }
        }

        public static void CreateCode(List<Models.DataTable> tables,List<string> selectedxmls)
        {
            FileUtils.ClearDir();
            List<XmlDocument> xmls = new List<XmlDocument>();
            foreach(var a in selectedxmls)
            {
                xmls.Add(FileUtils.GetXMLDoc(a));
            }
            foreach (var table in tables)
            {
                var Fields = SQLiteUtils.GetFieldListByTableID(table.Id);

                foreach (var xml in xmls)
                {
                    string BaseCode = xml.SelectNodes("node/BaseCode")[0].InnerText;
                    #region 替换基础代码中的通用部分
                    BaseCode = BaseCode.Replace("@TableName", table.TableName);
                    BaseCode = BaseCode.Replace("@NameSpace", GlobalVariable.WorkingProject.NameSpace);
                    #endregion
                    foreach(XmlNode fieldxml in xml.SelectSingleNode("node/Fields").ChildNodes)
                    {
                        List<Models.Field> thisFields = new List<Models.Field>();
                        string thisCode = fieldxml.InnerText;
                        string outField = "";
                        switch(fieldxml.Attributes["For"].Value)
                        {
                            case "ALL":
                                {
                                    thisFields = Fields;
                                    break;
                                }
                            case "List":
                                {
                                    thisFields = Fields.Where(tb => tb.ForList).ToList();
                                    break;
                                }
                            case "Detail":
                                {
                                    thisFields = Fields.Where(tb => tb.ForDetail).ToList();
                                    break;
                                }
                            case "Search":
                                {
                                    thisFields = Fields.Where(tb => tb.ForSearch).ToList();
                                    break;
                                }
                        }
                        foreach (var field in thisFields )
                        {
                            outField += thisCode.Replace("@FieldType", field.FieldType).Replace("@FieldName", field.FieldName) + "\n";
                        }
                        BaseCode = BaseCode.Replace("@" + fieldxml.Name, outField);
                        string FileName = xml.SelectSingleNode("node/FileName").InnerXml.Replace("@TableName", table.TableName);
                        FileUtils.SaveFile(BaseCode, FileName);
                    }
                }

                
            }
            FileUtils.ShowResult();
        }

        public static void PublicCode()
        {

        }
    }
}
