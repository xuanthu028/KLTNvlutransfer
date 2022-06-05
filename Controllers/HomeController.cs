using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VLUTransfer.Daos;

namespace VLUTransfer.Controllers
{
    public class HomeController : Controller
    {
        PostDao postDao = new PostDao();
        public ActionResult Index()
        {
            ViewBag.posts = postDao.GetPosts();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}