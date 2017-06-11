using Abp.Domain.Services;

namespace TaonyNet.Blog
{
    public interface IBlogManager : IDomainService
    {
        void AddBlog(Blog blog);
    }
}
