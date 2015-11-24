using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataAccessLayer;
using DataAccessLayer.Entitys;

namespace MyMeetings.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var context = new MeetingContext())
            {
               
//                UserMeetingsInfo info = new UserMeetingsInfo
//                {
//                    Id = 1,
//                };
//                context.UserMeetingInfos.Add(info);
//                context.SaveChanges();
            }
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