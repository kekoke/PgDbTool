using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PgDbTool.ConsoleApp.Db
{
    public static class PgDbClient
    {
        public static SqlSugarClient DbClient;
       static PgDbClient()
        {
            string connectionString = "PORT=49153;DATABASE=postgres;HOST=localhost;PASSWORD=postgrespw;USER ID=postgres";
            if (DbClient is null)
            {
                DbClient = new SqlSugarClient(new ConnectionConfig()
                {
                    DbType = SqlSugar.DbType.PostgreSQL,
                    ConnectionString = connectionString,
                    IsAutoCloseConnection = true,
                    MoreSettings = new ConnMoreSettings()
                    {
                        PgSqlIsAutoToLower = false //数据库存在大写字段的 ，需要把这个设为false ，并且实体和字段名称要一样
                    },
                    AopEvents = new AopEvents
                    {
                        OnLogExecuting = (sql, p) =>
                        {
                            //Console.WriteLine(sql);
                            //Console.WriteLine(string.Join(",", p?.Select(it => it.ParameterName + ":" + it.Value)));
                        }
                    }
                });
            }  
        }
    }
}
