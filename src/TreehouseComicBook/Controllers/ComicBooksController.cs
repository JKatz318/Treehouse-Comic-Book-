using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TreehouseComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            if (DateTime.Today.DayOfWeek==DayOfWeek.Sunday)
            {
                return Redirect("/");
            }
            return Content("Hello from the comic books controller!");
          
                
            
        }

    }
            
            
}

