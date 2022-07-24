using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PgDbTool.ConsoleApp
{
    public class AttributeManager
    {
        public TableAttribute GetTableAttribute(Type type)
        {
            TableAttribute attribute = Attribute.GetCustomAttribute(type, typeof(TableAttribute)) as TableAttribute;
            if(attribute == null)
            {
                throw new Exception("The TableAttribute was not found.");
            }else
            {
                return attribute;
            }
        }

        public DescriptionAttribute GetDescriptionAttribute(Type type)
        {
            DescriptionAttribute  attribute = Attribute.GetCustomAttribute(type, typeof(DescriptionAttribute)) as DescriptionAttribute;
            if (attribute == null)
            {
                throw new Exception("The DescriptionAttribute was not found.");
            }
            else
            {
                return attribute;
            }
        }
    }
}
