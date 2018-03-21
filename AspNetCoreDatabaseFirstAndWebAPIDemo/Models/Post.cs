using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Posts")]
    public partial class Post
    {
        public int PostId { get; set; }
        public int BlogId { get; set; }
        public string Conent { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public Blog PostNavigation { get; set; }
    }
}
