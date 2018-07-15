using MissionIT.WebHelpCore.Models.HelpClasses;
using MissionIT.WebHelpCore.Models.ModelRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Data
{
    public class SectionRepository : Repository<Section>, ISectionRepository
    {
        public SectionRepository(HelpDbContext context)
            : base(context)
        {

        }

        public HelpDbContext HelpDbContext
        {
            get { return Context as HelpDbContext; }
            // set { HelpDbContext = value; }
        }

        Section ISectionRepository.GetSectionWithArticles(int id)
        {
            return HelpDbContext.Sections.Include(a => a.SectionID == id).SingleOrDefault(a => a.SectionID == id);
        }
    }
}
