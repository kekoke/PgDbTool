using PgDbTool.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PgDbTool.Entity.app
{
    [Description]
    [Table("Student", Schema = "app")]
    public class Student : BaseEntity
    {
        [Description("学生名字")]
        public string Name { get; set; }
        [Description("学生年龄")]
        public int Age { get; set; }
    }
}
