﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MissionIT.WebHelpCore.Models.HelpClasses;

namespace MissionIT.WebHelpCore.Models.ModelRepository
{
    public interface ISectionRepository : IRepository<Section>
    {
        Section GetSectionWithArticles(int id);
    }
}
