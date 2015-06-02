using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Codes
{
    public class ICacheDependencyCode : CodeHelper
    {
        public static string GetICacheDependencyCode(Model.CodeStyle style)
        {
            return ReadFromTemplate(Model.CreateStyle.CURRENT_PATH + "\\ICacheDependency\\ICacheDependency.template", null, null, style);
        }
    }
}
