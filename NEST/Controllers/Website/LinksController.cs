﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NEST.Models;

namespace NEST.Controllers
{
    public class LinksController : Controller
    {



        private NESTV1Entities db = new NESTV1Entities();


        public ActionResult Index(string pagename)
        {
            try
            {
                var contentbodies = db.ContentBodies.Where(c => c.SEOUrl.ToLower() == pagename.ToLower()).OrderBy(s => s.SortOrder);
                return View(contentbodies.ToList());
            }
            catch
            {
                return View();

            }
        }


       
    }
}
