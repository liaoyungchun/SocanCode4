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
        /// ����������
        /// </summary>
        public static void RunCommand(string cmd)
        {
            string tempPath = Environment.GetEnvironmentVariable("TEMP");
            string fileName = tempPath + "\\" + Guid.NewGuid().ToString("N") + ".bat";
            CodeUtility.FileStream.WriteFile(fileName, cmd.ToString());
            Process.Start(fileName);
        }

        /// <summary>
        /// ��ģ����ȡ��Ҫ���ɵĴ���
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
        /// �ж�һ���ֶ��ǲ���Int���͵ģ�����bigint,int,smallint,tinyint��
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
        /// �ж�һ���ֶ��ǲ���String���͵ģ�����Xml,String,StringFixedLength,AnsiString,AnsiStringFixedLength��
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
        /// �Ƿ�Ҫ��Add�����м���ò���
        /// DAL��ʹ洢�����о�Ҫ�ô��ж�
        /// </summary>
        public static bool ShouldBeParameter(Model.Table table, Model.Field field)
        {
            if (!field.IsIdentifier && (string.IsNullOrEmpty(field.DefaultValue)))
                return true;
            else
                return false;
        }

        /// <summary>
        /// ����һ�и�ʽ���ַ���
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
        /// ���Ӹ�ʽ���ַ���
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
        /// ȡ���޸Ļ�ɾ��ʱ����������
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
        /// ȡ���޸Ļ�ɾ��ʱҪ�������������ֵ,���ؽ���磺Id,Name,Sex
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
        /// ȡ����ModelΪ����ʱ�������Key,���ؽ���磺model.Id + "_" + model.Name + "_" + model.Sex
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
        /// ȡ����ModelΪ����ʱ�������Key,���ؽ���磺Id + "_" + Name + "_" + Sex
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
        /// Ϊ�洢���̻�ȡ���������ؽ���磺@in_Id int,@in_Name char(20),@in_Age bit
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
        /// ΪMySql��SQL���ȡ�����������ؽ���磺Id=@in_Id AND Name=@in_Name AND Age=@in_Age�������е����Ϊ�˼���Ҳ�������
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
        /// ΪSqlServer��SQL���ȡ�����������ؽ���磺[Id]=@in_Id AND [Name]=@in_Name AND [Age]=@in_Age
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