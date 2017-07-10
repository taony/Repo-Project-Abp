using System;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace TaonyNet.Blog
{
    public class Blog : Entity, IHasCreationTime, ISoftDelete
    {

        public DateTime CreationTime { get; set; }

        public string Title { get; set; }

        public string Contents { get; set; }

        public string Tags { get; set; }

        public string Remark { get; set; }

        public bool IsDeleted { get; set; }
    }
}
