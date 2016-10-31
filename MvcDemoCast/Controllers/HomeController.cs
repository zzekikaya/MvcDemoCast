using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyFoundation;

namespace MvcDemoCast.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/
        private IMessageSenderComponent messageSender;
         

       

        public HomeController(IMessageSenderComponent _messageSender)
        {
            messageSender = _messageSender;
            messageSender.SendMessage("deneme");
            
        }

        public ActionResult Index()
        {
            return View();
        }

    }
}
