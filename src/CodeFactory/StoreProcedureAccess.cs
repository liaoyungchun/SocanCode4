using System;
using System.Collections.Generic;
using System.Text;
using CodeUtility;

namespace CodeFactory
{
    public class StoreProcedureAccess
    {
        public static void CreateStoreProcedureFile(Model.Database db, List<Model.Table> selTables, string path)
        {
            StringBuilder code = new StringBuilder();
            switch (db.Type)
            {
                case Model.Database.DatabaseType.MySql:
                    foreach (Model.Table table in selTables)
                    {
                        code.Append(Codes.MySqlStoreProcedureCode.GetMySqlStoreProcedureCode(table));
                    }
                    FileStream.WriteFile(path + "\\StoreProcedures(for MySql).sql", code.ToString());
                    break;
                case Model.Database.DatabaseType.Access:
                case Model.Database.DatabaseType.Sql2000:
                case Model.Database.DatabaseType.Sql2005:
                default:
                    foreach (Model.Table table in selTables)
                    {
                        code.Append(Codes.SqlStoredProcedureCode.GetSqlStoredProcedureCode(table));
                    }
                    FileStream.WriteFile(path + "\\StoreProcedures(for SqlServer).sql", code.ToString());
                    break;
            }
        }
    }
}
