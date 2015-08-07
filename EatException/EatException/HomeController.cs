using System;
using System.Net;
using System.Web.Mvc;

namespace EatException
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Index()
        {
//            throw new InvalidOperationException("Original exception");
//            return new HttpStatusCodeResult(HttpStatusCode.InternalServerError);
            Server.Transfer("~/500.cshtml");
            return new HttpStatusCodeResult(HttpStatusCode.OK);
        }
    }
}