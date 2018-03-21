using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Posts")]
    public partial class Post
    {
        public int PostId { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }
        public DateTime PublishTime { get; set; }
    }
}
