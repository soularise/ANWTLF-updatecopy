using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEST.Models;

namespace NEST.Controllers
{
    public class AboutController : Controller
    {
        private NESTV1Entities db = new NESTV1Entities();


        public ActionResult Index(string pagename)
        {
            int id = 8;
            var contentbodies = db.ContentBodies.Where(c => c.ContentSection_ID == id).OrderBy(s => s.SortOrder);
            return View(contentbodies.ToList());
        }

    }
}
