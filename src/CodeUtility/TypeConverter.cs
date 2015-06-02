using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Model;

namespace CodeUtility
{
    public class TypeConverter
    {
        /// <summary>
        /// 取得C#的类型，如byte,bool,int,Guid
        /// </summary>
        public static string DataTypeToCSharpTypeString(DbType type)
        {
            switch (type)
            {
                case DbType.VarNumeric:
                case DbType.Currency:
                case DbType.Decimal:
                    return "decimal";
                case DbType.Double:
                    return "double";
                case DbType.Byte:
                    return "byte";
                case DbType.Boolean:
                    return "bool";
                case DbType.Date:
                case DbType.Time:
                case DbType.DateTime:
                    return "DateTime";
                case DbType.Guid:
                    return "Guid";
                case DbType.SByte:
                    return "sbyte";
                case DbType.Int16:
                    return "Int16";
                case DbType.Int32:
                    return "int";
                case DbType.Int64:
                    return "long";
                case DbType.Single:
                    return "float";
                case DbType.UInt16:
                    return "UInt16";
                case DbType.UInt32:
                    return "uint";
                case DbType.UInt64:
                    return "ulong";
                case DbType.Xml:
                case DbType.String:
                case DbType.StringFixedLength:
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                    return "string";
                case DbType.Object:
                case DbType.Binary:
                default:
                    return "byte[]";
            }
        }

        /// <summary>
        /// 取得DBUtility中的转化方法，如GetByte，GetBinary，GetBool
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string DataTypeToDBUtilityConvertMethod(DbType type)
        {
            switch (type)
            {
                case DbType.VarNumeric:
                case DbType.Currency:
                case DbType.Decimal:
                    return "GetDecimal";
                case DbType.Double:
                    return "GetDouble";
                case DbType.Byte:
                    return "GetByte";
                case DbType.Boolean:
                    return "GetBool";
                case DbType.Date:
                case DbType.Time:
                case DbType.DateTime:
                    return "GetDateTime";
                case DbType.Guid:
                    return "GetGuid";
                case DbType.SByte:
                    return "GetSByte";
                case DbType.Int16:
                    return "GetInt16";
                case DbType.Int32:
                    return "GetInt";
                case DbType.Int64:
                    return "GetLong";
                case DbType.Single:
                    return "GetFloat";
                case DbType.UInt16:
                    return "GetUInt16";
                case DbType.UInt32:
                    return "GetUInt";
                case DbType.UInt64:
                    return "GetULong";
                case DbType.Xml:
                case DbType.String:
                case DbType.StringFixedLength:
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                    return "GetString";
                case DbType.Object:
                case DbType.Binary:
                default:
                    return "GetBinary";
            }
        }

        /// <summary>
        /// 取得C#的方法，如Convert.ToInt32，Convert.ToString
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static string DataTypeToCSharpConvertMethod(DbType type)
        {
            switch (type)
            {
                case DbType.VarNumeric:
                case DbType.Currency:
                case DbType.Decimal:
                    return "Convert.ToDecimal";
                case DbType.Double:
                    return "Convert.ToDouble";
                case DbType.Byte:
                    return "Convert.ToByte";
                case DbType.Boolean:
                    return "Convert.ToBoolean";
                case DbType.Date:
                case DbType.Time:
                case DbType.DateTime:
                    return "Convert.ToDateTime";
                case DbType.Guid:
                    return "new Guid";
                case DbType.SByte:
                    return "Convert.ToSByte";
                case DbType.Int16:
                    return "Convert.ToInt16";
                case DbType.Int32:
                    return "Convert.ToInt32";
                case DbType.Int64:
                    return "Convert.ToInt64";
                case DbType.Single:
                    return "Convert.ToSingle";
                case DbType.UInt16:
                    return "Convert.ToUInt16";
                case DbType.UInt32:
                    return "Convert.ToUInt32";
                case DbType.UInt64:
                    return "Convert.ToUInt64";
                case DbType.Xml:
                case DbType.String:
                case DbType.StringFixedLength:
                case DbType.AnsiString:
                case DbType.AnsiStringFixedLength:
                    return "Convert.ToString";
                case DbType.Object:
                case DbType.Binary:
                default:
                    return "Convert.ToByte";
            }
        }
    }
}
