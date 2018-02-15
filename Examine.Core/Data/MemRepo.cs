using System;
using System.Collections.Generic;
using System.Linq;
using Examine.Core.Models;

namespace Examine.Core.Data
{
    public class MemRepo<TEntity> : IRepository<TEntity>
        where TEntity: Entity
    {
        private static List<TEntity> repo = new List<TEntity>();

        public void Add(TEntity entity)
        {
            Del(entity.Id);
            repo.Add(entity);
        }

        public void Del(Guid id)
        {
            var item = Get(id);
            
            if (item != null)
            {
                repo.Remove(item);
            }
        }

        public TEntity Get(Guid id)
        {
            return repo.SingleOrDefault(x => x.Id == id);
        }
    }
}