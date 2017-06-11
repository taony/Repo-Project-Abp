using System.Linq;
using TaonyNet.EntityFramework;
using TaonyNet.MultiTenancy;

namespace TaonyNet.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TaonyNetDbContext _context;

        public DefaultTenantCreator(TaonyNetDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
