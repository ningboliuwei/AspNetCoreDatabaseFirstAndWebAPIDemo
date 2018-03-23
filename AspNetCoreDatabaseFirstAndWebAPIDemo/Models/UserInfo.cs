using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Models
{
    [Table("TB_Users")]
    public class UserInfo
    {
        [Key] public long Id { get; set; }
        public string Account { get; set; }
        public string Password { get; set; }
        public string RealName { get; set; }
    }
}
