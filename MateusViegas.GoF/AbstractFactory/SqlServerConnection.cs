using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace MateusViegas.GoF.AbstractFactory
{
    public class SqlServerConnectionFactory : DatabaseFactory
    {
        public override DbConnection CreateConnection(string connectionString)
        {
            return new SqlServerConnectionFactory().CreateConnection(connectionString);
        }
    }
}
