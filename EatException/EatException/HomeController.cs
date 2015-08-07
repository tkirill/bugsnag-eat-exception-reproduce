using System;
using System.Web.Mvc;

namespace EatException
{
    [RoutePrefix("")]
    public class HomeController : Controller
    {
        [Route]
        public ActionResult Exception()
        {
            throw new InvalidOperationException("Original exception");
        }
    }
}