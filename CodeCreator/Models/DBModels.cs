using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCreator.Models
{
    public class DBModels
    {
    }

    /// <summary>
    /// 项目
    /// </summary>
    public class Project
    {
        public string Id { get; set; }
        [DisplayName("中文名")]
        public string CHName { get; set; }
        [DisplayName("命名空间")]
        public string NameSpace { get; set; }
        [DisplayName("连接字符串")]
        public string ConnString { get; set; }

        [DisplayName("数据库类型")]
        public string DBType { get; set; }
    }

    /// <summary>
    /// 数据表
    /// </summary>
    public class DataTable
    {
        public string Id { get; set; }
        public string ProjectID { get; set; }
        [DisplayName("表名")]
        public string TableName { get; set; }
        [DisplayName("中文名")]
        public string CHName { get; set; }

        [DisplayName("标题列宽度")]
        public int LableWidth { get; set; }
    }

    /// <summary>
    /// 字段
    /// </summary>
    public class Field
    {
        public string Id { get; set; }
        public string DataTableID { get; set; }
        [DisplayName("字段名")]
        public string FieldName { get; set; }
        [DisplayName("中文名")]
        public string CHName { get; set; }
        [DisplayName("数据库类型")]
        public string FieldDBType { get; set; }
        [DisplayName("字段类型")]
        public string FieldType { get; set; }
        [DisplayName("查询")]
        public bool ForSearch { get; set; }
        [DisplayName("列表")]
        public bool ForList { get; set; }
        [DisplayName("详情")]
        public bool ForDetail { get; set; }
        [DisplayName("必填")]
        public bool InputValidate { get; set; }
        [DisplayName("数字")]
        public bool NumricValidate { get; set; }
        [DisplayName("可见")]
        public bool Visible { get; set; }
        [DisplayName("输入框类型")]
        public string InputType { get; set; }

        public int OrderIndex { get; set; }

        public bool IsKey { get; set; }
    }

    public class DBField
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }

}
