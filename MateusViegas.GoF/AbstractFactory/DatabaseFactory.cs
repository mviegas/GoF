using System;
using System.Data.Common;

namespace MateusViegas.GoF
{
    public abstract class DatabaseFactory : IDatabaseFactory
    {
        public abstract DbConnection CreateConnection(string connectionString);

        public DbCommand CreateCommand(DbConnection connection)
        {
            return connection.CreateCommand();
        }
    }
}
