using DotStark_LLP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotStark_LLP.Models.Strengths;

namespace DotStark_LLP.Controllers
{
    public class StrengthsController : Controller
    {
        // GET: Strengths
        public ActionResult Index()
        {
            var strengthService = new StrengthsService();
            var model = new IndexViewModel()
            {
                Strengths = strengthService.GetStrengths().ToList()
            };
            return View(model);
        }
    }
}