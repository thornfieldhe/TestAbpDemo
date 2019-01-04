using System;
using Abp.Domain.Entities;
using Abp.Domain.Repositories;
using Abp.EntityFrameworkCore;
using Abp.EntityFrameworkCore.Repositories;

namespace ABPDemo.EntityFrameworkCore.Repositories
{
    /// <summary>
    /// Base class for custom repositories of the application.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    /// <typeparam name="TPrimaryKey">Primary key type of the entity</typeparam>
    public abstract class ABPDemoRepositoryBase<TEntity, TPrimaryKey> : EfCoreRepositoryBase<ABPDemoDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ABPDemoRepositoryBase(IDbContextProvider<ABPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }

        // Add your common methods for all repositories
    }

    /// <summary>
    /// Base class for custom repositories of the application.
    /// This is a shortcut of <see cref="ABPDemoRepositoryBase{TEntity,TPrimaryKey}"/> for <see cref="int"/> primary key.
    /// </summary>
    /// <typeparam name="TEntity">Entity type</typeparam>
    public abstract class ABPDemoRepositoryBase<TEntity> : ABPDemoRepositoryBase<TEntity, long>, IRepository<TEntity>
        where TEntity : class, IEntity<long>
    {
        protected ABPDemoRepositoryBase(IDbContextProvider<ABPDemoDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
        }
            
        // Do not add any method here, add to the class above (since this inherits it)!!!
    }
}
