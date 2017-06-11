using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TaonyNet.Blog
{
    public class Archive: Entity, IHasCreationTime, ISoftDelete
    {
        public DateTime CreationTime { get; set; }
        public bool IsDeleted { get; set; }
    }
}
