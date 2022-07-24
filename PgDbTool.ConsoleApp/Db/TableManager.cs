using PgDbTool.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;

namespace PgDbTool.ConsoleApp.Db
{
    public class TableManager
    {
        public void UpdateColumnsDescription(Type type)
        {
            AttributeManager attributeManager = new AttributeManager();
            var tableAttr = attributeManager.GetTableAttribute(type);

            Console.WriteLine($@"******************** begin update table  {type.Name} ******************** ");

            string schema = tableAttr.Schema;
            string tableName = NameConvertor.ConvertCamelCaseToCapsWithUnderscores(type.Name);

            StringBuilder stringBuilder = new StringBuilder();
            PropertyInfo[] properties = type.GetProperties();
            foreach (var property in properties)
            {
                var descAttribute = property.GetCustomAttribute(typeof(DescriptionAttribute)) as DescriptionAttribute;
                if (descAttribute == null)
                {
                    continue;
                }
                string columnName = NameConvertor.ConvertCamelCaseToCapsWithUnderscores(property.Name);
                string descption = descAttribute.Description;
                string updateColSql = $@"comment on column {schema}.{tableName}.{columnName} is '{descption}';";
                stringBuilder.AppendLine(updateColSql);
                Console.WriteLine(updateColSql);
            }
            string updateTableSql = stringBuilder.ToString();
            PgDbClient.DbClient.Ado.ExecuteCommand(updateTableSql);
            Console.WriteLine($@"******************** update table  {type.Name} end ******************** ");
            Console.WriteLine($@"");
        }

        public void UpdateAllTablesColumnsDescription(Type type)
        {
            var assembly = type.Assembly;
            var enties = assembly.GetTypes();
            foreach (var item in enties)
            {
                if (item.BaseType == typeof(BaseEntity))
                {
                    UpdateColumnsDescription(item);
                }
            }
        }

    }
}
