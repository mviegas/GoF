using System;
using System.Data.Common;

namespace MateusViegas.GoF
{
    public interface IDatabaseFactory
    {
        DbConnection CreateConnection(string connectionString);

        DbCommand CreateCommand(DbConnection connection);
    }
}
