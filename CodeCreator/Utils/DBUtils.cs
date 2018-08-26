using CodeCreator.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Dapper;
using System.Data.SqlClient;

namespace CodeCreator.Utils
{

    public static class DBUtils
    {


        /// <summary>
        /// 获取数据库中的所有数据表
        /// 返回表名的列表（List<string>）即可
        /// </summary>
        /// <returns></returns>
        public static List<string> GetTables()
        {
            List<string> results = new List<string>();
            switch (GlobalVariable.WorkingProject.DBType)
            {
                case GlobalVariable.DBType.MSSQL:
                    {
                        return GetTablesFromMSSQL();
                        break;
                    }
                default: break;
            }
            return results;
        }

        /// <summary>
        /// 根据表名获取字段列表
        /// 返回结果中第一列为字段名，第二列为字段类型
        /// </summary>
        /// <param name="TableName">数据表名</param>
        /// <returns></returns>
        public static List<DBField> GetFields()
        {
            List<DBField> results = new List<DBField>();
            switch (GlobalVariable.WorkingProject.DBType)
            {
                case GlobalVariable.DBType.MSSQL:
                    {
                        return GetFieldsFromMSSQL();
                        break;
                    }
                default: break;
            }
            return results;
        }

        private static List<string> GetTablesFromMSSQL()
        {
            SqlConnection conn = new SqlConnection(GlobalVariable.WorkingProject.ConnString);
            string sql = "select name from sysobjects where xtype='u'";
            return conn.Query<string>(sql).ToList();
        }

        private static List<DBField> GetFieldsFromMSSQL()
        {
            SqlConnection conn = new SqlConnection(GlobalVariable.WorkingProject.ConnString);
            string sql = string.Format("select b.name Name,c.name Type from sysobjects a,syscolumns b,systypes c where a.id=b.id and a.name = '{0}' and a.xtype = 'U' and b.xtype = c.xtype and c.name <> 'sysname'", GlobalVariable.WorkingDataTable.TableName);
            return conn.Query<DBField>(sql).ToList();
        }
    }
}
