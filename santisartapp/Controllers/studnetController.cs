using santisartapp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace santisartapp.Controllers
{
    public class studnetController : Controller
    {
        // GET: studnet
        testEntities db = new testEntities();
        santisar_Entities dbserv = new santisar_Entities();
        public ActionResult Index()
        {
            return View(db.STUDENTS.ToList());
        }
        public ActionResult Index2()
        {
            return View(db.STUDENTS.ToList());
        }



    }
}