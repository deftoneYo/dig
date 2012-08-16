﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Dig.Web.Areas.Mock.Controllers
{
    public class MockController : Controller
    {
        //
        // GET: /Mock/Mock/

        public ActionResult Index()
        {
            return View();
        }

        #region Generic Mocks
        public ActionResult AutoComplete()
        {
            return View();
        }
        #endregion

        public ActionResult EventGrid()
        {
            return View();
        }

    }
}
