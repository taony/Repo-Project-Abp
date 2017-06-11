using TaonyNet.EntityFramework;
using EntityFramework.DynamicFilters;

namespace TaonyNet.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly TaonyNetDbContext _context;

        public InitialHostDbBuilder(TaonyNetDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
