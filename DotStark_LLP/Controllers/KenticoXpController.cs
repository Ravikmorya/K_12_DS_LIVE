using DotStark_LLP.Models.KenticoXp;
using DotStark_LLP.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotStark_LLP.Controllers
{
    public class KenticoXpController : Controller
    {
        // GET: Kentico
        public ActionResult Index()
        {
            var imagemvcService = new ImageMvcService();
            var kenticoxpService = new KenticoXpService();
            var model = new IndexViewModel() 
            {
                Images = imagemvcService.GetImages().ToList(),
                KenticoXp = kenticoxpService.GetKenticos().ToList()
            };
            return View(model);
        }
    }
}