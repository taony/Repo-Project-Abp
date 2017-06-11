using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Abp.Domain.Repositories;
using Abp.Web.Mvc.Authorization;
using TaonyNet.Blog;

namespace TaonyNet.Web.Controllers
{
    [AbpMvcAuthorize]
    public class BlogController : ControllerBase
    {
        private readonly BlogManager _blogManager;
        private readonly IRepository<Blog.Blog> _blogRepository;

        public BlogController(BlogManager blogManager, IRepository<Blog.Blog> blogRepository)
        {
            _blogManager = blogManager;
            _blogRepository = blogRepository;
        }

        // GET: Blog
        public ActionResult Index()
        {
            Blog.Blog blog = new Blog.Blog();

            blog.Title = "taodaofsd";


            _blogRepository.Insert(blog)  ;

            return View();
        }
    }
}