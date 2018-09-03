using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeCreator.Models;

namespace CodeCreator.Utils
{
    public static class SQLiteUtils
    {
       

        public static SQLiteConnection GetConnection()
        {
            return new SQLiteConnection(GlobalVariable.SQLiteConn);
        }
        /// <summary>
        /// 查询一张表的全部数据
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public static List<T> GetDatas<T>()
        {
            List<T> results = new List<T>();
            var conn = GetConnection();
            string sql = string.Format("select * from {0}", typeof(T).Name);
            results = conn.Query<T>(sql).ToList();
            return results;
        }

        /// <summary>
        /// 插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void InsertData<T>(T t)
        {
            var conn = GetConnection();
            conn.Execute(InsertSQL<T>(), t);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void UpdateData<T>(T t)
        {
            var conn = GetConnection();
            conn.Execute(UpdateSQL<T>(), t);
        }

        /// <summary>
        /// 批量插入
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="t"></param>
        public static void InsertData<T>(List<T> t)
        {
            var conn = GetConnection();
            conn.Execute(InsertSQL<T>(), t);
        }

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <param name="t">待更新的List</param>
        public static void UpdateData<T>(List<T> t)
        {
            var conn = GetConnection();
            conn.Execute(UpdateSQL<T>(), t);
        }

        /// <summary>
        /// 生成更新SQL
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns>SQL语句（带参数）</returns>
        private static string UpdateSQL<T>()
        {
            string sql = "update {0} set {1} where Id=@id";
            var p = typeof(T).GetProperties();
            string name = typeof(T).Name;
            string fields = "";
            for (int i = 0; i < p.Length; i++)
            {
                if (p[i].Name == "Id")
                    continue;
                fields += p[i].Name + "=@" + p[i].Name;
                if (i != p.Length - 1)
                {
                    fields += ",";
                }
            }
            return string.Format(sql, name, fields);
        }

        /// <summary>
        /// 生成插入SQL
        /// </summary>
        /// <typeparam name="T">实体类型</typeparam>
        /// <returns>SQL语句（带参数）</returns>
        private static string InsertSQL<T>()
        {
            string sql = "insert into {0} ({1}) values ({2})";
            var p = typeof(T).GetProperties();
            string name = typeof(T).Name;
            string fields = "";
            string values = "";
            for (int i = 0; i < p.Length; i++)
            {
                fields += p[i].Name;
                values += "@" + p[i].Name;
                if (i != p.Length - 1)
                {
                    fields += ",";
                    values += ",";
                }
            }
            return string.Format(sql, name, fields, values);
        }

        /// <summary>
        /// 重载数据表
        /// </summary>
        public static void RefreshTableList()
        {
            if (GlobalVariable.WorkingProject == null)
                return;
            GlobalVariable.WorkingDataTable = null;
            var conn = GetConnection();
            string sql = "";
            #region 获取当前项目的表和字段
            var currentDBNameList = DBUtils.GetTables();
            sql = string.Format("select * from DataTable where ProjectID='{0}'", GlobalVariable.WorkingProject.Id);
            var oldtablelist = conn.Query<DataTable>(sql).ToList();
            sql= string.Format("select * from Field where DataTableID in (select Id from DataTable where ProjectID ='{0}')", GlobalVariable.WorkingProject.Id);
            var oldfieldlist = conn.Query<Field>(sql);
            #endregion
            bool copydata = oldtablelist.Count > 0 ? true : false;
            if(copydata)
            {
                //先删掉旧的数据
                sql =
                    string.Format("delete from Field where DataTableID in (select Id from DataTable where ProjectID ='{0}');", GlobalVariable.WorkingProject.Id) +
                    string.Format("delete from DataTable where ProjectID='{0}';", GlobalVariable.WorkingProject.Id);
                conn.Execute(sql);
            }
            foreach (string name in currentDBNameList)
            {
                DataTable d = oldtablelist.Where(tb => tb.TableName == name).FirstOrDefault();
                if (d == null)
                {
                    d = new DataTable();
                    d.ProjectID = GlobalVariable.WorkingProject.Id;
                    d.Id = Guid.NewGuid().ToString();
                    d.TableName = name;
                    d.LableWidth = 3;
                }
                else if(copydata)
                {
                    var FieldList = oldfieldlist.Where(tb => tb.DataTableID == d.Id).ToList();
                    InsertData(FieldList);
                }
                InsertData(d);
            }
        }

        /// <summary>
        /// 刷新一张表的字段列表
        /// </summary>
        public static void RefreshFieldList()
        {
            var conn = GetConnection();
            var currentFieldList = DBUtils.GetFields();
            string sql = "";
            sql = string.Format("select * from Field where DataTableID ='{0}'", GlobalVariable.WorkingDataTable.Id);
            var oldfieldlist = conn.Query<Field>(sql).ToList();
            for(int i=0;i<currentFieldList.Count;i++)
            {
                Field f= oldfieldlist.Where(tb => tb.FieldName == currentFieldList[i].Name).FirstOrDefault();
                if (f == null)
                {
                    f = new Field
                    {
                        DataTableID = GlobalVariable.WorkingDataTable.Id,
                        Id = Guid.NewGuid().ToString(),
                        InputValidate = false,
                        NumricValidate = false,
                        Visible = true,
                        FieldDBType = currentFieldList[i].Type,
                        ForDetail = false,
                        ForList = false,
                        ForSearch = false,
                        IsKey = false,
                        OrderIndex = i,
                        CHName= "",
                        FieldName= currentFieldList[i].Name,
                        InputType=GlobalVariable.InputType._textbox,
                    };
                    if (currentFieldList[i].Name.ToLower() == "id")
                        f.IsKey = true;
                    f.FieldType = DBTypeConverter(f.FieldDBType);
                }
                InsertData(f);
            }
        }

        public static List<Field> GetFieldListByTableID(string Id)
        {
            var conn = GetConnection();
            string sql = string.Format("select * from Field where DataTableID='{0}'", Id);
            return conn.Query<Field>(sql).ToList();
        }


        public static string DBTypeConverter(string type)
        {
            type = type.ToLower();
            if (type.Contains("int"))
                return GlobalVariable.FieldType._int;
            if (type.Contains("decimal"))
                return GlobalVariable.FieldType._decimal;
            if (type.Contains("float"))
                return GlobalVariable.FieldType._float;
            if (type.Contains("double"))
                return GlobalVariable.FieldType._double;
            if (type.Contains("date"))
                return GlobalVariable.FieldType._datetime;
            if (type.Contains("time"))
                return GlobalVariable.FieldType._datetime;
            if (type.Contains("bit"))
                return GlobalVariable.FieldType._bool;
            return GlobalVariable.FieldType._string;
        }
    }
}
