using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Data;
using System.Text.RegularExpressions;
using System.Reflection;

namespace Codes
{
    public class CodeHelper
    {
        /// <summary>
        /// 运行命令行
        /// </summary>
        public static void RunCommand(string cmd)
        {
            string tempPath = Environment.GetEnvironmentVariable("TEMP");
            string fileName = tempPath + "\\" + Guid.NewGuid().ToString("N") + ".bat";
            CodeUtility.FileStream.WriteFile(fileName, cmd.ToString());
            Process.Start(fileName);
        }

        /// <summary>
        /// 从模板中取得要生成的代码
        /// </summary>
        public static string ReadFromTemplate(string file, Model.Database db, Model.Table table, Model.CodeStyle style)
        {
            string code = CodeUtility.FileStream.ReadFile(file);

            code = code.Replace("$Year$", DateTime.Now.Year.ToString());
            code = code.Replace("$Version$", Assembly.GetEntryAssembly().GetName().Version.ToString());
            code = code.Replace("$CreateTime$", DateTime.Now.ToString());

            if (db != null)
            {
                code = code.Replace("$DBName$", db.DbName);
                code = code.Replace("$DALNamespace$", style.DALNameSpace);
            }
            if (table != null)
            {
                code = code.Replace("$TableName$", table.Name); 
                code = code.Replace("$IdType$", CodeUtility.TypeConverter.DataTypeToCSharpTypeString(table.ConditionRows[0].DbType));
                code = code.Replace("$IdTypeConvertMethod$", CodeUtility.TypeConverter.DataTypeToCSharpConvertMethod(table.ConditionRows[0].DbType));                

                code = code.Replace("$KeyArguments$", GetArgumentsOfFunction(table));
                code = code.Replace("$KeyArgumentValues$", GetArgumentValuesOfFunction(table));
                code = code.Replace("$CacheKeyOfModel$",GetCacheKeyOfModel(table));
                code = code.Replace("$CacheKey$",GetCacheKey(table));
            }
            if (style != null)
            {
                code = code.Replace("$DBHelperName$", style.DBHelperName);
                code = code.Replace("$ModelNameSpace$", style.ModelNameSpace);
                code = code.Replace("$DALNamespace$", style.DALNameSpace);
                code = code.Replace("$BLNameSpace$", style.BLNameSpace);
                code = code.Replace("$BeforeNamespace$", style.BeforeNamespace);
                code = code.Replace("$AfterNamespace$", style.AfterNamespace);
                code = code.Replace("$TableCacheDependencyNamespace$", style.TableCacheDependencyNamespace);

                MatchCollection matches = Regex.Matches(code, @"\$\[(?<Descn>.*)\]\$");
                switch (style.BlFrame)
                {
                    case Model.CodeStyle.BLFrame.BLS:
                        foreach (Match match in matches)
                        {
                            code = code.Replace(match.Value,
                                string.Format("[WebMethod(Description=\"{0}\")]", match.Groups["Descn"].Value));
                        }
                        break;
                    case Model.CodeStyle.BLFrame.BLL:
                    default:
                        foreach (Match match in matches)
                        {
                            code = code.Replace(match.Value,
                                string.Format("/// <summary>\r\n\t\t/// {0}\r\n\t\t/// </summary>", match.Groups["Descn"].Value));
                        }
                        break;
                }
            }
            return code;
        }

        /// <summary>
        /// 判断一个字段是不是Int类型的（包括bigint,int,smallint,tinyint）
        /// </summary>
        public static bool IsIntDbType(Model.Field field)
        {
            switch (field.DbType)
            {
                case DbType.Int16:
                case DbType.Int32:
                case DbType.Int64:
                case DbType.UInt16:
                case DbType.UInt32:
                case DbType.UInt64:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 判断一个字段是不是String类型的（包括Xml,String,StringFixedLength,AnsiString,AnsiStringFixedLength）
        /// </summary>
        public static bool IsStringDbType(Model.Field field)
        {
            switch (field.DbType)
            {
                case DbType.Xml:
                case DbType.String:
                case DbType.StringFixedLength:
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                    return true;
                default:
                    return false;
            }
        }

        /// <summary>
        /// 是否要在Add方法中加入该参数
        /// DAL层和存储过程中均要用此判断
        /// </summary>
        public static bool ShouldBeParameter(Model.Table table, Model.Field field)
        {
            if (!field.IsIdentifier && (string.IsNullOrEmpty(field.DefaultValue)))
                return true;
            else
                return false;
        }

        /// <summary>
        /// 增加一行格式化字符串
        /// </summary>
        public static void AppendFormatLine(StringBuilder code, int tabCount, string format, params object[] args)
        {
            for (int i = 0; i < tabCount; i++)
            {
                format = format.Insert(0, "\t");
            }
            if (args != null && args.Length > 0)
                code.AppendLine(string.Format(format, args));
            else
                code.AppendLine(format);
        }

        /// <summary>
        /// 增加格式化字符串
        /// </summary>
        public static void AppendFormat(StringBuilder code, int tabCount, string format, params object[] args)
        {
            for (int i = 0; i < tabCount; i++)
            {
                format = format.Insert(0, "\t");
            }
            if (args != null && args.Length > 0)
                code.Append(string.Format(format, args));
            else
                code.Append(format);
        }

        /// <summary>
        /// 取得修改或删除时的条件参数
        /// </summary>
        public static string GetArgumentsOfFunction(Model.Table table)
        {
            StringBuilder strArguments = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strArguments.Append(CodeUtility.TypeConverter.DataTypeToCSharpTypeString(model.DbType)
                    + " " + model.FieldName + ", ");
            }
            strArguments.Remove(strArguments.Length - 2, 2);
            return strArguments.ToString();
        }

        /// <summary>
        /// 取得修改或删除时要传入的条件参数值,返回结果如：Id,Name,Sex
        /// </summary>
        public static string GetArgumentValuesOfFunction(Model.Table table)
        {
            StringBuilder strArguments = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strArguments.Append(model.FieldName + ", ");
            }
            strArguments.Remove(strArguments.Length - 2, 2);
            return strArguments.ToString();
        }

        /// <summary>
        /// 取得以Model为参数时，缓存的Key,返回结果如：model.Id + "_" + model.Name + "_" + model.Sex
        /// </summary>
        public static string GetCacheKeyOfModel(Model.Table table)
        {
            StringBuilder strArguments = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strArguments.Append("model." + model.FieldName + " +\"_\" + ");
            }
            strArguments.Remove(strArguments.Length - 8, 8);
            return strArguments.ToString();
        }

        /// <summary>
        /// 取得以Model为参数时，缓存的Key,返回结果如：Id + "_" + Name + "_" + Sex
        /// </summary>
        public static string GetCacheKey(Model.Table table)
        {
            StringBuilder strArguments = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strArguments.Append(model.FieldName + " +\"_\" + ");
            }
            strArguments.Remove(strArguments.Length - 8, 8);
            return strArguments.ToString();
        }

        /// <summary>
        /// 为存储过程获取参数，返回结果如：@in_Id int,@in_Name char(20),@in_Age bit
        /// </summary>
        public static void GetArgumentsOfSQL(Model.Table table, StringBuilder code)
        {
            foreach (Model.Field field in table.ConditionRows)
            {
                if (field.ShouldAddLength)
                    AppendFormatLine(code, 1, "{0} {1}({2}),", field.SqlStoreProcedureParameter, field.SqlTypeString, field.FieldLength);
                else
                    AppendFormatLine(code, 1, "{0} {1},", field.SqlStoreProcedureParameter, field.SqlTypeString);
            }
            code.Remove(code.ToString().LastIndexOf(","), 1);
        }

        /// <summary>
        /// 为MySql的SQL语句取得条件，返回结果如：Id=@in_Id AND Name=@in_Name AND Age=@in_Age（程序中的语句为了兼容也用这个）
        /// </summary>
        public static string GetConditonOfMySql(Model.Table table)
        {
            StringBuilder strConditon = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strConditon.Append(string.Format("{0}={1} AND ", model.FieldName, model.SqlStoreProcedureParameter));
            }
            strConditon.Remove(strConditon.Length - 5, 5);
            return strConditon.ToString();
        }

        /// <summary>
        /// 为SqlServer的SQL语句取得条件，返回结果如：[Id]=@in_Id AND [Name]=@in_Name AND [Age]=@in_Age
        /// </summary>
        public static string GetConditonOfSql(Model.Table table)
        {
            StringBuilder strConditon = new StringBuilder();
            foreach (Model.Field model in table.ConditionRows)
            {
                strConditon.Append(string.Format("[{0}]={1} AND ", model.FieldName, model.SqlStoreProcedureParameter));
            }
            strConditon.Remove(strConditon.Length - 5, 5);
            return strConditon.ToString();
        }
    }
}
