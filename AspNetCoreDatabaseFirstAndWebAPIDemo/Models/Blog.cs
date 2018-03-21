using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Blogs")]
    public partial class Blog
    {
        public int BlogId { get; set; }
        public string Title { get; set; }
        public List<Post> Posts { get; set; }
    }
}
