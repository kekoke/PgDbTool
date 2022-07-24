using PgDbTool.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PgDbTool.Entity.app
{
    [Description]
    [Table("Book",Schema ="app")]
    public class Book: BaseEntity
    {
        [Description("书籍编码")]
        public string BookCode { get; set; }
        [Description("书名")]
        public string Book_Name { get; set; }
    }
}
