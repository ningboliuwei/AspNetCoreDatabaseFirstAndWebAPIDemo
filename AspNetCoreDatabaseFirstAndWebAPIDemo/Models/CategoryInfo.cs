using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Models
{
    [Table("TB_Categories")]
    public class CategoryInfo
    {
        [Key] public long Id { get; set; }
        [MinLength(1), MaxLength(50)]
        public string CategoryName { get; set; }
    }
}
