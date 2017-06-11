using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace TaonyNet.EntityFramework.Repositories
{
    public abstract class TaonyNetRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<TaonyNetDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected TaonyNetRepositoryBase(IDbContextProvider<TaonyNetDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class TaonyNetRepositoryBase<TEntity> : TaonyNetRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected TaonyNetRepositoryBase(IDbContextProvider<TaonyNetDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
