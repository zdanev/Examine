using System;
using Examine.Core.Models;

namespace Examine.Core.Data
{
    public interface IRepository<TEntity> where TEntity: Entity
    {
        void Add(TEntity entiry);
        
        void Del(Guid id);
        
        TEntity Get(Guid id);
    }
}