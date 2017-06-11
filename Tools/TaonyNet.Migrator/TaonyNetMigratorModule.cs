using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using TaonyNet.EntityFramework;

namespace TaonyNet.Migrator
{
    [DependsOn(typeof(TaonyNetDataModule))]
    public class TaonyNetMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<TaonyNetDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}