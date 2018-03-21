using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Blogs")]
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        public Post Post { get; set; }
    }
}
