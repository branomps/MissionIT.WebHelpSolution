using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Models.ModelRepository
{
    public interface IUnitOfWork : IDisposable
    {
        ISectionRepository Sections { get; }
        IArticleRepository Articles { get; }
        int Complete();
    }
}
