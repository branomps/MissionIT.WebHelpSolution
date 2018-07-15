using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Models.ModelRepository
{
    interface IRepository<T> where T : class 
    {
        T GetOne(int id);
        IEnumerable<T> GetAll();
        IEnumerable<T> Find(Expression<Func<T, bool>> predicate);
        void Add(T tEntity);
        void Update(T tEntity);
        void Remove(T tEntity);
    }
}
