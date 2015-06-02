using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CodeUtility;

namespace Codes
{
    public partial class ModelCode : CodeHelper
    {
        /// <summary>
        /// 生成Model实体层代码
        /// </summary>
        /// <param name="l"></param>
        /// <returns></returns>
        public static string GetModelCode(Model.Table table, Model.CodeStyle style)
        {
            List<Model.Field> l = table.Fields;

            StringBuilder code = new StringBuilder(CommonCode.GetCSharpCopyrightCode());
            AppendFormatLine(code, 0, "using System;");
            code.AppendLine();
            AppendFormatLine(code, 0, "namespace {0}", style.ModelNameSpace);
            AppendFormatLine(code, 0, "{");
            AppendFormatLine(code, 1, "/// <summary>");
            AppendFormatLine(code, 1, "/// 实体类 {0}", table.Name);
            AppendFormatLine(code, 1, "/// </summary>");
            AppendFormatLine(code, 1, "[Serializable]");
            AppendFormatLine(code, 1, "public class {0} : ICloneable", table.Name);
            AppendFormatLine(code, 1, "{");

            #region ----------  空构造函数  ----------
            AppendFormatLine(code, 2, "public {0}()", table.Name);
            AppendFormatLine(code, 2, "{ }");
            #endregion

            code.AppendLine();

            #region ----------  构造函数  ----------
            AppendFormatLine(code, 2, "/// <summary>");
            AppendFormatLine(code, 2, "/// 构造函数 {0}", table.Name);
            AppendFormatLine(code, 2, "/// </summary>");
            foreach (Model.Field field in table.Fields)
            {
                AppendFormatLine(code, 2, "/// <param name=\"{0}\">{1}</param>", field.ConstructorsParameter, field.FieldDescn);
            }
            AppendFormat(code, 2, "public {0}(", table.Name);
            foreach (Model.Field field in table.Fields)
            {
                code.Append(string.Format("{0} {1}, ", CodeUtility.TypeConverter.DataTypeToCSharpTypeString(field.DbType), field.ConstructorsParameter)); //参数列表
            }
            code.Remove(code.Length - 2, 2);
            code.Append(")");
            code.AppendLine();
            AppendFormatLine(code, 2, "{");
            foreach (Model.Field field in table.Fields)
            {
                AppendFormatLine(code, 3, "{0} = {1};", field.PrivateProperty, field.ConstructorsParameter); //赋值
            }
            AppendFormatLine(code, 2, "}");
            #endregion

            code.AppendLine();
            AppendFormatLine(code, 2, "#region Model");
            code.AppendLine();

            foreach (Model.Field model in l)
            {
                AppendFormatLine(code, 2, "private {0} {1};",
                    CodeUtility.TypeConverter.DataTypeToCSharpTypeString(model.DbType), model.PrivateProperty);
            }

            foreach (Model.Field model in l)
            {
                AppendFormatLine(code, 2, "/// <summary>");
                AppendFormatLine(code, 2, "/// {0}", model.FieldDescn);
                AppendFormatLine(code, 2, "/// </summary>");
                AppendFormatLine(code, 2, "public {0} {1}", CodeUtility.TypeConverter.DataTypeToCSharpTypeString(model.DbType), model.FieldName);
                AppendFormatLine(code, 2, "{");
                AppendFormatLine(code, 3, "set {{ {0} = value; }}", model.PrivateProperty);
                AppendFormatLine(code, 3, "get {{ return {0}; }}", model.PrivateProperty);
                AppendFormatLine(code, 2, "}");
            }
            code.AppendLine();
            AppendFormatLine(code, 2, "#endregion");

            code.AppendLine();
            AppendFormatLine(code,2,"#region ICloneable 成员");
            code.AppendLine();
            AppendFormatLine(code,2,"public object Clone()");
            AppendFormatLine(code,2,"{");
            AppendFormatLine(code,3,"return this.MemberwiseClone();");
            AppendFormatLine(code,2,"}");
            code.AppendLine();
            AppendFormatLine(code,2,"#endregion");
            AppendFormatLine(code, 1, "}");
            AppendFormatLine(code, 0, "}");
            return code.ToString();
        }
    }
}
