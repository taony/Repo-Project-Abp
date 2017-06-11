using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Repositories;
using Abp.Domain.Services;

namespace TaonyNet.Blog
{
    public class BlogManager : DomainService,IBlogManager
    {
        private IRepository<Blog> _blogRepository;

        public BlogManager(IRepository<Blog> blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public void AddBlog(Blog blog)
        {
            _blogRepository.Insert(blog);
        }
    }
}
