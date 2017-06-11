using System.Collections.Generic;
using System.Linq;
using Abp.Domain.Repositories;
using TaonyNet.Blog;

namespace TaonyNet.Blogs
{
    public class BlogAppService : TaonyNetAppServiceBase, IBlogAppService
    {
        private readonly IRepository<Blog.Blog> _blogRepository;
        private readonly IBlogManager _blogManager;

        public BlogAppService(IRepository<Blog.Blog> blogRepository, IBlogManager blogManager)
        {
            _blogRepository = blogRepository;
            _blogManager = blogManager;
        }

        public IList<Blog.Blog> GetList()
        {
            var list = _blogRepository.GetAll().OrderByDescending(t => t.CreationTime).ToList();
            return list;
        }
    }
}
