using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using CodeUtility;

namespace Codes
{
    public partial class BLCode : CodeHelper
    {
        /// <summary>
        /// 生成业务逻辑层.asmx
        /// </summary>
        public static string GetBLCode(Model.Database db, Model.Table table, Model.CodeStyle style)
        {
            StringBuilder code = new StringBuilder();
            AppendFormatLine(code, 0, "<%@ WebService Language=\"C#\" CodeBehind=\"{0}{1}.asmx.cs\" Class=\"{2}.{1}\" %>",
                style.AfterNamespaceDot, table.Name, style.BLNameSpace);
            return code.ToString();
        }

        /// <summary>
        /// 生成业务逻辑层.cs
        /// </summary>
        public static string GetBLCSCode(Model.Database db, Model.Table table, Model.CodeStyle style)
        {
            StringBuilder code = new StringBuilder(CommonCode.GetCSharpCopyrightCode());

            AppendFormatLine(code, 0, "using System;");
            AppendFormatLine(code, 0, "using System.Data;");

            if (style.SlnFrame == Model.CodeStyle.SlnFrames.Factory)
            {
                AppendFormatLine(code, 0, "using DALFactory;");
            }
            if (style.BlFrame == Model.CodeStyle.BLFrame.BLS)
            {
                AppendFormatLine(code, 0, "using System.Web.Services;");
                AppendFormatLine(code, 0, "using System.ComponentModel;");
            }

            AppendFormatLine(code, 0, "using System.Collections.Generic;");
            AppendFormatLine(code, 0, "using System.Text;");
            AppendFormatLine(code, 0, "using System.Web;");
            AppendFormatLine(code, 0, "using System.Web.Caching;");
            AppendFormatLine(code, 0, "using System.Text.RegularExpressions;");
            code.AppendLine();
            AppendFormatLine(code, 0, "namespace {0}", style.BLNameSpace);
            AppendFormatLine(code, 0, "{");
            AppendFormatLine(code, 1, "/// <summary>");
            AppendFormatLine(code, 1, "/// 业务逻辑类 {0}", table.Name);
            AppendFormatLine(code, 1, "/// </summary>");

            if (style.BlFrame == Model.CodeStyle.BLFrame.BLS)
            {
                AppendFormatLine(code, 1, "[WebService(Namespace = \"http://www.Socansoft.com/\")]");
                AppendFormatLine(code, 1, "[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]");
                AppendFormatLine(code, 1, "[ToolboxItem(false)]");
            }
            if (style.CacheFrame == Model.CodeStyle.CacheFrames.None)
                AppendFormatLine(code, 1, "public class {0}", table.Name);
            else
                AppendFormatLine(code, 1, "public class {0} : CacheHelper", table.Name);

            AppendFormatLine(code, 1, "{");

            if (style.SlnFrame == Model.CodeStyle.SlnFrames.Factory)
            {
                AppendFormatLine(code, 2, "private readonly {0}.I{1} dal = DataAccess.Create{2}{3}();",
                    style.IDALNameSpace, table.Name, style.AfterNamespace, table.Name);
            }
            else
            {
                AppendFormatLine(code, 2, "private readonly {0}.{1} dal = new {0}.{1}();",
                    style.DALNameSpace, table.Name);
            }

            AppendFormatLine(code, 2, "public {0}()", table.Name);
            if (style.CacheFrame != Model.CodeStyle.CacheFrames.None)
                AppendFormatLine(code, 3, ": base(\"{0}{1}_\")", style.AfterNamespaceLine, table.Name);

            AppendFormatLine(code, 2, "{ }");
            code.AppendLine();

            switch (style.CacheFrame)
            {
                case Model.CodeStyle.CacheFrames.None:
                    code.Append(ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\BL\\None.template", db, table, style));
                    break;
                case Model.CodeStyle.CacheFrames.ObjectCache:
                    code.Append(ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\BL\\ObjectCache.template", db, table, style));
                    break;
                case Model.CodeStyle.CacheFrames.AggregateDependency:
                    code.Append(ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\BL\\AggregateDependency.template", db, table, style));
                    break;
                case Model.CodeStyle.CacheFrames.ObjectCacheAndAggregateDependency:
                    code.Append(ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\BL\\ObjectCacheAndAggregateDependency.template", db, table, style));
                    break;
                default:
                    break;
            }
            code.AppendLine();
            AppendFormatLine(code, 2, "#region 验证参数的有效性，请在此加入更多业务逻辑的验证");
            code.AppendLine();
            code.Append(GetCheckArgumentCode(style, table));
            code.AppendLine();
            AppendFormatLine(code, 2, "#endregion");
            AppendFormatLine(code, 1, "}");
            AppendFormatLine(code, 0, "}");

            return code.ToString();
        }

        public static string GetCheckArgumentCode(Model.CodeStyle style, Model.Table table)
        {
            StringBuilder code = new StringBuilder();
            AppendFormatLine(code, 2, "/// <summary>");
            AppendFormatLine(code, 2, "/// 验证实体的有效性");
            AppendFormatLine(code, 2, "/// </summary>");
            AppendFormatLine(code, 2, "private void CheckModel({0}.{1} model)", style.ModelNameSpace, table.Name);
            AppendFormatLine(code, 2, "{");
            AppendFormatLine(code, 3, "if (model == null)");
            AppendFormatLine(code, 4, "throw new ArgumentNullException(\"参数不能为空。\");");
            code.AppendLine();

            foreach (Model.Field field in table.Fields)
            {
                if (!field.AllowNull && IsStringDbType(field))
                {
                    AppendFormatLine(code, 3, "if (!Regex.IsMatch(model.{0}, @\"^[\\s\\w\\u4e00-\\u9fa5]{{1,{1}}}$\"))",
                        field.FieldName, field.FieldLength < 1 ? 4000 : field.FieldLength);
                    AppendFormatLine(code, 4, "throw new ArgumentException(\"{0}格式不正确。\");", field.FieldDescn);
                    code.AppendLine();
                }
            }
            code.Remove(code.Length - 2, 2);

            AppendFormatLine(code, 2, "}");
            code.AppendLine();

            AppendFormatLine(code, 2, "/// <summary>");
            AppendFormatLine(code, 2, "/// 验证条件参数的有效性");
            AppendFormatLine(code, 2, "/// </summary>");
            AppendFormatLine(code, 2, "private void CheckConditionArgument({0})", GetArgumentsOfFunction(table));
            AppendFormatLine(code, 2, "{");

            int count = 0;
            foreach (Model.Field field in table.ConditionRows)
            {
                if (!field.AllowNull && IsStringDbType(field))
                {
                    AppendFormatLine(code, 3, "if (!Regex.IsMatch({0}, @\"^[\\s\\w\\u4e00-\\u9fa5]{{1,{1}}}$\"))", field.FieldName, field.FieldSize);
                    AppendFormatLine(code, 4, "throw new ArgumentException(\"{0}格式不正确。\");", field.FieldDescn);
                    code.AppendLine();
                    count++;
                }
            }
            if (count > 0)
            {
                code.Remove(code.Length - 2, 2);
            }

            AppendFormatLine(code, 2, "}");
            return code.ToString();
        }

        /// <summary>
        /// Caches.cs文件的代码
        /// </summary>
        public static string GetCacheHelperCode(Model.CodeStyle style)
        {
            return ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\BL\\CacheHelper.template", null, null, style);
        }
    }
}
