using dotnethomework.Context;
using dotnethomework.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System.Diagnostics;

namespace dotnethomework.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		public MyDbContext context { get; set; }

		public HomeController(ILogger<HomeController> logger, MyDbContext _context)
		{
			_logger = logger;
			context= _context;
		}

		[HttpGet]
		public IActionResult Index()
		{
			List<Blog> blogs = context.Blogs.ToList();

			return View(blogs);
		}

		[HttpGet]
		public IActionResult logIn()
		{
			return View();
		}

		[HttpPost]
		public IActionResult logIn(User user)
		{
			//if (context.Set<User>().Any(x=>x.email == user.email))
			//{

			//}

			return View();
		}

		[HttpGet]
		public IActionResult signIn()
		{
			return View();
		}

		[HttpPost]
		public IActionResult signIn(User user)
		{
			context.Users.Add(user);
			context.SaveChanges();
			return View("logIn");
		}

        [HttpGet]
        public IActionResult addBlog()
        {         
            return View();
        }


        [HttpPost]
        public IActionResult addBlog(Blog blog)
        {
			blog.userID = 3;
            context.Blogs.Add(blog);
            context.SaveChanges();
            return RedirectToAction("index");
        }

        [HttpGet]
        public IActionResult showBlog(int ID)
        {
			Blog blog= context.Find<Blog>(ID);

			return View(blog);
        }

    }
}