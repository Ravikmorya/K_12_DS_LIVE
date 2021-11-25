using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using CMS.DocumentEngine;
using DotStark_LLP.Models.Home;

using DotStark_LLP.Services;
using Kentico.PageBuilder.Web.Mvc;
using Kentico.Web.Mvc;

namespace DotStark_LLP.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        
        {
            TreeNode page = DocumentHelper.GetDocuments().Path("/Home").OnCurrentSite().TopN(1).FirstOrDefault();
            if (page == null)
            {
                return HttpNotFound();
            }

            HttpContext.Kentico().PageBuilder().Initialize(page.DocumentID);

            var bannerService = new BannerService();
            var homeItemService = new HomeItemService();
            
            //var homeEx = new HomeExService();
            var model = new IndexViewModel()
            {
                Banners = bannerService.GetBanners().ToList(),
                HomeItems = homeItemService.GetHomeItems().ToList(),
                HomeExs = bannerService.GetHomeEx().ToList(),
                //HomeExs = homeEx.GetHomeEx().ToList()

                //HomeItems = homeItemService.GetHomeItems().Select(HomeItemViewModel.GetViewModel)
            };

            return View(model);
        }
    }
}