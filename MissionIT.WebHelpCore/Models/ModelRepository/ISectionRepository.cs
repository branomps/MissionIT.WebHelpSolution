using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelpCore.Models.HelpClasses;

namespace MissionIT.WebHelpCore.Models.ModelRepository
{
    interface ISectionRepository
    {
        Section GetSectionWithArticles(int id);
    }
}
