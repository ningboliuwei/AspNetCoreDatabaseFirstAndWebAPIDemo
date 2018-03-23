using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDatabaseFirstAndWebAPIDemo.Models
{
    [Table("TB_Dishes")]
    public class DishInfo
    {
        [Key] public long Id { get; set; }
        public string DishName { get; set; }
        public string Category { get; set; }
        public double Price { get; set; }
        public string Picture { get; set; }

        #region 暂时用不着的
        //        public string ProvidePeriod { get; set; }
        //        [DefaultValue(0)]
        //        public int LikeVotesCount { get; set; }
        //        public string LikeList { get; set; }
        //        [DefaultValue(0)]
        //        public int DislikeVotesCount { get; set; }
        //        public string DislikeList { get; set; }
        //        [DefaultValue("已上架")]
        //        public string Status { get; set; }
        //        public virtual List<IngredientDosageInfo> IngredientDosages { get; set; }
        #endregion

    }

}
