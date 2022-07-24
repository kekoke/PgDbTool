using PgDbTool.Entity.app;
using PgDbTool.ConsoleApp.Db;
using System;

namespace PgDbTool.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("PgSql数据库更新表字段控制台");
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine("");

            Console.ForegroundColor = ConsoleColor.White;
            Type type = typeof(Book);
            TableManager tableManager = new TableManager();
            tableManager.UpdateAllTablesColumnsDescription(type);

            Console.ReadLine();
        }


    }
}
