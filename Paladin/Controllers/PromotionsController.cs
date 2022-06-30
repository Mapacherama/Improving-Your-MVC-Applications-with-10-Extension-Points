using Paladin.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Paladin.Controllers
{
    internal class PromotionsController : Controller
    {

        // Main Page Promos
        public ActionResult Promos()
        {
            return View();
        }

        // Mobile App Page - "On the Go!"
        [IsPaladinMobile]
        public ActionResult GoPromo()
        {
            return View();
        }

    }
}