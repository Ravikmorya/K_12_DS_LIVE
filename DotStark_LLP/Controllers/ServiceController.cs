using DotStark_LLP.Models;
using DotStark_LLP.Services;
using Kentico.PageBuilder.Web.Mvc.PageTemplates;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DotStark_LLP.Controllers
{
    public class ServiceController : Controller
    {
        
        
        // GET: Services
        public ActionResult Index()
        {
            var serviceService = new ServiceService();
            var model = new IndexViewModel()
            {
                Servicess = serviceService.GetServiss().ToList()

            };
            return View(model);
        }

        // GET: Articles/Show/{guid}
        //[OutputCache(CacheProfile = "Default", VaryByParam = "guid")]
        //public ActionResult Show(Guid guid, string pageAlias)
        //{
        //    var service = serviceService.GetServiss(guid).ToList();

        //    if (service == null)
        //    {
        //        return HttpNotFound();
        //    }

        //    // Redirect if page alias does not match
        //    if (!string.IsNullOrEmpty(pageAlias) && !service.NodeAlias.Equals(pageAlias, StringComparison.InvariantCultureIgnoreCase))
        //    {
        //        return RedirectToActionPermanent("Show", new { guid = service.NodeGUID, pageAlias = service.NodeAlias });
        //    }

        //    //mOutputCacheDependencies.AddDependencyOnPages<Article>();

        //    return new TemplateResult(service.DocumentID);
        //}
    }
}