using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PgDbTool.Entity
{
    [Table("BaseEntity", Schema = "bas")]
    public class BaseEntity
    {
        [Description("主键")]
        public string Id { get; set; }
        [Description("创建人")]
        public string Creator { get; set; }
        [Description("创建时间")]
        public DateTime CreationTime { get; set; }
    }
}
