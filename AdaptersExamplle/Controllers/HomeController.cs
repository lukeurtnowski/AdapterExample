using AdaptersExample.DataModel;
using AdaptersExamplle.Adaptors.Adaptors;
using AdaptersExamplle.Adaptors.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdaptersExamplle.Controllers
{
    public class HomeController : Controller
    {
        IPost _postAdapt;

        public HomeController()
        {
            _postAdapt = new MockPostAdaptor();
//            _postAdapt = new DataPostAdaptor();
        }

        public HomeController(IPost postAdapt)
        {
            _postAdapt = postAdapt;
        }

        public ActionResult Index()
        {
            List<Post> allPost = _postAdapt.GetAll();
            return View(allPost);
        }

        public ActionResult ViewPost(int id)
        {
            Post post = _postAdapt.GetPost(id);
            return View(post);
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