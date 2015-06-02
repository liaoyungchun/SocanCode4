using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Text.RegularExpressions;

namespace Model
{
    public class Field : IComparable
    {
        private string tableName;
        private bool isIdentifier;
        private bool isKeyfield;
        private DbType dbType;
        private int fieldSize;
        private long fieldLength;
        private bool allowNull;
        private string fieldDescn;
        private int fieldNumber;
        private string fieldName;
        private string defaultValue;
        private string sqlTypeString;
        private string mySqlTypeString;

        /// <summary>
        /// 表名
        /// </summary>
        public string TableName
        {
            get { return tableName; }
            set { tableName = value; }
        }

        /// <summary>
        /// 字段序列
        /// </summary>
        public int FieldNumber
        {
            get { return fieldNumber; }
            set { fieldNumber = value; }
        }

        /// <summary>
        /// 字段名
        /// </summary>
        public string FieldName
        {
            get { return fieldName; }
            set { fieldName = value; }
        }

        /// <summary>
        /// 是否是标识
        /// </summary>
        public bool IsIdentifier
        {
            get { return isIdentifier; }
            set { isIdentifier = value; }
        }

        /// <summary>
        /// 是否是主键
        /// </summary>
        public bool IsKeyField
        {
            get { return isKeyfield; }
            set { isKeyfield = value; }
        }

        /// <summary>
        /// 数据类型
        /// </summary>
        public DbType DbType
        {
            get { return dbType; }
        }

        /// <summary>
        /// SqlServer中的数据类型
        /// </summary>
        public string SqlTypeString
        {
            get
            {
                return sqlTypeString;
            }
            set
            {
                sqlTypeString = value;

                switch (value)
                {
                    case "bit":
                        dbType = DbType.Boolean;
                        break;
                    case "int":
                        dbType = DbType.Int32;
                        break;
                    case "uniqueidentifier":
                        dbType = DbType.Guid;
                        break;
                    case "bigint":
                        dbType = DbType.Int64;
                        break;
                    case "decimal": // 这里如果用DbType.Decimal则会丢失小数，所以用Double
                    case "float":
                        dbType = DbType.Double;
                        break;
                    case "real":
                        dbType = DbType.Single;
                        break;
                    case "tinyint":
                        dbType = DbType.Byte;
                        break;
                    case "smallint":
                        dbType = DbType.Int16;
                        break;
                    case "xml":
                        dbType = DbType.Xml;
                        break;
                    case "numeric":
                        dbType = DbType.Decimal;
                        break;
                    case "smalldatetime":
                    case "datetime":
                        dbType = DbType.DateTime;
                        break;
                    case "smallmoney":
                    case "money":
                        dbType = DbType.Currency;
                        break;
                    case "varbinary":
                    case "binary":
                    case "timestamp":
                        dbType = DbType.Binary;
                        break;
                    case "char":
                        dbType = DbType.AnsiStringFixedLength;
                        break;
                    case "varchar":
                        dbType = DbType.AnsiString;
                        break;
                    case "nchar":
                        dbType = DbType.StringFixedLength;
                        break;
                    case "nvarchar":
                    case "text":
                    case "ntext":
                        dbType = DbType.String;
                        break;
                    case "sql_variant":
                    case "image":
                    default:
                        dbType = DbType.Object;
                        break;
                }
            }
        }

        /// <summary>
        /// Access中的数据类型
        /// （注意，因为获取到的结构中是数字表示的，
        /// 所以get的时候要根据DbType取得，set的时候要设置DbType）
        /// </summary>
        public string OleDbTypeString
        {
            get
            {
                switch (dbType)
                {
                    case DbType.Boolean:
                        return "Boolean";
                    case DbType.Decimal: // 这里特殊处理，以免丢失小数
                    case DbType.Double:
                        return "Double";
                    case DbType.Binary:
                    case DbType.Object:
                        return "Variant";
                    case DbType.Single:
                        return "Single";
                    case DbType.Int32:
                    case DbType.Byte:
                    case DbType.Int16:
                    case DbType.SByte:
                    case DbType.UInt32:
                    case DbType.UInt16:
                        return "Integer";
                    case DbType.Int64:
                    case DbType.UInt64:
                        return "Long";
                    case DbType.VarNumeric:
                    case DbType.Currency:
                        return "Currency";
                    case DbType.Date:
                    case DbType.Time:
                    case DbType.DateTime:
                        return "Date";
                    case DbType.Xml:
                    case DbType.Guid:
                    case DbType.AnsiString:
                    case DbType.AnsiStringFixedLength:
                    case DbType.String:
                    case DbType.StringFixedLength:
                    default:
                        return "String";
                }
            }
            set
            {
                switch (int.Parse(value))
                {
                    case 11:
                        dbType = DbType.Boolean;
                        break;
                    case 7:
                        dbType = DbType.DateTime;
                        break;
                    case 3:
                        dbType = DbType.Int32;
                        break;
                    case 72:
                        dbType = DbType.Guid;
                        break;
                    case 6:
                        dbType = DbType.Currency;
                        break;
                    case 128:
                        dbType = DbType.Binary;
                        break;
                    case 131: //dbType = DbType.Decimal; 这里特殊处理，以免丢失小数                    
                    case 5:
                        dbType = DbType.Double;
                        break;
                    case 4:
                        dbType = DbType.Single;
                        break;
                    case 2:
                        dbType = DbType.Int16;
                        break;
                    case 17:
                        dbType = DbType.Byte;
                        break;
                        break;
                    case 130:
                        dbType = DbType.String;
                        break;
                    default:
                        dbType = DbType.Object;
                        break;
                }
            }
        }

        /// <summary>
        /// MySql中的数据类型
        /// </summary>
        public string MySqlTypeString
        {
            get
            {
                return mySqlTypeString;
            }
            set
            {
                mySqlTypeString = value;

                switch (value)
                {
                    case "bigint":
                        dbType = DbType.Int64;
                        break;
                    case "year":
                    case "date":
                        dbType = DbType.Date;
                        break;
                    case "bit":
                    case "bool":
                        dbType = DbType.Boolean;
                        break;
                    case "varbinary":
                    case "binary":
                        dbType = DbType.Binary;
                        break;
                    case "mediumint":
                    case "int":
                        dbType = DbType.Int32;
                        break;
                    case "numeric":
                        dbType = DbType.Decimal;
                        break;
                    case "real":
                    case "double":
                    case "decimal": // 这里特殊处理，以免丢失小数
                    case "float":
                        dbType = DbType.Double;
                        break;
                    case "tinyint":
                        dbType = DbType.Byte;
                        break;
                    case "smallint":
                        dbType = DbType.Int16;
                        break;
                    case "tinytext":
                    case "mediumtext":
                    case "text":
                    case "varchar":
                    case "longtext":
                        dbType = DbType.String;
                        break;
                    case "char":
                        dbType = DbType.StringFixedLength;
                        break;
                    case "time":
                        dbType = DbType.Time;
                        break;
                    case "timestamp":
                    case "datetime":
                        dbType = DbType.DateTime;
                        break;
                    case "tinyblob":
                    case "mediumblob":
                    case "blob":
                    case "longblob":
                    default:
                        dbType = DbType.Object;
                        break;
                }
            }
        }

        /// <summary>
        /// 占用字节数
        /// </summary>
        public int FieldSize
        {
            get { return fieldSize; }
            set { fieldSize = value; }
        }

        /// <summary>
        /// 长度
        /// </summary>
        public long FieldLength
        {
            get { return fieldLength; }
            set { fieldLength = value; }
        }

        /// <summary>
        /// 是否允许空
        /// </summary>
        public bool AllowNull
        {
            get { return allowNull; }
            set { allowNull = value; }
        }

        /// <summary>
        /// 默认值
        /// </summary>
        public string DefaultValue
        {
            get { return defaultValue; }
            set { defaultValue = value; }
        }

        /// <summary>
        /// 字段说明
        /// </summary>
        public string FieldDescn
        {
            get
            {
                if (!string.IsNullOrEmpty(fieldDescn))
                {
                    return fieldDescn;
                }
                else
                {
                    return FieldName;
                }
            }
            set
            {
                fieldDescn = Regex.Replace(value, @"\s*[\n]+\s*", ""); //过滤掉换行，及换行前后的空格
            }
        }

        #region 扩展只读属性

        /// <summary>
        /// 是否需要在参数中加字段长度(如果长度超过8000，视为text型，无需加长度)
        /// </summary>
        public bool ShouldAddLength
        {
            get
            {
                if ((dbType == DbType.AnsiString || dbType == DbType.AnsiStringFixedLength ||
                    dbType == DbType.String || dbType == DbType.StringFixedLength) && fieldLength <= 8000)
                    return true;
                else
                    return false;
            }
        }

        /// <summary>
        /// 只读：构造函数中的参数名,首字母小字,例：nameField
        /// </summary>
        public string ConstructorsParameter
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(fieldName[0].ToString().ToLower());
                sb.Append(fieldName.Remove(0, 1));
                return sb.ToString();
            }
        }

        /// <summary>
        /// 只读：类私有变量,下划线 + 首字母小写，例：_nameField
        /// </summary>
        public string PrivateProperty
        {
            get { return string.Format("_{0}", ConstructorsParameter); }
        }

        /// <summary>
        /// 只读：SqlServer存储过程中的参数名,例：@in_NameField
        /// </summary>
        public string SqlStoreProcedureParameter
        {
            get { return string.Format("@in_{0}", fieldName); }
        }

        /// <summary>
        /// 只读：MySql存储过程中的参数名,例：in_NameField
        /// </summary>
        public string MySqlStoreProcedureParameter
        {
            get { return string.Format("in_{0}", fieldName); }
        }

        #endregion

        #region IComparable 成员

        public int CompareTo(object obj)
        {
            Field field = obj as Field;
            return this.FieldNumber.CompareTo(field.FieldNumber);
        }

        #endregion
    }
}
