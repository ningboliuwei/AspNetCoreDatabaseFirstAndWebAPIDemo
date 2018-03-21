using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Attachements")]
    public partial class Attachement
    {
        public int AttachmentId { get; set; }
        public string Filename { get; set; }
    }
}
