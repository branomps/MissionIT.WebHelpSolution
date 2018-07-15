using MissionIT.WebHelpCore.Models.HelpClasses;
using MissionIT.WebHelpCore.Models.ModelRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Data
{
    public class ArticleRepository : Repository<Article>, IArticleRepository
    {
        public ArticleRepository(HelpDbContext context)
            : base(context)
        {

        }

        public HelpDbContext HelpDbContext
        {
            get { return Context as HelpDbContext; }
            //set { HelpDbContext = value; }
        }

        public IEnumerable<Article> GetArticleWithSection()
        {
            return HelpDbContext.Articles.ToList();
        }
    }
}
