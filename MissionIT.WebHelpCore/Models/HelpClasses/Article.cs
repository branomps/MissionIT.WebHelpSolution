using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static System.Collections.Specialized.BitVector32;

namespace MissionIT.WebHelpCore.Models.HelpClasses
{
    public class Article
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ArticleID { get; set; }
        [Required, StringLength(100), Display(Name = "Name")]
        public string ArticleName { get; set; }
        [Required, StringLength(10000), Display(Name = "Article Description"), DataType(DataType.MultilineText)]
        public string ArticleDescription { get; set; }
        [Required]
        public string ArticleImageUrl { get; set; }
        public int? SectionID { get; set; }

        public Section Section { get; set; }
    }
}
