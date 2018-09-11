using CodeCreator.Models;
using System.Collections.Generic;

namespace CodeCreator
{
    public static class GlobalVariable
    {
        public const string SQLiteConn = "Data Source=D:\\DB\\CodeCreator.db;Version=3;";

        public const string ResultPath = "D:\\DB\\Results\\";

        public static Project WorkingProject { get; set; }

        public static DataTable WorkingDataTable { get; set; }

        public static List<string> CheckedXmls { get; set; }

        public class DBType
        {
            public const string MSSQL = "MSSQL";
            public const string MySQL = "MySQL";
            public const string Oracle = "Oracle";
            public const string SQLite = "SQLite";
            public const string PostgreSQL = "PostgreSQL";
        }

        public class FieldType
        {
            public const string _int = "int";
            public const string _string = "string";
            public const string _datetime = "DateTime";
            public const string _bool = "bool";
            public const string _float = "float";
            public const string _double = "double";
            public const string _decimal = "decimal";
        }

        public class InputType
        {
            public const string _textbox = "TextBox";
            public const string _textarea = "TextArea";
            public const string _date = "Date";
            public const string _dictionary = "Dictionary";
        }

        public class SearchType
        {
            public const string _eq = "=";
            public const string _gt = ">";
            public const string _ge = ">=";
            public const string _lt = "<";
            public const string _le = "<=";
            public const string _between = "Between";
            public const string _anywhere = "Anywhere";
            public const string _startwith = "StartWith";
            public const string _endwith = "EndWith";
        }
    }
}