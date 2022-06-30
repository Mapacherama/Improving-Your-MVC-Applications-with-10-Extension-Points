using Paladin.Infrastructure;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace Paladin.Controllers
{
    public abstract class PaladinController: Controller
    {
        private Guid _tracker;

        protected Guid Tracker
        {
            get { return _tracker; }
            private set { _tracker = value; }
        }

        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (Session["Tracker"] != null)
            {
                Guid.TryParse(Session["Tracker"].ToString(), out _tracker);
            }
        }

        public ActionResult CSV(IEnumerable model)
        {
            return new CSVResult(model, "TestCSV");
        }
    }
}