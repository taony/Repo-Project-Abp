using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using TaonyNet.Authorization.Roles;
using TaonyNet.Blog;
using TaonyNet.MultiTenancy;
using TaonyNet.Users;

namespace TaonyNet.EntityFramework
{
    public class TaonyNetDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public TaonyNetDbContext() : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in TaonyNetDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of TaonyNetDbContext since ABP automatically handles it.
         */
        public TaonyNetDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public TaonyNetDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public TaonyNetDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        public IDbSet<Blog.Blog> Tasks { get; set; }

        public IDbSet<Archive> Archives { get; set; }

    }
}
