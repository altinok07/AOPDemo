using AOPDemo.Core.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AOPDemo.Core.Repository
{
    public class BaseRepository<TModel, TContext> : IBaseInterface<TModel>
        where TModel : class, new()
        where TContext : DbContext, new()
    {
        public void Add(TModel entity)
        {
            using (TContext context = new TContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public bool Delete(TModel entity)
        {
            throw new NotImplementedException();
        }

        public TModel Get(int Id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetActive()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TModel> GetAll()
        {
            using (TContext context = new TContext())
            {
                var result = context.Set<TModel>().ToList();

                return result;
            }
        }

        public bool Update(TModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
