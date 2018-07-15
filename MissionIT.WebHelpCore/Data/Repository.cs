using MissionIT.WebHelpCore.Models.ModelRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MissionIT.WebHelpCore.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected readonly HelpDbContext Context;

        public Repository(HelpDbContext ctx)
        {
            Context = ctx;
        }

        public T GetOne(int id)
        {
            return Context.Set<T>().Find(id);
        }
        public IEnumerable<T> GetAll()
        {
            return Context.Set<T>().ToList();
        }
        public IEnumerable<T> Find(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }

        public void Add(T tEntity)
        {
            Context.Set<T>().Add(tEntity);
        }

        public void Update(T tEntity)
        {
            Context.Set<T>().Update(tEntity);
        }

        public void Remove(T tEntity)
        {
            Context.Set<T>().Remove(tEntity);
        }
    }
}
