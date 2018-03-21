using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AspNetCoreDatabseFirstAndWebAPIDemo.models
{
    [Table("Users")]
    public partial class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Realname { get; set; }
        public DateTime Birthday { get; set; }
    }
}
