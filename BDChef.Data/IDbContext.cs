
using BDChef.Domain;
using System.Collections.Generic;
using System.Data.Entity;

namespace BDChef.Data
{
   public interface IDbContext
    {
        IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity;
        int SaveChanges();
    }
}
