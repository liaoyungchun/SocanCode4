using System;
using System.Collections.Generic;
using System.Text;

namespace Fabrics
{
    interface ISchema
    {
        Model.Database GetSchema(string connectionString, Model.Database.DatabaseType type);
    }
}
